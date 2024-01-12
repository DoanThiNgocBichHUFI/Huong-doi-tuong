using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PhanNguyenDuyHung_2001202092_KTL1
{
    class NhanVien
    {
        //Attributes
        string maNV;
        string hotenNV;
        int songaycong;
        float hsluong;
        string trinhdo;
        string chucvu;
        
        //Constructors
        public string MaNV
        {
            get{return maNV;}
            set{maNV = value;}
        }
        public string Chucvu
        {
            get { return chucvu; }
            set
            {
                if (!(string.Compare(value, "Truong phong", true) == 0 && string.Compare(value, "Pho phong", true) == 0 && string.Compare(value, "Chuyen vien", true) == 0))
                {
                    value = "Chuyen vien";
                    chucvu = value;
                }
                else
                {
                    chucvu = value;
                }
            }
        }
        public string Hoten
        {
            get { return hotenNV; }
            set { hotenNV = value; }
        }
        public int Ngaycong
        {
            get { return songaycong; }
            set { songaycong = value; }
        }
        public float Hesoluong
        {
            get { return hsluong; }
            set { hsluong = value; }
        }
        public string Trinhdo
        {
            get { return trinhdo; }
            set
            {
                if (!(string.Compare(value, "Cu nhan", true) == 0 || string.Compare(value, "Thac si", true) == 0 || string.Compare(value, "Cu nhan", true) == 0))
                {
                    value = "Cu nhan";
                    trinhdo = value;
                }
                else
                {
                    trinhdo = value;
                }
            }
        }
        //Methods
        public NhanVien()
        {
            this.maNV = "H260";
            this.hotenNV = "Phan Nguyen Duy Hung";
            this.songaycong = 28;
            this.hsluong = 2;
            this.trinhdo = "Thac si";
            this.chucvu = "Pho phong";
        }
              public NhanVien(string maNV)
        {
            this.maNV = maNV;
            this.hotenNV = "Phan Nguyen Duy Hung";
            this.songaycong = 28;
            this.hsluong = 2;
            this.trinhdo = "Thac si";
            this.chucvu = "Pho phong";
        }
        public NhanVien(string maNV,string hotenNV,int songaycong, float hsluong,string trinhdo, string chucvu)
        {
            this.maNV = maNV;
            this.hotenNV = hotenNV;
            this.songaycong = songaycong;
            this.hsluong = hsluong;
            this.trinhdo = trinhdo;
            this.chucvu = chucvu;
        }
     

        public void NhapNhanVien()
        {
            Console.Write("Nhap ma nhan vien:"); maNV = Console.ReadLine();
            Console.Write("Nhap ho ten nhan vien:"); hotenNV = Console.ReadLine();
            Console.Write("Nhap so ngay cong nhan vien"); songaycong = int.Parse(Console.ReadLine());
            Console.Write("Nhap he so luong nhan vien:");hsluong = float.Parse(Console.ReadLine());
            Console.Write("Nhap trinh do nhan vien:"); trinhdo = Console.ReadLine();
            Console.Write("Nhap chuc vu cua nhan vien:"); chucvu = Console.ReadLine();
        }

        public int Phucap
        {
            get {
                int value;
                if (string.Compare(trinhdo, "Tien si", true) == 0)
                {

                    value = 1000;
                }
                else if (string.Compare(trinhdo, "Thac si", true) == 0)
                {
                    value = 500;
                }
                else 
                {
                    value = 300;                  

                }
                if (string.Compare(chucvu, "Truong phong", true) == 0)
                    {
                        value = value + 1500;
                        
                    }
                    else if (string.Compare(chucvu, "Pho phong", true) == 0)
                    {
                            value = value + 1000;
                           
                    }
                                  
                else
                {
                    value = value+0;
                        
                }
                
                return value; 
            }
           
                
        }
        public float luongnhanvien()
        {
            return hsluong * 1390 + Phucap +songaycong * 50;
        }

        public void XuatNhanVien()
        {
            Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}",maNV, hotenNV, songaycong, hsluong, trinhdo, chucvu, luongnhanvien(), Phucap); 
           
        }

    }
}
