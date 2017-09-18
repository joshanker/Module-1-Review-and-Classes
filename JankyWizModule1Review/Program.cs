using System;
using System.Collections.Generic;
using System.Text;
using JankyWizModule1Review.Classes;

namespace JankyWizModule1Review
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You stand before Castle Jankerstein, ready to enter!");
            Console.WriteLine("Press [C] to continue into the tired trope of a castle or [R] to run away");

            string input = Console.ReadLine().ToUpper();
            InputChoice enteredChoice = new InputChoice();
            string currentRoom;


            ///////////////////////////////////////////////////////////////////////////
            string entryRoomResponse = enteredChoice.EntryRoomChoice(input.ToUpper());
            while ((entryRoomResponse != "enterthecastle") && (entryRoomResponse != "exit"))
            {
                input = Console.ReadLine().ToUpper();
                entryRoomResponse = enteredChoice.EntryRoomChoice(input.ToUpper());
            }

            if (entryRoomResponse == "exit")
            {
                Environment.Exit(0);
            }
            Console.WriteLine();
            Console.WriteLine("You push open the creaky door and enter the castle.");

            //invoke the next room
            currentRoom = "Foyer";
            Rooms Foyer = new Rooms();
            Foyer.Desc = "There's a toolbag on the ground.  You should [P]ick it up.";
            Console.WriteLine(Foyer.Desc);
            Foyer.Command = "[P]ick up the toolbag.";
            Foyer.PrintInputLine();
            Console.WriteLine(Foyer.Command);


            string foyerInput = Console.ReadLine().ToUpper();

            foyerInput = enteredChoice.FoyerInput(foyerInput);
            while ((foyerInput != "pickupthebag") && (foyerInput != "exit") && (foyerInput != "c"))
            {
                if (foyerInput == "V")
                {
                    Foyer.PrintDesc();
                    Foyer.PrintInputLine();
                }

                foyerInput = Console.ReadLine().ToUpper();
                foyerInput = enteredChoice.FoyerInput(foyerInput.ToUpper());
            }

            if (foyerInput == "exit")
            {
                Environment.Exit(0);
            }



            Console.WriteLine();
            Console.WriteLine("You've got a lot of tools in here!  They will help you beat this castle.  \nThey are:");
            Console.WriteLine();

            List<String> tools = new List<string>() {"For Loops", "While Loops", "Arrays", "Stacks", "Queues", "Lists", "Dictionaries", "Hash Sets", "Classes", "Objects", "Inheritance", "Interfaces", "A 'Using' statement",
                "Getters", "Setters", "Properties", "Methods","Overrides","Virtual","Abstract", "Method Signatures", "Access Modifiers", "Return Types", "Parameters/Arguments", "Data Types of string, char, int, bool, double",       };


            for (int i = 1; i < tools.Count; i = i + 2)
            {
                Console.Write(tools[i-1].PadRight(25));
                Console.WriteLine(tools[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Press [R] when you're [R]eady to move on to the first challenge!");
            string readyornot = Console.ReadLine();

            while (readyornot != "R")
            {
                Console.WriteLine("look, it's either hit [R] for [R]eady or press ctrl+c to exit, so \nyou may as well keep going...");
                readyornot = Console.ReadLine();
            }




            Console.WriteLine();
            Console.WriteLine("end of main.");
            Environment.Exit(0);









        }
    }
}
