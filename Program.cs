using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // ErişimBelirteci, GeriDönüşTipi, MetotAdı (ParametreListesi/Argüman)
            // {
                // Komutlar
                // return;(Geri dönüş olacaksa)

            // }

            int a = 2;
            int b = 3;
            int toplam = a+b;
            int sonuc = carp(a,b);
            Console.WriteLine(sonuc);
            Console.WriteLine(toplam);

            metotlar ornek = new metotlar();
            ornek.ekranaYaz(Convert.ToString(toplam));
            int sonuc2 = ornek.arttırveCarp(a,b);
            ornek.ekranaYaz(Convert.ToString(sonuc2));
            ornek.ekranaYaz(Convert.ToString(a+b));
            int sonuc3 = ornek.arttırCarp(ref a, ref b); 
            ornek.ekranaYaz(Convert.ToString(sonuc3));
            ornek.ekranaYaz(Convert.ToString(a+b));
            // ref kullanılan değerleri kalıcı olarak değiştirir.


        }
        static int carp(int x, int y)
        {
            return (x * y);
        }
    }
    class metotlar
    {
        public void ekranaYaz(string veri)
        {
            Console.WriteLine(veri);
        }
        public int arttırveCarp(int deger1, int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return (deger1 * deger2);
        }
        public int arttırCarp(ref int deger3, ref int deger4)
        {
            deger3 += 1;
            deger4 += 1;
            return (deger3 * deger4);
        }
    }
}
