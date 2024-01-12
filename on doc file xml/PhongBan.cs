using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PhanNguyenDuyHung_2001202092_KTL1
{
    class PhongBan
    {
        string tenphong;
        string vitri;
        List<NhanVien> dsNhanvien = new List<NhanVien>();
        public string Tenphong
        {
            get{return tenphong;}
            set{ tenphong = value;}
        }
        public string Vitri
        {
            get{return vitri;}
            set{vitri =value;}
        }
      internal List<NhanVien> DsNhanvien { get => dsNhanvien; set => dsNhanvien = value; }
        List<PhongBan> pb = new List<PhongBan>();
        public void NhaptuFile(string file)
        {
            XmlDocument read = new XmlDocument();
            read.Load(file);
            XmlNodeList ListPhong = read.SelectNodes("/phongbans/phongban");
            foreach (XmlNode node in ListPhong)
            {
                PhongBan a = new PhongBan();
                a.tenphong = node["tenphong"].InnerText;
                a.vitri = node["vitri"].InnerText;

                XmlNodeList ListNV = node["dsnv"].ChildNodes;
                foreach (XmlNode node1 in ListNV)
                {
                    NhanVien nv = new NhanVien();
                    nv.MaNV = node1["manv"].InnerText;
                    nv.Hoten = node1["hoten"].InnerText;
                    nv.Ngaycong = int.Parse(node1["snc"].InnerText);
                    nv.Hesoluong = float.Parse(node1["hsl"].InnerText);
                    nv.Trinhdo = node1["trinhdo"].InnerText;
                    nv.Chucvu = node1["chucvu"].InnerText;
                    a.DsNhanvien.Add(nv);
                }
                pb.Add(a);
            }
        }
        public void XuatdsNhanVien()
        {
            Console.Write("\nXuat danh sach nhan vien cua phong ban {0}:",tenphong);
            foreach (PhongBan a in pb)
            {
                Console.WriteLine("{0,-15} {1,-7}",a.tenphong,a.vitri);
                foreach (NhanVien nv in a.dsNhanvien)
                {
                    nv.XuatNhanVien();
                }
            }
        }

        //public float TongLuong()
        //{
        //    float Tong = new float();
        //    Tong = 0;
        //    foreach (NhanVien nv in dsNhanvien)
        //    {
        //        Tong = Tong + nv.luongnhanvien();
        //    }
        //    return Tong;
        //}
        //public void SapxeptheoPhongBan()
        //{
        //    dsNhanvien = dsNhanvien.OrderBy(t => t.luongnhanvien()).ToList();
        //}
        //public void TimThongTin()
        //{
        //    string hoten;
        //    int temp=-1;
        //    Console.Write("\nNhap ho ten can tim"); hoten = Console.ReadLine();
        //    foreach (NhanVien nv in dsNhanvien)
        //    {
        //        if (string.Compare(nv.Hoten, hoten, true) == 1)
        //        {
        //            temp = 1;
        //            break;
        //        }
        //    }

        //    if (temp ==-1)
        //    {
        //        Console.Write("\nHo ten khong ton tai");
        //    }
        //    else 
        //    {
        //        Console.Write("\nHo ten co ton tai trong phong ban");
        //    }
        //}
    }
}
