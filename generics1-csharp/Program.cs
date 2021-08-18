using System;

namespace course
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> printServiceInt = new PrintService<int>();
            PrintService<string> printServiceString = new PrintService<string>();

            Console.Write("How many values? (int) ");
            int n = int.Parse(Console.ReadLine());

            for(int i=0; i<n; i++) {
                int x = int.Parse(Console.ReadLine());
                printServiceInt.AddValue(x);
            }

            printServiceInt.print();
            Console.WriteLine("First " + printServiceInt.first());

            Console.WriteLine("===============================");

            Console.Write("How many values? (string) ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                string s = Console.ReadLine();
                printServiceString.AddValue(s);
            }

            printServiceString.print();
            Console.WriteLine("First " + printServiceString.first());


        }
    }
}
