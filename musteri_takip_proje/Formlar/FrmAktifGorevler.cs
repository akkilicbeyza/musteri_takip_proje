using musteri_takip_proje.Entity;
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
    public partial class FrmAktifGorevler : Form
    {
        public FrmAktifGorevler()
        {
            InitializeComponent();
        }

        private void FrmAktifGorevler_Load(object sender, EventArgs e)
        {
            DbmusteriTakipEntities db = new DbmusteriTakipEntities();

            var gorevler = (from x in db.TblGorevler
                            select new
                            {
                                x.ID,
                                AdSoyad = x.TblMusteri.Ad + " " + x.TblMusteri.Soyad,
                                x.Aciklama,
                                x.Durum,
                                x.Tarih
                            }).Where(y => y.Durum == true).ToList();
            gridControl1.DataSource = gorevler;
        }
    }
}
