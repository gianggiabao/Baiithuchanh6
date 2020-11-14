using Microsoft.VisualBasic;
using System;
using System.Security.Cryptography.X509Certificates;

namespace BTH6
{
    class Nhanvien
    {
        protected string hoten, diachi;
        protected DateTime ngaysinh;
        public Nhanvien()
        {
            hoten = diachi = "";
            ngaysinh = DateTime.Now;
        }
        public Nhanvien(string hoten,string diachi,DateTime ngaysinh)
        {
            this.hoten = hoten;
            this.diachi = diachi;
            this.ngaysinh = ngaysinh;
        }
        public virtual void Nhap()
        {
            Console.Write("nhap ho ten:");
            hoten = Console.ReadLine();
            Console.Write("Nhap dia chi:");
            diachi = Console.ReadLine();
            Console.Write("Nhap ngay sinh");
            ngaysinh = DateTime.Parse(Console.ReadLine());
        }
        public virtual void Hien()
        {
            Console.WriteLine("{0}\t{1}\t{2}", hoten, diachi, ngaysinh);
        }
        public  virtual double TinhLuong()
        {
            return 0;
        }
    }
     class NVSX:Nhanvien
    {
        private int ssp;
        public NVSX() : base() { ssp = 0; }
        public NVSX(string hoten,string diachi,DateTime ngaysinh,int ssp) : base(hoten, diachi, ngaysinh) { this.ssp = ssp; }
        public override void Nhap()
        {
            Console.WriteLine("Nhap thong tin cho nhan vien san xuat:");
            base.Nhap();
            Console.Write("nhan so san pham:");
            ssp = int.Parse(Console.ReadLine());
        }
        public override void Hien()
        {
            Console.WriteLine("thong tin nhan vien san xuat");
            Console.WriteLine("so san pham :" + ssp);
            Console.WriteLine("Luong " + TinhLuong());
            base.Hien();
        }
        public override double TinhLuong()
        {
            return ssp * 20;
        }
    }
    class NVCN:Nhanvien
    {
        private int snc;
        public NVCN() : base() { snc = 0; }
        public NVCN(string hoten,string diachi,DateTime ngaysinh ,int snc) : base(hoten,diachi,ngaysinh) { this.snc = snc; }
        public override void Nhap()
        {
            Console.WriteLine("Nhap thong tin nhan vien cong nhat");
            Console.WriteLine("nhap so ngay cong:");
            snc = int.Parse(Console.ReadLine());
            base.Nhap();
        }
        public override void Hien()
        {
            Console.WriteLine("hien thong tin nhan vien cong nhat");
            Console.WriteLine("so ngay cong :" + snc);
            Console.WriteLine("luong :"+TinhLuong());
            base.Hien();
        }
        public override double TinhLuong()
        {
            return snc * 50;
        }
    }
   class NVQL:Nhanvien
    {
       private double hesoluong;
        private  int luongcoban ;
        public NVQL() : base() { hesoluong = luongcoban = 0; }
        public NVQL(string hoten ,string diachi,DateTime ngaysinh,double hesoluong,int luongcoban) : base(hoten,diachi,ngaysinh) { this.hesoluong = hesoluong;this.luongcoban = luongcoban; }
        
        public override void Nhap()
        {
            Console.WriteLine("nhap thong tin nhan vien quan ly");
            Console.WriteLine("Nhan he so luong:");
            hesoluong = double.Parse(Console.ReadLine());
            Console.WriteLine("nhap luong co ban:");
            luongcoban = int.Parse(Console.ReadLine());
            base.Nhap();
        }
        public override void Hien()
        {
            Console.WriteLine("Hien thong tin nhan vien quan ly");
            Console.WriteLine("he so luong " + hesoluong);
            Console.WriteLine("luong " + TinhLuong());
            base.Hien();
        }
        public override double TinhLuong()
        {
            return hesoluong * luongcoban;
        }
    }
   class QuanLy
    {
        private Nhanvien[] ds;
        private int snv;
        public void Nhap()
        {
            Console.Write("Nhap so nhan vien:");
            snv = int.Parse(Console.ReadLine());
            ds = new Nhanvien[snv];
            for (int i = 0; i < snv; ++i)
            {
                Console.WriteLine("ban muon nhap thong cho nhan vien quanly(Q),congnhan(C),sanxuat(S)");
                char ch = char.Parse(Console.ReadLine());
                switch(char.ToLower(ch))
                {
                    case 'Q': ds[i] = new NVQL();ds[i].Nhap();break;
                    case 'C': ds[i] = new NVCN(); ds[i].Nhap(); break;
                    case 'S': ds[i] = new NVSX(); ds[i].Nhap(); break;
                }
            }  
        }
        public void Hien()
        {
            for(int i=0;i<snv;i++)
            {
                ds[i].Hien();
            }    
        }
    }
    class Program
    {
        static void Main()
        {
            QuanLy t = new QuanLy();
            t.Nhap();
            t.Hien();
            Console.ReadKey();
        }
    }
}
