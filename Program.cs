namespace CS_Code_Challenges;

class Program
{
    static void Main(string[] args)
    {
        // Challenge 1
        Challenge_one one = new Challenge_one();
        Console.WriteLine("\t\t\t\t\t\tChallenge 1:");
        Console.WriteLine("\t\tPrintNumbers:");
        one.PrintNumbers();
        Console.WriteLine("\n\t\tPrintString:");
        string[] arr = {"Hello", "Hi"};
        one.PrintStrings(arr);
        Console.WriteLine("\n\t\tCheckIfNumberIsPositiveOrNegative:");
        int number = -1;
        one.CheckIfNumberIsPositiveOrNegative(number);

        Console.WriteLine("\n");

        // Challenge 2
        Challenge_two two = new Challenge_two();
        Console.WriteLine("\t\t\t\t\t\tChallenge 2:");
        Console.WriteLine("\t\tGuessNumber:");
        two.GuessNumber();
        Console.WriteLine("\n\t\tFibonacci:");
        int number2 = 9;
        two.Fibonacci(number2);
        Console.WriteLine("\n\n\t\tCheckIfNumberIsEvenOrOdd:");
        double a = 3;
        double b = 8;
        two.CheckIfNumberIsEvenOrOdd(a, b);

        Console.WriteLine("\n");
        
        // Challenge 3
        Challenge_three three = new Challenge_three();
        Console.WriteLine("\t\t\t\t\t\tChallenge 3:");
        Console.WriteLine("\t\tFizzbuzz:");
        three.FizzBuzz();
        Console.WriteLine("\n\n\t\tRecursiveFactorial:");
        int number3 = 7;
        three.RecursiveFactorial(number3);
        Console.WriteLine(three.RecursiveFactorial(number3));
        Console.WriteLine("\n\t\tReverseString:");
        string str = "Hello World";
        string reversedStr = three.ReverseString(str);
        Console.WriteLine(reversedStr);

        Console.WriteLine("\n");
        // validate some methods
        void ValidateRecursiveFactorial()
        {
            int n = 5;
            int expected = 120; // 5! = 120
            int result = three.RecursiveFactorial(n);

            if (result == expected)
            {
                Console.WriteLine($"Test passed: RecursiveFactorial({n}) = {expected}");
            }
            else
            {
                Console.WriteLine($"Test failed: RecursiveFactorial({n}) = {result}, expected: {expected}");
            }
        }

        ValidateRecursiveFactorial();
    }
}
