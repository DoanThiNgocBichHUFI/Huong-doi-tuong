using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On
{
    abstract class nhanvien
    {
        string manhanvien;
        protected string tennv;
        protected int namsinh;
        string gioitinh;
        protected double hsl;
        protected int namvl;
        public static double lcb = 1210;

        public string Manhanvien { get => manhanvien;
            set
            {
                if(value.All(Char.IsDigit)&&value.Length==10)
                    manhanvien = value;
                else
                    Console.WriteLine("Nhap sai:");
            }

        }

        public string Gioitinh { get => gioitinh;
            set
            {
                if (value == "Nam" || value == "Nu")
                    gioitinh = value;
                else
                    Console.WriteLine("Nhap sai:");
            }
        }
        public nhanvien()
        {

        }
        public nhanvien(nhanvien a)
        {
            this.manhanvien = a.manhanvien;
            this.tennv = a.tennv;
            this.namsinh = a.namsinh;
            this.gioitinh = a.gioitinh;
            this.hsl = a.hsl;
            this.namvl = a.namvl;
        }
        public virtual void nhap()
        {
            Console.WriteLine("NHap ma nhan vien:");
            Manhanvien = Console.ReadLine();
            Console.WriteLine("NHap ten nhan vien:");
            tennv = Console.ReadLine();
            Console.WriteLine("NHap nam sinh:");
            namsinh =int.Parse(Console.ReadLine());
            Console.WriteLine("NHap gioi tinh:");
            Gioitinh = Console.ReadLine();
            Console.WriteLine("NHap he so luong:");
            hsl=double.Parse(Console.ReadLine());
            Console.WriteLine("NHap nam vao lam:");
            namvl =int.Parse(Console.ReadLine());
            
        }
        abstract public char xeploai();
        abstract public double luong();
        public double thunhap()
        {
            if (xeploai() == 'A')
                return luong() + PCTN();
            else if (xeploai() == 'B')
                return 0.9 * luong() + PCTN();
            else if (xeploai() =='C')
                return 0.85*luong() + PCTN();
            else 
                return 0.7*luong() + PCTN();
        }
        public double PCTN()
        {
            int sonam;
            sonam = DateTime.Today.Year - namvl;
            if (sonam >= 5)
                return sonam * lcb / 100;
            else
                return 0;
        }
        abstract public void xuat();
    }
    interface Ihotro
    {
        double xangxe();
        double comtrua();
    }
    class sanxuat:nhanvien
    {
        int songaynghi;
        static double pcnn =0.1;
        public override char xeploai()
        {
            if (songaynghi <= 1)
                return 'A';
            else if (songaynghi <= 3)
                return 'B';
            else if (songaynghi <= 5)
                return 'C';
            else
                return 'D';

        }
        public override double luong()
        {
            return hsl * lcb * (1 + pcnn);
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("So ngay nghi:");
            songaynghi = int.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            Console.WriteLine("{0}  {2}  {3}  {4}  {5}  {6}  {7}   {8}",Manhanvien,tennv,namsinh,Gioitinh,hsl,namvl,xeploai(),luong(),thunhap());
        }
    }
    class kinhdoanh:nhanvien,Ihotro
    {
        double doanhthuTT;
        double doanhsoBH;
        public double xangxe()
        {
            return 500000;
        }
        public double comtrua()
        {
            return 500000;
        }
        public override char xeploai()
        {
            
            if (doanhsoBH>=2*doanhthuTT)
                return 'A';
            else if (doanhsoBH>=doanhthuTT)
                return 'B';
            else if (doanhsoBH>doanhthuTT*0.5)
                return 'C';
            else
                return 'D';

        }
        public double hoahong()
        {
            double doanhthu =(doanhsoBH - doanhthuTT) * 500;
            if (doanhthu > 0)
                return 0.15 *doanhthu;
            else
                return 0;
        }
        public override double luong()
        {
            
            return hsl * lcb +hoahong();
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("doanh thu toi thieu:");
            doanhthuTT = double.Parse(Console.ReadLine());
            Console.WriteLine("doanh so ban hang:");
            doanhsoBH = double.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            Console.WriteLine("{0}  {2}  {3}  {4}  {5}  {6}  {7}   {8}", Manhanvien, tennv, namsinh, Gioitinh, hsl, namvl, xeploai(), luong(), thunhap());
        }
    }
    class canbo : nhanvien, Ihotro
    {
        double hscv;
        string chucvu;
        public double xangxe()
        {
            return 300000;
        }
        public double comtrua()
        {
            return 1000000;
        }
        public override char xeploai()
        {


            return 'A';


        }
        public double PCCV()
        {
            return hscv * 1100;
        }
        public override double luong()
        {

            return hsl * lcb + PCCV();
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("chuc vu:");
            chucvu = Console.ReadLine();
            Console.WriteLine("he so chuc vu:");
            hscv = double.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            Console.WriteLine("{0}  {2}  {3}  {4}  {5}  {6}  {7}   {8}", Manhanvien, tennv, namsinh, Gioitinh, hsl, namvl, xeploai(), luong(), thunhap());
        }
    }

    }
