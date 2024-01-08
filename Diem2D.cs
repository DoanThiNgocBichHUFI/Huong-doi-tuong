using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Diem2D
    {
        int x, y;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public double tinhkc()
        {
            return Math.Sqrt(x * x + y * y);
        }
        public void nhap()
        {
            Console.WriteLine("Nhap toa do x:");
            X = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap toa do y:");
            Y = int.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine("toa do x:"+x+"Toa do y"+y);
            Console.WriteLine("toa do x:{0}  toa do y: {1}",x ,y);
        }
    }
}
