using System;

namespace ToanTuPhanSo
{
    class PhepToan
    {
        public int UocChungLonNhat(int a, int b)
        {
            int ucln = 0;
            if (a == b)
            {
                ucln = a;
            }
            else
            {
                while (a != b)
                {
                    if (a > b)
                    {
                        a = a - b;
                    }
                    else
                    {
                        b = b - a;
                    }
                }
                ucln = a;
            }
            return ucln;
        }
        public double kt_Nhap()
        {
            double tra = 0;
            while (tra == 0)
            {
                try
                {
                    tra = double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.Write("ban nhap khong phai la so vui long nhap lai");
                }
            }
            return tra;
        }
    }
    class PhanSo
    {
        int iTu, iMau;
        PhepToan pt = new PhepToan();
        public PhanSo(int iTu = 0, int iMau = 1)
        {
            this.iTu = iTu;
            this.iMau = iMau;
        }
        public void XuatPhanSo()
        {
            Console.WriteLine("Phan so co dang : " + iTu + " / " + iMau);
        }
        public void XuatTuSo()
        {
            Console.WriteLine("Phan so co tu : " + iTu );
        }
        public void XuatMauSo()
        {
            Console.WriteLine("Phan so co mau : " + iMau);
        }
        public void setTu(int x)
        {
            this.iTu = x;
        }
        public void setMau(int x)
        {
            this.iMau = x;
        }
        public int getTu()
        {
            return iTu;
        }
        public int getMau()
        {
            return iMau;
        }
        public PhanSo RutGon(PhanSo a)
        {
            PhanSo c = new PhanSo();
            if (a.iTu == 0)
            {
                Console.WriteLine("Phan So bang 0");
                c=a;
            }
            else
            {
                if(a.iMau == 0)
                {
                    Console.WriteLine("Phan so co Mau la khong");
                    c = a;
                }
                else
                {
                    int kt = pt.UocChungLonNhat(iTu, iMau);
                    if ( kt!= 0 && kt != 1)
                    {
                        c.iTu = a.iTu / kt;
                        c.iMau = a.iMau / kt;
                    }
                }
                
            }
            
            return c;
        }
        public PhanSo NghichDao()
        {
            PhanSo c = new PhanSo();
            c.iTu = iMau;
            c.iMau = iTu;
            return c;
        }
        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            PhanSo c = new PhanSo();
            if (a.iMau == b.iMau)
            {
                c.iTu = a.iTu + b.iTu;
                c.iMau = a.iMau;
            }
            else
            {
                c.iTu = a.iTu * b.iMau + b.iTu + a.iMau;
                c.iMau = a.iMau * b.iMau;                
            }
            return c.RutGon(c);
        }
        public static PhanSo operator -(PhanSo a, PhanSo b)
        {
            PhanSo c = new PhanSo();
            if (a.iMau == b.iMau)
            {
                c.iTu = a.iTu - b.iTu;
                c.iMau = a.iMau;
            }
            else
            {
                c.iTu = a.iTu * b.iMau - b.iTu + a.iMau;
                c.iMau = a.iMau * b.iMau;
            }
            return c.RutGon(c);
        }
        public static PhanSo operator *(PhanSo a, PhanSo b)
        {
            PhanSo c = new PhanSo();
            c.iTu = a.iTu * b.iTu;
            c.iMau = a.iMau * b.iMau;
            return c.RutGon(c);
        }
        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            PhanSo c = new PhanSo();
            c.iTu = a.iTu * b.iMau;
            c.iMau = a.iMau * b.iTu;
            return c.RutGon(c);
        }
        public static bool operator ==(PhanSo a, PhanSo b)
        {
            bool kt=false;
            a = a.RutGon(a);
            b = b.RutGon(b);
            if (a.iTu == b.iTu && a.iMau == b.iMau) kt = true;
            return kt;
        }
        public static bool operator !=(PhanSo a, PhanSo b)
        {
            bool kt = false;
            a = a.RutGon(a);
            b = b.RutGon(b);
            if (a.iTu == b.iTu && a.iMau == b.iMau)
            {
                 kt = false;
            }
            else kt = true;
            return kt;
        }
        public static bool operator >(PhanSo a, PhanSo b)
        {
            bool kt = false;
            a = a.RutGon(a);
            b = b.RutGon(b);
            if (a.iTu*b.iMau>b.iTu*a.iMau) kt = true;
            return kt;
        }
        public static bool operator <(PhanSo a, PhanSo b)
        {
            bool kt = false;
            a = a.RutGon(a);
            b = b.RutGon(b);
            if (a.iTu * b.iMau < b.iTu * a.iMau) kt = true;
            return kt;
        }
        public static bool operator >=(PhanSo a, PhanSo b)
        {
            bool kt = false;
            a = a.RutGon(a);
            b = b.RutGon(b);
            if (a.iTu * b.iMau >= b.iTu * a.iMau) kt = true;
            return kt;
        }
        public static bool operator <=(PhanSo a, PhanSo b)
        {
            bool kt = false;
            a = a.RutGon(a);
            b = b.RutGon(b);
            if (a.iTu * b.iMau >= b.iTu * a.iMau) kt = true;
            return kt;
        }
    }   
    class Program
    {
        PhepToan kt = new PhepToan();
        static int index = 1;
        static int curren = 1;
        PhanSo[] listPhanSo = new PhanSo[20];       
        int NhapTu()
        {
            Console.WriteLine("vui long nhap tu so: ");
            return (int)kt.kt_Nhap();
        }
        int NhapMau()
        {
            int mau = 0;
            while (mau == 0)
            {
                Console.WriteLine("vui long nhap mau so khac 0: ");
                mau = (int)kt.kt_Nhap();
            }
            return mau;
        }
        int ChonDoiTuong()
        {
            int k = 0;
            while (k == 0)
            {
                int j = 0;
                while (j < index)
                {
                    j = (int)kt.kt_Nhap();
                }
                k = j;
            }
            return k;
        }
        void addPhanSo()
        {
            PhanSo ps_new = new PhanSo();
            ps_new.setTu(NhapTu());
            ps_new.setMau(NhapMau());
            listPhanSo[index] = ps_new;
            index++;
        }
        void CongDoiTuong(int x)
        {
            listPhanSo[curren] = listPhanSo[curren] + listPhanSo[x];
            Console.WriteLine("Phan So Hien Tai : ");
            listPhanSo[curren].XuatPhanSo();
        }
        void TruDoiTuong(int x)
        {
            listPhanSo[curren] = listPhanSo[curren] - listPhanSo[x];
            Console.WriteLine("Phan So Hien Tai : ");
            listPhanSo[curren].XuatPhanSo();
        }
        void NhanDoiTuong(int x)
        {
            listPhanSo[curren] = listPhanSo[curren] * listPhanSo[x];
            Console.WriteLine("Phan So Hien Tai : ");
            listPhanSo[curren].XuatPhanSo();
        }
        void ChiaDoiTuong(int x)
        {
            listPhanSo[curren] = listPhanSo[curren] / listPhanSo[x];
            Console.WriteLine("Phan So Hien Tai : ");
            listPhanSo[curren].XuatPhanSo();
        } 
        void EditPhanSo()
        {
            int i = 0;
            while (i != 8)
            {
                Console.WriteLine("nhap phuong thuc lua chon cua ban: ");
                Console.WriteLine("1) thay doi tu : ");
                Console.WriteLine("2) thay doi mau : ");
                Console.WriteLine("3) cong voi mot doi tuong trong mang: ");
                Console.WriteLine("4) tru voi mot doi tuong trong mang : ");
                Console.WriteLine("5) nhan voi mot doi tuong trong mang : ");
                Console.WriteLine("6) chia voi mot doi tuong trong mang : ");
                Console.WriteLine("7) Nghich dao : ");
                Console.WriteLine("8) khong thay doi : ");
                i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        {
                            Console.WriteLine("1) thay doi tu : ");
                            NhapTu();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("2) thay doi mau : ");
                            NhapMau();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("3) cong voi mot doi tuong trong mang: ");
                            Console.WriteLine("chon mot doi tuong muon cong trong mang: ");
                            CongDoiTuong(ChonDoiTuong());
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("4) tru voi mot doi tuong trong mang : ");
                            TruDoiTuong(ChonDoiTuong());
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("5) nhan voi mot doi tuong trong mang : ");
                            NhanDoiTuong(ChonDoiTuong());
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("6) chia voi mot doi tuong trong mang : ");
                            ChiaDoiTuong(ChonDoiTuong());
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("7) Nghich dao : ");
                            listPhanSo[curren].NghichDao();
                            listPhanSo[curren].XuatPhanSo();
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("8) khong thay doi : ");
                            break;
                        }
                    
                    default:
                        {
                            Console.Write("vui long nhap gia tri tu 1=>8");
                            break;
                        }
                }
            }
        }
        void XuatPhanSo(int x)
        {
            listPhanSo[x].XuatPhanSo();
        }
        void XuatDanhSachAll()
        {
            for (int i = 1; i < index; i++)
            {
                XuatPhanSo(i);
            }
        }
        void XuatDanhSachTangDan()
        {
            PhanSo[] listtam = listPhanSo;
            for (int i = 1; i < index; i++)
            {
                for (int j = 1; j < index - 1; j++)
                {
                    if (listtam[j] > listtam[j + 1])
                    {
                        PhanSo tam = listtam[j + 1];
                        listtam[j + 1] = listtam[j];
                        listtam[j] = tam;
                    }
                }
            }
            for (int i = 1; i < index; i++)
            {
                listtam[i].XuatPhanSo();
            }
        }
        void DanhSachCungMau()
        {
            for(int i = 0; i < index; i++)
            {
                if (listPhanSo[i].getMau() == listPhanSo[curren].getMau())
                {
                    listPhanSo[i].XuatPhanSo();
                    Console.WriteLine();
                }
            }
        }
        void DanhSachCungTu()
        {
            for (int i = 0; i < index; i++)
            {
                if (listPhanSo[i].getTu() == listPhanSo[curren].getTu())
                {
                    listPhanSo[i].XuatPhanSo();
                    Console.WriteLine();
                }
            }
        }
        void DanhSachNhoHon()
        {
            for (int i = 0; i < index; i++)
            {
                if (listPhanSo[i].getMau() < listPhanSo[curren].getMau())
                {
                    listPhanSo[i].XuatPhanSo();
                    Console.WriteLine();
                }
            }
        }
        void DanhSachLonHon()
        {
            for (int i = 0; i < index; i++)
            {
                if (listPhanSo[i].getMau() > listPhanSo[curren].getMau())
                {
                    listPhanSo[i].XuatPhanSo();
                    Console.WriteLine();
                }
            }
        }
        void XuatDanhSach_Menu()
        {
            int i = 0;
            while (i != 5)
            {
                Console.WriteLine("nhap phuong thuc lua chon cua ban: ");
                Console.WriteLine("1) cac doi tuong cung mau : ");
                Console.WriteLine("2) cac doi tuong cung tu : ");
                Console.WriteLine("3) cac doi tuong nho hon: ");
                Console.WriteLine("4) cac doi tuong lon hon : ");
                Console.WriteLine("5) Tro Lai : ");
                i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        {
                            Console.WriteLine("1) cac doi tuong cung mau : ");
                            DanhSachCungMau();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("2) cac doi tuong cung tu : ");
                            DanhSachCungTu();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("3) cac doi tuong nho hon: ");
                            DanhSachNhoHon();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("4) cac doi tuong lon hon : ");
                            DanhSachLonHon();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("5) Tro Lai : ");
                            break;
                        }
                    default:
                        {
                            Console.Write("vui long nhap gia tri tu 1=>5");
                            break;
                        }
                }
            }
        }
        void SoSanh()
        {
            int i = 0;
            while (i != 7)
            {
                Console.WriteLine("nhap phuong thuc lua chon cua ban: ");
                Console.WriteLine("1) == : ");
                Console.WriteLine("2) != : ");
                Console.WriteLine("3) >: ");
                Console.WriteLine("4) < : ");
                Console.WriteLine("5) >= : ");
                Console.WriteLine("6) <= : ");
                Console.WriteLine("7) Tro lai ");
                i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        {
                            Console.WriteLine("1) == : ");
                            Console.Write("chon doi tuong so sanh: ");
                            Console.WriteLine(listPhanSo[curren] == listPhanSo[ChonDoiTuong()]);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("2) != : ");
                            Console.Write("chon doi tuong so sanh: ");
                            Console.WriteLine(listPhanSo[curren] != listPhanSo[ChonDoiTuong()]);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("3) >: ");
                            Console.Write("chon doi tuong so sanh: ");
                            Console.WriteLine(listPhanSo[curren] > listPhanSo[ChonDoiTuong()]);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("4) < : ");
                            Console.Write("chon doi tuong so sanh: ");
                            Console.WriteLine(listPhanSo[curren] < listPhanSo[ChonDoiTuong()]);
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("5) >= : ");
                            Console.Write("chon doi tuong so sanh: ");
                            Console.WriteLine(listPhanSo[curren] >= listPhanSo[ChonDoiTuong()]);
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("6) <= : ");
                            Console.Write("chon doi tuong so sanh: ");
                            Console.WriteLine(listPhanSo[curren] <= listPhanSo[ChonDoiTuong()]);
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("7) Tro lai ");
                            break;
                        }
                    default:
                        {
                            Console.Write("vui long nhap gia tri tu 1=>7");
                            break;
                        }
                }
            }
        }
        void play()
        {
            int i = 0;
            
            while (i != 9)
            {
                Console.WriteLine("nhap phuong thuc lua chon cua ban: ");
                Console.WriteLine("1) them mot doi tuong : ");
                Console.WriteLine("2) chon doi tuong trong danh sach : ");
                Console.WriteLine("3) xuat thong tin doi tuong duoc chon: ");
                Console.WriteLine("4) xuat ra danh sach cac doi tuong : ");
                Console.WriteLine("5) xuat ra danh sach cac doi tuong duoc sap sep tang dan : ");
                Console.WriteLine("6) edit doi tuong hien tai : ");
                Console.WriteLine("7) so sanh doi tuong hien tai voi mot doi tuong : ");
                Console.WriteLine("8) xuat danh sach cac doi tuong voi cac phep so sanh voi doi tuong hien tai: ");
                Console.WriteLine("9) ket thuc chuong trinh : ");
                i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        {
                            Console.WriteLine("1) them mot doi tuong : ");
                            addPhanSo();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("2) chon doi tuong trong danh sach : "+(index-1));
                            curren= ChonDoiTuong();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("3) xuat thong tin doi tuong duoc chon: ");
                            XuatPhanSo(curren);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("4) xuat ra danh sach cac doi tuong : ");
                            XuatDanhSachAll();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("5) xuat ra danh sach cac doi tuong duoc sap sep tang dan : ");
                            XuatDanhSachTangDan();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("6) edit doi tuong hien tai : ");
                            EditPhanSo();
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("7) so sanh doi tuong hien tai voi mot doi tuong : ");
                            SoSanh();
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("8) xuat danh sach cac doi tuong voi cac phep so sanh voi doi tuong hien tai: ");
                            XuatDanhSach_Menu();
                            break;
                        }
                    default:
                        {
                            Console.Write("vui long nhap gia tri tu 1=>9");
                            break;
                        }
                }
            }

        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.listPhanSo[1] = new PhanSo();
            p.play();
        }
    }
}