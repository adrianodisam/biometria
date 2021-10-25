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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://mmanivel3.lovestoblog.com");
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

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
