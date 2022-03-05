using System;

namespace Csharp_with_Microsoft
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello my friends");
            string aF1 = "ThanhSon";
            string aF2 = "KhacThinh";
            Console.WriteLine($"My friends are {aF1} and {aF2}");
            Console.WriteLine($"the name {aF1} has {aF1.Length} words");
            Console.WriteLine($"the name {aF2} has {aF2.Length} words");

            string whatisL = "    She is NGOC    ";
            Console.WriteLine($"[{whatisL}]");
            Console.WriteLine("Who is she");

            string greeting = "      Hello World!       ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");

            int groupone;
            groupone = 1;
            int grouptwo;
            grouptwo = groupone + 1;
            
            // int => long => float => double

            int a = 10;
            float b = 20.055f;
            int totalINT = (int)(a + b);
            System.Console.WriteLine(totalINT);
            float total = a + b;
            System.Console.WriteLine("số thực là " + total);

            int k = 3, n = 4;
            System.Console.WriteLine(1.0*k + n);
            int x = 1, y = 2;
            float divF = 1.0f*x / y;
            double divD = 1.0*x / y;
            System.Console.WriteLine(divF + " " + divD);

            y--;
            System.Console.WriteLine(y);
        }
    }
}
