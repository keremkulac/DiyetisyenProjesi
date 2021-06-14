using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace WindowsFormsApp3
{

    class HastalarVeriTabani
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
        //Alınan HastaKayit türünden objeyi veritabanına ekler.
        public void HastaEkle(HastaKayit hasta)
        {
            ConnectionControl();
               
            SqlCommand command = new SqlCommand(
             "INSERT into  Hastalar values(@HastaAdi,@HastaSoyad,@HastaHastalikTipi,@HastaYas,@HastaKilo,@HastaTC,@HastaTelNo,@HastaDiyet,@HastaDiyetTarih)", _connection);
            command.Parameters.AddWithValue("@HastaAdi", hasta.Ad);
            command.Parameters.AddWithValue("@HastaSoyad", hasta.Soyad);
            command.Parameters.AddWithValue("@HastaHastalikTipi", hasta.HastalikAdi);
            command.Parameters.AddWithValue("@HastaYas", hasta.Yas);
            command.Parameters.AddWithValue("@HastaKilo", hasta.Kilo);
            command.Parameters.AddWithValue("@HastaTC", hasta.TC);
            command.Parameters.AddWithValue("@HastaTelNo", hasta.TelNo);
            command.Parameters.AddWithValue("@HastaDiyet", hasta.DiyetTipi);
            command.Parameters.AddWithValue("@HastaDiyetTarih", hasta.Tarih);
            command.ExecuteNonQuery();
            _connection.Close();
        }


        public DataSet HastaCek()
        {
            ConnectionControl();
            string sorgu = "SELECT* FROM Hastalar";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, _connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            _connection.Close();
            return ds;
        }

        public DataSet HastaOgunleriCek(string tcNo)
        {
            ConnectionControl();
            string sorgu = "SELECT* FROM Ogun where HastaTCNo = '" + tcNo + "' ";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, _connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            _connection.Close();
            return ds;
        }



    }
}
