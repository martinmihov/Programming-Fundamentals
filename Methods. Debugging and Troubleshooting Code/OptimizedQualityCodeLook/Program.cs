namespace OptimizedQualityCodeLook
{
    using System; // using Console
    public class SpecificNameForTheProgram // All methods are declared in class
    {
        static int numbers = 100; // Under class and before the methods we can add variables that are valid for all methods below.
        public static void Main() // Methods are executed in Main Method ( c# )
        {
            PrintValues();
        }
        // BestPractice is to have maximum of 7 parameters in a method...
        public static void PrintValues() // In class we can add as many methods as we need;
        {
            Console.WriteLine("Hi!");
            Console.WriteLine("Hi again!");
        }
    }
}
