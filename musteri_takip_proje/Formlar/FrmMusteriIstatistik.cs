using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using musteri_takip_proje.Entity;

namespace musteri_takip_proje.Formlar
{
    public partial class FrmMusteriIstatistik : Form
    {
        public FrmMusteriIstatistik()
        {
            InitializeComponent();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }
        DbmusteriTakipEntities db = new DbmusteriTakipEntities();
        private void FrmMusteriIstatistik_Load(object sender, EventArgs e)
        {
            LblToplamDepartman.Text = db.TblDepartmanlar.Count().ToString();
            LblToplamFirma.Text = db.TblFirmalar.Count().ToString();
            LblToplamMusteri.Text = db.TblMusteri.Count().ToString();
            LblAktifİs.Text = db.TblGorevler.Count(x => x.Durum == true).ToString();
            LblPasifİs.Text = db.TblGorevler.Count(x => x.Durum == false).ToString();
            LblSonGorev.Text = db.TblGorevler.OrderByDescending(x => x.ID).Select(x => x.Aciklama).FirstOrDefault();
            LblSonGorevDetay.Text = db.TblGorevler.OrderByDescending(x => x.ID).Select(x => x.Tarih).FirstOrDefault().ToString();
            LblİsYapilanSehir.Text = db.TblFirmalar.Select(x => x.İl).Distinct().Count().ToString();
            LblSektor.Text = db.TblFirmalar.Select(x => x.Sektör).Distinct().Count().ToString();
            DateTime bugun = DateTime.Today;
           // LblBugunkiGorev.Text = db.TblGorevler.Count(x => x.Tarih == bugun).ToString();
            LblAyinDepartmani.Text = db.TblDepartmanlar.Where(x => x.ID == 7).Select(y => y.Ad).FirstOrDefault().ToString();
        }
    }
}
