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
    public partial class FrmFirmalar : Form
    {
        public FrmFirmalar()
        {
            InitializeComponent();
        }
        DbmusteriTakipEntities db = new DbmusteriTakipEntities();
        void firmalar()
        {
            var degerler = from x in db.TblFirmalar
                           select new
                           {
                               x.ID,
                               x.Ad,
                               x.Yetkili,
                               x.Telefon,
                               x.Mail,
                               x.Sektör
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmFirmalar_Load(object sender, EventArgs e)
        {
            firmalar();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            firmalar();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TblFirmalar f = new TblFirmalar();
            f.Ad = TxtAd.Text;
            f.Yetkili = TxtYetkili.Text;
            f.Telefon = TxtTelefon.Text;
            f.Mail = TxtMail.Text;
            f.Sektör = TxtSektor.Text;
            db.TblFirmalar.Add(f);
            db.SaveChanges();
            XtraMessageBox.Show("Yeni Firma Kaydı Başarılı Bir Şekilde Gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            firmalar();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int x = int.Parse(TxtID.Text);
            var deger = db.TblFirmalar.Find(x);
            db.TblFirmalar.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show("Firma Silme İşlemi Başarılı Bir Şekilde Gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            firmalar();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
            TxtYetkili.Text = gridView1.GetFocusedRowCellValue("Yetkili").ToString();
            TxtTelefon.Text = gridView1.GetFocusedRowCellValue("Telefon").ToString();
            TxtMail.Text = gridView1.GetFocusedRowCellValue("Mail").ToString();
            TxtSektor.Text = gridView1.GetFocusedRowCellValue("Sektör").ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(TxtID.Text);
            var deger = db.TblFirmalar.Find(x);
            deger.Ad = TxtAd.Text;
            deger.Yetkili = TxtYetkili.Text;
            deger.Telefon = TxtTelefon.Text;
            deger.Mail = TxtMail.Text;
            deger.Sektör = TxtSektor.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Firma Güncelleme İşlemi Başarılı Bir Şekilde Gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            firmalar();
        }
    }
}
