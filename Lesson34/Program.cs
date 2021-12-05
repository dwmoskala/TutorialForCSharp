using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson34
{
    class Program
    {
        static int dailyPrize;
        static readonly int initialMoney = 30;
        static readonly int minValueToChoose = 1;
        static readonly int maxValueToChoose = 49;
        static readonly int multiplierForThreeHits = 24;
        static readonly int multiplierForFourHits = 200;
        static readonly int multiplierForFiveHits = 7000;
        static readonly Random random = new Random();

        static void Main()
        {
            int currentMoney;

            do
            {
                currentMoney = initialMoney;
                ConsoleKey choose;

                do
                {
                    dailyPrize = random.Next(1, 51) * 1000000;
                    int ticketCost = 3;
                    int maxTickets = 5;
                    int allTickets = 0;
                    List<int[]> ticket = new List<int[]>();

                    do
                    {
                        Console.Clear();
                        Console.WriteLine($"Welcome in lottery game!");
                        Console.WriteLine($"\nToday's prize: {dailyPrize} $.");
                        Console.WriteLine($"Your account balance: {currentMoney} $.");
                     
                        ShowTicket(ticket);

                        if (currentMoney >= ticketCost && allTickets < maxTickets)
                        {
                            Console.WriteLine($"\n1 - Bet a ticket for {ticketCost} $ [{allTickets}/{maxTickets}]");
                        }
                        if (allTickets == maxTickets)
                        {
                            Console.WriteLine();
                        }
                        Console.WriteLine("2 - Check tickets and start lottery");
                        Console.WriteLine("3 - Finish the game with your current money");
                        choose = Console.ReadKey().Key;
                        
                        if (choose == ConsoleKey.D1 && currentMoney  >= ticketCost && allTickets < maxTickets)
                        {
                            ticket.Add(BetTicket());
                            currentMoney -= ticketCost;
                            allTickets++;
                        }

                    } while (choose == ConsoleKey.D1);

                    Console.Clear();

                    if (ticket.Count > 0)
                    {
                        int moneyWon = Check(ticket);

                        if (moneyWon > 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"\nCongratulations, you won {moneyWon} $!");
                            Console.ResetColor();
                            currentMoney += moneyWon;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"\nToo bad, you did not win anything!");
                            Console.ResetColor();
                        }
                    }
                    else
                    {
                        Console.WriteLine("You did not bet any tickets in current draw.");
                    }
                    Console.Write("Press any key...");
                    Console.ReadKey();

                } while (currentMoney >= 0 && choose != ConsoleKey.D3);

                Console.Clear();
                Console.WriteLine($"Game over. Your score: {currentMoney - initialMoney} $.");
                Console.Write("\nPress ENTER to start new game. Press different key to exit game.");

            } while (Console.ReadKey().Key == ConsoleKey.Enter);
        }

        private static void ShowTicket(List<int[]> ticket)
        {
            if (ticket.Count == 0)
            {
                Console.WriteLine("\nYou did not bet anything yet.");
            }
            else
            {
                int i = 0;

                Console.WriteLine("\nYour tickets: ");
                foreach (int[] singleTicket in ticket)
                {
                    i++;
                    int counter = 1;

                    Console.Write($"Ticket {i}: ");
                    foreach (int number in singleTicket)
                    {
                        if (counter < singleTicket.Length)
                        {
                            Console.Write(number + ", ");
                        }
                        else
                        {
                            Console.Write(number);
                        }

                        counter++;
                    }

                    Console.WriteLine();
                }
            }
        }

        private static int[] BetTicket()
        {
            int[] allNumbers = new int[6];
            int number = -1;

            for (int i = 0; i < allNumbers.Length; i++)
            {
                number = -1;
                Console.Clear();
                Console.Write("Already bet numbers: ");        
                foreach (int item in allNumbers)
                {
                    if (item > 0)
                    {
                        Console.Write(item + ", ");
                    }
                }

                Console.Write($"\n\nChoose a number from {minValueToChoose} to {maxValueToChoose} [{i + 1}/{allNumbers.Length}]: ");
                bool correctValue = int.TryParse(Console.ReadLine(), out number);
               
                if (correctValue && number >= minValueToChoose && number <= maxValueToChoose && !allNumbers.Contains(number))
                {
                    allNumbers[i] = number;
                }
                else
                {
                    Console.Write("\nYou enter wrong number!");
                    i--;
                    Console.ReadKey();
                }
            }

            Array.Sort(allNumbers);

            return allNumbers;
        }

        private static int Check(List<int[]> ticket)
        {
            int prize = 0;
            int[] allNumbers = new int[6];
            int counter = 1;

            for (int i = 0; i < allNumbers.Length; i++)
            {
                int number = random.Next(minValueToChoose, maxValueToChoose + 1);

                if (!allNumbers.Contains(number))
                {
                    allNumbers[i] = number;
                }
                else
                {
                    i--;
                }
            }

            Array.Sort(allNumbers);

            Console.Write("Lotto numbers: ");
            foreach (int number in allNumbers)
            {
                if (counter < allNumbers.Length)
                {
                    Console.Write(number + ", ");
                }
                else
                {
                    Console.Write(number);
                }
                counter++;
            }

            int[] hitNumbers = CheckTicket(ticket, allNumbers);
            int prizeValuePerHit;

            if (hitNumbers[0] > 0)
            {
                prizeValuePerHit = hitNumbers[0] * multiplierForThreeHits;
                Console.WriteLine($"Prize for 3 hits: {prizeValuePerHit} $.");
                prize += prizeValuePerHit;
            }
            if (hitNumbers[1] > 0)
            {
                prizeValuePerHit = hitNumbers[1] * multiplierForFourHits;
                Console.WriteLine($"Prize for 4 hits: {prizeValuePerHit} $.");
                prize += prizeValuePerHit;
            }
            if (hitNumbers[2] > 0)
            {
                prizeValuePerHit = hitNumbers[2] * multiplierForFiveHits;
                Console.WriteLine($"Prize for 5 hits: {prizeValuePerHit} $.");
                prize += prizeValuePerHit;
            }
            if (hitNumbers[3] > 0)
            {
                prizeValuePerHit = (hitNumbers[3] * dailyPrize) /  (hitNumbers[3] + random.Next(0, 6));
                Console.WriteLine($"Prize for 6 hits: {prizeValuePerHit} $.");
                prize += prizeValuePerHit;
            }

            return prize;
        }

        private static int[] CheckTicket(List<int[]> ticket, int[] allNumbers)
        {
            int[] winNumbers = new int[4];
            int i = 0;
            Console.WriteLine("\n\nYour tickets:");
            foreach (int[] singleTicket in ticket)
            {
                int hits = 0;

                i++;
                Console.Write($"Ticket {i}: ");
                foreach (int number in singleTicket)
                {
                    if (allNumbers.Contains(number))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(number);
                        Console.ResetColor();
                        Console.Write(", ");
                        hits++;
                    }
                    else
                    {
                        Console.Write(number + ", ");
                    }
                }

                switch (hits)
                {
                    case 3:
                        winNumbers[0]++;
                        break;

                    case 4:
                        winNumbers[1]++;
                        break;

                    case 5:
                        winNumbers[2]++;
                        break;

                    case 6:
                        winNumbers[3]++;
                        break;
                }

                Console.WriteLine($"[Hits: {hits}/{allNumbers.Length}]");
            }

            return winNumbers;
        }
    }
}
