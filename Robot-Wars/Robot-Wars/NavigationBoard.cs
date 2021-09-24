using System.Collections.Generic;

namespace Robot_Wars
{
    public class NavigationBoard
    {
        public int maxRight { get; set; }
        public int maxTop { get; set; }
        public Robot robotOne { get; set; } = new Robot();
        public Robot robotTwo { get; set; } = new Robot();

        public void ReadUpperRightCoordinates(string coordinateString)
        {
            var coordList = new List<string>();
            foreach (var coord in coordinateString.Split(" "))
                coordList.Add(coord);
            maxRight = int.Parse(coordList[0]);
            maxTop = int.Parse(coordList[1]);
        }

        public void ReadPositionInputRobotOne(string robotOneInput)
        {
            var inputList = new List<string>();
            foreach (var value in robotOneInput.Split(" "))
                inputList.Add(value);
            robotOne.X = int.Parse(inputList[0]);
            robotOne.Y = int.Parse(inputList[1]);
            robotOne.Orientation = inputList[2];
        }

        public void ReadPositionInputRobotTwo(string robotTwoInput)
        {
            var inputList = new List<string>();
            foreach (var value in robotTwoInput.Split(" "))
                inputList.Add(value);
            robotTwo.X = int.Parse(inputList[0]);
            robotTwo.Y = int.Parse(inputList[1]);
            robotTwo.Orientation = inputList[2];
        }

        public void ReadMovementInputRobotOne(string robotOneInput)
        {
            var inputList = new List<string>();

            if (robotOneInput.Length == 1)
                inputList.Add(robotOneInput);
            else
            {
                var charArray = robotOneInput.ToCharArray();
                foreach (var value in charArray)
                    inputList.Add(value.ToString());
            }
            
            foreach (var command in inputList)
            {
                if (command.Equals("L"))
                {
                    if (robotOne.Orientation == "N")
                        robotOne.Orientation = "W";
                    else if (robotOne.Orientation == "E")
                        robotOne.Orientation = "N";
                    else if (robotOne.Orientation == "S")
                        robotOne.Orientation = "E";
                    else if (robotOne.Orientation == "W")
                        robotOne.Orientation = "S";
                }
                else if (command.Equals("R"))
                {
                    if (robotOne.Orientation == "N")
                        robotOne.Orientation = "E";
                    else if (robotOne.Orientation == "E")
                        robotOne.Orientation = "S";
                    else if (robotOne.Orientation == "S")
                        robotOne.Orientation = "W";
                    else if (robotOne.Orientation == "W")
                        robotOne.Orientation = "N";
                }
                else if (command.Equals("M"))
                {
                    if (robotOne.Orientation == "N")
                    {
                        robotOne.Y++;
                        if (robotOne.Y > maxTop ||
                            (robotOne.X == robotTwo.X && robotOne.Y == robotTwo.Y))
                            robotOne.Y--;
                    }
                    else if (robotOne.Orientation == "E")
                    {
                        robotOne.X++;
                        if (robotOne.X > maxRight ||
                            (robotOne.X == robotTwo.X && robotOne.Y == robotTwo.Y))
                            robotOne.X--;
                    }
                    else if (robotOne.Orientation == "S")
                    {
                        robotOne.Y--;
                        if (robotOne.Y < 0 ||
                            (robotOne.X == robotTwo.X && robotOne.Y == robotTwo.Y))
                            robotOne.Y++;
                    }
                    else if (robotOne.Orientation == "W")
                    {
                        robotOne.X--;
                        if (robotOne.X < 0 ||
                            (robotOne.X == robotTwo.X && robotOne.Y == robotTwo.Y))
                            robotOne.X++;
                    }
                }
            }
        }

        public void ReadMovementInputRobotTwo(string robotTwoInput)
        {
            var inputList = new List<string>();

            if (robotTwoInput.Length == 1)
                inputList.Add(robotTwoInput);
            else
            {
                var charArray = robotTwoInput.ToCharArray();
                foreach (var value in charArray)
                    inputList.Add(value.ToString());
            }

            foreach (var command in inputList)
            {
                if (command.Equals("L"))
                {
                    if (robotTwo.Orientation == "N")
                        robotTwo.Orientation = "W";
                    else if (robotTwo.Orientation == "E")
                        robotTwo.Orientation = "N";
                    else if (robotTwo.Orientation == "S")
                        robotTwo.Orientation = "E";
                    else if (robotTwo.Orientation == "W")
                        robotTwo.Orientation = "S";
                }
                else if (command.Equals("R"))
                {
                    if (robotTwo.Orientation == "N")
                        robotTwo.Orientation = "E";
                    else if (robotTwo.Orientation == "E")
                        robotTwo.Orientation = "S";
                    else if (robotTwo.Orientation == "S")
                        robotTwo.Orientation = "W";
                    else if (robotTwo.Orientation == "W")
                        robotTwo.Orientation = "N";
                }
                else if (command.Equals("M"))
                {
                    if (robotTwo.Orientation == "N")
                    {
                        robotTwo.Y++;
                        if (robotTwo.Y > maxTop ||
                            (robotTwo.X == robotOne.X && robotTwo.Y == robotOne.Y))
                            robotTwo.Y--;
                    }
                    else if (robotTwo.Orientation == "E")
                    {
                        robotTwo.X++;
                        if (robotTwo.X > maxRight ||
                            (robotTwo.X == robotOne.X && robotTwo.Y == robotOne.Y))
                            robotTwo.X--;
                    }
                    else if (robotTwo.Orientation == "S")
                    {
                        robotTwo.Y--;
                        if (robotTwo.Y < 0 ||
                            (robotTwo.X == robotOne.X && robotTwo.Y == robotOne.Y))
                            robotTwo.Y++;
                    }
                    else if (robotTwo.Orientation == "W")
                    {
                        robotTwo.X--;
                        if (robotTwo.X < 0 ||
                            (robotTwo.X == robotOne.X && robotTwo.Y == robotOne.Y))
                            robotTwo.X++;
                    }
                }
            }
        }        
    }
}
