using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi_5
{
    abstract class tongcty
    {
        protected string maNV;
        protected string hoTen;

        abstract public string danhHieu();

        abstract public double tinhLuong();

        abstract public string danhGiaNL();
       
    }
class ctyabc: tongcty
    {
        string gTinh;
        DateTime ngSinh;
        protected int nvl;
        protected double hsl;

        public static int lcb = 1210;

        public ctyabc(string manv, string ten, string gtinh, int nvl, double hsl)
        {
            this.maNV = maNV;
            this.hoTen = ten;
            this.gTinh = gtinh;
            this.nvl = nvl;
            this.hsl = hsl;
        }
        public double PCTN()
        {
            int tn = DateTime.Today.Year - nvl;
            if (tn >= 5)
                return tn * lcb / 100;
            return 0;
        }

        abstract public char xepLoai();

        abstract public double tinhLuong();

        public virtual void nhap()
        {
            Console.WriteLine("Nhap ma nv, ten nv, gioi tinh( Nam/Nu)");
            maNV = Console.ReadLine();
            hoTen = Console.ReadLine();
            gTinh = Console.ReadLine();
            Console.WriteLine("Nhap nam vao lam:");
            nvl = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap he so luong: ");
            hsl = double.Parse(Console.ReadLine());
        }
        public override string danhHieu()
        {
            if (xepLoai() == 'A')
                return "Chien si thi dua";
             if (xepLoai() == 'B')
                return "Lao dong tien tien";
             else
                 return "khong dat";
        }

        public double thuNhap()
        {
            char xl= xepLoai();
            double luong = 0;
            if (xl == 'A')
                luong = 1.0;
            if (xl == 'B')
                luong = 0.75;
            if (xl == 'C')
                luong = 0.5;
            return luong * tinhLuong() + PCTN();
        }
    }

    class NVSX: ctyabc
    {
        int snn;

        static double PCNN= 0.1;

        public NVSX(string manv, string ten, string gt, int nvl, double hsl, int snn): base(manv,ten,gt,nvl,hsl)
        {
            this.snn = snn;
        }

        public override char xepLoai()
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

        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("Nhap so ngay nghi: ");
            snn = int.Parse(Console.ReadLine());
        }

        public override double tinhLuong()
        {
            return 0.1 * lcb * (1 + PCNN);
        }
    }

    class NVKD : ctyabc
    {
        double DTTT, DSBH;
       
        public NVKD(string manv, string  ten,string gt,int nvl, double hsl, double DTTT, double DSBH):base(manv,ten,gt,nvl,hsl)
        {
            this.DTTT = DTTT;
            this.DSBH = DSBH;
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("Nhap doanh thu nv: ");
            DTTT = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap doanh thu TT:");
            DTTT = double.Parse(Console.ReadLine());
        }

        public override char xepLoai()
        {
            if (DSBH < 0.5 * DTTT)
                return 'D';
            if (DSBH < DTTT)
                return 'C';
            if (DSBH == DTTT)
                return 'B';
            return 'A';
        }

        public double hoaHong()
        {
            double vuotMuc = DSBH - DTTT;
            if (vuotMuc > 0)
                return 0.15 * vuotMuc * 500;
            return 0;
        }

        public override double tinhLuong()
        {
            return hsl * lcb + hoaHong();
        }
    }

    class canBo:ctyabc
    {
        string chucVu;
        int hsChucVu;
        int hsl;

        public override char xepLoai()
        {
            return 'A';
        }

        public override double tinhLuong()
        {
            return hsl * lcb + (hsChucVu * 1100);
        }
    }
   class ctyBCD : tongcty
    {
        double tongTien;

        public double tinhLuong()
        {
            return 0.15 * tongTien;
        }
        public override string danhHieu()
        {

            if (tinhLuong() > 20000)
                return "Chien si thi dua";
            else if (tinhLuong() > 20000)
                return "Lao dong tien tien";
            else
                return "khong dat";
        }

        public ctyBCD(string manv, string ten, double tongLuong)
        {
            this.maNV = maNV;
        }

        public override string danhGiaNL()
        {
            if (danhHieu() == "Chien si thi dua" || danhHieu() == "Lao dong tien tien")
                return "Nang luc tot";
            else
                return "khong dat";
        }
    }
}
