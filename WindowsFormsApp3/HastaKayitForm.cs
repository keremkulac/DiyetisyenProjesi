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
        HastaKayit eklenecekHasta = new HastaKayit();
        long MevcutHastaTC;
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

        private void lblKaydet_Click(object sender, EventArgs e)
        {
            HastaKayitAl();
            DiyetFabrikasi diyetFabrika = new DiyetFabrikasi();
            IDiyet diyet = diyetFabrika.diyetOlustur(hasta.HastalikAdi);

            eklenecekHasta.HastalikAdi = cmbHastalikAd.Text;
            eklenecekHasta.Ad = txtAd.Text;
            eklenecekHasta.Soyad = txtSoyad.Text;
            eklenecekHasta.Yas = Convert.ToInt32(txtYas.Text);
            eklenecekHasta.Kilo = Convert.ToInt32(txtKilo.Text);
            eklenecekHasta.TC = Convert.ToInt64(txtTC.Text);
            eklenecekHasta.TelNo = Convert.ToInt64(txtTelNo.Text);
            eklenecekHasta.DiyetTipi = diyet.DiyetVer();
            eklenecekHasta.Tarih = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            MevcutHastaTC = eklenecekHasta.TC;
            hastaKayit.HastaEkle(eklenecekHasta);
            temizle();
            MessageBox.Show("Kayıt başarılı...");

        }

        private void lblRaporVer_Click(object sender, EventArgs e)
        {
            this.Close();
            HastaRaporVer hastaRapor = new HastaRaporVer();
            hastaRapor.Show();
        }
        public List<string> ListeAl()
        {
            List<string> diyetList = new List<string>();
            diyetList.Add(MevcutHastaTC.ToString());
            diyetList.Add(richTextBox1.Text);
            diyetList.Add(richTextBox2.Text);
            diyetList.Add(richTextBox3.Text);
            richTextBox1.Clear();
            richTextBox2.Clear();
            richTextBox3.Clear();
            return diyetList;
        }
        private void lblDevamEt_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            richTextBox2.Visible = true;
            lblDevamEt2.Visible = true;
            pctrDevamEt2.Visible = true;
        }

        private void lblDevamEt2_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            richTextBox3.Visible = true;
            pctrKaydet.Visible = true;
            lblOgunKaydet.Visible = true;
        }

        private void lblOgunKaydet_Click(object sender, EventArgs e)
        {
            DiyetFabrikasi diyetFabrika = new DiyetFabrikasi();
            IDiyet diyet = diyetFabrika.diyetOlustur(hasta.HastalikAdi);
            diyet.DiyetOgun(ListeAl());
        }

        private void HastaKayitForm_Load(object sender, EventArgs e)
        {

        }
    }
}
