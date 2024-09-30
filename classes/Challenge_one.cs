public class Challenge_one
{
    public void PrintNumbers()
    {
        // Todo: Print out the numbers 1 - 10
        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

    }

    public void PrintStrings(string[] arr)
    {
        /* Todo: Print out each string that is passed to the array as an argument*/
        foreach(string strings in arr)
        {
            Console.WriteLine(strings);
        }
    }

    public void CheckIfNumberIsPositiveOrNegative(int n)
    {
        /*
        Todo: Check if a number is positive, negative or zero.
        */
        if(n > 0)
        {
            Console.WriteLine($"Number ({n}) is positive");
        }
        else if (n < 0)
        {
            Console.WriteLine($"Number ({n}) is negative");
        }
        else if(n == 0)
        {
            Console.WriteLine($"Number ({n}) is zero");
        }
    }


}