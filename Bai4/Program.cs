using System;

namespace Bai4
{
    internal class Program
    {
        // trò chơi đoán số (Khôi-20it438- 20mc)
        static void Main(string[] args)
        {
            while (true)
            {
                int randno = Newnum(1, 101);
                int count = 1;
                while (true)
                {
                    Console.Write("Nhap 1 so trong khoang tu 1 đen 100:");
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input == 0)
                        return;
                    else if (input < randno)
                    {
                        Console.WriteLine("Thap, ban thu lai.");
                        ++count;
                        continue;
                    }
                    else if (input > randno)
                    {
                        Console.WriteLine("Cao, ban thu lai.");
                        ++count;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("You guessed it! The number was {0}!",
                                           randno);
                        Console.WriteLine("It took you {0} {1}.\n", count,
                                           count == 1 ? "try" : "tries");
                        break;
                    }
                }
            }

        }
        static int Newnum(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}

