using System;
using System.Xml;

namespace buoi4{   
    abstract class monhoc{
        protected string maMon;
        protected string tenMon;
        protected int stc;
        protected string khoaPT;
        protected double diem;

        public monhoc(){

        }

        public void xuat(){
            Console.WriteLine("{0} {1} {2} {3}",maMon,tenMon,stc,tinhHP());
        }
        abstract public double tinhHP();
        abstract public double tinhDTL();
    }
    
    class monLT: monhoc{
        protected double diemTL, diemGK, diemCK;
        static double hocPhi= 250000;

        public monLT(string ma, string ten, int sotc){
            this.maMon= ma;
            this.tenMon= ten;
            this.stc= sotc;
        }
        public override double tinhHP(){
            return stc* hocPhi;
        }

        public override double tinhDTL()
        {
            return diemTL*0.2 + diemGK*0.3+ diemCK*0.5;
        }
    }

    class monTH:monhoc{
        protected double diem1,diem2, diem3, diem4;
        static double donGia= 350000;
        static double tienCSVC= 100000;

        public monTH(string ma,string ten, int sotc){
            this.maMon= ma;
            this.tenMon= ten;
            this.stc= sotc;
        }
        public override double tinhHP(){
            return stc* donGia;
        }

        public override double tinhDTL()
        {
            return (diem1+diem2+diem3+diem4)/4;
        }
    }

    class monDA:monhoc{
        protected double diemGVHD, diemGVPB;

        public static double donGiaDA= 200000;

        public monDA(string ma, string ten, int sotc){
            this.maMon= ma;
            this.tenMon= ten;
            this.stc= sotc;
        }
        public override double tinhDTL()
        {
            return (diemGVHD*2 + diemGVPB)/3; 
        }

        public override double tinhHP()
        {
            return donGiaDA*stc;
        }
    }

    class DSMH{
        List<monhoc> MH= new List<monhoc>();
        
        public void docFile(string fileName){
            XmlDocument read = new XmlDocument();
            read.Load(fileName);
            XmlNodeList nodeList = read.SelectNodes("/Monhocs/MH");
            foreach(XmlNode node in nodeList){
                monhoc mon;
                string mh= node["ma"].InnerText;
                string ten= node["ten"].InnerText;
                int soTC= int.Parse(node["sotc"].InnerText);
                string loai= node["loai"].InnerText;
                if(loai == "LT"){
                    mon= new monLT(mh, ten,soTC);
                    MH.Add(mon);
                }
                if(loai == "TH"){
                    mon= new monTH(mh,ten,soTC);
                    MH.Add(mon);
                }
                if(loai == "DA"){
                    mon =new monDA(mh,ten,soTC);
                    MH.Add(mon);
                }
            }

            foreach(monhoc a in MH){
                a.xuat();

            }
        }
    }
 }