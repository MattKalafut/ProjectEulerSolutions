namespace Problem_001;

/// <summary>
/// https://projecteuler.net/problem=1
/// Problem:
/// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
/// Find the sum of all the multiples of 3 or 5 below 1000
///
/// Answer: 233168
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        var sum = 0;

        for (var i = 0; i < 1000; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum += i;
            }
        }
        Console.WriteLine(sum);
    }
}