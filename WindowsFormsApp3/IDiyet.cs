using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public interface IDiyet
    {


        string DiyetVer(); //Interface için gereken method, hastaya gereken diyet tipini verir.
         void DiyetOgun(List<string> Diyet); //Ogunler için gereken liste
    }
}
