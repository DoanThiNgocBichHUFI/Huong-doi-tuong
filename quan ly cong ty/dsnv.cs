using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace B2
{
    class dsnv
    {
        List<CtyABC> abc=new List<CtyABC>();
        List<CtyBCD> bcd = new List<CtyBCD>();
        public void docfile(string filename)
        {
            XmlDocument read = new XmlDocument();
            read.Load(filename);
            XmlNodeList nodelist1 = read.SelectNodes("/tcongtys/tcongty");
            foreach (XmlNode node1 in nodelist1)
            {
                string cty = node1["tencty"].InnerText;
                XmlNodeList nodelist = node1["congtys"].ChildNodes;
                if (cty == "abc")
                {

                    foreach (XmlNode node in nodelist)
                    {
                        CtyABC a;
                        string bp = node["bophan"].InnerText;
                        string ma = node["manv"].InnerText;
                        string ten = node["tennv"].InnerText;
                        string gt = node["gioitinh"].InnerText;
                        int nvl = int.Parse(node["nvl"].InnerText);
                        double hsl = double.Parse(node["hsl"].InnerText);
                        if (bp == "nvsx")
                        {
                            int snn = int.Parse(node["snn"].InnerText);
                            a = new NVSX(ma, ten, gt, nvl, hsl, snn);
                            //abc.Add(a);
                        }
                        else if (bp == "nvkd")
                        {
                            double dttt = double.Parse(node["dttt"].InnerText);
                            double dsbh = double.Parse(node["dsbh"].InnerText);
                            a = new NVKD(ma, ten, gt, nvl, hsl, dttt, dsbh);
                        }
                        else
                        {
                            string chucvu = node["chucvu"].InnerText;
                            double hscv = double.Parse(node["hscv"].InnerText);
                            a = new Canbo(ma, ten, gt, nvl, hsl, chucvu, hscv);
                        }
                        abc.Add(a);
                    }
                }
                else
                {
                    foreach (XmlNode node in nodelist)
                    {
                        CtyBCD a;
                        string ma = node["manv"].InnerText;
                        string ten = node["tennv"].InnerText;
                        double tongtien = double.Parse(node["tongluong"].InnerText);
                        a = new CtyBCD(ma, ten, tongtien);
                        bcd.Add(a);
                    }
                }
            }
        }
        public void xuat()
        {
            Console.WriteLine("Cong ty ABC:");
            foreach(CtyABC a in abc)
             a.xuat();
            Console.WriteLine("Cong ty BCD:");
            foreach (CtyBCD a in bcd)
                a.xuat();
        }
    }
}
