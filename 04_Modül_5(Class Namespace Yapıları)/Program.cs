using System;

namespace oyun_ve_uygulama_akadami_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Yeni inst = new Yeni();

            inst.birinci = 10;
            inst.ikinci = 20;
            //inst.ucuncu-->buna erişemem çünkü private.

            //Console.WriteLine(inst.birinci + inst.ikinci);//10+20
            Console.WriteLine(inst.toplama());
            Console.WriteLine("/////////////////////////////////////////////");
            /////////////////////////////////////////////////////////////////////////////
            //10 un 2. kuvveti
            //en kucuk deger
            //mutlak deger

            int sayi_1 = 8;
            int sayi_2 = 2;

            Console.WriteLine(Math.Pow(sayi_1, sayi_2));//64
            Console.WriteLine(Math.Pow(10, 2));//100
            Console.WriteLine(Math.Min(8, 2));//2
            Console.WriteLine(Math.Abs(-2.54f));//2.54


            Console.ReadLine();
        }
    }

    class Yeni
    {
        public int birinci;
        public int ikinci;
        //private int ucuncu;

        public int toplama()
        {
            return birinci + ikinci;
        }
    }
}
