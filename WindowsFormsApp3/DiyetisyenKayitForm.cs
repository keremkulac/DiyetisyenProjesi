using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{

    public partial class DiyetisyenKayitForm : Form
    {
        DiyetisyenVeriTabani diyetisyenKayit = new DiyetisyenVeriTabani();
        DiyetisyenKayit diyetisyen = new DiyetisyenKayit();
        static VeriTabani connect = new VeriTabani();
        public static SqlConnection _connection = new SqlConnection(connect.BaglantiAdresi);
        public void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        public DiyetisyenKayitForm()
        {
            InitializeComponent();
        }
 
        private void DiyetisyenKayitForm_Load(object sender, EventArgs e)
        {
            KullanicilariCek();
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
            diyetisyenKayit.DiyetisyenEkle(new DiyetisyenKayit()
            {
                KullaniciAdi = txtKullaniciAd.Text,
                Sifre = txtKullaniciSifre.Text,
                Ad = txtKullaniciAd.Text,
                Soyad = txtKullaniciSoyad.Text,
                TC = Convert.ToInt64(txtKullaniciTcNo.Text),
                TelNo = Convert.ToInt64(txtKullaniciTelNo.Text),
                Tur = "Diyetisyen"
            });

        }
        void KullanicilariCek()
        {
            ConnectionControl();
            string sorgu = "SELECT* FROM Kullanicilar";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, _connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dtKullanicilar.DataSource = ds.Tables[0];
            _connection.Close();
        }

        private void txtKullaniciSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtKullanicilar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
