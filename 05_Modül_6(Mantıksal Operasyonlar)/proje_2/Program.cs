using System;
using oyun_ve_uygulama_akadami_05_1.Topla; //yeni namesapce yi çağırmamız gerekiyor.//kütüphaneyi çağırdık.

namespace oyun_ve_uygulama_akadami_05_1
{
    class Program
    {
        static void Main(string[] args)//bu bir metot
        {
            int sayi = 0;
            int sayi_1 = 0;
            sayi = Toplam(50);
            sayi_1 = Toplama.Toplam_1(50); //buradan erişmek için toplam_1 yı public yaptık aşağıda.
            //sayi += b;HATA:çünkü b toplam fonksiyonunun değişkeni.
            Console.WriteLine(sayi);
            Console.WriteLine(sayi_1);
            Console.WriteLine("///////////////////////////////////////////////////////////////");
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            int golSayisi = 0;
            string takimSeviyesi = "";
            Random g_sayi = new Random();
            golSayisi=g_sayi.Next(0, 6);//6 dahil değil.

            switch (golSayisi)
            {
                case 1:
                    takimSeviyesi = "OK";
                    break;
                case 2:
                    takimSeviyesi = "Güzel";
                    break;
                case 3:
                    takimSeviyesi = "Yüksek";
                    break;
                case 4:
                    takimSeviyesi = "Muhtesem";
                    break;
                case 5:
                    takimSeviyesi = "WOW";
                    break;
                default:
                    takimSeviyesi = "Kotu";
                    break;
            }
            Console.WriteLine(takimSeviyesi);
            Console.WriteLine("///////////////////////////////////////////////////////////////");
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            string[] siparisNo =
            {
                "Halime",
                "Beyza",
                "Çiçek"
            };
            for (int i = siparisNo.Length; i > 0 ; i--)//i >= 0 dersek uyarı veriyor çünkü -1 i aramaya çalışıyor.
            {
                Console.WriteLine(siparisNo[i - 1]);//array 0 dan başladığı için.
            }
            Console.WriteLine("///////////////////////////////////////////////////////////////");
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            int sayi_3 = 0;
            int sayi_4 = 0;
            do//bir kere kesinlikle çalışıyor.
            {
                sayi_3++;
                if (sayi_3 == 7) continue;//7 olunca bulunduğu yerden sonraki kodları es geçmiş olacak.yani 6 ya kadar yazılacak çünkü sonsuz döngü olacak sayi_3 içeride artamıyor..
                Console.WriteLine(sayi_3);//9 a kadar yazılacak sayilar.(break ve contunie olmayınca)
                //sayi_3++; //continu olunca sonsuz döngü olmaması için bunu yukaru yazıyoruz.
                //break;//sadece 0 yazılacak.

            } while (sayi_3 < 10);//10 dan kucuk oldugu surece calıstır.

            while(sayi_4 < 10)//yukardaki ile aynı sonucu veriyor.
            {
                sayi_4++;
                if (sayi_4 == 7) continue;
                Console.WriteLine(sayi_4);
            }

            Console.ReadLine();
        }
        static int Toplam(int a)//bu bir metot//Ben bu toplam fonksiyonunu başka class lar içinde de kullanmak istiyorum o zaman namesapce yazacağım.
        {
            int b = 10;//Toplam fonksiyonun lokal değişkeni.
            return a + b;
        }
    }
}

namespace oyun_ve_uygulama_akadami_05_1.Topla//namesapacenin adı Topla//Bunu artık istediğim herhangi bir yerden çağırabilirim.
{
    class Toplama
    {
        public static int Toplam_1(int a)//bu bir metot//Ben bu toplam fonksiyonunu başka class lar içinde de kullanmak istiyorum o zaman namesapce yazacağım.
        {
            int b = 5;//Toplam fonksiyonun lokal değişkeni.
            return a + b;
        }
    }
}
