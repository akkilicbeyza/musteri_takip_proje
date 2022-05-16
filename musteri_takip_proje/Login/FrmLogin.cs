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

namespace musteri_takip_proje.Login
{


    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        DbmusteriTakipEntities db = new DbmusteriTakipEntities();
        Form1 fr = new Form1();

        private void textEdit1_Click(object sender, EventArgs e)
        {
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
        }

        private void textEdit2_Click(object sender, EventArgs e)
        {
            panel3.BackColor = SystemColors.Control;
            panel4.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1 fr = new Form1();
            //fr.Show();
            var admin = db.TblAdmin.Where(x => x.Kullanici == txtKullaniciAdi.Text && x.Sifre == txtSifre.Text).FirstOrDefault();
            if (admin != null)
            {
                fr.Show();
            }
            else
            {
                XtraMessageBox.Show("Hatalı Giriş Yaptınız, Lütfen Tekrar Deneyiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void linkLabelKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
