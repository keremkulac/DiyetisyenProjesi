using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    //4 Adet diyet tipi vardır, isteniyosa daha fazla eklenebilir
    public enum DiyetTipi
    {
        Akdeniz, Yesillik, GlutenFree, DenizUrunleri
    }
    public class DiyetFabrikasi
    {
        //Kullanicidan aldigi hastalık adı ile gereken diyeti oluşturan fabrika
        public IDiyet diyetOlustur(string hastalikAdi)
        {
            IDiyet diyet = null;
            //İstenen diyet tipi koşuluna göre diyet oluşturur.
            if (hastalikAdi == "Obez")
            {
                diyet = new Yesillik();
            }
            else if (hastalikAdi == "Çölyak")
            {
                diyet = new GlutenFree();
            }
            else if (hastalikAdi == "Şeker")
            {
                diyet = new Akdeniz();

            }
            return diyet;
        }
    }
}
