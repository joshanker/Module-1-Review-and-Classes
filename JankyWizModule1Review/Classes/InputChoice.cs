using System;
using System.Collections.Generic;
using System.Text;

namespace JankyWizModule1Review.Classes
{
    public class InputChoice
    {
        //Console.WriteLine(enteredChoice.FoyerDesc);
        public void PrintInputLine()
        {
            
            Console.WriteLine("[V]: View room description | [X]: eXit the game.");
        }



        //////////////////////   EntryRoom  ///////////////////

        public string EntryRoomChoice(string entryChoice)
        {

            if (entryChoice == "C")
            {
                return "enterthecastle";
            }
            else if (entryChoice == "R")
            {
                Console.WriteLine("Okay, thanks for playing.");
                return "exit";
            }
            else
            {
                Console.WriteLine("Sorry, I don't understand that command.");
                Console.WriteLine("Please enter [C] to enter the Castle, or [R] to run away.");
                return entryChoice;
            }
        }




        ////////////////////  Foyer  ///////////////////// 
        public string FoyerInput(string entryChoice)
        {

            if (entryChoice == "P")
            {
                Console.WriteLine("You pick up the bag and look inside.");
                return "pickupthebag";
            }
            if (entryChoice == "X")
            {
                Console.WriteLine("Okay, thanks for playing.");
                return "exit";
            }
            if(entryChoice == "V")
            {
                return "V";
            }
            else
            {
                Console.WriteLine("Sorry, I don't understand that command.");
                Console.WriteLine("Press [V] to view room description.");
                return entryChoice;
            }
        }


















    }



}




