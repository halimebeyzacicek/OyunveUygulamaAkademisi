using System;

namespace oyun_ve_uygulama_akadami_05
{
    class Program
    {
        public static int sayi_4;//burada kullandığım için bir sayıya eşitlememe gerek yok.
        static void Main(string[] args)//Bu bir metot
        {
            //20 ye kadar sayi olan bir zar
            //15-20 arasında büyük zarar
            //10-15 arasında orta boyut zarar
            //5-10 zarar yok
            //2-5 kendime zarar
            //4. veya 5. zar 18 üstünde gelirse, ek zarar vereceğiz.


            Random zar = new Random();//Random static bir class değil

            int birinciAtis = zar.Next(1, 21);//21 dahil değil.
            int ikinciAtis = zar.Next(1, 21);
            int ucuncuAtis = zar.Next(1, 21);
            int dorduncuAtis = zar.Next(1, 21);
            int besinciAtis = zar.Next(1, 21);

            float ortalama = (birinciAtis + ikinciAtis + ucuncuAtis) / 3f;

            if (ortalama > 15)
            {
                Console.WriteLine("Büyük zarar verdin!");
            }
            else if (ortalama > 10 && ortalama <= 15)//Hatalı!------10<ortalama<=15
            {
                Console.WriteLine("Orta zarar verdin!");
            }
            else if (ortalama > 5 && ortalama <= 10)
            {
                Console.WriteLine("Zarar yok!");
            }
            else if (ortalama<=5 && ortalama>2)
            {
                Console.WriteLine("Kendine zarar verdin!");
            }
            else
            {
                Console.WriteLine("2 den kucuk oldugunda çalışır.");
            }

            if (dorduncuAtis >= 20 || besinciAtis >= 2)
            {
                Console.WriteLine("Ek zarar verdin!");
            }

            if (ortalama >= 10)
            {
                Console.WriteLine("ortalama 10 un üzerinde");
                if (birinciAtis > 12)
                {
                    Console.WriteLine("Birinci atiş 12 nin üzerinde");
                    if (ikinciAtis > 15)
                    {
                        Console.WriteLine("Nested if örneği");//nested=iç içe
                    }
                    else if(ikinciAtis > 12)//üsteki if e girerse buna girmez.
                    {
                        Console.WriteLine("İkinci 12 nin üzerinde.");
                    }
                }
            }
            Console.WriteLine("İlk 3 sayının ortalaması: " + ortalama);
            Console.WriteLine(birinciAtis + " " + ikinciAtis + " " + ucuncuAtis + " " + dorduncuAtis + " " + besinciAtis);
            Console.WriteLine("///////////////////////////////////////////////////////////////////////");
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            string[] siparis_No = new string[3];//bunu üretebimek için new kullanıyoruz.

            siparis_No[0] = "Halime";
            siparis_No[1] = "Bayze";
            siparis_No[2] = "Çiçek";

            siparis_No[0] = "Beyza";

            Console.WriteLine(siparis_No[2]);
            //Console.WriteLine(siparis_No[3]); //Hata:System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'

            string[] siparis_No_1 = { "birinciSiparis", "ikinciSiparis", "ucuncuSiparis" };//Deklerasyon//otomatik olarak 3 elemanlı bir array olusturuldu.

            Console.WriteLine(siparis_No_1[2]);
            Console.WriteLine(siparis_No_1.Length);
            Console.WriteLine("///////////////////////////////////////////////////////////////////////");
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            foreach(string siparis in siparis_No_1)
            {
                Console.WriteLine(siparis); //3 kere dönecek.
            }

            int[] fiyat = { 250, 300, 700 };
            int toplamFiyat=0;
            int say = 0;

            foreach(var tekilFiyat in fiyat)
            {
                toplamFiyat += tekilFiyat;
                say++;
            }
            Console.WriteLine(toplamFiyat+" "+say);
            Console.WriteLine("///////////////////////////////////////////////////////////////////////");
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            int sayi = 5;
            string isim = "Halime Çiçek";

            Console.WriteLine("a" == "a");//Karşılaştıma yapıyor. Eşit ise true.
            Console.WriteLine("b" == "B");
            Console.WriteLine(1.2f == 1.3f);
            Console.WriteLine(1 != sayi);//eşit değilse

            Console.WriteLine(isim.Contains("lime"));

            Console.WriteLine(sayi == 6 ? "Halime" : "Zehra");//dogru ise halime yanlış ise zehra yazdırılacak.
            Console.WriteLine(sayi <= 6 ? 1 : 2);
            Console.WriteLine("///////////////////////////////////////////////////////////////////////");
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            int sayi_2 = 5;
            //int sayi_5;//HATA main içinde tanımladığım degişkeni bir sayiya eşitlemeliyim. 
            if (sayi_2 == 5)
            {
                int sayi_3 = 20;
                sayi_4 = 30;//main in üstünde tanımlı.
                Console.WriteLine(sayi_3);
            }
            //Console.WriteLine(sayi3);//HATA:Alt seviyede tanımladığımız değişkeni bu sekilde üst seviyede okutamayız
            Console.WriteLine(sayi_4);

            Console.ReadLine();
        }
    }
}
