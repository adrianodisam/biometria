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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnN1_Click(object sender, EventArgs e)
        {
            Variaveis.Acesso = "N1";
            Form nivel1 = new Form1();
            this.Hide();
            nivel1.Show();
        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            Variaveis.Acesso = "N2";
            Form nivel1 = new Form1();
            this.Hide();
            nivel1.Show();
        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            Variaveis.Acesso = "N3";
            Form nivel1 = new Form1();
            this.Hide();
            nivel1.Show();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes) Application.ExitThread();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
