using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2
{
    class CtyBCD:Congty
    {
        
            double Tongtien;
            public override double tinhluong()
            {
                return 0.15 * Tongtien;
            }
            public override string danhgia()
            {
                double luong = tinhluong();
                if (luong > 20000)
                    return"Chien si thi đua";
                else if (luong > 10000)
                    return "Lao dong tien tien";
                else
                return "khong dat";
            }
            public CtyBCD(string manv,string tennv,double tongluong)
            {
            this.Ma = manv;
            this.Ten = tennv;
            this.Tongtien = tongluong;
            }
            public void xuat()
            {
            Console.WriteLine("{0}  {1}   {2}  {3}   {4}  ",Ma,Ten,tinhluong(),danhgia(),nangluc());
            }
    }
}

