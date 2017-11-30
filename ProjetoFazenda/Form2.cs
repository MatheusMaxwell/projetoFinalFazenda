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
    public partial class Form2 : Form
    {
        HttpClient client;
        Uri animaisURI;

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
        int ID = 0;
        public Form2()
        {
            InitializeComponent();
            if (client == null)
            {
                client = new HttpClient();
                client.BaseAddress = new Uri("http://webapifazenda.azurewebsites.net");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            }
            getAll();
            getAllComboBox();
            ClearData();
        }

        private async void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && cbSexo.Text != "" && txtProp.Text != ""  && txtRaca.Text != "" && cbEspecie.Text != "" && txtNascimento.Text != "")
            {
                Animal anim = new Animal();
                anim.Nome = txtNome.Text;
                if (cbSexo.SelectedIndex == 0)
                    anim.Sexo = "M";
                else
                    anim.Sexo = "F";
                anim.Proprietario = txtProp.Text;
                anim.Raca = txtRaca.Text;
                anim.Especie = (int)cbEspecie.SelectedValue;
                anim.DataNascimento = DateTime.Parse(txtNascimento.Text);
                anim.EspecieNome = cbEspecie.Text;

                using (var client = new HttpClient())
                {
                    var serializedMaterial = JsonConvert.SerializeObject(anim);
                    var content = new StringContent(serializedMaterial, Encoding.UTF8, "application/json");
                    var result = await client.PostAsync("http://webapifazenda.azurewebsites.net/api/animals", content);
                    if (result.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Animal adicionado!");
                        getAll();
                        ClearData();
                    }

                    else
                        MessageBox.Show("Erro ao adicionar animal!");
                }
                
            }
            else
            {
                MessageBox.Show("Verifique se os campos foram preenchidos.");
            }
        }

        private void getAll()
        {
            ClearData();
            System.Net.Http.HttpResponseMessage response = client.GetAsync("http://webapifazenda.azurewebsites.net/api/animals").Result;

            if (response.IsSuccessStatusCode)
            {
                animaisURI = response.Headers.Location;

                var animais = response.Content.ReadAsAsync<IEnumerable<Animal>>().Result;

                dataGridView1.DataSource = animais;

            }


            else
                MessageBox.Show("Não foi possível obter o estoque : " + response.StatusCode);
            lblQtdLinhas.Text = dataGridView1.Rows.Count.ToString() + " linhas selecionada(s).";
        }
        //Clear Data  
        private void ClearData()
        {
            txtNome.Text = "";
            cbSexo.Text = "";
            txtProp.Text = "";
            txtNascimento.Text = "dd/MM/yyyy";
            txtNascimento.ForeColor = Color.Gray;
            txtRaca.Text = "";
            cbEspecie.Text = "";
            ID = 0;
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && cbSexo.Text != "" && txtProp.Text != "" && txtRaca.Text != "" && cbEspecie.Text != "")
            {
                Animal anim = new Animal();
                anim.Nome = txtNome.Text;
                if (cbSexo.SelectedIndex == 0)
                    anim.Sexo = "M";
                else
                    anim.Sexo = "F";
                anim.Proprietario = txtProp.Text;
                anim.Raca = txtRaca.Text;
                anim.Especie = (int)cbEspecie.SelectedValue;
                anim.DataNascimento = DateTime.Parse(txtNascimento.Text);
                anim.EspecieNome = cbEspecie.Text;
                anim.Id = ID;
                using (var client = new HttpClient())
                {
                    HttpResponseMessage responseMessage = await client.PutAsJsonAsync("http://webapifazenda.azurewebsites.net/api/animals" + "/" + ID, anim);
                    if (responseMessage.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Animal alterado!");
                        getAll();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao alterar o animal : " + responseMessage.StatusCode);
                    }
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos!");
            }
       
        }


        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                DialogResult result = MessageBox.Show("Deseja realmente exluir este animal? \n ID:"+ID+" || Nome:"+txtNome.Text, "Alerta", MessageBoxButtons.YesNo);
                if(result == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = new Uri("http://webapifazenda.azurewebsites.net/api/animals");
                        HttpResponseMessage responseMessage = await client.DeleteAsync(String.Format("{0}/{1}", "http://webapifazenda.azurewebsites.net/api/animals", ID));
                        if (responseMessage.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Animal excluído com sucesso!");
                            getAll();
                        }
                        else
                        {
                            if (responseMessage.StatusCode.ToString().Contains("InternalServerErro"))
                            {
                                MessageBox.Show("Este animal já está associada a uma vacinaçao.");
                            }
                            else
                            {
                                MessageBox.Show("Falha ao excluir o animal: " + responseMessage.StatusCode.ToString());
                            }
                        }
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Selecione o animal para deletar.");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'bDFazendaDataSet1.Especie' table. You can move, or remove it, as needed.
            //this.especieTableAdapter1.Fill(this.bDFazendaDataSet1.Especie);
            //// TODO: This line of code loads data into the 'bDFazendaDataSet.Especie' table. You can move, or remove it, as needed.
            //this.especieTableAdapter.Fill(this.bDFazendaDataSet.Especie);

        }

        private void getAllComboBox()
        {
            System.Net.Http.HttpResponseMessage response = client.GetAsync("http://webapifazenda.azurewebsites.net/api/especies").Result;

            if (response.IsSuccessStatusCode)
            {
                animaisURI = response.Headers.Location;

                var especies = response.Content.ReadAsAsync<IEnumerable<Especie>>().Result;

                cbEspecie.DataSource = especies;
                cbEspecie.DisplayMember = "Descricao";
                cbEspecie.ValueMember = "Id";

                cbBuscaEspecie.DataSource = especies;
                cbBuscaEspecie.DisplayMember = "Descricao";
                cbBuscaEspecie.ValueMember = "Id";


            }


            else
                MessageBox.Show("Não foi possível concluir a busca: " + response.StatusCode);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtNome.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(); ;
                cbSexo.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(); ;
                txtProp.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(); ;
                txtNascimento.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(); ;
                txtRaca.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString(); ;
                cbEspecie.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString(); ;

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getAll();
        }

        private void txtNascimento_Click(object sender, EventArgs e)
        {
            if (txtNascimento.Text == "dd/MM/yyyy")
            {
                txtNascimento.Text = "";
            }
            txtNascimento.ForeColor = Color.Black;

        }

        private void cbBusca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBusca.SelectedIndex == 0) //nome
            {
                lblBusca1.Text = "Nome:";
                lblBusca1.Visible = true;
                txtBusca1.Visible = true;
                txtBusca1.Text = "";
                cbBuscaEspecie.Visible = false;
                lblDataF.Visible = false;
                txtDataFBusca.Visible = false;
                lblSexoBusca.Visible = false;
                cbBuscaSexo.Visible = false;
                btnBusca.Visible = true;
                
            }
            else if (cbBusca.SelectedIndex == 1)//sexo
            {
                lblBusca1.Text = "";
                lblBusca1.Visible = false;
                txtBusca1.Visible = false;
                cbBuscaEspecie.Visible = false;
                lblDataF.Visible = false;
                txtDataFBusca.Visible = false;
                lblSexoBusca.Visible = true;
                cbBuscaSexo.Visible = true;
                btnBusca.Visible = true;
            }
            else if (cbBusca.SelectedIndex == 2)//nascimento
            {
                lblBusca1.Text = "Data Inicial:";
                lblBusca1.Visible = true;
                txtBusca1.Visible = true;
                txtBusca1.Text = "ddMMyyyy";
                txtBusca1.ForeColor = Color.Gray;
                cbBuscaEspecie.Visible = false;
                lblDataF.Visible = true;
                txtDataFBusca.Visible = true;
                txtDataFBusca.Text = "ddMMyyyy";
                txtDataFBusca.ForeColor = Color.Gray;
                lblSexoBusca.Visible = false;
                cbBuscaSexo.Visible = false;
                btnBusca.Visible = true;
            }
            else if (cbBusca.SelectedIndex == 3)//sexo + nascimento
            {
                lblBusca1.Text = "Data Inicial:";
                lblBusca1.Visible = true;
                txtBusca1.Visible = true;
                txtBusca1.Text = "ddMMyyyy";
                txtBusca1.ForeColor = Color.Gray;
                cbBuscaEspecie.Visible = false;
                lblDataF.Visible = true;
                txtDataFBusca.Visible = true;
                txtDataFBusca.Text = "ddMMyyyy";
                txtDataFBusca.ForeColor = Color.Gray;
                lblSexoBusca.Visible = true;
                cbBuscaSexo.Visible = true;
                btnBusca.Visible = true;
            }
            else if (cbBusca.SelectedIndex == 4) //raca
            {
                lblBusca1.Text = "Raça:";
                lblBusca1.Visible = true;
                txtBusca1.Visible = true;
                txtBusca1.Text = "";
                cbBuscaEspecie.Visible = false;
                lblDataF.Visible = false;
                txtDataFBusca.Visible = false;
                lblSexoBusca.Visible = false;
                cbBuscaSexo.Visible = false;
                btnBusca.Visible = true;
            }
            else if (cbBusca.SelectedIndex == 5)//proprietario
            {
                lblBusca1.Text = "Proprietário:";
                lblBusca1.Visible = true;
                txtBusca1.Visible = true;
                txtBusca1.Text = "";
                cbBuscaEspecie.Visible = false;
                lblDataF.Visible = false;
                txtDataFBusca.Visible = false;
                lblSexoBusca.Visible = false;
                cbBuscaSexo.Visible = false;
                btnBusca.Visible = true;
            }
            else if (cbBusca.SelectedIndex == 6) //especie
            {
                lblBusca1.Text = "Espécie:";
                lblBusca1.Visible = true;
                txtBusca1.Visible = false;
                cbBuscaEspecie.Visible = true;
                lblDataF.Visible = false;
                txtDataFBusca.Visible = false;
                lblSexoBusca.Visible = false;
                cbBuscaSexo.Visible = false;
                btnBusca.Visible = true;
            }
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            if (cbBusca.SelectedIndex == 0) //nome
            {
                if (txtBusca1.Text != "")
                    GetBuscaNome(txtBusca1.Text);
                else
                    MessageBox.Show("Preencha o campo!");

            }
            else if (cbBusca.SelectedIndex == 1)//sexo
            {
                if (cbBuscaSexo.SelectedIndex == 0)
                    GetBuscaSexo("M");
                else if (cbBuscaSexo.SelectedIndex == 1)
                    GetBuscaSexo("F");
                else
                    MessageBox.Show("Preencha o campo!");
            }
            else if (cbBusca.SelectedIndex == 2)//nascimento
            {
                if (txtBusca1.Text != "" && txtDataFBusca.Text != "")
                    GetBuscaNascimento(txtBusca1.Text, txtDataFBusca.Text);
                else
                    MessageBox.Show("Preencha os campos!");
            }
            else if (cbBusca.SelectedIndex == 3)//sexo + nascimento
            {
                if (txtBusca1.Text != "" && txtDataFBusca.Text != "" && cbBuscaSexo.Text != "")
                    if (cbBuscaSexo.SelectedIndex == 0)
                        GetBuscaSexoNascimento(txtBusca1.Text, txtDataFBusca.Text, "M");
                    else if(cbBuscaSexo.SelectedIndex == 1)
                        GetBuscaSexoNascimento(txtBusca1.Text, txtDataFBusca.Text, "F");
                else
                        MessageBox.Show("Preencha os campos!");
            }
            else if (cbBusca.SelectedIndex == 4) //raca
            {
                if (txtBusca1.Text != "")
                    GetBuscaRaca(txtBusca1.Text);
                else
                    MessageBox.Show("Preencha o campo!");
            }
            else if (cbBusca.SelectedIndex == 5)//proprietario
            {
                if (txtBusca1.Text != "")
                    GetBuscaProp(txtBusca1.Text);
                else
                    MessageBox.Show("Preencha o campo!");
            }
            else if (cbBusca.SelectedIndex == 6) //especie
            {
                if (cbBuscaEspecie.Text != "")
                    GetBuscaEspecie((int)cbBuscaEspecie.SelectedValue);
                else
                    MessageBox.Show("Preencha o campo!");
            }
            lblQtdLinhas.Text = dataGridView1.Rows.Count.ToString() + " linhas selecionada(s).";
        }

        private void GetBuscaNome(string nome)
        {
            System.Net.Http.HttpResponseMessage response = client.GetAsync("http://webapifazenda.azurewebsites.net/api/animals/nome/" + nome).Result;

            if (response.IsSuccessStatusCode)
            {
                animaisURI = response.Headers.Location;

                var animais = response.Content.ReadAsAsync<IEnumerable<Animal>>().Result;

                dataGridView1.DataSource = animais;

            }


            else
                MessageBox.Show("Não foi possível obter o estoque : " + response.StatusCode);
        }

        private void GetBuscaSexo(string sexo)
        {
            System.Net.Http.HttpResponseMessage response = client.GetAsync("http://webapifazenda.azurewebsites.net/api/animals/sexo/" + sexo).Result;

            if (response.IsSuccessStatusCode)
            {
                animaisURI = response.Headers.Location;

                var animais = response.Content.ReadAsAsync<IEnumerable<Animal>>().Result;

                dataGridView1.DataSource = animais;

            }


            else
                MessageBox.Show("Não foi possível obter o estoque : " + response.StatusCode);
        }

        private void GetBuscaNascimento(string dataI, string dataF)
        {
            System.Net.Http.HttpResponseMessage response = client.GetAsync("http://webapifazenda.azurewebsites.net/api/animals/data/" + dataI +"/"+dataF).Result;

            if (response.IsSuccessStatusCode)
            {
                animaisURI = response.Headers.Location;

                var animais = response.Content.ReadAsAsync<IEnumerable<Animal>>().Result;

                dataGridView1.DataSource = animais;

            }


            else
                MessageBox.Show("Não foi possível obter o estoque : " + response.StatusCode);
        }

        private void GetBuscaSexoNascimento(string dataI, string dataF, string sexo)
        {
            System.Net.Http.HttpResponseMessage response = client.GetAsync("http://webapifazenda.azurewebsites.net/api/animals/dataSexo/" + dataI + "/"+dataF+"/"+sexo).Result;

            if (response.IsSuccessStatusCode)
            {
                animaisURI = response.Headers.Location;

                var animais = response.Content.ReadAsAsync<IEnumerable<Animal>>().Result;

                dataGridView1.DataSource = animais;

            }


            else
                MessageBox.Show("Não foi possível obter o estoque : " + response.StatusCode);
        }

        private void GetBuscaRaca(string raca)
        {
            System.Net.Http.HttpResponseMessage response = client.GetAsync("http://webapifazenda.azurewebsites.net/api/animals/raca/" + raca).Result;

            if (response.IsSuccessStatusCode)
            {
                animaisURI = response.Headers.Location;

                var animais = response.Content.ReadAsAsync<IEnumerable<Animal>>().Result;

                dataGridView1.DataSource = animais;

            }


            else
                MessageBox.Show("Não foi possível obter o estoque : " + response.StatusCode);
        }

        private void GetBuscaProp(string prop)
        {
            System.Net.Http.HttpResponseMessage response = client.GetAsync("http://webapifazenda.azurewebsites.net/api/animals/proprietario/" + prop).Result;

            if (response.IsSuccessStatusCode)
            {
                animaisURI = response.Headers.Location;

                var animais = response.Content.ReadAsAsync<IEnumerable<Animal>>().Result;

                dataGridView1.DataSource = animais;

            }


            else
                MessageBox.Show("Não foi possível obter o estoque : " + response.StatusCode);
        }

        private void GetBuscaEspecie (int id)
        {
            System.Net.Http.HttpResponseMessage response = client.GetAsync("http://webapifazenda.azurewebsites.net/api/animals/especie/" + id).Result;

            if (response.IsSuccessStatusCode)
            {
                animaisURI = response.Headers.Location;

                var animais = response.Content.ReadAsAsync<IEnumerable<Animal>>().Result;

                dataGridView1.DataSource = animais;

            }


            else
                MessageBox.Show("Não foi possível obter o estoque : " + response.StatusCode);
        }

        private void txtBusca1_Click(object sender, EventArgs e)
        {
            if (txtBusca1.Text == "ddMMyyyy")
            {
                txtBusca1.Text = "";
            }
            txtBusca1.ForeColor = Color.Black;

        }

        private void txtDataFBusca_Click(object sender, EventArgs e)
        {
            if (txtDataFBusca.Text == "ddMMyyyy")
            {
                txtDataFBusca.Text = "";
            }
            txtDataFBusca.ForeColor = Color.Black;

        }
    }
}
