public class Challenge_two
{
    public void GuessNumber()
    {
        int? secret = 0; // Assign the secret value
        int? guess = 0;
        while (guess != secret)
        {
            Console.WriteLine("Guess the secret number: ");
            guess = int.Parse(Console.ReadLine());
            // Todo: Implement the correct conditionals inside the while loop.
            break;
        }
    }

    public void Fibonacci(int n)
    {
        int a = 0, b = 1, c;
        Console.WriteLine($"{a} + {b} + ");
        // Todo: Write out the Fibonacci sequence, tips: use a for loop.
        // c = a + b;
        // a = b;
        // b = c;
    }

    public void CheckIfNumberIsEvenOrOdd(double a, double b)
    {
        // Todo: Check if a number is even or odd
        // if the number is even, write out "even"
        // if the number is odd, write out "odd"
        Console.WriteLine("");
    }
}