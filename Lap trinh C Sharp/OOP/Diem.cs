using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Diem
    {
        private int x;
        private int y;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public Diem() { }

        public Diem(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void nhapDiem()
        {
            x = Int32.Parse(Console.ReadLine());
            y = Int32.Parse(Console.ReadLine());
        }

        public void hienThi()
        {
            Console.WriteLine($"{x}/{y}");
        }
        
        public void doiDiem(int x, int y)
        {
            this.x += x;
            this.y += y;
        }

        public double khoangCach()
        {
            return Math.Sqrt(x * x + y * y);
        }

        public double khoangDach(Diem d)
        {
            return Math.Sqrt((x - d.x)* (x - d.x) + (y - d.y) * (y - d.y));
        }
    }
}
