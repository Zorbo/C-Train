using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointsAndLines;
using CSharpLearn;

class EntryPoint
{

    static void Main(string[] args)
    {
        User user = new User("John Doe", Race.Earthling);               
        User secondUser = new User("Jane Doe", Race.Earthling);              

        User thirdUser = new User("Boby Magic", Race.Marsian);
        Console.WriteLine(user.ID);
        Console.WriteLine(secondUser.ID);
        Console.WriteLine(thirdUser.ID);
        Console.WriteLine(User.currentID);

        // Static class
        Utilities.ColorfullWriteline(user.UserName, ConsoleColor.Magenta);

        //Console is also a static class!
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(user.HEIGHT);
        Console.WriteLine(thirdUser.HEIGHT);
        Console.ForegroundColor = ConsoleColor.White;

        Human human = new Human(180, 81);

        Console.WriteLine(human.Height);
        // becouse Height method got a set
        human.Height = 181;
        Console.WriteLine(human.Height);

        Console.WriteLine(human.Weight);
        // becouse Weight method got a set
        human.Weight = 81;

        
        

        Console.WriteLine(human.Weight);
        Console.WriteLine(user.UserName);
        
        user.Password = "password";
        
        
        
        
        Console.ReadLine();

    }

}

