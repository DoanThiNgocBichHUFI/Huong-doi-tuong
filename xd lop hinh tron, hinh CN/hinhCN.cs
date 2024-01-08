using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi_2
{
    class hinhCN
    {
        private double cd, cr; // khai báo biến lớp

        // khai báo  phương thức get/set
        public double Cr {
            get {
                return cr;
            }
            set {
            // các câu lệnh xử lý giá trị value
                if (value < 0)
                    cr = 0;
                else
                cr = value;
            }
        }

        public double Cd {
            get { return cd; }
            set {
            // các câu lệnh xử lý giá trị value.
                if (value < 0)
                    cd = 0;
                else
                    cd = value;
            }
        }

        public hinhCN() {  // phg  thức khởi tạo mặc định (ko tham số)
            this.cd = 0; //  this đại diện cho 1 class hay 1 đối tg đang làm việc trên nó.
            this.cr = 0;
        }

        public hinhCN(double cd, double cr) {// phg thức khởi tạo có tham số
            this.Cd = cd;
            this.Cr = cr;
        }

        public hinhCN(hinhCN a){ // phg thức khởi tạo sao chép
            this.cr = a.cr;
            this.cd = a.cd;
        }

        ~hinhCN() { // phg thức hủy
        
        }

        public double tinhCV() { 
            return (cd + cr)* 2;
        }

        public double tinhDT() {
            return cd * cr;
        }

        public void nhap() { 
            do{
                Console.WriteLine("Nhap thu tu chieu dai, rong: ");
                this.Cd = double.Parse(Console.ReadLine());
                this.Cr = double.Parse(Console.ReadLine());
            }while(Cd <= 0 || Cr <= 0);
        }

        public double duongCheo() {
            return Math.Sqrt(Math.Pow(cd,2) + Math.Pow(cr,2));
        }

        public void xuat() {
            Console.WriteLine("\n Chieu dai: {0}, chieu rong: {1} , Chu vi: {2}, Dien tich: {3}, Duong cheo: {4}", cd,cr,tinhCV(),tinhDT(),duongCheo());
        }

        public void changeSize(int tx, int ty, int type) {
            if (type == 0)
            {
                this.cr = this.cr - tx;
                this.cd = this.cd - ty;
            }
            else {
                this.cr = this.cr + tx;
                this.cd = this.cd + ty;
            }
        }
    }
}
