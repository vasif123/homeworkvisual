using System;

namespace homeworkkk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mehsulun adini yazin");
            Product name  = new Product(Console.ReadLine());
            Console.WriteLine("price daxil edin");
            Product price = new Product(Console.ReadLine());
            Console.WriteLine("mehsul sayini daxil edin");
            Product count = new Product(Console.ReadLine());
        }
    }
}
