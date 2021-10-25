using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMABIOMETRICO6SEM
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://mmanivel3.lovestoblog.com/nivel2/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar o seu acesso e retornar ao menu principal?", "Sair",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Form inicio = new frmInicio();
                inicio.Show();
            }
        }
    }
}
