using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2
{
    class NVKD:CtyABC
    {
            double doanhthu, doanhthuTT;
            
            public NVKD(string manv, string ten, string gt, int nvl, double hsl,double DTTT,double DSBH)
                : base(manv, ten, gt, nvl, hsl)
            {
                this.doanhthuTT = DTTT;
                this.doanhthu = DSBH;
            }
            public override void nhap()
            {
                base.nhap();
                Console.WriteLine("Nhap doanh thu nv:");
                doanhthu = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhap doanh thu TT:");
                doanhthuTT = double.Parse(Console.ReadLine());
            }
            public override char xeploai()
            {
                if (doanhthu < 0.5 * doanhthuTT)
                    return 'D';
                if (doanhthu < doanhthuTT)
                    return 'C';
                if (doanhthu == doanhthuTT)
                    return 'B';
                //if (doanhthu >= 2 * doanhthuTT)
                return 'A';

            }
            public double hoahong()
            {
                double vuot = doanhthu - doanhthuTT;
                if (vuot > 0)
                    return 0.15 * vuot * 500;
                return 0;
            }

            public override double tinhluong()
            {
                return Hsl * lcb + hoahong();
            }
        }
    }

