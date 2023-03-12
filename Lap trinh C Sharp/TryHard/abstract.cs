using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Product : IProduct
    {
        protected double price = 0;

        public virtual void getInfo()
        {
            Console.WriteLine("Product Information");
        }

        public void testProduct()
        {
            this.getInfo();
        }

        public virtual void getPrice()
        {
            Console.WriteLine("Product price");
        }
    }

    public class Iphone : Product
    {
        public Iphone()
        {
            price =  500;
        }

        public override void getInfo()
        {
            Console.WriteLine("Day la Iphone");
            base.getInfo();
        }

        public override void getPrice()
        {
            Console.WriteLine("Gia la 1 Jack");
            base.getPrice();
        }
    }

    public interface IProduct
    {
        public void getPrice();
    }


    //public class testProduct
    //{
    //    static void Main(string[] args)
    //    {
    //        Product p = new Product();
    //        p.getInfo();
    //        p.getPrice();

    //        Iphone p2 = new Iphone();
    //        p2.getInfo();
    //        p2.getPrice();
            
    //    }
    //}
}
