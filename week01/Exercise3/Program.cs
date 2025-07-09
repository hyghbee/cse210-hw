using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
            {
                Random randomGenerator = new Random();
                int magicNumber = randomGenerator.Next(1, 101); // 1 to 100

                int guess;

                do
                {
                    Console.Write("What is your guess? ");
                    guess = int.Parse(Console.ReadLine());

                    if (guess < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (guess > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine("You guessed it!");
                    }

                } while (guess != magicNumber);
            }
        }
    }