using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class BookId
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> book = new Dictionary<int, string>();

            book.Add(1, "Sefiller");
            book.Add(2, "Kaşağı");
            book.Add(3, "Bird Box");
            book.Add(4, "Suç ve Ceza");
            book.Add(5, "1984");
            book.Add(6, "Başlangıç");

            foreach (var bookName in book)
            {
                Console.WriteLine(bookName.Key + " numaralı kitap: " + bookName.Value);
            }
        }
    }
}
