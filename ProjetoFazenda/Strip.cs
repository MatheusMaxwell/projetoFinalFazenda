using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFazenda
{
    public partial class Strip : Form
    {

        public Strip(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
        }

        private void animaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeFormsChildren();
            Form2 f2 = new Form2();
            f2.MdiParent = this;
            f2.StartPosition = FormStartPosition.CenterScreen;
            f2.Show();

        }



        private void closeFormsChildren()
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].IsMdiChild)
                {
                    Application.OpenForms[i].Close();
                }
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void especiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeFormsChildren();
            Form3 f3 = new Form3();
            f3.MdiParent = this;
            f3.StartPosition = FormStartPosition.CenterScreen;
            f3.Show();
        }

        private void vacinaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeFormsChildren();
            Form4 f4 = new Form4();
            f4.MdiParent = this;
            f4.StartPosition = FormStartPosition.CenterScreen;
            f4.Show();
        }

        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeFormsChildren();
            Form6 f6 = new Form6(lblUsuario.Text);
            f6.MdiParent = this;
            f6.StartPosition = FormStartPosition.CenterScreen;
            f6.Show();
        }

        private void novaContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeFormsChildren();
            Form5 f5 = new Form5();
            f5.MdiParent = this;
            f5.StartPosition = FormStartPosition.CenterScreen;
            f5.Show();
        }
    }
}
