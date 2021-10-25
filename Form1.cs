using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SISTEMABIOMETRICO6SEM
{
    public partial class Form1 : Form
    {
        String arquivo;
        Bitmap digital;
        
        int[] h;
        int[] h2;
        int[] h3;
        int[] h4;
        int[] h5;
        int[] h6;
        int[] h7;
        int[] h8;

        

        String identificacao, ide;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "Insira a digital para acesso ao "+Variaveis.Acesso;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult d1 = openFileDialog1.ShowDialog();
            arquivo = openFileDialog1.FileName;
            if (d1 == System.Windows.Forms.DialogResult.OK)
            {
                    textBox1.Text = "";
                    Bitmap b1 = new Bitmap(arquivo);
                    Bitmap b2 = new Bitmap(b1.Width, b1.Height);

                    int fN = b1.Width;
                    int fM = b1.Height;
                    int[,] f = new int[fN, fM];

                    for (int x = 0; x < fN; x++)
                        for (int y = 0; y < fM; y++)
                            f[x, y] = (int)(0.3 * b1.GetPixel(x, y).R + 0.6 * b1.GetPixel(x, y).G + 0.1 * b1.GetPixel(x, y).B);

                    for (int x = 0; x < fN; x++)
                        for (int y = 0; y < fM; y++)
                            b2.SetPixel(x, y, Color.FromArgb(f[x, y], f[x, y], f[x, y]));

                    pictureBox1.Image = b2;
                    digital = b2;

                    Leitura();
                    Amostragem();
                    Login();
            }
        }

        public void Leitura()
        {
            int[] f = new int[this.digital.Width];
            int[] f2 = new int[this.digital.Width];
            int[] f3 = new int[this.digital.Width];
            int[] f4 = new int[this.digital.Width];
            int[] f5 = new int[this.digital.Width];
            int[] f6 = new int[this.digital.Width];
            int[] f7 = new int[this.digital.Width];
            int[] f8 = new int[this.digital.Width];

            int linha1 = this.digital.Height / 10;
            int linha2 = this.digital.Height / 8;
            int linha3 = this.digital.Height / 5;
            int linha4 = linha3 + linha1;
            int linha5 = this.digital.Height / 2;
            int linha6 = linha5 + linha1;
            int linha7 = linha5 + linha3;
            int linha8 = linha5 + linha3 + linha1;

            for (int x = 0; x < this.digital.Width; x++)
            {
                f[x] = digital.GetPixel(x, linha1).R;
                f2[x] = digital.GetPixel(x, linha2).R;
                f3[x] = digital.GetPixel(x, linha3).R;
                f4[x] = digital.GetPixel(x, linha4).R;
                f5[x] = digital.GetPixel(x, linha5).R;
                f6[x] = digital.GetPixel(x, linha6).R;
                f7[x] = digital.GetPixel(x, linha7).R;
                f8[x] = digital.GetPixel(x, linha8).R;
            }

            this.h = f;
            this.h2 = f2;
            this.h3 = f3;
            this.h4 = f4;
            this.h5 = f5;
            this.h6 = f6;
            this.h7 = f7;
            this.h8 = f8;

            int x0 = 0;
            int y0 = 255 - f[0];
            int y2 = 255 - f[1];
            int y3 = 255 - f[2];
            int y4 = 255 - f[3];
            int y5 = 255 - f[4];
            int y6 = 255 - f[5];
            int y7 = 255 - f[6];
            int y8 = 255 - f[7];


            for (int x = 0; x < this.digital.Width; x++)
            {
                x0 = x;
                y0 = 255 - f[x];
                y2 = 255 - f2[x];
                y3 = 255 - f3[x];
                y4 = 255 - f4[x];
                y5 = 255 - f5[x];
                y6 = 255 - f6[x];
                y7 = 255 - f7[x];
                y8 = 255 - f8[x];

            }

        }

        void Amostragem()
        {
           
            int l = 9;
            int[] v = new int[this.h.Count()];
            int[] v2 = new int[this.h.Count()];
            int[] v3 = new int[this.h.Count()];
            int[] v4 = new int[this.h.Count()];
            int[] v5 = new int[this.h.Count()];
            int[] v6 = new int[this.h.Count()];
            int[] v7 = new int[this.h.Count()];
            int[] v8 = new int[this.h.Count()];

            int partes = this.h.Count() / 32;
            int acum = 0;
            int acum2 = 0;
            int acum3 = 0;
            int acum4 = 0;
            int acum5 = 0;
            int acum6 = 0;
            int acum7 = 0;
            int acum8 = 0;

            for (int x = 0; x < this.h.Count(); x++)
            {
                for (int j = 0; j < partes; j++)
                {
                    if (x + j >= this.h.Count()) { break; }
                    // acumula e tira média
                    acum += this.h[x + j] * l / this.digital.Height;
                    acum2 += this.h2[x + j] * l / this.digital.Height;
                    acum3 += this.h3[x + j] * l / this.digital.Height;
                    acum4 += this.h4[x + j] * l / this.digital.Height;
                    acum5 += this.h5[x + j] * l / this.digital.Height;
                    acum6 += this.h6[x + j] * l / this.digital.Height;
                    acum7 += this.h7[x + j] * l / this.digital.Height;
                    acum8 += this.h8[x + j] * l / this.digital.Height;
                }

                v[x] = acum / partes; acum = 0;
                v2[x] = acum2 / partes; acum2 = 0;
                v3[x] = acum3 / partes; acum3 = 0;
                v4[x] = acum4 / partes; acum4 = 0;
                v5[x] = acum5 / partes; acum5 = 0;
                v6[x] = acum6 / partes; acum6 = 0;
                v7[x] = acum6 / partes; acum7 = 0;
                v8[x] = acum8 / partes; acum8 = 0;

                Variaveis.t += v[x].ToString();
                Variaveis.t2 += v2[x].ToString();
                Variaveis.t3 += v3[x].ToString();
                Variaveis.t4 += v4[x].ToString();
                Variaveis.t5 += v5[x].ToString();
                Variaveis.t6 += v6[x].ToString();
                Variaveis.t7 += v7[x].ToString();
                Variaveis.t8 += v8[x].ToString();

                x += partes;
            }

            Variaveis.t += Variaveis.t2 + Variaveis.t3 + Variaveis.t4 + Variaveis.t5 + Variaveis.t6 + Variaveis.t7 + Variaveis.t8;

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form inicio = new frmInicio();
            inicio.Show();
        }

        void Login()
        {
            
            identificacao = Variaveis.t;
            textBox1.Text = identificacao;
            Boolean login = false;
            double idd = double.Parse(identificacao);
            try
            {
                
                
                using (StreamReader sr = new StreamReader("cadastro.txt"))
                {
                    String line;
                    string[] stringSeparators = new string[] { "," };
                    string[] id;
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        id = line.Split(stringSeparators, StringSplitOptions.None);

                        double td = double.Parse(Variaveis.t);
                        if ((idd / td < 1 && idd / td > 0) | (id[0] == Variaveis.t))
                        {
                            label1.Text = id[1].ToString();
                            ide = label1.Text;
                            login = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro consultando a base de dados","Erro",MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            if (login)
            {
              

                    if(Variaveis.Acesso == "N1" && (ide == "N1" || ide == "N2" || ide == "N3"))
                    {
                         MessageBox.Show("Acesso concedido com sucesso!", "Sistema", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                         Form2 f2 = new Form2();
                        this.Hide();
                        f2.Show();
                        Variaveis.Tentativas = 3;
                        Variaveis.t = "";
                        Variaveis.t2 = "";
                        Variaveis.t3 = "";
                        Variaveis.t4 = "";
                        Variaveis.t5 = "";
                        Variaveis.t6 = "";
                        Variaveis.t7 = "";
                        Variaveis.t8 = "";
                        textBox1.Text = "";
                }
                    else if(Variaveis.Acesso == "N2" && (ide == "N2" || ide == "N3"))
                    {

                         MessageBox.Show("Acesso concedido com sucesso!", "Sistema", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                        Form3 f3 = new Form3();
                        this.Hide();
                        f3.Show();
                        Variaveis.Tentativas = 3;
                        Variaveis.t = "";
                        Variaveis.t2 = "";
                        Variaveis.t3 = "";
                        Variaveis.t4 = "";
                        Variaveis.t5 = "";
                        Variaveis.t6 = "";
                        Variaveis.t7 = "";
                        Variaveis.t8 = "";
                        textBox1.Text = "";
                }

                    else if (Variaveis.Acesso == "N3" && (ide == "N3"))
                    {
    
                        MessageBox.Show("Acesso concedido com sucesso!", "Sistema", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        Form4 f4 = new Form4();
                        this.Hide();
                        f4.Show();
                        Variaveis.Tentativas = 3;
                        Variaveis.t = "";
                        Variaveis.t2 = "";
                        Variaveis.t3 = "";
                        Variaveis.t4 = "";
                        Variaveis.t5 = "";
                        Variaveis.t6 = "";
                        Variaveis.t7 = "";
                        Variaveis.t8 = "";
                        textBox1.Text = "";
                }

                    else
                    {
                        
                        Variaveis.Tentativas--;
                        Variaveis.t = "";
                        Variaveis.t2 = "";
                        Variaveis.t3 = "";
                        Variaveis.t4 = "";
                        Variaveis.t5 = "";
                        Variaveis.t6 = "";
                        Variaveis.t7 = "";
                        Variaveis.t8 = "";

                        if(Variaveis.Tentativas!= 0)
                    {
                        MessageBox.Show("Acesso Negado! A digital analisada não atende os critérios deste nível de privilégio. Resta(m) "+Variaveis.Tentativas+" tentativa(s)",
                         "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Acesso Negado! A digital analisada não atende os critérios deste nível de privilégio. Tentativas esgotadas, o sistema será encerrado!",
                         "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.ExitThread();
                    }
                        
                }

            }
                   

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes) Application.ExitThread();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
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



    }
}
