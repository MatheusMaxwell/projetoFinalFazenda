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
    public partial class Form5 : Form
    {

        SqlConnection conn = new SqlConnection(@"Server=tcp:myserverm.database.windows.net,1433;Initial Catalog=BDFazenda;Persist Security Info=False;User ID=MatheusMeireles;Password=Hebreu36221899;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        SqlCommand cmd; 

        public Form5()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text != "" && txtSenha.Text != "" && txtSenha2.Text != "")
            {
                if (!verificarExistenciaLogin())
                {
                    string senha1 = Criptografia(txtSenha.Text);
                    string senha2 = Criptografia(txtSenha2.Text);
                    if (senha1 == senha2)
                    {
                        cmd = new SqlCommand("insert into Conta(Login, Senha) values (@login, @senha)", conn);
                        conn.Open();
                        cmd.Parameters.AddWithValue("@login", txtLogin.Text);
                        cmd.Parameters.AddWithValue("@senha", senha1);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Usuario inserido!");
                        txtLogin.Text = "";
                        txtSenha.Text = "";
                        txtSenha2.Text = "";
                    }
                    else
                        MessageBox.Show("Senhas distintas!");
                    
                }
                else
                    MessageBox.Show("Este login já está em uso.");
            }
            else
                MessageBox.Show("Preencha os campos!");
        }

        private Boolean verificarExistenciaLogin()
        {
            

            string sql = "SELECT Login from Conta";

            cmd = new SqlCommand(sql, conn);

            conn.Open();

            SqlDataReader leitor = cmd.ExecuteReader();
            string str1 = "";
            string str2 = txtLogin.Text.ToUpper();
            while (leitor.Read())
            {
                str1 = leitor["Login"].ToString().ToUpper();
                if (str1.Equals(str2))
                {
                    conn.Close();
                    return true;
                }
            }
            conn.Close();
            return false;

        }
        private string Criptografia(string valor)
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
