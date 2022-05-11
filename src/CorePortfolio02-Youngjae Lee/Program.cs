/*
    Purpose: Write 2 programs, one of which is the Coin Toss Simulator and the other being Slot Machine Simulator. Coin Toss Simulator will generate the number of (user-input) times of 
             coin flips and display how many heads and tails were resulted. The Slot Machine Simulator is a gambling device that the user inserts money into and then pulls a lever (or presses a
             button). The slot machine then displays a set of random images. If two or more of the images matches, the user wins an amount of money that the slot machine dispenses back to the user.
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------  
    Input: NumberOfTosses (int) for the Coin Toss Simulator, depositAmount (int) and userChoice (char) for the Slot Machine Simulator
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
    Process: Write two methods, one named Coin_Toss_Simulator() and the other named Slot_Machine_Simulator().
             For both of the methods, set the return value to Void since it does not have to return anything.

             ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
             For the Coin_Toss_Simulator method, display a notion that this is a Coin Toss Simulator by using Console.WriteLine() method. 
             Then, ask the user for the input using the same method and store it in an int variable named NumberOfTosses using Console.ReadLine() method.
             Create 2 int variables, one of which will count the number of heads, the other which will count the number of tails. Name them NumberOfHeads and NumberOfTails respectively.
             Create an instance of Class "Random" which will be used later.
             
             Create a for loop that will repeat (NumberOfTosses) times and inside the loop, create a local variable named "result" that will generate randomness and store the value.
             Do this by using random.next() method.
             
             Create 1 if statement and else statement within the for loop that will work for the case when the result is head (0) or tail (1)
             
             The if statement will be the case for the head(0) and will display a message "Toss (tossNumber): Heads". After, it will increment Number_of_Heads by 1.
             
             The else statement will be the case for the tail(1) and will display a message "Toss (tossNumber): Tails". After it will increment Number_of_Tails by 1.

             Once the for loop ends, write two messages that will show the Number_of_Heads and Number_of_Tails by using Console.Writeline() method.

             ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
             For the Slot_Machine_Simulator method, display a notion that this is a Slot Machine Simulator by using Console.WriteLine() method.
             This method will use a do-while loop so initially set a bool variable named "stop" equal to False. Also, create a double variable named "TotalAmount" and "TotalAmountWon" to   
             accumulate the total amount deposited and the total amount won respectively. Also, create an instance of Class "Random" which will be used later.
             
             Create a do-while loop that repeats while stop != true. For the do block, ask the user for the input for the amount to deposit and store it in an int variable named "depositAmount".
             Also create a counter for 6 possible results named "Cherries, Oranges, Plums, Bells, Melons, Bars" and set them to 0 initially.
             Then create a for loop that repeats 3 times. Inside the for loop, create a local variable named "result" that will generate randomness and store the value. 
             Do this by using random.next() method. After generating the randomness, write a switch statement that will represent each case. 
             Each switch statement will display the name of the fruit and increment its counter by 1. Do this by using Console.Write() method and ++ operator.

             after for loop is finished, write if statements for the case counter of each fruit are equal to 2 or 3. Also, write an else statement for no match.
             
             if it is equal to 2, display a message the user has won twice the amount of
             "depositAmount" and add the amount won in the global variable "TotalAmountWon". 
             
             If it is equal to 3, display a message the user has won third the amount of "depositAmount" and add the amount won in the global variable "TotalAmountWon"
             
             Else, display a message "No match. Good luck next time!".
             
             After writing 12 possible if statements and 1 else statement, add the value of local variable "depositAmount" to the global variable "TotalAmount".
             
             Create a local bool variable name stop2 that is initially false

             Create a while loop that operates while stop2 is false 

             Then, in the while loop ask the user for the choice to stop playing by displaying a message and store the user input in the "userChoice" variable. 

             if the value of "userChoice" is equal to "y", break the loop.
             
             if the value of "userChoice" is equal to "n", set the global variable "stop" to false and break the loop.
           
             Else, display a message "invalid input".
             
             after the do-while loop ends, display 3 messages that each of them represents the total amount deposit, total amount won, and net gain/loss total respectively.
             
             
             ---------------------------------------------------------------------------------------------------------------------------------------------------------------
              
              Create a method named "start". Inside the method, create a bool variable named "quit" and set it to false. 

              Then, create a while loop that operates while the bool variable is equal to false.

              In the while loop, display the menu option by assigning a number from 1 to 3. Create a local int variable named userInput and store the user input in it using 
              Console.Readline() method. 

              Write 3 if statements for each menu option and 1 else statement for invalid input.
              
              1 if statement will process Coin_Toss_Simulator() method
              
              1 if statement will process Slot_Machine_Simulator method
              
              1 if statement will set the "quit" variable to true and display a message "Good-bye"
              
              else statement will display a message "Invalid input. Please try again."

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    
    Output for the coin toss simulator:  ("Toss [TossNumber]: Heads") x [the user-input] times in a line
                                          "Number of Heads: [NumberOfHeads]"
                                          "Number of Tails: [NumberOfTails]"
    
    Output for the slot machine simulator:

    Case 1: [fruit1][fruit2][fruit3]
            "No match. Good luck next time!"
    
    Case 2: [fruit1][fruit1][fruit2]
            "Two [fruit1] match you won $[depositAmount * 2]"

    Case 3: [fruit1][fruit1][fruit1]
             "Three [fruit1] match you won $[depositAmount * 3]"

 -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            
    Test Plan for the coin toss simulator:
    
    Test case 1: 10 tosses
    Test data: NumberOfTosses (int) = 10
    Expected result: "Toss [TossNumber]: Heads") x [10] times in a line
                     "Number of Heads: [NumberOfHeads]"
                     "Number of Tails: [NumberOfTails]"

    Test Plan for the slot machine simulator:
    
    Test case 1: 1000 dollars
    Test data: depositAmount (int) = 1000

    Expected result 1: [fruit1][fruit2][fruit3]
                       "No match. Good luck next time!"
    
    Expected result 2: [fruit1][fruit1][fruit2]
                       "Two [fruit1] match you won $[2000]"

    Expected result 3: [fruit1][fruit1][fruit1]
                       "Three [fruit1] match you won $[3000]"

    * if the user inputs 'n' after
    
    Expected result 1: "Total amount deposited: $[1000]"
                       "Total amount won: $[0]"
                       "Net gain/loss total: $[1000]"
    
    Expected result 2: "Total amount deposited: $[1000]"
                       "Total amount won: $[2000]"
                       "Net gain/loss total: $[1000]"
    
    Expected result 3: "Total amount deposited: $[1000]"
                       "Total amount won: $[3000]"
                       "Net gain/loss total: $[2000]"
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    Author: Youngjae Lee

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    Last modified date: 2021 Feb 23
*/


