using System;


namespace HelloWorld
{
    public class Progrma1
    {

        public static void Main(string[] args)
        {
            double a = 20;
            double b = 10;

            Math math = new Math();
            double addResult = math.Add(a, b);
            double sustractResult = math.Substract(a, b);

            Console.WriteLine(addResult.ToString());

            Console.WriteLine(sustractResult.ToString());

        }
    }
}
