using System;

namespace oyun_ve_uygulama_akadami_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string sehir_Adi_1="İzmir";
            string yemek_1 = "bomba";
            int fiyat_1=5;
            float sicakli_1=25.5f;

            Console.Write(sehir_Adi_1);
            Console.Write("\'de ");
            Console.Write(yemek_1);
            Console.Write(" yedim ve tanesi ");
            Console.Write(fiyat_1);
            Console.Write(" liraydi ve hava sıcaklığı ");
            Console.Write(sicakli_1);
            Console.WriteLine(" dereceydi.");
            Console.WriteLine("////////////////////////////////////////////////////");
            //////////////////////////////////////////////////////////////////////////

            string birinci = "Çiçek";
            string ikinci = "Halime Beyza " + birinci;
            string ucuncu = "Ogrenci " + birinci + " " + "Halime Beyza"; 
            Console.WriteLine(ikinci);
            Console.WriteLine(ucuncu);
            Console.WriteLine("////////////////////////////////////////////////////");
            //////////////////////////////////////////////////////////////////////////

            string dorduncu = $"{birinci} {ikinci}";
            string besinci = $"{birinci} {ikinci} elle yazi yazilabilir.";
            string altinci = $@"c:\users\halime\{ikinci}\veri";
            Console.WriteLine(dorduncu);
            Console.WriteLine(besinci);
            Console.WriteLine(altinci);


            Console.ReadLine();
        }
    }
}
