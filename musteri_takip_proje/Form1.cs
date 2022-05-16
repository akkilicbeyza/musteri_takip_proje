using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musteri_takip_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Formlar.FrmDepartmanlar frm;
        private void btnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm == null || frm.IsDisposed)
            {
                frm = new Formlar.FrmDepartmanlar();
                frm.MdiParent = this;
                frm.Show();
            }
        }
        Formlar.FrmMusteriler frm2;
        private void BtnMusteriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frm2 == null || frm2.IsDisposed)
            {
            frm2 = new Formlar.FrmMusteriler();
            frm2.MdiParent = this;
            frm2.Show();
            }
        }
        Formlar.FrmMusteriIstatistik frm3;
        private void BtnMusteriIstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm3 == null || frm3.IsDisposed)
            {
                frm3 = new Formlar.FrmMusteriIstatistik();
                frm3.MdiParent = this;
                frm3.Show();
            }
        }
        Formlar.FrmGorevListesi frm4;
        private void BtnGorevListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm4 == null || frm4.IsDisposed)
            {
                frm4 = new Formlar.FrmGorevListesi();
                frm4.MdiParent = this;
                frm4.Show();
            }
        }

        private void BtnGorevTanimla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmGorev fr = new Formlar.FrmGorev();
            fr.Show();
        }

        private void BtnGorevDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmGorevDetay fr = new Formlar.FrmGorevDetay();
            fr.Show();
        }
        Formlar.FrmAnaform frm5;
        private void BtnAnaForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm5 == null || frm5.IsDisposed)
            {
                frm5 = new Formlar.FrmAnaform();
                frm5.MdiParent = this;
                frm5.Show();
            }
        }
        Formlar.FrmAktifCagrilar fr;
        private void BtnAktifCagrilar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null || fr.IsDisposed)
            {
                fr = new Formlar.FrmAktifCagrilar();
                fr.MdiParent = this;
                fr.Show();
            }
        }
        Formlar.FrmPasifCagrilar frm7;
        private void BtnPasifCagrilar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                if (frm7 == null || frm7.IsDisposed)
                {
                    frm7 = new Formlar.FrmPasifCagrilar();
                    frm7.MdiParent = this;
                    frm7.Show();
                }
        }
        Formlar.FrmAktifGorevler frm8;
        private void BtnAktifGorevler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm8 == null || frm8.IsDisposed)
            {
                frm8 = new Formlar.FrmAktifGorevler();
                frm8.MdiParent = this;
                frm8.Show();
            }
        }
        Formlar.FrmTamamlananGorevler frm9;
        private void BtnTamamlananGorevler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm9 == null || frm9.IsDisposed)
            {
                frm9 = new Formlar.FrmTamamlananGorevler();
                frm9.MdiParent = this;
                frm9.Show();
            }
        }

        private void BtnHesapMakinesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmHesapMakinesi hm = new Formlar.FrmHesapMakinesi();
            hm.Show();
        }

        private void BtnInstagram_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        System.Diagnostics.Process.Start("https://www.instagram.com/cuzineelazig/");
        }

        private void BtnKur_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.bloomberght.com/doviz");
        }
        private void BtnHarita_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/maps/place/Cuzine/@38.6678925,39.1719846,17z/data=!3m1!4b1!4m5!3m4!1s0x4076c025dcc2638d:0x95e507249465f648!8m2!3d38.6678743!4d39.1741107");
        }
        private void BtnFirmaListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmFirmalar frmfirma = new Formlar.FrmFirmalar();
            frmfirma.MdiParent = this;
            frmfirma.Show();
        }

        private void BtnDepartmanIstatistikleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmDepartmanIstatistikleri frm = new Formlar.FrmDepartmanIstatistikleri();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnFirmaIstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmFirmaIstatistikleri frm = new Formlar.FrmFirmaIstatistikleri();
            frm.MdiParent = this;
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }
    }
}
