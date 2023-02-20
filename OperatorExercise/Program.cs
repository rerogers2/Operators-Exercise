namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Get two numbers from the user
            Console.Write("Give me a number: ");
            var a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Give me another number: ");
            var b = Convert.ToDouble(Console.ReadLine());
            // run operators on the two numbers
            operators(a, b);

            // find the area of a circle
            Console.WriteLine("\nThat was fun. Now, let's find the area of a circle.\n");
            Console.Write("Give me a radius: "); // I would need to check that a number was inputed instead of a character
            var r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Mmmm, numbers. The area of the circle with radius {r} units is {Math.Round(AreaOfCircle(r), 2)} square units.");
        }

        static void operators(double a, double b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}"); 
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} * {b} = {Math.Round(a * b,2)}");
            double quotient = a / b;
            double remainder = a % b;
            Console.WriteLine($"{a}/{b} is {Math.Round(quotient, 0)} remainder {Math.Round(remainder, 2)}");
            //Console.WriteLine($"{a} / {b} = {Math.Round(quotient, 2)}");
            //Console.WriteLine($"{a} % {b} = {Math.Round(remainder, 2)} <- this is the remainder.");
        }

        static double AreaOfCircle(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
    }
}
