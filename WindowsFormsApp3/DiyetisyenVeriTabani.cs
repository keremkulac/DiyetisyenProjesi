using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    class DiyetisyenVeriTabani
    {
        static VeriTabani connect = new VeriTabani();
        public static SqlConnection _connection = new SqlConnection(connect.BaglantiAdresi);
        public void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        //Bu method, kullanıcıdan aldığı diyetisyen objesini veritabanına ekler.

        public void DiyetisyenEkle(DiyetisyenKayit diyetisyen)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
            "Insert into Kullanicilar values(@KullaniciID,@KullaniciSifre,@KullaniciTur,@KullaniciIsim,@KullaniciSoyad,@KullaniciTC,@KullaniciTelNo)", _connection);
            command.Parameters.AddWithValue("@KullaniciID", diyetisyen.KullaniciAdi);
            command.Parameters.AddWithValue("@KullaniciSifre", diyetisyen.Sifre);
            command.Parameters.AddWithValue("@KullaniciTur", diyetisyen.Tur);
            command.Parameters.AddWithValue("@KullaniciIsim", diyetisyen.Ad);
            command.Parameters.AddWithValue("@KullaniciSoyad", diyetisyen.Soyad);
            command.Parameters.AddWithValue("@KullaniciTC", diyetisyen.TC);
            command.Parameters.AddWithValue("@KullaniciTelNo", diyetisyen.TelNo);
             
            command.ExecuteNonQuery();
            System.Windows.Forms.MessageBox.Show("Başarıyla eklendi!");
            _connection.Close();
        }
    }
}
