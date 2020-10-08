//Copyright (C) Kit Houle 2020, all rights reserved.

using System;

namespace BrandNewAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            mapLocations newlocation = new mapLocations();
            mapLocations.initialize();
            

            
            //Program Start
            Console.WriteLine("Hello! Welcome to the Land of Crysalis.\n Tell me, adventurer, what is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(userName + "?");
            Console.WriteLine("\nWhat a silly name! It sounds made up.");

            //Game Start
            Console.WriteLine("\nAnyways, let's start your Adventure in the Land of Crysalis!" +
                                "\n------------------------------------------------------------");
            
            Console.Write("\nSo, " + userName + ". ");
            //Question 1
            Console.WriteLine(locationList[0]);

            //Question 1 answer
            //bool gameOver = false;
            
            string answer1 = (Console.ReadLine());
            //while (!gameOver)
        {
            {
            //
            switch (answer1)
                {
                case "a":
                    Console.WriteLine("Oh no! The Ogre squashed you! Better luck next time.");
                    //gameOver = true;
                    for (int i = 0; i < 50; i++)
                    {
                        Console.ReadLine();
                    }
                    Console.ReadLine();
                    break;
    //Add in GAmeOver here to close program.
                case "b":
                    Console.WriteLine("Good Choice! The Ogre is happy and continues on his way.");
                    break;
                default:
                    Console.WriteLine("Sorry, I didn't catch that. Please try again.");
    //jump to repeating the question again somehow to try again
                    break;
                }
            }
        }
            //Question 2
            Console.WriteLine(locationList[1]);
            string answer2 = Console.ReadLine();
            //Question 2 answer
            if (answer2 == "a")
                {
                Console.WriteLine(optionList[0]);
                    //Question 3
                    Console.WriteLine(locationList[2]);
                    string answer3 = Console.ReadLine();
                    //Question 3 answer
                    switch (answer3)
                        {
                        case "y":
                            Console.WriteLine(optionList[2]);
                            Console.WriteLine("\nThankyou, " + userName + "! I'm so glad you came to help!");
                            Console.ReadLine();
                            Console.WriteLine(locationList[4]);
                            string answer5 = Console.ReadLine();
                            if (answer5 == "a")
                            {
                            Console.WriteLine(optionList[4]);
                            }
                                else
                                    {
                                    Console.WriteLine(locationList[9]);
                                    }
//Console.WriteLine() the new option!
                            break;
                        case "n":
                            Console.WriteLine(optionList[3]);
                                //Question 4
                                    Console.WriteLine(locationList[3]);
                                    string answer4 = Console.ReadLine();
                                    //Question 4 answer
                                    bool gameOver = false;
                                    while (!gameOver)
                                    switch (answer4)
                                    {
                                        default:
                                            Console.WriteLine(locationList[9]);
                                            gameOver = true;
                                            break;
                                    }
                                    break;
                }
                }
                else
                    {
                    Console.WriteLine(optionList[1]);
                    Console.WriteLine(locationList[9]);
                    }
            
            


    //Might be stuck here.. how can I continue the proper locations without inputting a writeLine for it each time? And to not refer to all of them?
            
            //for (int i = 3; i > 4; i++)
            //{
            //    Console.WriteLine(locationList[i +1]);
            //}
        //thought the for loop was working but makes it harder when not following linear locationList and stuff







            //Waiting for end key from user to wait before closing
            Console.ReadKey();
           
                

        }
    }
}
