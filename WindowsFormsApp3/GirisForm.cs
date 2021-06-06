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
    public partial class GirisForm : Form
    {
        static VeriTabani connect = new VeriTabani();
        public static SqlConnection _connection = new SqlConnection(connect.BaglantiAdresi);
        public GirisForm()
        {
            InitializeComponent();
        }

        private void lblGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciID.Text;
            string sifre = txtSifre.Text;
            _connection.Open();
            SqlDataAdapter komut = new SqlDataAdapter("select * from Kullanicilar where KullaniciID = '" + kullaniciAdi + "' and KullaniciSifre='" + sifre + "'", _connection);
            DataTable dt = new System.Data.DataTable();
            komut.Fill(dt);
            // string kullaniciTur = dt.Rows[0]["KullaniciTur"].ToString();
            //  MessageBox.Show(kullaniciTur);
            if (dt.Rows.Count == 1)
            {
                switch (dt.Rows[0]["KullaniciTur"] as string)
                {
                    case "Admin     ":
                        {
                            MessageBox.Show("Admin girdi");
                            this.Hide();
                            DiyetisyenKayitForm diyetisyen = new DiyetisyenKayitForm();
                            diyetisyen.Show();
                            break;
                        }

                    case "Diyetisyen":
                        {

                            MessageBox.Show("Diyetisyen girdi");
                            this.Hide();
                            HastaKayitForm hasta = new HastaKayitForm();
                            hasta.Show();
                            break;
                        }
                    default:
                        {
                            // ... handle unexpected roles here...
                            break;
                        }
                }
            }
            else
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
            _connection.Close();
        }

        private void GirisForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

