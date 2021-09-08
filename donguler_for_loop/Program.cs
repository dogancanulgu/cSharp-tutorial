using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Write("Lütfen bir sayı giriniz: ");
            // int sayac = int.Parse(Console.ReadLine());
            // for (int i = 0; i <= sayac; i++)
            // {
            //     if (i % 2 == 1)
            //         System.Console.WriteLine(i);
            // }
            // int tekToplam = 0;
            // int ciftToplam = 0;
            // for (int i = 0; i <= 1000; i++)
            // {
            //     if (i % 2 == 1)
            //         tekToplam += i;
            //     else
            //         ciftToplam += i;
            // }
            // System.Console.WriteLine("Tek toplam: "+ tekToplam);
            // System.Console.WriteLine("Çift toplam: "+ ciftToplam);

            for (int i = 1; i < 10; i++)
            {
                if(i == 4)
                    break;
                System.Console.WriteLine(i);
            }
                for (int i = 1; i < 10; i++)
            {
                if(i == 4)
                    continue;
                System.Console.WriteLine(i);
            }
        }
    }
}
