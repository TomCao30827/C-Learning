using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda
{
    internal class Program
    {
        public delegate int TinhToan(int x, int y);

        static void Main(string[] args)
        {
            TinhToan tinhTong = (int x, int y) => { return x + y; };

            int kq = tinhTong(1, 2);

            Console.WriteLine("Ket qua la " + kq);

            Func<int, int, int, int> tongBa = (int x, int y, int z) => { return x + y + z; };

            int ba = tongBa(1, 2, 3);
            Console.WriteLine("Ket qua la " + ba);
        }
    }
}
