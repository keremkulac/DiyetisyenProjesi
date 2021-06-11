using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class HastaKayit
    {
        public string ad;
        public string Ad
        {
            get { return ad; }
            set { ad = value.ToUpper(); }
        }
        public string soyad;
        public string Soyad
        {
            get { return soyad; }
            set { soyad = value.ToUpper(); }
        }
        public string HastalikAdi { get; set; }
        public int Yas { get; set; }
        public int Kilo { get; set; }
        public long TC { get; set; }
        public long TelNo { get; set; }
        public string Tarih { get; set; }
        public string DiyetTipi { get; set; }
        public string Sabah { get; internal set; }
        public string Ogle { get; internal set; }
        public string Aksam { get; internal set; }
    }
}
