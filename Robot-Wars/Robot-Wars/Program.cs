using System;

namespace Robot_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            // display title text
            Console.WriteLine("Robot Wars");
            
            // prompt for input
            Console.WriteLine("\nEnter input:");

            // instantiate NavigationBoard object
            var nb = new NavigationBoard();

            // read upper-right coordinates of arena
            nb.ReadUpperRightCoordinates(Console.ReadLine());
            
            // read robot one position input
            nb.ReadPositionInputRobotOne(Console.ReadLine());

            // read robot one movement input
            nb.ReadMovementInputRobotOne(Console.ReadLine());

            // read robot two position input
            nb.ReadPositionInputRobotTwo(Console.ReadLine());

            // read robot two movement input
            nb.ReadMovementInputRobotTwo(Console.ReadLine());

            // print output
            Console.WriteLine("\nOutput:");
            Console.WriteLine(nb.robotOne.X + " " + nb.robotOne.Y + " " + nb.robotOne.Orientation);
            Console.WriteLine(nb.robotTwo.X + " " + nb.robotTwo.Y + " " + nb.robotTwo.Orientation);
        }
    }
}
