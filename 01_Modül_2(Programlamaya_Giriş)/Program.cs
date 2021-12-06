using System;

namespace oyun_ve_uygulama_akadami_01
{
    class Program
    {
        static int a;
        static float b;
        private static bool c;//başka class'dan erişilemez.(True veya False)
        private static string d;//birden fazla karakteri içinde tutabiliyor.

        static void Main(string[] args)
        {
            Console.WriteLine("Bu bir satırdır.");
            Console.WriteLine("Bu da bir satırdır.");

            Console.Write("\nBu bir sonraki satırdır.");
            Console.Write("\nBu satir en alttadir.");
            Console.WriteLine("\n----------------------------------------------");
            ///////////////////////////////////////////////////////////////
            a = 1;
            b = 1.1f;
            c = true;
            d = "Birden fazla karakter.";
            //b = 1.1m;//HATA
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(1.1m);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine("----------------------------------------------");
            ///////////////////////////////////////////////////////////////
            string benimAdim;//Deklerasyon,tanımlama.
            float ondalikliUcBasamakliSayi;//Camel Case
            float OndalikliSayi;//Pascal Case
            benimAdim = "Halime";
            Console.WriteLine(benimAdim);
            benimAdim = "Beyza";
            Console.WriteLine(benimAdim);
            Console.WriteLine("----------------------------------------------");
            ///////////////////////////////////////////////////////////////
            //var tam; //HATA Set etmem gerekiyor.
            var tam = true;//bool oluyor
            var tam_1 = 1.2f;//float oluyor
            Console.WriteLine(tam);
            Console.WriteLine(tam_1);


            Console.ReadLine();//Console' un kapanmaması için bunu ekledik.
        }
    }
}
