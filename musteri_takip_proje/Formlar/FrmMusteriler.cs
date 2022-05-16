using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using musteri_takip_proje.Entity;

namespace musteri_takip_proje.Formlar
{
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        DbmusteriTakipEntities db = new DbmusteriTakipEntities();
        void musteriler()
        {
            var degerler = from x in db.TblMusteri
                           select new
                           {
                               x.ID,
                               x.Ad,
                               x.Soyad,
                               x.Telefon,
                               x.Departman,
                               x.Adres
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            musteriler();

            var departmanlar = (from x in db.TblDepartmanlar
                                select new
                                {
                                    x.ID,
                                    x.Ad
                                }).ToList();

            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "Ad";
            lookUpEdit1.Properties.DataSource = departmanlar;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            musteriler();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TblMusteri t = new TblMusteri();
            t.Ad = TxtAd.Text;
            t.Soyad = TxtSoyad.Text;
            t.Telefon = TxtTelefon.Text;
            t.Adres = TxtAdres.Text;
            t.Departman = int.Parse(lookUpEdit1.EditValue.ToString());
            db.TblMusteri.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Yeni Müşteri Kaydı Başarılı Bir Şekilde Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            musteriler();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var x = int.Parse(TxtID.Text);
            var deger = db.TblMusteri.Find(x);
            db.SaveChanges();
            XtraMessageBox.Show("Müşteri Başarılı Bir Şekilde Silindi. Silinen Müşteriler Listesinden Tüm Silinmiş Müşterilere Ulaşabilirsiniz. ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            musteriler();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
            TxtSoyad.Text = gridView1.GetFocusedRowCellValue("Soyad").ToString();
            TxtTelefon.Text = gridView1.GetFocusedRowCellValue("Telefon").ToString();
            TxtAdres.Text = gridView1.GetFocusedRowCellValue("Adres").ToString();
            lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("Departman").ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(TxtID.Text);
            var deger = db.TblMusteri.Find(x);
            deger.Ad = TxtAd.Text;
            deger.Soyad = TxtSoyad.Text;
            deger.Telefon = TxtTelefon.Text;
            deger.Adres = TxtAdres.Text;
            deger.Departman = int.Parse(lookUpEdit1.EditValue.ToString());
            db.SaveChanges();
            XtraMessageBox.Show("Müşteri Bilgileri Başarılı Bir Şekilde Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Question);
            musteriler();
        }
    }
}
