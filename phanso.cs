using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class phanso
    {
        int tu, mau;

        public int Mau
        {
            get { return mau; }
            set { mau = value; }
        }

        public int Tu
        {
            get { return tu; }
            set { tu = value; }
        }
        public void nhap()
        {
            Console.WriteLine("NHap tu so:");
            Tu=int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("NHap mau so:");
                Mau = int.Parse(Console.ReadLine());
            } while (Mau == 0);
        }
        public void xuat()
        {
            Console.WriteLine("{0}/{1} ",tu,mau);
        }
        public void chuyendau()
        {
            if(mau<0)
            {
                tu = tu * -1;
                mau = mau * -1;
            }
        }
        int USCLN(int a,int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while(a!=b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }
      
        public void RGPS()
        {
            tu = tu / USCLN(tu, mau);
            mau = mau / USCLN(tu, mau);
        }

    }
}
