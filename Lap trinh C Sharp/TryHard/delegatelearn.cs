using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatelearn
{
    public class Logs
    {
        // Phai cung KIEU TRA VE va CUNG KIEU THAM SO TRUYEN VAO    
        public delegate void ShowLog(string message);

        static public void Infor(string s)
        {
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("Infor : " + s);
            Console.ResetColor();
        }

        public static void Warning(string str)
        {
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("Anotation : " + str);
            Console.ResetColor();
        }

        public static int Sum(int x, int y)
        {
            return x + y;
        }


        //static void Main(string[] args)
        //{
        //    ShowLog showLog;
        //    showLog = Infor;
        //    showLog("Dark qua");
        //    showLog = Warning;
        //    showLog("Bruhhh");

        //    Console.WriteLine();

        //    showLog = null;
        //    showLog += Infor;
        //    showLog += Warning;
        //    showLog += Infor;
        //    showLog += Warning;

        //    showLog("Testing");

        //    Console.WriteLine();

        //    Action<string> showMe;
        //    showMe = Infor;
        //    showMe("Hello Zawarudo");
        //    showMe = Warning;
        //    showMe("Star Plati");

        //    showMe += Infor;
        //    showMe += Warning;
        //    showMe += Infor;
        //    showMe += Warning;

        //    showMe("JOJOLION");


        //    Func<int, int, int> trial;
        //    trial = Sum;
        //    Console.WriteLine("Ket qua la: " + trial(1, 1));

        //}
    }
}
