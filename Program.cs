using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //hinhTron a= new hinhTron();
            //a.nhap();
            //double b = a.tinhCV();
            //Console.WriteLine("Chu vi hinh tron= {0}",b);
            //a.xuat();
            //Console.ReadLine();

            //hinhCN a = new hinhCN();
            //a.nhap();
            //a.xuat();

            // Tạo một đối tượng mới của lớp hinhCN
            hinhCN hinh = new hinhCN();

            // Gán giá trị cho chiều rộng và chiều dài
            hinh.Cr = 10;

            // In ra giá trị ban đầu của chiều rộng và chiều dài
            Console.WriteLine("Chiều rộng ban đầu: " + hinh.Cr);

            // Sử dụng phương thức changeSize để thay đổi kích thước
            hinh.changeSize(2, 3, 1);

            // In ra giá trị sau khi thay đổi kích thước
            Console.WriteLine("Chiều rộng sau khi tăng: " + hinh.Cr);

            // Sử dụng phương thức changeSize để thay đổi kích thước
            hinh.changeSize(2, 3, 0);

            // In ra giá trị sau khi thay đổi kích thước
            Console.WriteLine("Chiều rộng sau khi giảm: " + hinh.Cr);
            Console.ReadLine();
        }
    }
}
