using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2
{
    class Canbo:CtyABC
    {
       
            string chucvu;
            double hsPCCV;
            public override void nhap()
            {
                base.nhap();
                Console.WriteLine("Nhap chuc vu nv:");
                chucvu = Console.ReadLine();
                Console.WriteLine("Nhap hs PCCV:");
                hsPCCV = double.Parse(Console.ReadLine());
            }
            public override char xeploai()
            {
                return 'A';
            }
            public double PCCV()
            {
                return 1100 * hsPCCV;

            }
            public override double tinhluong()
            {
                return Hsl * lcb + PCCV();
            }
            public Canbo(string manv, string ten, string gt, int nvl, double hsl,string chucvu,double HSCV) 
            : base(manv, ten, gt, nvl, hsl)
            {
            this.chucvu = chucvu;
            this.hsPCCV = HSCV;
            }
        }
    }

