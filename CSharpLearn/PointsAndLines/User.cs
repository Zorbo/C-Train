using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PointsAndLines
{

    class User
    {

        public Race race;

        public static int currentID;  
        public readonly int HEIGHT;

        public const int HEIGH = 50;  // constant REQUIE A VALUE LIKE FINAL IN JAVA

        // readonly = cannod be modify, its final and get the value in the constructor 
        public readonly int ID; //Like in Java: THE_NAME_OF_THE_CAT

        private string username;
        private string password;

        public User(string username, Race race)
        {
            this.username = username;
            currentID++;
            ID = currentID;
            this.race = race;


            if (this.race == Race.Marsian)
            {

                HEIGHT = 100;
            }
            else if(this.race == Race.Earthling)
            {
                HEIGHT = 180;
            }        
        }

    

        public string UserName
        {
            get { return "The user name is: " + username; }
            //ALWAYS USE VALUE KEYWORD ITS GIVE YOU BACK THE VALUE

           /* set
            {
                if (value.Length >= 3 && value.Length <= 20)
                {
                    username = value;
                }
                else
                {
                    Console.WriteLine("Ooops this is not a valid username! Please use username to 3-20 characters");
                    Console.ReadLine();
                }
            } */

        }


        public string Password
        {

            set
            {
                if (value.Equals("password"))
                {
                    password = value;
                    Console.WriteLine("Access granted!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Invaild password!");
                    Console.ReadLine();
                }
            }
        }

    }
}




