using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musteri_takip_proje.Formlar
{
    public partial class FrmHesapMakinesi : Form
    {
        public FrmHesapMakinesi()
        {
            InitializeComponent();
        }

        private void SeciliButonlar(object sender, EventArgs e)
        {
            if (TxtEkran.Text == "0")
            {
                TxtEkran.Text = " ";
            }
            TxtEkran.Text = TxtEkran.Text + ((SimpleButton)sender).Text;
        }

        private void BtnNokta_Click(object sender, EventArgs e)
        {
            if (TxtEkran.Text.IndexOf(".")< 1)
            {
                TxtEkran.Text = TxtEkran.Text + ".";
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            TxtEkran.Text = "0";
        }

        private void BtnKucuk_Click(object sender, EventArgs e)
        {
            TxtEkran.Text = TxtEkran.Text.Substring(0,TxtEkran.Text.Length-1);
            if (TxtEkran.Text == " ")
            {
                TxtEkran.Text = "0";
            }
        }

        double sayi1, sayi2, sonuc;

        private void BtnTopla_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(TxtEkran.Text);
            TxtEkran.Text = "0";
            secim = 1;
        }

        private void BtnCikar_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(TxtEkran.Text);
            TxtEkran.Text = "0";
            secim = 2;
        }

        private void BtnCarp_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(TxtEkran.Text);
            TxtEkran.Text = "0";
            secim = 3;
        }

        private void BtnBol_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(TxtEkran.Text);
            TxtEkran.Text = "0";
            secim = 4;
        }

        private void BtnEsittir_Click(object sender, EventArgs e)
        {
            sayi2 = double.Parse(TxtEkran.Text);
            if (secim == 1)
            {
                sonuc = sayi1 + sayi2;
                TxtEkran.Text = sonuc.ToString();
            }
            if (secim == 2)
            {
                sonuc = sayi1 - sayi2;
                TxtEkran.Text = sonuc.ToString();
            }
            if (secim == 3)
            {
                sonuc = sayi1 * sayi2;
                TxtEkran.Text = sonuc.ToString();
            }
            if (secim == 4)
            {
                sonuc = sayi1 / sayi2;
                TxtEkran.Text = sonuc.ToString();
            }
        }

        private void FrmHesapMakinesi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
            {
                Btn0.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
            {
                Btn1.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
            {
                Btn2.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
            {
                Btn3.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
            {
                Btn4.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
            {
                Btn5.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
            {
                Btn6.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
            {
                Btn7.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
            {
                Btn8.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
            {
                Btn9.PerformClick();
            }
        }

        int secim = 0;
        private void FrmHesapMakinesi_Load(object sender, EventArgs e)
        {
            
        }
    }
}
