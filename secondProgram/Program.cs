using System;
using System.Linq;
using System.Collections.Generic;
namespace Lab2
{
    class secondProgram
    {
        static void Main()
        {
            string play = "y";
            do
            {
                string input = "0";
                List<int> mainList = new List<int>();
                List<int> oddList = new List<int>();
                List<int> evenList = new List<int>();
                while (input != "")
                {
                    Console.Write("Enter an integer:");
                    input = Console.ReadLine();
                    // Removing the if breaks the code
                    if (input != "")
                    {
                        // Main list
                        mainList.Add(int.Parse(input));

                        // Even list
                        if (int.Parse(input) % 2 == 0)
                        {
                            evenList.Add(int.Parse(input));
                        }
                        // Odd list
                        else
                        {
                            oddList.Add(int.Parse(input));
                        }
                    }
                }

                if (mainList.Count == 0)
                {
                    Console.WriteLine("You did not enter an integer.");
                }
                else
                {
                    // Maximum and minimum numbers
                    // From Main List
                    int max = -100000000;
                    int min = 100000000;
                    for (int i = 0; i < mainList.Count; i++)
                    {
                        if (mainList[i] > max)
                        {
                            max = mainList[i];
                        }
                        if (mainList[i] < min)
                        {
                            min = mainList[i];
                        }
                    }

                    // Even and Odd
                    // Odd
                    // Amount
                    int numOddList = oddList.Count;
                    // Total
                    int totalOddList = 0;
                    for (int i = 0; i < oddList.Count; i++)
                    {
                        totalOddList += oddList[i];
                    }
                    // Average
                    double averageOddList = 0;
                    if (oddList.Count != 0)
                    {
                        averageOddList = totalOddList / oddList.Count;
                    }

                    // Even
                    // Amount
                    int numEvenList = evenList.Count;
                    // Total
                    int totalEvenList = 0;
                    for (int i = 0; i < evenList.Count; i++)
                    {
                        totalEvenList += evenList[i];
                    }
                    // Average
                    double averageEvenList = 0;
                    if (evenList.Count != 0)
                    {
                        averageEvenList = totalEvenList / evenList.Count;
                    }

                    // Final Message
                    Console.WriteLine("\nThe maximum integer you entered is: " + max +
                    "\nThe minimum integer you entered is: " + min +

                    "\n\nThe number of odd integer(s) you entered is: " + numOddList +
                    "\nThe sum of all odd integer(s) you entered is: " + totalOddList +
                    "\nThe average of all odd integer(s) you entered is: " + averageOddList +

                    "\n\nThe number of even integer(s) you entered is: " + numEvenList +
                    "\nThe sum of all even integer(s) you entered is: " + totalEvenList +
                    "\nThe average of all even integer(s) you entered is: " + averageEvenList
                );

                }
                // Play again
                Console.Write("\nPlay again? (y)");
                play = Console.ReadLine();
            } while (play == "y" || play == "Y");

            // Exit
            Console.Write("\nThank you for play. Press any key to exit.");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
