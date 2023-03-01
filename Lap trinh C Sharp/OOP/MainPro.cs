namespace OOP
{
    internal class MainPro
    {
        static void Main(string[] args)
        {
            Gach a= new Gach();
            a.nhapTTin();
            a.hienThi();
            Console.WriteLine("Max dt: " + a.maxDt(300, 400));
            Console.WriteLine("So luong gach: " + a.soLuongHopGach(300, 400));

        }
    }
}