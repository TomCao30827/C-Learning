using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class SinhVien
    {
        private string? mssv;
        private string? hoten;
        private MyDate sinhNhat;
        private int slhp;
        private String[]? tenHP;
        private String[]? diem = new String[] {};

        public string Mssv { get => mssv; set => mssv = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public int Slhp { get => slhp; set => slhp = value; }
        public string[] TenHP { get => tenHP; set => tenHP = value; }
        public string[] Diem { get => diem; set => diem = value; }
        internal MyDate SinhNhat { get => sinhNhat; set => sinhNhat = value; }

        public SinhVien() { }

        public SinhVien(string mssv, string hoten, MyDate sinhNhat, int slhp, string[] tenHP, string[] diem)
        {
            Mssv = mssv;
            Hoten = hoten;
            SinhNhat = new MyDate();
            Slhp = slhp;
            TenHP = tenHP;
            Diem = diem;
        }
        
        public SinhVien(SinhVien a)
        {
            this.mssv = a.mssv;
            this.hoten = a.hoten;
            this.slhp = a.slhp;
            this.tenHP = a.tenHP;
        }

        public void NhapTT()
        {
            Console.WriteLine("Nhap mssv");
            mssv = Console.ReadLine();
            Console.WriteLine("Nhap hoten");
            hoten = Console.ReadLine();
            Console.WriteLine("Nhap slhp");
            slhp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap ten hp");

            for (int i = 0; i < slhp; i++)
            {
                tenHP[i] = Console.ReadLine();       
            }
        }

        public void GanDiem()
        {
            Console.WriteLine("Nhap diem tung hoc phan");
            for (int i = 0; i < slhp; i++)
            {
                diem[i] = Console.ReadLine();
            }
        }

        public double ChuyenDoiDiem(string a)
        {
            
            switch(a)
            {
                case "A": return 9;
                case "B+": return 8.5;
                case "B": return 8;
                case "C+": return 7.5;
                case "C": return 7;
                case "D+": return 6.5;
                case "D": return 6;
                default: return 0;
            }
        }


        public double KquaTB()
        {
            double sum = 0;
            for (int i = 0; i < slhp; i++)
            {
                sum += ChuyenDoiDiem(diem[i]);
            }
            return ((sum / slhp)* 4/10);
        }

        public void DangKyHP()
        {
            tenHP[slhp] = Console.ReadLine();
            slhp++;
        }

        public void XoaHP()
        {
            Console.WriteLine("Nhap hoc phan can xoa");
            string t = Console.ReadLine();
            for (int i = 0; i < slhp; i++)
            {
                if (tenHP[i].Equals(t))
                {
                    for (int j = slhp -1; j > i; j--)
                    {
                        tenHP[j] = tenHP[j- 1];
                    }
                    slhp--;
                    Console.WriteLine("Da xoa hoc phan");
                }
                else
                {
                    Console.WriteLine("Hoc phan khong ton tai");
                }
            }
        }
    }
}
