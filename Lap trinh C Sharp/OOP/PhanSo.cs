using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class PhanSo
    {
        private int tuSo;
        private int mauSo;

        public int TuSo { get => tuSo; set => tuSo = value; }
        public int MauSo { get => mauSo; set => mauSo = value; }

        public PhanSo() { }

        public PhanSo(int tuSo, int mauSo)
        {
            this.tuSo = tuSo;
            this.mauSo = mauSo;
        }

        public void nhapPhanSo()
        {
            Console.WriteLine("Nhap tu so");
            tuSo = Convert.ToInt32(Console.ReadLine());
            mauSo= Convert.ToInt32(Console.ReadLine());
        }

        public void hienThi()
        {
            if (mauSo == 1)
            {
                Console.WriteLine(tuSo);
            }
            else if(tuSo == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(tuSo + "/" + mauSo);
            }
        }

        public void ngichDao()
        {
            int t = tuSo;
            tuSo = mauSo;
            mauSo = tuSo;
        }

        public PhanSo giaTriNgichDao()
        {
            return new PhanSo(mauSo, tuSo);
        }

        public float giaTriThuc()
        {
            return (float)(tuSo / mauSo);
        }
    }
}
