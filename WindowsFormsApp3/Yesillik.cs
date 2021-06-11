using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Yesillik : IDiyet
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

        public string DiyetVer()
        {
            return this.DiyetYesillik();
        }


        private string DiyetYesillik()
        {
            return "Yeşillik";
        }


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

