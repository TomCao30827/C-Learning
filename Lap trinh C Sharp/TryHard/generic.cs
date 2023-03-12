namespace Generic

{
    internal class generic
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T t = a;
            a = b;
            b = t;
        }
        
        class Product<T>
        {
            T ID;
            
            public void setID(T ID)
            {
                this.ID = ID;
            }

            public void printID()
            {
                Console.WriteLine(ID);
            }
        }

 /*       static void Main(string[] args)
        {
            int a = 4;
            int b = 5;

            Swap(ref a, ref b);
            Console.WriteLine("{0} va {1}", a, b);

            Product<int> p = new Product<int>();
            p.printID();
        }
 */
        
    }
}