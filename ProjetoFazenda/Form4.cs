using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFazenda
{
    public partial class Form4 : Form
    {
        HttpClient client;
        Uri animaisURI;
        int ID = 0;
        public Form4()
        {
            InitializeComponent();
            if (client == null)
            {
                client = new HttpClient();
                client.BaseAddress = new Uri("http://webapifazenda.azurewebsites.net/");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            }
            getAll();
            getAllComboBox();
        }
        private void getAllComboBox()
        {
            System.Net.Http.HttpResponseMessage response = client.GetAsync("http://webapifazenda.azurewebsites.net/api/animals").Result;

            if (response.IsSuccessStatusCode)
            {
                animaisURI = response.Headers.Location;

                var especies = response.Content.ReadAsAsync<IEnumerable<Animal>>().Result;

                cbAnimal.DataSource = especies;
                cbAnimal.DisplayMember = "Nome";
                cbAnimal.ValueMember = "Id";
                
            

                cbAnimalBusca.DataSource = especies;
                cbAnimalBusca.DisplayMember = "Nome";
                cbAnimalBusca.ValueMember = "Id";



            }


            else
                MessageBox.Show("Não foi possível concluir a busca: " + response.StatusCode);

        }

        private void getAll()
        {
            ClearData();
            System.Net.Http.HttpResponseMessage response = client.GetAsync("http://webapifazenda.azurewebsites.net/api/vacinacoes").Result;

            if (response.IsSuccessStatusCode)
            {
                animaisURI = response.Headers.Location;

                var vacinacoes = response.Content.ReadAsAsync<IEnumerable<Vacinacao>>().Result;

                dataGridView1.DataSource = vacinacoes;

            }


            else
                MessageBox.Show("Não foi possível obter o estoque : " + response.StatusCode);

            lblQtdLinhas.Text = dataGridView1.Rows.Count.ToString() + " linhas selecionada(s).";
        }

        private void ClearData()
        {
            txtData.Text = "dd/MM/yyyy";
            txtData.ForeColor = Color.Gray;
            ID = 0;
        }
        private async void btnIncluir_Click(object sender, EventArgs e)
        {
            if (cbAnimal.Text != "" && txtData.Text != "")
            {
                Vacinacao vac = new Vacinacao();
                vac.AnimalId = (int)cbAnimal.SelectedValue;
                vac.NomeAnimal = cbAnimal.Text;
                vac.Data = DateTime.Parse(txtData.Text);
                using (var client = new HttpClient())
                {
                    var serializedMaterial = JsonConvert.SerializeObject(vac);
                    var content = new StringContent(serializedMaterial, Encoding.UTF8, "application/json");
                    var result = await client.PostAsync("http://webapifazenda.azurewebsites.net/api/vacinacoes", content);
                    if (result.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Vacinação adicionado!");
                        getAll();
                    }

                    else
                        MessageBox.Show("Erro ao adicionar vacinação!");
                }
            }
            else
                MessageBox.Show("Preencha os campos!");
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (cbAnimal.Text != "" && txtData.Text != "")
            {
                Vacinacao vac = new Vacinacao();
                vac.AnimalId = (int)cbAnimal.SelectedValue;
                vac.NomeAnimal = cbAnimal.Text;
                vac.Data = DateTime.Parse(txtData.Text);
                vac.Id = ID;
                using (var client = new HttpClient())
                {
                    HttpResponseMessage responseMessage = await client.PutAsJsonAsync("http://webapifazenda.azurewebsites.net/api/vacinacoes" + "/" + ID, vac);
                    if (responseMessage.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Vacinacao alterada!");
                        getAll();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao alterar a vacinacao : " + responseMessage.StatusCode);
                    }
                }
            }
            else
                MessageBox.Show("Preencha os campos!");
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                DialogResult result = MessageBox.Show("Deseja realmente exluir esta vacinaçao? \n ID:" + ID + " || Animal: "+ cbAnimal.Text, "Alerta", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = new Uri("http://webapifazenda.azurewebsites.net/api/vacinacoes");
                        HttpResponseMessage responseMessage = await client.DeleteAsync(String.Format("{0}/{1}", "http://webapifazenda.azurewebsites.net/api/vacinacoes", ID));
                        if (responseMessage.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Vacinacao excluída com sucesso!");
                            getAll();
                        }
                        else
                        {
                            MessageBox.Show("Falha ao excluir a vacinacao: " + responseMessage.StatusCode);
                        }
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Selecione a vacinacao para deletar.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                cbAnimal.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(); ;
                txtData.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(); ;

            }

        }

        private void btnGrid_Click(object sender, EventArgs e)
        {
            getAll();
        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {
            if(txtData.Text == "dd/MM/yyyy")
            {
                txtData.Text = "";
            }
            txtData.ForeColor = Color.Black;

        }

        private void cbBusca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbBusca.SelectedIndex == 0)
            {
                cbAnimalBusca.Text = "";
                cbAnimalBusca.Visible = false;
                lblAnimal.Visible = false;
                lblDataI.Visible = true;
                txtDataIni.Visible = true;
                txtDataIni.Text = "ddMMyyyy";
                txtDataIni.ForeColor = Color.Gray;
                lblDataF.Visible = true;
                txtDataFin.Visible = true;
                txtDataFin.Text = "ddMMyyyy";
                txtDataFin.ForeColor = Color.Gray;
                btnBusca.Visible = true;

            }
            else if(cbBusca.SelectedIndex == 1)
            {
                cbAnimalBusca.Visible = true;
                lblAnimal.Visible = true;
                txtDataIni.Visible = false;
                lblDataI.Visible = false;
                txtDataFin.Visible = false;
                lblDataF.Visible = false;
                btnBusca.Visible = true;
            }
        }

        private void txtDataI_Click(object sender, EventArgs e)
        {
            if (txtDataIni.Text == "ddMMyyyy")
            {
                txtDataIni.Text = "";
            }
            txtDataIni.ForeColor = Color.Black;

        }

        private void txtDataF_Click(object sender, EventArgs e)
        {
            if (txtDataFin.Text == "ddMMyyyy")
            {
                txtDataFin.Text = "";
            }
            txtDataFin.ForeColor = Color.Black;

        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            if(cbBusca.SelectedIndex == 0 && txtDataIni.Text != "" && txtDataFin.Text != "")
            {
                buscaData(txtDataIni.Text, txtDataFin.Text);
            }
            else if(cbBusca.SelectedIndex == 1 && cbAnimalBusca.Text != "")
            {
                buscaAnimal((int)cbAnimalBusca.SelectedValue);
            }

            lblQtdLinhas.Text = dataGridView1.Rows.Count.ToString() + " linhas selecionada(s).";
        }

        private void buscaData (string dataI, string dataF)
        {
            System.Net.Http.HttpResponseMessage response = client.GetAsync("http://webapifazenda.azurewebsites.net/api/vacinacoes/data/"+dataI+"/"+dataF).Result;

            if (response.IsSuccessStatusCode)
            {
                animaisURI = response.Headers.Location;

                var vacinacoes = response.Content.ReadAsAsync<IEnumerable<Vacinacao>>().Result;

                dataGridView1.DataSource = vacinacoes;

            }


            else
                MessageBox.Show("Não foi possível obter o estoque : " + response.StatusCode);
        }

        private void buscaAnimal (int idAnimal)
        {
            System.Net.Http.HttpResponseMessage response = client.GetAsync("http://webapifazenda.azurewebsites.net/api/vacinacoes/animal/" + idAnimal).Result;

            if (response.IsSuccessStatusCode)
            {
                animaisURI = response.Headers.Location;

                var vacinacoes = response.Content.ReadAsAsync<IEnumerable<Vacinacao>>().Result;

                dataGridView1.DataSource = vacinacoes;

            }


            else
                MessageBox.Show("Não foi possível obter o estoque : " + response.StatusCode);
        }
    }
}
