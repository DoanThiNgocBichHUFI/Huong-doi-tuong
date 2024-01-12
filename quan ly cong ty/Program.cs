using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2
{
    class Program
    {
        static void Main(string[] args)
        {
            dsnv a = new dsnv();
            a.docfile("../../data.xml");
            a.xuat();
            Console.ReadLine();
        }
    }
}
