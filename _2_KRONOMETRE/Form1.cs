using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_KRONOMETRE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Saat = 0, Dakika = 0, Saniye = 0, Salise = 0;
        int saniye = 60;
        int dakika = 0;

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnSifirla.Enabled = true;
            btnBasla.Text = "SÜRDÜR";
            btnBasla.Enabled = true;
            btnDurdur.Enabled = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 10;

            
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 10;
            Salise++;

            if (Salise == 100)
            {
                Salise = 0;
                Saniye++;

                if (Saniye == 60)
                {
                    Saniye = 0;
                    Dakika++;

                    if (Dakika == 60)
                    {
                        Dakika = 0;
                        Saat++;
                    }
                }
            }

            textSalise.Text = String.Format("{0:D2}", Salise);
            textSaniye.Text = String.Format("{0:D2}", Saniye);
            textDakika.Text = String.Format("{0:D2}", Dakika);
            textSaat.Text = String.Format("{0:D2}", Saat);
        }


        private void btnSifirla_Click(object sender, EventArgs e)
        {
            Saat = 0;
            Dakika = 0;
            Saniye = 0;
            Salise = 0;

            textSalise.Text = "00";
            textSaniye.Text = "00";
            textDakika.Text = "00";
            textSaat.Text = "00";

            btnBasla.Enabled = true;
            btnBasla.Text = "BAŞLAT";
            btnDurdur.Enabled = false;
            btnSifirla.Enabled = false;
        }

        private void textSalise_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnGeriSayimaBasla_Click(object sender, EventArgs e)
        {
            timer2.Start();
            dakika = Convert.ToInt32(txtsayi.Text);
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1000;
            btnSifirla.Enabled = false;
            btnBasla.Enabled = false;
            btnDurdur.Enabled = true;
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 1000;
            saniye = saniye - 1;
            txtsaniye.Text = saniye.ToString();
            txtdakika.Text = (dakika - 1).ToString();
            if (saniye == 0)
            {
                dakika = dakika - 1;
                txtdakika.Text = dakika.ToString();
                saniye = 60;
            }
            if (txtdakika.Text == "-1")
            {
                timer2.Stop();
                txtdakika.Text = "00";
                txtsaniye.Text = "00";
            }
        }


    }
}
