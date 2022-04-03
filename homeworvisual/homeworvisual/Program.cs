using System;

namespace homeworvisual
{
    class Program
    {
        static void Main(string[] args)
        {
            sum();
        }
        #region task-1
        //Daxil Edilmis 3 Dene Ededin Arasinda En Boyuyunu Tapan Alqoritm Qurmaq.
        //static void sum()
        //{
        //    Console.WriteLine("deyer daxil et");
        //    string num1str = Console.ReadLine();
        //    string num2str = Console.ReadLine();
        //    string num3str = Console.ReadLine();

        //    try
        //    {
        //        int a = int.Parse(num1str);
        //        int b = int.Parse(num2str);
        //        int c = int.Parse(num3str);
        //        if (a > b && a > c)
        //        {
        //            Console.WriteLine($"en boyuk {a} dir");
        //        }
        //        else if (b > c && b > a)
        //        {
        //            Console.WriteLine($"en boyuk {b} dir");
        //        }
        //        else if (c > b && c > a)
        //        {
        //            Console.WriteLine($"en boyuk {c} dir");
        //        }
        //        else
        //        {
        //            Console.WriteLine("ededler bir birine beraberdi");
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        Console.WriteLine("eded daxil et");
        //    }
        //}
        #endregion
        #region task-2
        //Daxil Edilmis 5 Dene Ededin Ededi Ortasini Tapan Alqoritm Qurmaq
        //static void sum()
        //{
        //    Console.WriteLine("deyer daxil et");
        //    string num1str = Console.ReadLine();
        //    string num2str = Console.ReadLine();
        //    string num3str = Console.ReadLine();
        //    string num4str = Console.ReadLine();
        //    string num5str = Console.ReadLine();
        //    try
        //    {
        //        int a = int.Parse(num1str);
        //        int b = int.Parse(num2str);
        //        int c = int.Parse(num3str);
        //        int d = int.Parse(num4str);
        //        int e = int.Parse(num5str);


        //        int sum = a + b + c + d + e;
        //        int average = sum / 5;

        //        Console.WriteLine($"ededi orta {average} dir");
        //    }
        //    catch (Exception)
        //    {

        //        Console.WriteLine("Eded daxil et !!!!!!");
        //    }
        //}
        #endregion
        #region task-3
        //Duzbucaqlinin Sahe Ve Perimetrini Tapan Alqoritm Qurmaq
        //static void sum()
        //{
        //    Console.WriteLine("eded daxil edin");
        //    string uzunluq = Console.ReadLine();
        //    string en = Console.ReadLine();
        //    try
        //    {
        //        int a = int.Parse(uzunluq);
        //        int b = int.Parse(en);
        //        int S = a * b;
        //        int P = (a + b) * 2;

        //        Console.WriteLine($"duzbucaqlinin Sahesi {S} dir");
        //        Console.WriteLine($"duzbucaqlinin Perimetri {P} dir");
        //    }
        //    catch (Exception)
        //    {
        //        Console.WriteLine("eded daxil et!!!!!!");
        //    }
        //}
        #endregion
        #region task-4
        //Isdifadəçi Ədəd Daxil Edir.Daxil Edilən Ədəd Sadə Və Ya Mürəkkəb Olduğunu Tapana Alqoritm Qururn.
        //static void sum()
        //{
        //    Console.WriteLine("Deyer daxil et");
        //    string name = Console.ReadLine();
        //    try
        //    {
        //        int a = int.Parse(name);
        //        int count = 0;
        //        if (a > 1)
        //        {
        //            for (int i = 1; i < a; i++)
        //            {
        //                if (a % i == 0)
        //                {
        //                    count++;
        //                }
        //                if (count > 2)
        //                {
        //                    Console.WriteLine($"{a} murekkeb ededdir");
        //                    break;
        //                }
        //            }
        //            if (count <= 2)
        //            {
        //                Console.WriteLine($"{a} sade ededdir");
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("1 den boyuk eded daxil edin");
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        Console.WriteLine("eded daxil et!!!!");
        //    }
        //}
        #endregion
        #region task-5
        ////İsdifadəçi Ədəd Daxil Edir.Daxil Edilən Ədədin Neçə Mərtəbəbli Olduğunu Tapan Alqoritmi Qurun
        //static void sum()
        //{
        //    Console.WriteLine("Deyer daxil edin");
        //    string name = Console.ReadLine();
        //    try
        //    {
        //        int a = int.Parse(name);
        //        int count = 0;
        //        while (a > 1)
        //        {
        //            a = a / 10;
        //            count++;