using System;

namespace CorePortfolio02_Youngjae_Lee
{
    class Program
    {
        
        //coin toss simulator method
        static void Coin_Toss_Simulator()
        {   
            //telling the user this is a coin toss simulator
            Console.WriteLine("-----------------------");
            Console.WriteLine("| Coin Toss Simulator |");
            Console.WriteLine("-----------------------");
            Console.WriteLine("This program simulates tossing a coin multiple times.");

            //asking the user how many tosses the user wants to make
            Console.Write("How many tosses:");

            //storing the user input
            int NumberOfTosses = int.Parse(Console.ReadLine());

            //setting heads and tails counter
            int NumberOfHeads = 0;
            int NumberOfTails = 0;

            //instantiating random class
            Random rand = new Random();

            //declaring the for loop
            for(int tossNumber = 1; tossNumber <= NumberOfTosses; tossNumber++)
            {
                //generating a randomness
                int result = rand.Next(0, 2);

                //if it is head
                if(result == 0)
                {
                    //output
                    Console.WriteLine($"Toss {tossNumber}: Heads");

                    //incrementing heads counter
                    NumberOfHeads++;
                }
                
                //if it is tail
                else
                {
                    //output
                    Console.WriteLine($"Toss {tossNumber}: Tails");

                    //incrementing tails counter
                    NumberOfTails++;
                }
            }

            //summarizing the number of heads and tails in total
            Console.WriteLine($"Number of Heads: {NumberOfHeads}");
            Console.WriteLine($"Number of Tails: {NumberOfTails}");

        }
        
