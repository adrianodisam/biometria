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
    public partial class Form2 : Form
    {
        public Form2()
        {

            InitializeComponent();
           

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }
        private void FrmLogin_Unload(object sender, FormClosingEventArgs e)
        {
            // Exibe uma caixa de menssagem e obtem o resutado da escolha do usuario
            DialogResult Dialogo = MessageBox.Show("Voce deseja realmente fechar o aplicativo?", "Fechar Aplicativo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            // I    dentifica a escolha do usu�rio
            switch (Dialogo)
            {
                case DialogResult.Yes:
                    // Permite que o aplicativo seja fechado(esta linha é superflua, esta aqui apenas para exemplo)
                    e.Cancel = true;
                    break;
                case DialogResult.No:
                    // Impede que o aplicativo seja fechado
                    e.Cancel = false;
                    break;
                case DialogResult.Cancel:
                    // Impede que o aplicativo seja fechado
                    e.Cancel = true;
                    break;
            }

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            webBrowser1.Navigate("http://mmanivel1.lovestoblog.com/");

           
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
