public class Challenge_two
{
    public void GuessNumber()
    {
        int? secret = 12; // Assign the secret value
        int? guess = 0;
        while (guess != secret)
        {
            Console.WriteLine("Guess the secret number: ");
            guess = int.Parse(Console.ReadLine()!);
            // Todo: Implement the correct conditionals inside the while loop.
            if (guess != secret)
            {
                Console.WriteLine($"\"{guess}\" is not the secret number");
            }
            else 
            {
                Console.WriteLine($"You got it! \"{guess}\" was the secret number");
            }
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
        for (int i = 0; i < n; i++)
        {
        	c = a + b;
            Console.Write($"{c} ");
            a = b;
            b = c;
        }
    }

    public void CheckIfNumberIsEvenOrOdd(double a, double b)
    {
        // Todo: Check if a number is even or odd
        // if the number is even, write out "even"
        // if the number is odd, write out "odd"

        // a % 2 == 0 -> if there is nothing left after dividing a by 2, then it's even
        // b % 2 != 0 -> if there is something left after dividing b by 2, then it's odd
        if(a % 2 == 0 && b % 2 != 0)
        {
            //a is even & b is odd
            Console.WriteLine("a is even & b is odd");
        }
        else if(a % 2 != 0 && b % 2 == 0)
        {
            //a is odd & b is even
            Console.WriteLine("a is odd & b is even");
        }
        else if(a % 2 == 0 && b % 2 == 0)
        {
            // a and b are even
            Console.WriteLine("a & b are both even");
        }
        else{
            Console.WriteLine("a & b are both odd");
        }
        Console.WriteLine("");
    }
}