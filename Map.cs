//Copyright (C) Kit Houle 2020, all rights reserved.

using System;

namespace BrandNewAdventure
{
    class locations
    {
//Changed appearance of Console
            Console.Title = "Adventure";
            Console.ForegroundColor = ConsoleColor.Cyan;

                //List of location descriptions
            string[,] locationList = new string [10,10];
            //Question 1 (answers in below code for this one)
//won't generate a map?????
                locationList[0,0] = "\nYou begin your journey. It's a beautiful day outside," +
                                    "\nthe sun is warm on your face as you travel down a dirt road." +
                                    "\n\nAn Ogre jumps in your path! He looks upset and angry." +
                                    "\n\"I am hungry!\" he bellows." +
                                    "\nDo you [a] fight him or [b] give him some food?";
                //Question 2
                locationList[0,1] = "\nAs you continue down the path, you notice that the sky is turning darker." +
                                    "\nWhat do you do?" + 
                                    "\n[a] Look for cover in case it rains, or [b] continue walking";

                //Question 3 - if you chose Q2a
                locationList[0,2] = "\nAs you stand there under the trees wondering how long you'll have to wait," + 
                                    "\nyou see a stranger in the distance. Their carriage is stuck in the road." +
                                    "\nDo you help them? [y/n]";

                //Question 4 - if you chose Q2b
                locationList[0,3] = "\nYou are uninterrupted as you continue into town." + 
                                    "\nYou pass into the city gates just as it starts to rain." + 
                                    "\nThis city is a covered fortress," +
                                    "\nso you can hear the rain pattering against the wooden ceiling that encases the entire place.";
                //Question 5 (extention of Q3y)
                locationList[0,4] = "\n\n\"Yes, yes. Well, I'd best be on my way now! Thanks again!\""+
                                "\nThe person gives you a mysterious item, and leaves you in silence." +
                                "\n What would you like to do?" +
                                "\n[a] go to town and find a stone inspector"+
                                "\n[b] go to town and rest";

            //Ending
                locationList[9] = "\nYou find the inn and book a room for yourself."+
                                    "\nYou arrive in the room, and it's a very charming spot. It feels like a comforting wood cabin."+
                                    "\nIt's so comforting that you decide to go sleep."+
                                    "\n\nWhen you awake, you see surroundings you recognize. Your irl bedroom."+
                                    "\nGuess this was all a dream. \n\n END.";
    //Add in a gameover here and kick user out. mmmm not sure how.. since it's at the top of the code.. Just make it the ending I guess
//______________________________________________________________________________________________________________________________
                //Q2 option a
                optionList[0] = "\nYou ran for cover! I bet you feel silly now, since the clouds are still rolling in." +
                                "\nYou would've had lots of time to get to the next town!";
                                
                //Q2 option b
                optionList[1] = "\nFair choice. The rain won't start for a little while anyways."; 
                //Q3 yes
                optionList[2] = "\nYou rush over, helping lift the carriage wheel out of the divot in the road.";
                //Q3 no
                optionList[3] = "\nSure. don't help. Afterall, the rain might start soon... *you hear stifled laughter*";
                //Q5 a
                optionList[4] = "\nYou arrive in town, "+locationList[3]+
                                "\n\nYou find an appraiser for the mysterious stone."+
                                "\n\"Hmmmm yes. This stone is a form of Ogre currency. Just enough to pay for a room at the inn.\n\n"+
                                locationList[9];
                

    }
}