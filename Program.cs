using System;

namespace C_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //byte number = 2;
            //int count = 10;
            //float totalPrice = 20.95f; 
            //char character = 'A';
            //string firstName = "Jeff";
            //bool isWorking = true;

            var number = 2;
            var count = 10;
            var totalPrice = 20.95f; 
            var character = 'A';
            var firstName = "Jeff";
            var isWorking = true;

            Console.WriteLine(number);
            System.Console.WriteLine(count);
            System.Console.WriteLine(totalPrice);
            System.Console.WriteLine(character);
            System.Console.WriteLine(firstName);
            System.Console.WriteLine(isWorking);
            
            System.Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);

            System.Console.WriteLine("{0} {1}", float.MaxValue, float.MinValue);

            const float Pi = 3.14f;
            
            System.Console.WriteLine(Pi);

            //Type conversion
            //casting
            int i = 1;
            byte x = (byte)i;

            
        }
    }
}
