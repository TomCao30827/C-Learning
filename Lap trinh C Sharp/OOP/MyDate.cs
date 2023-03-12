using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class MyDate
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

        public MyDate(MyDate a)
        {
            this.ngay = a.ngay;
            this.thang = a.thang;
        }

        public void hienThi()
        {
            Console.WriteLine($"{ngay}/{thang}/{nam}");
        }

        public void nhapDate()
        {
            Console.WriteLine("Nhap ngay: ");
            ngay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap thang");
            thang = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap nam");
            nam = Convert.ToInt32(Console.ReadLine());
        }

        public int tinhSoNgay(int thang, int nam) 
        {
            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    if ((nam % 400 == 0) || (nam % 100 != 0 && nam % 4 == 0))
                    {
                        return 29;
                    }
                    else
                    {
                        return 28;
                    }
            }
            return 0;
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
                case 1:
                case 3: 
                case 5: 
                case 7: 
                case 8: 
                case 10: 
                case 12:
                    if (ngay > 31)
                    {
                        return false;
                    }break;

                case 4: 
                case 6: 
                case 9: 
                case 11:
                    if (ngay > 30)
                    {
                        return false;
                    }break;

                case 2:
                    if (((nam % 400 == 0) || (nam % 100 != 0 && nam % 4 == 0)) && ngay > 29)
                    {
                        return false;
                    }
                    else if (ngay > 28)
                    {
                        return false;
                    }
                    break;
            }
            return true;
        }

        public MyDate ngayHomSau()
        {
           if (ngay >= tinhSoNgay(thang, nam))
            {
                if (thang < 12)
                {
                    return new MyDate(1, thang + 1, nam);
                }
                else
                {
                    return new MyDate(1, 1, nam + 1);
                }
                   
            }
            return new MyDate(ngay + 1, thang, nam);
        }
    }
}
