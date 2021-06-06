using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class DenizUrunleri : IDiyet
    {
        

        public string DiyetVer()
        {
            return this.DiyetDenizUrunleri();
        }

        private string DiyetDenizUrunleri()
        {
            return "Deniz Ürünleri";
        }
    }
}