        //slot machine simulator method
        static void Slot_Machine_Simulator()
        {
            //telling the user that this is a slot maching simulator
            Console.WriteLine("--------------------------");
            Console.WriteLine("| Slot Machine Simulator |");
            Console.WriteLine("--------------------------");
            Console.WriteLine("This program simulates a slot machine.");

            //declaring a stop variable to false
            bool stop = false;

            //declaring accumulators
            double TotalAmount = 0;
            double TotalAmountWon = 0;

            //instantiating a random class
            Random rand = new Random();

            //declaring a do while loop
            do
            {
                //asking the user an amount to deposit
                Console.Write("Enter the amount to deposit into the slot machine:");

                //storing the user-input
                int depositAmount = int.Parse(Console.ReadLine());

                //declaring counters
                int cherries = 0;
                int oranges = 0;
                int plums = 0;
                int bells = 0;
                int melons = 0;
                int bars = 0;
                
                //declaring the for loop
                for(int count =1; count <=3; count++)
                {
                    //generating a randomness
                    int result = rand.Next(0, 6);

                    //declaring a switch statement
                    switch (result)
                    {
                        //if it is cherry
                        case 0:

                            //writing cherry
                            Console.Write("Cherries");

                            //incrementing its counter
                            cherries++;
                            break;

                        //if it is orange
                        case 1:

                            //writing orange
                            Console.Write("Oranges");

                            //incrementing its counter
                            oranges++;
                            break;

                        //if it is plum
                        case 2:

                            //writing plum
                            Console.Write("Plums");

                            //incrementing its counter
                            plums++;
                            break;

                        //if it is bell
                        case 3:

                            //writing bell
                            Console.Write("Bells");

                            //incrementing its counter
                            bells++;
                            break;

                        //if it is melon
                        case 4:

                            //writing melon
                            Console.Write("Melons");

                            //incrementing its counter
                            melons++;
                            break;

                        //if it is bar
                        case 5:

                            //writing bar
                            Console.Write("Bars");

                            //incrementing its counter
                            bars++;
                            break;
                    }

                    //for the last for loop no space is needed.
                    if(count == 3)
                    {
                        //move to next line
                        Console.WriteLine();
                        break;
                    }
                    //adding space
                    Console.Write(" ");

                }

                //if two cherries match
                if(cherries == 2)
                {
                    //output
                    Console.WriteLine($"Two cherries match you won ${depositAmount * 2}");

                    //recording total amount won
                    TotalAmountWon += (depositAmount * 2);
                }

                //if three cherries match
                else if (cherries == 3)
                {
                    //output
                    Console.WriteLine($"Three cherries match you won ${depositAmount * 3}");

                    //recording total amount won
                    TotalAmountWon += (depositAmount * 3);
                }

                //if two oranges match
                else if (oranges == 2)
                {
                    //output
                    Console.WriteLine($"Two oranges match you won ${depositAmount * 2}");

                    //recording total amount won
                    TotalAmountWon += (depositAmount * 2);
                }

                //if three oranges match
                else if (oranges == 3)
                {
                    //output
                    Console.WriteLine($"Three oranges match you won ${depositAmount * 3}");

                    //recording total amount won
                    TotalAmountWon += (depositAmount * 3);
                }

                //if two plums match
                else if (plums == 2)
                {
                    //output
                    Console.WriteLine($"Two plums match you won ${depositAmount * 2}");

                    //recording total amount won
                    TotalAmountWon += (depositAmount * 2);
                }

                //if three plums match
                else if (plums == 3)
                {
                    //output
                    Console.WriteLine($"Three plums match you won ${depositAmount * 3}");

                    //recording total amount won
                    TotalAmountWon += (depositAmount * 3);
                }

                //if two bells match
                else if (bells == 2)
                {
                    //output
                    Console.WriteLine($"Two bells match you won ${depositAmount * 2}");

                    //recording total amount won
                    TotalAmountWon += (depositAmount * 2);
                }

                //if three bells match
                else if (bells == 3)
                {
                    //output
                    Console.WriteLine($"Three bells match you won ${depositAmount * 3}");

                    //recording total amount won
                    TotalAmountWon += (depositAmount * 3);
                }

                //if two melons match
                else if (melons == 2)
                {
                    //output
                    Console.WriteLine($"Two melons match you won ${depositAmount * 2}");

                    //recording total amount won
                    TotalAmountWon += (depositAmount * 2);
                }

                //if three melons match
                else if (melons == 3)
                {
                    //output
                    Console.WriteLine($"Three melons match you won ${depositAmount * 3}");

                    //recording total amount won
                    TotalAmountWon += (depositAmount * 3);
                }

                //if two bars match
                else if (bars == 2)
                {
                    //output
                    Console.WriteLine($"Two bars match you won ${depositAmount * 2}");

                    //recording total amount won
                    TotalAmountWon += (depositAmount * 2);
                }

                //if three bars match
                else if (bars == 3)
                {
                    //output
                    Console.WriteLine($"Three bars match you won ${depositAmount * 3}");

                    //recording total amount won
                    TotalAmountWon += (depositAmount * 3);
                }

                //if no fruit match
                else
                {
                    //output
                    Console.WriteLine("No match. Good luck next time!");
                }
                
                //adding the deposit amount to the total amount
                TotalAmount += depositAmount;

                //setting the stop2 variable to false
                bool stop2 = false;

                //declaring the while loop
                while(stop2 != true)
                {
                    //asking if the user wants to play again
                    Console.Write("Do you want to play again? (y/n):");

                    //storing the user-input
                    char userChoice = char.Parse(Console.ReadLine());

                    //if the user wants to play again
                    if(userChoice == 'y')
                    {
                        break;
                    }

                    //if the user wants to quit
                    else if(userChoice == 'n')
                    {
                        stop = true;
                        break;
                    }

                    //handing invalid input
                    else
                    {
                        Console.WriteLine("Invalid input. Please try again.");
                    }
                }


            } while (stop != true);

            //summarizing the Total Amount, Total Amount Won, and net gain/loss total
            Console.WriteLine($"Total amount deposited: ${TotalAmount}");
            Console.WriteLine($"Total amount won: ${TotalAmountWon}");
            Console.WriteLine($"Net gain/loss total: ${Math.Abs(TotalAmountWon - TotalAmount)}");


        }

