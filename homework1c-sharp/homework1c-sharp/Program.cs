using System;

namespace homework1c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            sum();
        }
        #region task-1
        //Daxil Edilmis 3 Dene Ededin Arasinda En Boyuyunu Tapan Alqoritm Qurmaq.
        static void sum()
        {
            Console.WriteLine("deyer daxil et");
            string num1str = Console.ReadLine();
            string num2str = Console.ReadLine();
            string num3str = Console.ReadLine();

            try
            {
                int a = int.Parse(num1str);
                int b = int.Parse(num2str);
                int c = int.Parse(num3str);
                if (a > b && a > c)
                {
                    Console.WriteLine($"en boyuk {a} dir");
                }
                else if (b > c && b > a)
                {
                    Console.WriteLine($"en boyuk {b} dir");
                }
                else if (c > b && c > a)
                {
                    Console.WriteLine($"en boyuk {c} dir");
                }
                else
                {
                    Console.WriteLine("ededler bir birine beraberdi");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("eded daxil et");
                //    }
                #endregion


            }
        }
    }
}