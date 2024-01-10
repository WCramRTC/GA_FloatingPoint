namespace GA_FloatingPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exploring C# Double and Floating-Point Operations");

            // Understanding double
            Console.WriteLine("\n--- Understanding double ---");
            double myDouble = 123.456;
            Console.WriteLine($"Value of myDouble: {myDouble}");

            // Basic Floating-Point Operations
            Console.WriteLine("\n--- Basic Floating-Point Operations ---");
            double sum = 5.6 + 3.2; // Addition
            Console.WriteLine($"5.6 + 3.2 = {sum}");

            double difference = 10.5 - 4.3; // Subtraction
            Console.WriteLine($"10.5 - 4.3 = {difference}");

            double product = 2.5 * 3.0; // Multiplication
            Console.WriteLine($"2.5 * 3.0 = {product}");

            double quotient = 12.6 / 2.0; // Division
            Console.WriteLine($"12.6 / 2.0 = {quotient}");

            // Math Operations with int and double
            Console.WriteLine("\n--- Math Operations with int and double ---");
            int wholeNumber = 10;
            double floatingNumber = 5.5;
            double mixedSum = wholeNumber + floatingNumber; // Mixing int and double
            Console.WriteLine($"10 (int) + 5.5 (double) = {mixedSum}");

            // Complex Floating-Point Operations
            Console.WriteLine("\n--- Complex Floating-Point Operations ---");
            double complexOperation1 = (wholeNumber / 2.0) + 3.0 * floatingNumber;
            Console.WriteLine($"Complex Operation 1: (10 / 2.0) + 3.0 * 5.5 = {complexOperation1}");

            double complexOperation2 = 5.0 * (floatingNumber - 1.0) / 2.0;
            Console.WriteLine($"Complex Operation 2: 5.0 * (5.5 - 1.0) / 2.0 = {complexOperation2}");

            // Handling Floating-Point Precision
            Console.WriteLine("\n--- Handling Floating-Point Precision ---");
            double a = 0.1;
            double b = 0.2;
            double preciseSum = a + b;
            Console.WriteLine($"0.1 + 0.2 (Expected: 0.3, Actual: {preciseSum})");

            // Testing and Validation
            Console.WriteLine("\n--- Testing and Validation ---");
            // Here you can add calls to functions or additional code to validate the operations

            Console.WriteLine("Tutorial Complete!");
        } // main

    } // class

} // namespace
