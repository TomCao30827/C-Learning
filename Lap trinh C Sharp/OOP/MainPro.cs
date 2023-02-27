namespace OOP
{
    internal class MainPro
    {
        static void Main(string[] args)
        {
            MyDate t = new MyDate(22, 2, 2003);
            t.hienThi();
            t.nhapDate();
            t.hienThi();
            Console.WriteLine("So ngay cua thang la " + t.tinhSoNgay(t.Thang, t.Nam));
            t.ngayHomSau().hienThi();
        }
    }
}