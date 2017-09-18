using System;
using System.Collections.Generic;
using System.Text;

namespace JankyWizModule1Review.Classes
{
    public class Rooms
    {
        public void PrintInputLine()
        {
            
            Console.WriteLine("[V]: View room description | [X]: eXit the game");
        }



        private string desc;
        public string Desc
        {
            get { return this.desc; }
            set { this.desc = value; }
        }

        private string command;

        public string Command
        {
            get { return command; }
            set { this.command = value; }
        }

        public void PrintCommand()
        {
            Console.WriteLine(this.command);
        }


        private string success;

        public string Success
        {
            get { return this.success; }
            set { this.success = value; }
        }


        public void PrintDesc()
        {
            Console.WriteLine(this.desc);
        }








    }
}
