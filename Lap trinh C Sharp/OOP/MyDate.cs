using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class MyDate
    {
        private int ngay;
        private int thang;
        private int nam;

        public int Ngay { get => ngay; set => ngay = value; }
        public int Thang { get => thang; set => thang = value; }
        public int Nam { get => nam; set => nam = value; }

        public MyDate()
        {
            ngay = 1;
            thang = 1;
            nam = 1;
        }

        public MyDate(int ngay, int thang, int nam)
        {
            Ngay = ngay;
            Thang = thang;
            Nam = nam;
        }

        public void hienThi()
        {
            Console.WriteLine($"{ngay}/{thang}/{nam}");
        }

        public void nhapDate()
        {
            ngay = Convert.ToInt32(Console.ReadLine());
            thang = Convert.ToInt32(Console.ReadLine());
            nam = Convert.ToInt32(Console.ReadLine());
        }

        public Boolean ktraDate()
        {
            if (nam < 1 || thang < 1 || thang > 12 || ngay < 1)
            {
                return false;
            }
            else
            {

            }
            switch (thang)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    if (ngay > 31)
                    {
                        return false;
                    }break;

                case 4: case 6: case 9: case 11:
                    if (ngay > 30)
                    {
                        return false;
                    }break;

                case 2:
                    if ((nam % 400 == 0) || (nam % 100 != 0 && nam % 4 ==0) )
                    {
                        return false;
                    }break;
            }
            return true;
        }

        public MyDate ngayHomSau()
        {
            switch (thang)
            {
                case 1: case 3: case 5: case 7: case: case 8: case 10: case 12:
                    if (ngay == 31)
                    {
                        return new MyDate
                    }
            }
        }
    }
}
