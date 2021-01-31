using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Kurs 1";
            string kurs2 = "Kurs 2 ";
            string kurs3 = "Kurs 3";

            //array - dizi

            string[] kurslar = new string[] {
                "merhaba","nasılsın","derse giriş","kodlama yapıyoruz"};

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu \n- footer ");
                

            
        }
    }
}
