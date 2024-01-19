using System;

namespace nhanvien{
    class nhanVien{
        string maNV, hoTen, trinhDo, chucVu;
        int soNC;
        double hsl;

        public string MaNV{
            get=> maNV;
            set=> maNV= value;
        }
        public string Hoten{
            get=> hoTen;
            set=> hoTen= value;
        }
        public int SoNC{
            get =>soNC;
            set =>soNC = value;
        }
        public double Hsl{
            get=>hsl;
            set =>hsl = value;
        }
        public string ChucVu{
            get => chucVu;
            set{
                if(!((string.Compare(value,"Truong phong",true)== 0 || string.Compare(value,"Pho phong",true) == 0) || string.Compare(value,"Chuyen vien",true)==0))
                    {
                        value= "Chuyen vien";
                        chucVu = value;
                    }
                else
                    chucVu = value;
            }
        }

        public string TrinhDo{
            get => trinhDo;
            set{
                if(!((string.Compare(value,"Cu nhan",true)== 0 || string.Compare(value,"Thac si")== 0 || string.Compare(value,"Tien si",true)== 0)))
                    {
                        value = "Cu nhan";
                        trinhDo = value;
                    }
                else
                    trinhDo = value;
            }
        }

        public int phuCap{
            get{
                int value;
                if(string.Compare(trinhDo,"Tien si",true)== 0)
                    value= 1000;
                else if(string.Compare(trinhDo,"Thac si",true)== 0)
                    value= 500;
                else
                    value= 300;

                if(string.Compare(chucVu,"Truong phong",true)== 0)
                    value += 1500;
                else if(string.Compare(chucVu,"Pho phong",true) == 0)
                    value += 1000;
                else
                    value = value;
                return value;
            }
        }
        public double luong(){
            return hsl * 1390 + phuCap + soNC *50;
        }

        public nhanVien(){
            this.maNV = "H250";
            this.hoTen= "Ho ten nhan vien 1";
            this.soNC = 28;
            this.hsl = 2;
            this.trinhDo = "Thac si";
            this.chucVu = "Pho phong";
        }

        public nhanVien(string maSoNV){
            this.maNV = maNV;
            this.hoTen= "Ho ten nhan vien 1";
            this.soNC= 28;
            this.hsl = 2;
            this.trinhDo = "Thac si";
            this.chucVu = "Pho phong";
        }
        public nhanVien(string maSoNV,string hoTenNV,string trinhDoNV,string chucVuNV, int soNgayCong, double heSoLuong){
            this.MaNV = maSoNV;
            this.Hoten= hoTenNV;
            this.TrinhDo= trinhDoNV;
            this.ChucVu = chucVuNV;
            this.soNC= soNgayCong;
            this.hsl= heSoLuong;
        }
        public void nhap(){
            Console.WriteLine("Nhap ma nhan vien: ");
            maNV = Console.ReadLine();
            Console.WriteLine("Nhap ho ten nhan vien: ");
            hoTen = Console.ReadLine();
            Console.WriteLine("Nhap so ngay cong nhan vien: ");
            soNC =int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap he so luong nhan vien: ");
            hsl = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap trinh do nhan vien: ");
            trinhDo = Console.ReadLine();
            Console.WriteLine("Nhap chuc vu nhan vien: ");
            chucVu = Console.ReadLine();
        }
   
        public void xuatNV(){
            Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}",maNV,hoTen,soNC,hsl,trinhDo,chucVu,luong(),phuCap);
        }
    }
}

__________________________________

using System;
using System.Xml;

namespace nhanvien{
    class phongBan{
        string tenPHG;
        string vitri;

        List<nhanVien> dsnv= new List<nhanVien>();
        public string TenPHG{
            get =>tenPHG;
            set => tenPHG = value;
        }
        public string ViTri{
            get=>vitri;
            set =>vitri = value;
        }

        internal List<nhanVien>lst{
            get =>lst;
            set =>lst = value;
        }

        List<phongBan> pb= new List<phongBan>();

        public void nhapTuFile(string file){
            XmlDocument read= new XmlDocument();
            read.Load(file);
            XmlNodeList listPHG = read.SelectNodes("/phongbans/phongban");
            foreach(XmlNode node in listPHG){
                phongBan a= new phongBan();
                a.tenPHG= node["tenphong"].InnerText;
                a.vitri = node["vitri"].InnerText;

                XmlNodeList listNV= node["dsnv"].ChildNodes;
                foreach(XmlNode node1 in listNV){
                    nhanVien nv= new nhanVien();
                    nv.MaNV= node1["manv"].InnerText;
                    nv.Hoten = node1["hoten"].InnerText;
                    nv.SoNC= int.Parse(node1["snc"].InnerText);
                    nv.Hsl = double.Parse(node1["hsl"].InnerText);
                    nv.TrinhDo= node1["trinhdo"].InnerText;
                    nv.ChucVu = node1["chucvu"].InnerText;
                    a.dsnv.Add(nv);
                }
                pb.Add(a);
            }
        }
        public void xuatdsnv(){
            Console.WriteLine("Xuat danh sach nhan vien cua phong ban {0}: ",tenPHG);
            foreach(phongBan a in pb){
                Console.WriteLine("{0,-15} {1,-7}",a.tenPHG,a.vitri);
                foreach(nhanVien nv in a.dsnv)
                    nv.xuatNV();
            }
        }
    }
}  

________________________________________

using System;
namespace nhanvien{
    internal class Program
    {
        private static void Main(string[] args)
        {
            phongBan BaoChi = new phongBan();
            BaoChi.nhapTuFile("data.xml");
            BaoChi.xuatdsnv();
            Console.ReadLine();
        }
    }
}
