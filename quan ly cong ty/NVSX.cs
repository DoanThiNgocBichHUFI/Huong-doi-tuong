using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2
{
    class NVSX:CtyABC
    {

            int snn;            
            static double PCNN = 0.1;
            public NVSX(string manv, string ten, string gt, int nvl, double hsl, int snn)
                : base(manv, ten, gt, nvl, hsl)
            {
                this.snn = snn;
            }

            public override char xeploai()
            {
                if (snn <= 1)
                    return 'A';
                else if (snn <= 3)
                    return 'B';
                else if (snn <= 5)
                    return 'C';
                else
                    return 'D';
            }
            public override double tinhluong()
            {
                return Hsl * lcb * (1 + PCNN);
            }
            public override void nhap()
            {
                base.nhap();
                Console.WriteLine("Nhap so ngay nghi:");
                snn = int.Parse(Console.ReadLine());
            }
        }
    }