        //start method
        static void start()
        {

            //setting Quit variable to false
            bool Quit = false;

            //declaring the while loop
            while (Quit != true)
            {
                //displaying the menu option
                Console.WriteLine("|-------------------------------------|");
                Console.WriteLine("| Simulator Program Menu              |");
                Console.WriteLine("|-------------------------------------|");
                Console.WriteLine("| 1. Run Coin Toss Simulator          |");
                Console.WriteLine("| 2. Run Slot Machine Simulator       |");
                Console.WriteLine("| 3. Quit Program                     |");
                Console.WriteLine("|-------------------------------------|");

                //storing the user-input
                int userInput = int.Parse(Console.ReadLine());

                //if the user wants to play the coin toss simulator
                if (userInput == 1)
                {
                    //calling the coin toss simulator method
                    Coin_Toss_Simulator();
                }

                //if the user wants to play the slot maching simulator
                else if (userInput == 2)
                {
                    //calling the slot machine simulator method
                    Slot_Machine_Simulator();
                }

                //if the user wants to quit
                else if (userInput == 3)
                {
                    //saying good-bye
                    Console.WriteLine("Good-bye");

                    //setting Quit to true
                    Quit = true;
                }

                //handing an invalid input
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
        }
        static void Main(string[] args)
        {
            start();
        }
    }
}
