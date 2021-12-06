using System;

namespace oyun_ve_uygulama_akadami_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int birinci = 35;
            int ikinci = 34;

            Console.WriteLine(birinci + ikinci + " buraya yazi da yazabilir.");//35+34
            Console.WriteLine(birinci + " yazi " + ikinci);
            Console.WriteLine(birinci + " yazi " + ikinci + 10);
            Console.WriteLine((birinci + 10) + " yazi " + ikinci + 10);
            Console.WriteLine(birinci + 10);
            Console.WriteLine(birinci + 10 + 10 + " yazi");
            Console.WriteLine("////////////////////////////////////////////////");
            ////////////////////////////////////////////////////////////////////////////////////////
            int toplam = 35 + 34;
            int cikarma = 35 - 34;
            int carpma = 35 * 34;
            int bölme = 35 / 34;
            int mod = 35 % 34;

            float bölme_1 = 35 / 34;
            float bölme_2 = 35f / 34;
            float bölme_3 = 35 / 34f;
            float bölme_4 = 35f / 34f;

            float bölme_5 = (float)birinci / ikinci;

            Console.WriteLine("Toplam " + toplam + "\nCikarma " + cikarma + "\nCarpma " + carpma + "\nBölme " + bölme + "\nMod " + mod);
            Console.WriteLine("Bölme_1: " + bölme_1 + "\nBölme_2: " + bölme_2 + "\nBölme_3: " + bölme_3 + "\nBölme_4: " + bölme_4);
            Console.WriteLine("Bölme_5: " + bölme_5);
            Console.WriteLine("////////////////////////////////////////////////");
            ////////////////////////////////////////////////////////////////////////////////////////
            int örnek = 6 + 5 * 2;
            int örnek_1 = (6 + 5) * 2;

            Console.WriteLine("Örnek: " + örnek);
            Console.WriteLine("Örnek_1: " + örnek_1);
            Console.WriteLine("////////////////////////////////////////////////");
            ////////////////////////////////////////////////////////////////////////////////////////
            int ucuncu = birinci + 5;//35+5

            ucuncu += 10;//40+10
            ucuncu -= 10;//50-10
            ucuncu *= 2;//40*2
            ucuncu /= 5;//80/5

            ucuncu++;//16+1
            ucuncu--;//17-1
            ++ucuncu;//16+1

            Console.WriteLine("Ucuncu Sayi: " + ucuncu);
            Console.WriteLine("////////////////////////////////////////////////");
            ////////////////////////////////////////////////////////////////////////////////////////
            //santimetre den inch e cevirme.
            //metre2 den sqfeet e cevirme yapalım.

            //2.54cm = 1 inch
            //1sqfoot = 0.092903 m2 10.764

            int agac = 150;//cm
            int alan = 1000;//m2

            Console.WriteLine((agac/2.54f) + " inch olan bir agacım " + (alan*10.764f) + " sqfeet arazimde tek başına duruyor.");



            Console.ReadLine();
        }
    }
}
