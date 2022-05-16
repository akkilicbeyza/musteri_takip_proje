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
    public partial class FrmFirmaIstatistikleri : Form
    {
        public FrmFirmaIstatistikleri()
        {
            InitializeComponent();
        }
        DbmusteriTakipEntities db = new DbmusteriTakipEntities();
        private void FrmFirmaIstatistikleri_Load(object sender, EventArgs e)
        {
            chartControl1.Series["Firmalar"].Points.AddPoint("SMEG",100);
            chartControl1.Series["Firmalar"].Points.AddPoint("FRANKE",500);
            chartControl1.Series["Firmalar"].Points.AddPoint("QUA GRANİT",800);
            chartControl1.Series["Firmalar"].Points.AddPoint("DOMINOX",320);
            chartControl1.Series["Firmalar"].Points.AddPoint("ELİKA",50);
            chartControl1.Series["Firmalar"].Points.AddPoint("DUPONT CORIAN",1000);
            chartControl1.Series["Firmalar"].Points.AddPoint("CUZİNE",1500);
        }
    }
}
