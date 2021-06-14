using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace WindowsFormsApp3
{

    public class Akdeniz : IDiyet
    {
        //Veritabanı bağlantıları
        static VeriTabani connect = new VeriTabani();
        public static SqlConnection _connection = new SqlConnection(connect.BaglantiAdresi);
        //Bağlantı açık mı kontrolü
        public void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        public string DiyetVer() //Main Creator
        {
            return this.DiyetAkdeniz();
        }

        private string DiyetAkdeniz()
        {
            return "Akdeniz";
        }

        //Interface'i kullanarak istenen öğünleri veritabanına ekleyen method
        void IDiyet.DiyetOgun(List<string> Diyet)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
             "INSERT into  Ogun values(@HastaTCNo,@HastaOgunSabah,@HastaOgunOgle,@HastaOgunAksam)", _connection);

            command.Parameters.AddWithValue("@HastaTCNo", Diyet[0]);
            command.Parameters.AddWithValue("@HastaOgunSabah", Diyet[1]);
            command.Parameters.AddWithValue("@HastaOgunOgle", Diyet[2]);
            command.Parameters.AddWithValue("@HastaOgunAksam", Diyet[3]);
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }




}
