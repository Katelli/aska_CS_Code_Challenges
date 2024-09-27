namespace CS_Code_Challenges;

class Program
{
    static void Main(string[] args)
    {
        // Challenge 1
        Challenge_one one = new Challenge_one();
        Console.WriteLine("\t\t\t\tChallenge 1:");
        Console.WriteLine("Print numbers 1-10:");
        one.PrintNumbers();
        Console.WriteLine("\nPrint out each string that is sent:");
        string[] arr = {"Hello", "Hi"};
        one.PrintStrings(arr);
        Console.WriteLine("\nCheck if number is positive, negative or 0:");
        int number = -1;
        one.CheckIfNumberIsPositiveOrNegative(number);

        Console.WriteLine("\n");

        // Challenge 2
        Challenge_two two = new Challenge_two();
        Console.WriteLine("\t\t\t\tChallenge 2:");

        Console.WriteLine("\n");
        
        // Challenge 3
        Challenge_three three = new Challenge_three();
        Console.WriteLine("\t\t\t\tChallenge 3:");
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
