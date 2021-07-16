using System;

namespace newList
{
    class Program
    {
        static void Main(string[] args)
        {
            int someAnotherValue = 42;
            {
                int scopedValue = 5;
                Console.WriteLine($"{someAnotherValue} {scopedValue}");
            }
            {
                int scopedValue = 2;
                Console.WriteLine($"{someAnotherValue} {scopedValue}");
            }

            Console.WriteLine($"{someAnotherValue}");
            Console.WriteLine($"{scopedValue}");

        }
    }
}
