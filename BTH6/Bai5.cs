using System;
using System.Collections.Generic;
using System.Text;

namespace BTH6
{
    class Bai5
    {
        abstract class Phong
        {
            protected int songaythue;
            public Phong()
            {

            }
            public Phong(int songaythue)
            {
                this.songaythue = songaythue;
            }
            public virtual void Nhap()
            {
                Console.Write("Nhap so ngay thue:");
                songaythue = int.Parse(Console.ReadLine());
            }
            public virtual void Hien()
            {
                Console.WriteLine("So NGAY THUE" + songaythue);
            }
            public abstract double Tinh();
        }
        class PhongA : Phong
        {
            private int tiendv;
            public PhongA() : base() { tiendv = 0; }
            public PhongA(int songaythue, int tiendv) : base(songaythue) { this.tiendv = tiendv; }
            public override void Nhap()
            {
                base.Nhap();
                Console.WriteLine("Nhap thong tin phong A");
                Console.Write("Nhap tien dich vu:");
                tiendv = int.Parse(Console.ReadLine());

            }
            public override void Hien()
            {
                Console.WriteLine("Hien thi thong tin phong A");
                base.Hien();
                Console.WriteLine("Tien dich vu" + tiendv);
                Console.WriteLine("tong tien" + Tinh());
            }
            public override double Tinh()
            {
                if (songaythue < 5)
                    return songaythue * 80 + tiendv;
                else
                {
                    return (songaythue * 80 + tiendv) * 0.1;
                }
            }
        }
        class PhongB : Phong
        {
            public PhongB() : base() { }
            private PhongB(int songaythue) : base(songaythue) { }
            public override void Nhap()
            {
                Console.WriteLine("Nhap thong tin phong B");
                base.Nhap();
            }
            public override void Hien()
            {
                Console.WriteLine("Hien thi thong tin phong B");
                base.Hien();
                Console.WriteLine("tong tien: " + Tinh());
            }
            public override double Tinh()
            {
                if (songaythue < 5)
                    return songaythue * 60;
                else
                {
                    return (songaythue * 80) * 0.1;
                }
            }
        }
        class PhongC : Phong
        {
            public PhongC() : base() { }
            private PhongC(int songaythue) : base(songaythue) { }
            public override void Nhap()
            {
                Console.WriteLine("Nhap thong tin phong C");
                base.Nhap();
            }
            public override void Hien()
            {
                Console.WriteLine("Hien thi thong tin phong C");
                base.Hien();
                Console.WriteLine("tong tien: " + Tinh());
            }
            public override double Tinh()
            {
                if (songaythue < 5)
                    return songaythue * 40;
                else
                {
                    return (songaythue * 40) * 0.1;
                }
            }
        }
        class QL
        {
            private Phong[] DS;
            private int sp;
            public void Nhap()
            {
                Console.Write("Nhap so phong:");
                sp = int.Parse(Console.ReadLine());
                DS = new Phong[sp];
                for (int i = 0; i < sp; i++)
                {
                    Console.WriteLine("Ban Muon Nhap Thong Tin Cho Phong(A),Phong(B),Phong(C)");
                    char ch = char.Parse(Console.ReadLine());
                    switch (char.ToUpper(ch))
                    {
                        case 'A': DS[i] = new PhongA(); DS[i].Nhap(); break;
                        case 'B': DS[i] = new PhongB(); DS[i].Nhap(); break;
                        case 'C': DS[i] = new PhongC(); DS[i].Nhap(); break;
                    }

                }
            }
            public void Hien()
            {
                for (int i = 0; i < sp; i++)
                {
                    DS[i].Hien();
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
}
