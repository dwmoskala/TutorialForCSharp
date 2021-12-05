using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson34
{
    class Program
    {
        static int dailyPrize;
        static readonly int initialMoney = 30;
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
                        Console.WriteLine($"Welcome in game Lotto!");
                        Console.WriteLine($"\nToday's prize: {dailyPrize} $.");
                        Console.WriteLine($"Account balance: {currentMoney} $.");
                     
                        ShowTicket(ticket);

                        if (currentMoney >= ticketCost && allTickets < maxTickets)
                        {
                            Console.WriteLine($"\n1 - Bet a ticket for {ticketCost} $ [{allTickets + 1}/{maxTickets} available tickets]");
                        }

                        Console.WriteLine("2 - Check tickets and start draw");
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
                        int moneyWon = CheckTicket(ticket);

                        if (moneyWon > 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"\nCongratulations, you won {moneyWon}!");
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
                        if (counter < 6)
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
            int minValue = 1;
            int maxValue = 49;

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

                Console.Write($"\n\nChoose a number from {minValue} to {maxValue} [{i + 1}/{allNumbers.Length}]: ");
                bool correctValue = int.TryParse(Console.ReadLine(), out number);
               
                if (correctValue && number >= minValue && number <= maxValue && !allNumbers.Contains(number))
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

        private static int CheckTicket(List<int[]> ticket)
        {
            throw new NotImplementedException();
        }
    }
}
