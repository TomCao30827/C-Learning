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

        public bool lonHon(PhanSo a)
        {
            if (this.giaTriThuc() > a.giaTriThuc())
            {
                return true;
            }
            return false;
        }

        public PhanSo congPhanSo(PhanSo a)
        {
            if (this.mauSo == a.mauSo)
            {
                return new PhanSo(this.tuSo + a.tuSo, mauSo);
            }
            else
            {
                return new PhanSo((this.tuSo * a.MauSo) + (a.tuSo * this.mauSo), this.mauSo * a.mauSo);
            }
        }

        public PhanSo truPhanSo(PhanSo a)
        {
            if (this.mauSo == a.mauSo)
            {
                return new PhanSo(this.tuSo - a.tuSo, mauSo);
            }
            else
            {
                return new PhanSo((this.tuSo * a.MauSo) - (a.tuSo * this.mauSo), this.mauSo * a.mauSo);
            }
        }

        public PhanSo nhanPhanSo(PhanSo a)
        {
            return new PhanSo(this.tuSo * a.tuSo, this.mauSo * a.mauSo);
        }

        public PhanSo chiaPhanSo(PhanSo a)
        {
            return new PhanSo(this.tuSo * a.mauSo, this.mauSo * a.tuSo);
        }

        public PhanSo congSoNguyen(int a)
        {
            return new PhanSo(tuSo + (a * mauSo), mauSo);
        }

        public PhanSo truSoNguyen(int a)
        {
            return new PhanSo(tuSo - (a * mauSo), mauSo);
        }

        public PhanSo nhanSoNguyen(int a)
        {
            return new PhanSo(tuSo * a, mauSo);
        }

        public PhanSo chiaSoNguyen(int a)
        {
            return new PhanSo(tuSo, mauSo * a);
        }
    }
}
