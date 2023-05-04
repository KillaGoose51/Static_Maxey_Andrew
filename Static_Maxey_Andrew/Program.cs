using System;

namespace Static_Maxey_Andrew
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input two numbers");
            int firstinput = Convert.ToInt32(Console.ReadLine());
            int secinput = Convert.ToInt32(Console.ReadLine());
            //Integers
            Console.WriteLine($"The results when adding is");
            Console.WriteLine(Calculate.Add(firstinput, secinput));
            Console.WriteLine($"The results when subtracting is");
            Console.WriteLine(Calculate.Sub(firstinput, secinput));
            Console.WriteLine($"The results when multiplying is");
            Console.WriteLine(Calculate.Mult(firstinput, secinput));
            Console.WriteLine($"The results when dividing is");
            Console.WriteLine(Calculate.Div(firstinput, secinput));

            Console.WriteLine("Please input two numbers with decimals");
            float firstinputf = (float)Convert.ToDouble(Console.ReadLine());
            float secinputf = (float)Convert.ToDouble(Console.ReadLine());
            //Floats
            Console.WriteLine($"The float when adding is");
            Console.WriteLine(Calculate.Add(firstinputf, secinputf));
            Console.WriteLine($"The float when subtracting is");
            Console.WriteLine(Calculate.Sub(firstinputf, secinputf));
            Console.WriteLine($"The float when multiplying is");
            Console.WriteLine(Calculate.Mult(firstinputf, secinputf));
            Console.WriteLine($"The float when dividing is");
            Console.WriteLine(Calculate.Div(firstinputf, secinputf));
        }
    }
}
