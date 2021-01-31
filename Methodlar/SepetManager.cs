using System;
using System.Collections.Generic;
using System.Text;

namespace Methodlar
{
    class SepetManager
    {
        //naming convention
        //syntax

        public void Ekle(Urun urun) 
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi! " + " " + "Eklenen Ürün : "+ urun.Adi);
        }


        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi! " + " " + "Eklenen Ürün : " + urunAdi);
        }
    }
}
