using System;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add2(5, 4);
            //Add2(20, 30);
            //var result = Add2(10);

            //int number1 = 20;
            //int number2 = 100;
            //var result2 = Add3(out number1, number2);
            //Console.WriteLine("Sonuç : "+result2);
            //Console.WriteLine("number1 :"+number1);

            Console.WriteLine(Multiply(2,8));
            Console.WriteLine(Multiply(2,4,5));

            Console.WriteLine(Add4(2,2,3,4,5,6));
            Console.ReadLine();
        }


        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int x, int number1 = 20 , int number2 = 30)
        {
            var result = number1 + number2 ;
            return result;

        }
        
        static int Add3(out int number1, int number2) 
        {
            number1 = 30;
            return number1 + number2;

        }

    
        static int Multiply(int number1 , int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        static int Add4(int number1 , int number2)
        {
            return number1 + number2;
        }

        static int Add4(int number1 , params int[] numbers)
        {
            number1 = 2;
            return numbers.Sum();
            return number1 * numbers.Sum();
        }


    }
}
