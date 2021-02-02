using System;
using System.Collections;
using System.Collections.Generic;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> kitaplar = new List<string>();
            kitaplar.Add("Sefiller");
            kitaplar.Add("Kaşağı");
            kitaplar.Add("Bird Box");
            kitaplar.Add("Suç ve Ceza");
            kitaplar.Add("1984");

            MyList<string> yazarlar = new MyList<string>();
            yazarlar.Add("Victor Hugo");
            yazarlar.Add("Ömer Seyfettin");
            yazarlar.Add("Josh Malerman");
            yazarlar.Add("Victor Hugo");
            yazarlar.Add("George Orwell");

            foreach(var kitapAdi in kitaplar)
            {
                Console.WriteLine("Kitap Adı : " + kitapAdi); 
            }
          
            

        }

        class MyList<T>
        {
            T[] _array;
            T[] _tempArray;

            public MyList()
            {
                _array = new T[0];
            }
            public void Add(T item)
            {
                _tempArray = _array;
                _array = new T[_array.Length + 1];
                for (int i = 0; i < _tempArray.Length; i++)
                {
                    _array[i] = _tempArray[i];
                }

                _array[_array.Length - 1] = item;
            }
        }
    }
}

