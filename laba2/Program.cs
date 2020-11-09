using System;
using System.IO;

namespace laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);


            double a, b, c, d, s, k;

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            d = Convert.ToDouble(Console.ReadLine());

            
            s = (1 / Math.Sqrt(b - a)) + (2 / Math.Sqrt(c - b) + 3 / Math.Sqrt(d - c));

            k = Math.Sqrt(a - Math.Sqrt(b - Math.Sqrt(c)));


            if (s >= 0) Console.WriteLine(Math.Round(s, 2));
            else Console.WriteLine("ERROR");

            if (k >= 0) Console.WriteLine(Math.Round(k, 2));
            else Console.WriteLine("ERROR");


            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();

        }
    }
}
