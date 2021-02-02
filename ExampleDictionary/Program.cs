using System;
using System.Collections.Generic;

namespace ExampleDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> openWith =
                new Dictionary<string, string>();

            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            try
            {
                openWith.Add("txt", "winword.exe");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("An element with Key = \"txt\" already exists.");
            }

            Console.WriteLine("For key = \"rtf\", value = {0}.",
                openWith["rtf"]);

            openWith["rtf"] = "winword.exe";
            Console.WriteLine("For key = \"rtf\", value = {0}.",
                openWith["rtf"]);


            openWith["doc"] = "winword.exe";


            try
            {
                Console.WriteLine("For key = \"tif\", value = {0}.",
                    openWith["tif"]);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Key = \"tif\" is not found.");
            }


            string value = "";
            if (openWith.TryGetValue("tif", out value))
            {
                Console.WriteLine("For key = \"tif\", value = {0}.", value);
            }
            else
            {
                Console.WriteLine("Key = \"tif\" is not found.");
            }


            if (!openWith.ContainsKey("ht"))
            {
                openWith.Add("ht", "hypertrm.exe");
                Console.WriteLine("Value added for key = \"ht\": {0}",
                    openWith["ht"]);
            }

 
            Console.WriteLine();
            foreach (KeyValuePair<string, string> kvp in openWith)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    kvp.Key, kvp.Value);
            }

            Dictionary<string, string>.ValueCollection valueColl =
                openWith.Values;

            Console.WriteLine();
            foreach (string s in valueColl)
            {
                Console.WriteLine("Value = {0}", s);
            }

            Dictionary<string, string>.KeyCollection keyColl =
                openWith.Keys;

            // The elements of the KeyCollection are strongly typed
            // with the type that was specified for dictionary keys.
            Console.WriteLine();
            foreach (string s in keyColl)
            {
                Console.WriteLine("Key = {0}", s);
            }

            // Use the Remove method to remove a key/value pair.
            Console.WriteLine("\nRemove(\"doc\")");
            openWith.Remove("doc");

            if (!openWith.ContainsKey("doc"))
            {
                Console.WriteLine("Key \"doc\" is not found.");
            }

            /* This code example produces the following output:

            An element with Key = "txt" already exists.
            For key = "rtf", value = wordpad.exe.
            For key = "rtf", value = winword.exe.
            Key = "tif" is not found.
            Key = "tif" is not found.
            Value added for key = "ht": hypertrm.exe

            Key = txt, Value = notepad.exe
            Key = bmp, Value = paint.exe
            Key = dib, Value = paint.exe
            Key = rtf, Value = winword.exe
            Key = doc, Value = winword.exe
            Key = ht, Value = hypertrm.exe

            Value = notepad.exe
            Value = paint.exe
            Value = paint.exe
            Value = winword.exe
            Value = winword.exe
            Value = hypertrm.exe

            Key = txt
            Key = bmp
            Key = dib
            Key = rtf
            Key = doc
            Key = ht

            Remove("doc")
            Key "doc" is not found.
            */
        }
    }
}
