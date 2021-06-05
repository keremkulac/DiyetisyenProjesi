using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public enum DiyetTipi
    {
        Akdeniz, Yesillik, GlutenFree, DenizUrunleri
    }
    public class DiyetFabrikasi
    {
        public IDiyet diyetOlustur(string hastalikAdi)
        {
            IDiyet diyet = null;
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
