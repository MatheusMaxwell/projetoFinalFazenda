using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFazenda
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=tcp:myserverm.database.windows.net,1433;Initial Catalog=BDFazenda;Persist Security Info=False;User ID=MatheusMeireles;Password=Hebreu36221899;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtSenha.Text != "")
            {
                if (verificaLogin())
                {
                    this.Hide();
                    Strip st = new Strip(txtNome.Text);
                    st.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("Dados inválidos!");
            }
            else
                MessageBox.Show("Preencha os campos!");
            

        }

        private Boolean verificaLogin()
        {
            string sql = "SELECT Login, Senha from Conta";

            cmd = new SqlCommand(sql, conn);

            conn.Open();

            SqlDataReader leitor = cmd.ExecuteReader();
            string str1 = "";
            string login = txtNome.Text.ToUpper();
            string senha = Criptografia(txtSenha.Text);
            while (leitor.Read())
            {
                str1 = leitor["Login"].ToString().ToUpper();
                if (str1.Equals(login) && senha.Equals(leitor["Senha"].ToString()))
                {
                    conn.Close();
                    return true;
                }
            }
            conn.Close();
            return false;
        }

        private string Criptografia (string valor)
        {
            string strHex = "";
            try
            {
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] HashValue, MessageBytes = UE.GetBytes(valor);
                SHA512Managed SHhash = new SHA512Managed();
                
                HashValue = SHhash.ComputeHash(MessageBytes);
                foreach (byte b in HashValue)
                {
                    strHex += String.Format("{0:x2}", b);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
            return strHex;
        }
    }
}
