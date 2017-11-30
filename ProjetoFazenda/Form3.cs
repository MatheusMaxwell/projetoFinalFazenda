using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFazenda
{
    public partial class Form3 : Form
    {
        HttpClient client;
        Uri especiesUri;
        int ID = 0;
        public Form3()
        {
            InitializeComponent();
            if (client == null)
            {
                client = new HttpClient();
                client.BaseAddress = new Uri("http://webapifazenda.azurewebsites.net/");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            }
            getAll();
        }

        private void getAll()
        {
            ClearData();
            System.Net.Http.HttpResponseMessage response = client.GetAsync("http://webapifazenda.azurewebsites.net/api/especies").Result;

            if (response.IsSuccessStatusCode)
            {
                especiesUri = response.Headers.Location;

                var especies = response.Content.ReadAsAsync<IEnumerable<Especie>>().Result;

                dataGridView1.DataSource = especies;

            }


            else
                MessageBox.Show("Não foi possível obter o estoque : " + response.StatusCode);
            lblQtdLinhas.Text = dataGridView1.Rows.Count.ToString() + " linhas selecionadas.";
        }

        private async void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "")
            {
                if (!verificarExistenciaEspecie())
                {
                    Especie esp = new Especie();
                    esp.Descricao = txtNome.Text;

                    using (var client = new HttpClient())
                    {
                        var serializedMaterial = JsonConvert.SerializeObject(esp);
                        var content = new StringContent(serializedMaterial, Encoding.UTF8, "application/json");
                        var result = await client.PostAsync("http://webapifazenda.azurewebsites.net/api/especies", content);
                        if (result.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Especie adicionada!");
                            getAll();
                        }

                        else
                            MessageBox.Show("Erro ao adicionar especie!");
                    }
                }
                else
                    MessageBox.Show("Esta espécie já foi registrada!");
            }
            else
                MessageBox.Show("Preencha o campo!");

            ClearData();
        }


        private Boolean verificarExistenciaEspecie()
        {
            SqlConnection conn = new SqlConnection(@"Server=tcp:myserverm.database.windows.net,1433;Initial Catalog=BDFazenda;Persist Security Info=False;User ID=MatheusMeireles;Password=Hebreu36221899;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

            string sql = "SELECT Descricao from Especie";

            SqlCommand cmd = new SqlCommand(sql, conn);

            conn.Open();

            SqlDataReader leitor = cmd.ExecuteReader();
            string str1 = "";
            string str2 = txtNome.Text.ToUpper();
            while (leitor.Read())
            {
                str1 = leitor["Descricao"].ToString().ToUpper();
                if (str1.Equals(str2))
                {
                    conn.Close();
                    return true;
                }
            }
            conn.Close();
            return false;
            
        }

        private void btnGrid_Click(object sender, EventArgs e)
        {
            getAll();
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "")
            {
                if (!verificarExistenciaEspecie())
                {
                    Especie esp = new Especie();
                    esp.Descricao = txtNome.Text;
                    esp.Id = ID;
                    using (var client = new HttpClient())
                    {
                        HttpResponseMessage responseMessage = await client.PutAsJsonAsync("http://webapifazenda.azurewebsites.net/api/especies" + "/" + ID, esp);
                        if (responseMessage.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Especie alterada!");
                            getAll();
                        }
                        else
                        {
                            MessageBox.Show("Falha ao alterar a especie : " + responseMessage.StatusCode);
                        }
                    }
                }
                else
                    MessageBox.Show("Esta espécie já foi registrada!");
            }
            else
                MessageBox.Show("Preencha o campo!");

            ClearData();


        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                DialogResult result = MessageBox.Show("Deseja realmente exluir esta especie? \n ID:" + ID + " || Nome:" + txtNome.Text, "Alerta", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = new Uri("http://webapifazenda.azurewebsites.net/api/especies");
                        HttpResponseMessage responseMessage = await client.DeleteAsync(String.Format("{0}/{1}", "http://webapifazenda.azurewebsites.net/api/especies", ID));
                        if (responseMessage.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Especie excluída com sucesso!");
                            getAll();
                        }
                        else
                        {
                            if (responseMessage.StatusCode.ToString().Contains("InternalServerErro"))
                            {
                                MessageBox.Show("Esta espécie já está associada a um animal.");
                            }
                            else
                            {
                                MessageBox.Show("Falha ao excluir a especie: " + responseMessage.StatusCode);
                            }
                        }
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Selecione a especie para deletar.");
            }
        }
        private void ClearData()
        {
            txtNome.Text = "";
            ID = 0;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtNome.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(); ;
 
            }

        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            if (txtNomeBusca.Text != "")
            {
                System.Net.Http.HttpResponseMessage response = client.GetAsync("http://webapifazenda.azurewebsites.net/api/especies/nome/" + txtNomeBusca.Text).Result;

                if (response.IsSuccessStatusCode)
                {
                    especiesUri = response.Headers.Location;

                    var especies = response.Content.ReadAsAsync<IEnumerable<Especie>>().Result;

                    dataGridView1.DataSource = especies;

                }


                else
                    MessageBox.Show("Não foi possível obter o estoque : " + response.StatusCode);
            }
            else
                MessageBox.Show("Preencha o campo!");
            lblQtdLinhas.Text = dataGridView1.Rows.Count.ToString() + " linhas selecionadas.";
        }
    }
}
