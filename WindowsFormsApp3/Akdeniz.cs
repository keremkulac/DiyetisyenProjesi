using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{

    public class Akdeniz : IDiyet
    {
       
        public string DiyetVer() //Main Creator
        {
            return this.DiyetAkdeniz();
        }

        private string DiyetAkdeniz() 
        {
            return "Akdeniz";
        }


      





        //// SortedList<string, string> ogun = new SortedList<string, string>();
    }
}
