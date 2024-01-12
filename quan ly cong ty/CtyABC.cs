using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2
{
    abstract class CtyABC:Congty
    {
  
            string gioitinh;

            public string Gioitinh
            {
                get { return gioitinh; }
                set { gioitinh = value; }
            }
            int nvl;

            public int Nvl
            {
                get { return nvl; }
                set { nvl = value; }
            }
            double hsl;

            public double Hsl
            {
                get { return hsl; }
                set { hsl = value; }
            }
            protected static double lcb = 1150;
            public CtyABC(string manv, string ten, string gt, int nvl, double hsl)
            {
                this.Ma = manv;
                this.Ten = ten;
                this.gioitinh = gt;
                this.Nvl = nvl;
                this.Hsl = hsl;
            }

            public double PCTN()
            {
                int tn = DateTime.Today.Year - nvl; // tinh so nam lam viec
                if (tn >= 5)
                    return tn * lcb / 100;
                return 0;
            }

            abstract public char xeploai();
           // abstract public double tinhluong();
            public virtual void nhap()
            {
                Console.WriteLine("Nhap ma nv:");
                Ma = Console.ReadLine();
                Console.WriteLine("Nhap ten nv:");
                Ten = Console.ReadLine();
                Console.WriteLine("Nhap gioi tinh nv Nam/Nu:");
                Gioitinh = (Console.ReadLine());
                Console.WriteLine("Nhap nam vao lam:");
                Nvl = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap he so luong:");
                Hsl = double.Parse(Console.ReadLine());
            }

            public void xuat()
            {
                Console.WriteLine("{0}  ,{1}  ,{2}  ,{3},  {4},  {5},  {6}    {7}   {8}", Ma, Ten, Gioitinh, Nvl, Hsl, xeploai(), tinhluong(), danhgia(), nangluc());
            }
            public double thunhap()
            {
                char xl = xeploai();
                double luong = 0;
                if (xl == 'A')
                    luong = 1.0;
                if (xl == 'B')
                    luong = 0.75;
                if (xl == 'C')
                    luong = 0.5;
                return luong * tinhluong() + PCTN(); 
            }
            public override string danhgia()
            {
                char xl = xeploai();
                
                if (xl == 'A')
                    return "Chien si thi đua";
                else if (xl == 'B')
                   return "Lao dong tien tien";
                else 
                    return "Khong dat";
            }
        }
    }

