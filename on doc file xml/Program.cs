using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PhanNguyenDuyHung_2001202092_KTL1
{
    class Program
    {
        static void Main(string[] args)
        {
            PhongBan BaoChi = new PhongBan();
            BaoChi.NhaptuFile("../../DanhSachNhanVien.xml");
            BaoChi.XuatdsNhanVien();
           // Console.Write("Tong luong:{0}", BaoChi.TongLuong());
           // BaoChi.TimThongTin();
            Console.ReadLine();
            
        }
    }
}
