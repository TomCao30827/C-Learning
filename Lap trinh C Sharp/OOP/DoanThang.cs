using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class DoanThang
    {
        private Diem d1;
        private Diem d2;

        public Diem D1 { get => d1; set => d1 = value; }
        public Diem D2 { get => d2; set => d2 = value; }

        public DoanThang() { }

        public DoanThang(Diem d1, Diem d2)
        {
            this.d1 = d1;
            this.d2 = d2;
        }

        public DoanThang(int ax, int ay, int bx, int by)
        {
            d1 = new Diem(ax, ay);
            d2 = new Diem(bx, by);
        }

        public void nhapToaDo()
        {
            Console.WriteLine("Nhap toa do d1");
            d1.nhapDiem();
            Console.WriteLine("Nhap toa do d2");
            d2.nhapDiem();
        }

        public void hienThi()
        {
            Console.Write("Toa do 2 diem lan luot la: \nd1: ");
            d1.hienThi();
            Console.Write("d2"); 
            d2.hienThi();
        }

        public DoanThang tinhTien(int dx, int dy)
        {
            return new DoanThang(d1.doiDiemMoi(dx, dy), d2.doiDiemMoi(dx, dy));
        }

        public double tinhDoDai()
        {
            double doDai = Math.Sqrt((d1.X - d2.X)* (d1.X - d2.X) + (d1.Y - d2.Y)*(d1.Y - d2.Y));
            return doDai;
        }

        public double tinhGoc()
        {
            double theta = Math.Atan2((d1.Y - d2.Y), (d1.X - d2.X));
            return theta;
        }
    }
}
