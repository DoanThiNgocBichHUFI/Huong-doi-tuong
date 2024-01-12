using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2
{
    abstract public class Congty
    {
        string ma, ten;

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        public string Ma
        {
            get { return ma; }
            set { ma = value; }
        }
        public string nangluc()
        {
            string dg = danhgia();
            string nl = "";
            if (dg == "Chien si thi đua")
                nl = "nang luc tot";
            else if (dg == "Lao dong tien tien")
                nl = "Co nang luc";
            return nl;
        }
        abstract public string danhgia();
        abstract public double tinhluong();
    }
   
    
    
    
}
