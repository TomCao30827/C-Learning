using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Gach
    {
        private String maSo;
        private String mau;
        private int slGach;
        private int cdaiGach;
        private int cngangGach;
        private long giaBan;

        public string MaSo { get => maSo; set => maSo = value; }
        public string Mau { get => mau; set => mau = value; }
        public int SlGach { get => slGach; set => slGach = value; }
        public int CdaiGach { get => cdaiGach; set => cdaiGach = value; }
        public int CngangGach { get => cngangGach; set => cngangGach = value; }
        public long GiaBan { get => giaBan; set => giaBan = value; }
    
        public Gach() 
        { 
        
        }

    
        public Gach(string maSo, string mau, int slGach, int cdaiGach, int cngangGach, long giaBan)
        {
            MaSo = maSo;
            Mau = mau;
            SlGach = slGach;
            CdaiGach = cdaiGach;
            CngangGach = cngangGach;
            GiaBan = giaBan;
        }

        public void nhapTTin()
        {
            Console.WriteLine("Nhap maso");
            maSo = Console.ReadLine();
            Console.WriteLine("Nhap mau");
            mau = Console.ReadLine();
            Console.WriteLine("Nhap sluong gach");
            slGach = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap cdai gach");
            cdaiGach= int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap cngang gach");
            cngangGach= int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap gia ban");
            giaBan= int.Parse(Console.ReadLine());
        }

        public void hienThi()
        {
            Console.WriteLine("Ttin cua vien gach");
            Console.WriteLine("Ma so: " + maSo);
            Console.WriteLine("Mau: " + mau);
            Console.WriteLine("Sluong gach: " + slGach);
            Console.WriteLine("CdaiGach: " + cdaiGach);
            Console.WriteLine("CngangGach: " + cngangGach);
            Console.WriteLine("Gia ban: " + giaBan);
        }

        public float giaBanLe()
        {
            float giale = giaBan + (giaBan*20/100);
            return giale;
        }

        public double maxDt(int dai, int rong) 
        {
            int max = 0;
            do
            {
                max += cdaiGach * cngangGach;
            }
            while (max < dai * rong);
            return max - cdaiGach * cngangGach;
        }

        public int soLuongHopGach(int dai, int rong)
        {
            return (int)((maxDt(dai, rong)/ (cdaiGach * cngangGach)));
        }
    }
}