        //        }
        //        Console.WriteLine($"{count} mertebelidi");
        //    }
        //    catch (Exception)
        //    {
        //        Console.WriteLine("eded daxil et!!!!!");
        //    }
        //}
        #endregion
        #region task-6
        //İsdifadəçi Ədəd Daxil Edir.Daxil Edilən Ədədin Müsbət Və Natural Olmalıdır.
        //Daxil Edilən Ədədin Həm 7-ə Həm Də 3-ə Bölünüb Bölünməməsini Tapan Alqoritm Qurun.
        //static void sum()
        //{
        //    Console.WriteLine("Deyer daxil et");
        //    string name = Console.ReadLine();
        //    try
        //    {
        //        int a = int.Parse(name);
        //        if(a>1 && a % 21 == 0)
        //        {
        //            Console.WriteLine("eded hem 3-e,hem 7-e tam bolunur");
        //        }
        //        else
        //        {
        //            Console.WriteLine("duzgun eded daxil et");
        //        }

        //    }
        //    catch (Exception)
        //    {

        //        Console.WriteLine("eded daxil et !!!!!");
        //    }
        //}
        #endregion
        #region task-7
        //Tələbə İmtahan Qiymətini Daxil Edir.Daxil Edilən İmtahan Qiyməti 0 və 100 Aralığında Olmalıdır.
        //Əgər Qiymət 91 və 100 Aralığındadırsa A Çap Etsin.
        //Əgər Qiymət 81 və 90 Aralığındadırsa B Çap Etsin.
        //Əgər Qiymət 71 və 80 Aralığındadırsa C Çap Etsin.
        //Əgər Qiymət 61 və 70 Aralığındadırsa D Çap Etsin.
        //Əgər Qiymət 51 və 60 Aralığındadırsa E Çap Etsin.
        //Əgər Qiymət 51 -dən Kiçikdirsə Kəsildiniz Çap Etsin.

        //static void sum()
        //{
        //    Console.WriteLine("deyer daxil et");
        //    string name = Console.ReadLine();
        //    try
        //    {
        //        int i = int.Parse(name);
        //        if(i>=1 && i <= 100)
        //        {
        //            if (i>=91 && i<=100)
        //            {
        //                Console.WriteLine("A");
        //            }
        //            else if(i>=81 && i <= 90)
        //            {
        //                Console.WriteLine("B");
        //            }
        //            else if (i>=71 && i <= 80)
        //            {
        //                Console.WriteLine("C");
        //            }
        //            else if(i>=61 && i <= 70)
        //            {
        //                Console.WriteLine("D");
        //            }
        //            else if(i>=51 && i <= 60)
        //            {
        //                Console.WriteLine("E");
        //            }
        //            else if (i>=1 && i <= 50)
        //            {
        //                Console.WriteLine("kesildiniz");
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("1 ve 100 araliginda eded daxil et");
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        Console.WriteLine("Eded daxill ett!!!!!");
        //    }
        //}
        #endregion
        #region task-8
        //İsdifadəçi 2 Dənə Ədəd Daxil Edir. Daxil Edilən Ədədlərdə 
        //Daxil Olmaqla Bu Ədədlərin Aralığında Olan Ədədlərin Cəmin Tapan Alqoritm Qurun.
        //static void sum()
        //{
        //    Console.WriteLine("DEyer daxil et");
        //    string num1str = Console.ReadLine();
        //    string num2str = Console.ReadLine();
        //    try
        //    {
        //        int a = int.Parse(num1str);
        //        int b = int.Parse(num2str);
        //        int min;
        //        int max;
        //        int result = 0;
        //        int i;
        //        if (a != b)
        //        {
        //            if (a > b)
        //            {
        //                min = b;
        //                max = a;
        //            }
        //            else
        //            {
        //                min = a;
        //                max = b;
        //            }
        //            while (min <= max)
        //            {

        //                result += min;
        //                min++;
        //            }
        //            Console.WriteLine(result);
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        Console.WriteLine("eded daxil edin !!!!!");
        //    }
        //}
        #endregion
        #region task-9
        //İsdifadəçi 2 Dənə Ədəd  Daxil Edir n və m ədədləri.m Ədədinin n Qüvvətini Tapan Alqoritm Qurun.
        //static void sum()
        //{
        //    Console.WriteLine("deyer daxil edin");
        //    String num1str = Console.ReadLine();
        //    string num2str = Console.ReadLine();
        //    try
        //    {
        //        int m = int.Parse(num1str);
        //        int n = int.Parse(num2str);
        //        int result = 1;
        //        int i = 1;
        //        if(n>1 && m > 1)
        //        {
        //            while (i <= n)
        //            {
        //                result = result * m;
        //                i++;
        //            }
        //            Console.WriteLine(result);
        //        }
        //        else
        //        {
        //            Console.WriteLine("1 den boyuk eded daxil et");
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        Console.WriteLine("Eded daxil et!!!");
        //    }
        //}
        #endregion
    }

}
