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
    public partial class Form6 : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=tcp:myserverm.database.windows.net,1433;Initial Catalog=BDFazenda;Persist Security Info=False;User ID=MatheusMeireles;Password=Hebreu36221899;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        SqlCommand cmd;
        string usu;
        public Form6(string usuario)
        {
            InitializeComponent();
            usu = usuario;
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (verificarExistenciaLogin())
            {
                cmd = new SqlCommand("update Conta set Senha=@senha where Login=@login", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@login", usu);
                string senha = Criptografia(txtSenhaNova.Text);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Senha alterada!");
                txtSenhaAntiga.Text = "";
                txtSenhaNova.Text = "";
            }
            else
                MessageBox.Show("Dados inválidos!");
        }

        private Boolean verificarExistenciaLogin()
        {

            string sql = "SELECT Login, Senha from Conta";

            cmd = new SqlCommand(sql, conn);

            conn.Open();

            SqlDataReader leitor = cmd.ExecuteReader();
            string str1 = "";
            string str2 = usu.ToUpper();
            string senha = Criptografia(txtSenhaAntiga.Text);
            while (leitor.Read())
            {
                str1 = leitor["Login"].ToString().ToUpper();
                if (str1.Equals(str2) && senha.Equals(leitor["Senha"].ToString()))
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
