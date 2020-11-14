using System;


namespace BTH6._2
{
     class Person
    {
        private string hoten, quequan;
        private DateTime ngaysinh;
        public Person()
        {
            hoten = quequan = "";
        }
        public Person(string hoten,string quequan,DateTime ngaysinh)
        {
            this.hoten = hoten;
            this.quequan = quequan;
            this.ngaysinh = ngaysinh;
        }
        public virtual void Nhap()
        {
            Console.Write("Nhap ho ten :");
            hoten = Console.ReadLine();
            Console.Write("Nhap que quan:");
            quequan = Console.ReadLine();
            Console.WriteLine("nhap ngay sinh:");
            ngaysinh = DateTime.Parse(Console.ReadLine());

        }
        public virtual void Hien()
        {
            Console.WriteLine("{0}\t{1}\t{2}" + hoten, quequan, ngaysinh);
        }
    }
    class Sinhvien:Person
    {
        private string maSV, LOP;
        public Sinhvien() : base() { maSV = LOP = ""; }
        public Sinhvien(string hoten, string quequan, DateTime ngaysinh, string maSV, string LOP) : base(hoten,quequan,ngaysinh) { this.maSV = maSV;this.LOP = LOP; }
        public override void Nhap()
        {
            Console.WriteLine("Nhap thong tin sinh vien");
            Console.WriteLine("Nhap ma sinh vien ");
            maSV = Console.ReadLine();
            Console.WriteLine("Nhap lop");
            LOP = Console.ReadLine();
            base.Nhap();
        }
        public override void Hien()
        {
            Console.WriteLine("hien thong tin sinh vien");
            Console.WriteLine("ma sinh vien " + maSV);
            Console.WriteLine("Lop " + LOP);
            base.Hien();
        }
    }
    class QL
    {
        private int sn;
        private Person[] ds;
        public void Nhap()
        {
            Console.Write("Nhap so nguoi:");
            sn = int.Parse(Console.ReadLine());
            ds = new Person[sn];
            for (int i = 0; i < sn;++i)
            {
                Console.WriteLine("Ban muon nhap thong tin peson(P) hoac sinh vien(S)");
                char c = char.Parse(Console.ReadLine());
                switch(char.ToLower(c))
                {
                    case 'P':ds[i] = new Person(); ds[i].Nhap();break;
                    case 'S':ds[i] = new Sinhvien(); ds[i].Nhap(); break;
                }
            }  
        }
        public void Hien()
        {
            for (int i = 0; i < sn; ++i)
            {
                ds[i].Hien();
            }
        }
    }
    class Program
    {
        static void Main()
        {
            QL t = new QL();
            t.Nhap();
            t.Hien();
            Console.ReadKey();
        }
    }
}
