using System;

namespace Methodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string urunAdi2 = "Çilek";
            double fiyati2 = 10;
            string acikalama2 = "Çilek gibi çilek";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //type-safe-- tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------------------");
            }

            Console.WriteLine("---------Methodlar----------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut ","Yeşil armut " , 12, 10)
            sepetManager.Ekle2("Elma ","Yeşil elma ", 5, 9)
            sepetManager.Ekle2("Karpuz ","Diyarbakır Karpuzu ", 20, 5)


            Console.WriteLine(urunAdi + ": " + fiyati +" "  + aciklama);


        }
    }
}


//Don't repeat yourself - DRY - Clean Code