using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class DiyetisyenKayit
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
        public long TC { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }

        public string Tur { get; set; }
        public long TelNo { get; set; }
    }
}
