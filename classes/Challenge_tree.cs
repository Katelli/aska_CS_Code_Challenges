/*
These are very difficult.
*/
public class Challenge_three
{
    public void FizzBuzz()
    {
        // Todo: Implement fizzbuzz, if a number is divisible by 3: Fizz, if a number is divisible by 5: Buzz, if the number is divisible by both 3 and 5, FizzBuzz
        // https://www.geeksforgeeks.org/fizz-buzz-implementation/
        int f = 20;
        for(int i = 1; i <= f; i++)
        {
            if(i % 3 == 0 & i % 5 == 0)
            {
                // Fizzbuzz
                Console.Write("Fizzbuzz ");
            }
            else if(i % 3 == 0)
            {
                // Fizz
                Console.Write("Fizz ");
            }
            else if(i % 5 == 0)
            {
                // Buzz
                Console.Write("Buzz ");
            }
            else
            {
                Console.Write($"{i} ");
            }
        }
    }

    public int RecursiveFactorial(int n)
    {
        // Todo: Implement a recursive method(a method that calls itself within its own function scope)
        // To Check the factorial of a number(norsk: Fakultet) we look at n!, where n = n * 1 * 2 * 3...
        if (n == 0)
        {
            return 1;
        }
        // n * Method(n - 1);
        return n * RecursiveFactorial(n - 1);
    }

    public string ReverseString(string str)
    {
        // Todo: reverse the given string
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}