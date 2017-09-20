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
        Point point = new Point();
        Human human = new Human(180, 81);

        Console.WriteLine(human.Height);
        human.Height = 181;
        Console.WriteLine(human.Height);

        Console.WriteLine(human.Weight);
        human.Weight = 81;
        Console.WriteLine(human.Weight);

        point.x = 5;
        point.y = 3;

        Console.WriteLine(point.x);
        Console.WriteLine(point.y);
        Console.ReadLine();

    }

}

