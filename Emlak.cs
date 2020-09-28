using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;


namespace Calisma40_ClassSample
{
    class Emlak
    {
        private string semt;
        private string renk;
        private int odaSayisi;
        private int katSayisi;
        private double alan;

        public string Semti
        {
            get { return semt; }
            set
            {
                semt=value.ToUpper();
            }
        }
        public string Rengi
        {
            get { return renk; }
            set
            {
                renk=value.ToLower();
            }
        }
        public int OdaSayisi 
        {
            get { return odaSayisi; }
            set
            {
                odaSayisi=Math.Abs(value);
            }
        }
         public int KatSayisi 
        {
            get { return katSayisi; }
            set
            {
                katSayisi=Math.Abs(value);
            }
        }
         public double Alani 
        {
            get { return alan; }
            set
            {
                alan=Math.Abs(value);
            }
        }

    }
}
