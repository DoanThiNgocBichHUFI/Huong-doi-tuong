using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi_2
{
    class hinhTron
    {
        private double bankinh;

        public double BanKinh {
            get {
                return bankinh;
            }
            set {
                if (value < 0)
                {
                    bankinh = 0;
                }
                else
                    bankinh = value;
            }
        }

        public hinhTron() {
            this.bankinh = 0;
        }

        public hinhTron(double bankinh) {
            this.BanKinh = bankinh;
        }

        public hinhTron(hinhTron a) {
            this.bankinh = a.bankinh;
        }

        ~hinhTron() { 
        
        }

        public double tinhCV() {
            return this.bankinh * 3.14 * 2;
        }

        public double tinhDT() {
            return this.bankinh * this.bankinh * 3.14;
        }

        public void nhap() {
            Console.WriteLine("Nhap ban kinh: ");
            this.BanKinh = double.Parse(Console.ReadLine());
        }

        public void xuat() {
            Console.WriteLine("Ban kinh: {0}, chu vi: {1},dien tich: {2}",bankinh,tinhCV(),tinhDT());
        }
    }
}
