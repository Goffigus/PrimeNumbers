using System;
using static System.Console;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = true; 

            for(int i = 2; i < 100_000; i++)
            {

                for(int x = 2; x < i; x++) //loop that looks to see if there are any factors
                {
                    if(i%x == 0)
                    {
                        isPrime = false;
                        x = i;//exits loop once number is proven not to be prime
                    }
                }

                if(isPrime) //only print if number did not fail tests
                {
                    WriteLine(i);
                }
                isPrime = true;

            }
            
        }
    }
}
