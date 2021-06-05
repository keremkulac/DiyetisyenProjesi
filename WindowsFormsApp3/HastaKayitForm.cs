using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class HastaKayitForm : Form
    {
        HastalarVeriTabani hastaKayit = new HastalarVeriTabani();
        HastaKayit hasta = new HastaKayit();
        DiyetFabrikasi diyetFabrika = new DiyetFabrikasi();
        public HastaKayitForm()
        {
            InitializeComponent();
        }
        void temizle()
        {
            cmbHastalikAd.Text = "";
            txtAd.Clear();
            txtSoyad.Clear();
            txtYas.Clear();
            txtKilo.Clear();
            txtTC.Clear();
            txtTelNo.Clear();
        }
        void HastaKayitAl()
        {
            hasta.HastalikAdi = cmbHastalikAd.Text;
            hasta.Ad = txtAd.Text;
            hasta.Soyad = txtSoyad.Text;
            hasta.TC = Convert.ToInt64(txtTC.Text);
            hasta.TelNo = Convert.ToInt64(txtTelNo.Text);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            HastaKayitAl();
            DiyetFabrikasi diyetFabrika = new DiyetFabrikasi();
            IDiyet diyet = diyetFabrika.diyetOlustur(hasta.HastalikAdi);
           
            hastaKayit.HastaEkle(new HastaKayit()
            {
                HastalikAdi = cmbHastalikAd.Text,
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Yas = Convert.ToInt32(txtYas.Text),
                Kilo = Convert.ToInt32(txtKilo.Text),
                TC = Convert.ToInt64(txtTC.Text),
                TelNo = Convert.ToInt64(txtTelNo.Text),
                DiyetTipi = diyet.DiyetVer(),
                Tarih = dateTimePicker1.Value.ToString("MM/dd/yyyy")
            });
            temizle();
            MessageBox.Show("Kayıt başarılı...");
        }

 

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
            GirisForm giris = new GirisForm();
            giris.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
