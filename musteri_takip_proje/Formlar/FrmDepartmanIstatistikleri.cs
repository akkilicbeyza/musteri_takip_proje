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
    public partial class FrmDepartmanIstatistikleri : Form
    {
        public FrmDepartmanIstatistikleri()
        {
            InitializeComponent();
        }

        private void FrmDepartmanIstatistikleri_Load(object sender, EventArgs e)
        {
            chartControl1.Series["Departmanlar"].Points.AddPoint("Mutfak",6);
            chartControl1.Series["Departmanlar"].Points.AddPoint("Banyo",4);
            chartControl1.Series["Departmanlar"].Points.AddPoint("Vestiyer",2);
            chartControl1.Series["Departmanlar"].Points.AddPoint("Tüm Proje",6);
            chartControl1.Series["Departmanlar"].Points.AddPoint("Toplu Proje",3);
            chartControl1.Series["Departmanlar"].Points.AddPoint("FRANKE",3);
            chartControl1.Series["Departmanlar"].Points.AddPoint("SMEG",2);
        }
    }
}
