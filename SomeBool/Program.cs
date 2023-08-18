using System;

namespace SomeBool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var someBool = new Boolean();
            bool result = someBool == true && someBool == false;
            Console.WriteLine(result);
        }
    }
}