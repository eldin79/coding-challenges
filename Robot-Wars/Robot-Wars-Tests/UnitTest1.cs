using NUnit.Framework;
using Robot_Wars;

namespace Robot_Wars_Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void DefaultTest()
        {
            Assert.Pass();
        }

        [Test]
        public void NavigationBoardConstructorTest()
        {
            var nb = new NavigationBoard();
            Assert.IsInstanceOf<NavigationBoard>(nb);
        }

        [Test]
        public void NavigationBoardHasMaxRightCoordinateTest()
        {
            var nb = new NavigationBoard();
            Assert.IsInstanceOf<int>(nb.maxRight);
        }

        [Test]
        public void NavigationBoardHasMaxTopCoordinateTest()
        {
            var nb = new NavigationBoard();
            Assert.IsInstanceOf<int>(nb.maxTop);
        }

        [Test]
        public void ReadUpperRightCoordinatesTest()
        {
            var nb = new NavigationBoard();
            nb.ReadUpperRightCoordinates("5 5");
            Assert.AreEqual(5, nb.maxRight);
            Assert.AreEqual(5, nb.maxTop);
        }

        [Test]
        public void RobotConstructorTest()
        {
            var robot = new Robot();
            Assert.IsInstanceOf<Robot>(robot);
        }

        [Test]
        public void RobotHasXTest()
        {
            var robot = new Robot();
            Assert.IsInstanceOf<int>(robot.X);
        }

        [Test]
        public void RobotHasYTest()
        {
            var robot = new Robot();
            Assert.IsInstanceOf<int>(robot.Y);
        }

        [Test]
        public void RobotHasOrientationTest()
        {
            var robot = new Robot();
            Assert.IsInstanceOf<string>(robot.Orientation);
        }

        [Test]
        public void HasRobotOneTest()
        {
            var nb = new NavigationBoard();
            Assert.IsInstanceOf<Robot>(nb.robotOne);
        }

        [Test]
        public void HasRobotTwoTest()
        {
            var nb = new NavigationBoard();
            Assert.IsInstanceOf<Robot>(nb.robotTwo);
        }

        [Test]
        public void ReadRobotOnePositionInputTest()
        {
            var nb = new NavigationBoard();
            nb.ReadPositionInputRobotOne("1 2 N");
            Assert.AreEqual(1, nb.robotOne.X);
            Assert.AreEqual(2, nb.robotOne.Y);
            Assert.AreEqual("N", nb.robotOne.Orientation);
        }

        [Test]
        public void ReadRobotTwoPositionInputTest()
        {
            var nb = new NavigationBoard();
            nb.ReadPositionInputRobotTwo("3 3 E");
            Assert.AreEqual(3, nb.robotTwo.X);
            Assert.AreEqual(3, nb.robotTwo.Y);
            Assert.AreEqual("E", nb.robotTwo.Orientation);
        }

        // Robot One Turn Left
        
        [Test]
        public void RobotOneTurnLeftWhenFacingNorthTest()
        {
            var nb = new NavigationBoard();
            nb.robotOne.Orientation = "N";
            nb.ReadMovementInputRobotOne("L");
            Assert.AreEqual(0, nb.robotOne.X);
            Assert.AreEqual(0, nb.robotOne.Y);
            Assert.AreEqual("W", nb.robotOne.Orientation);
        }

        [Test]
        public void RobotOneTurnLeftWhenFacingEastTest()
        {
            var nb = new NavigationBoard();
            nb.robotOne.Orientation = "E";
            nb.ReadMovementInputRobotOne("L");
            Assert.AreEqual(0, nb.robotOne.X);
            Assert.AreEqual(0, nb.robotOne.Y);
            Assert.AreEqual("N", nb.robotOne.Orientation);
        }

        [Test]
        public void RobotOneTurnLeftWhenFacingWestTest()
        {
            var nb = new NavigationBoard();
            nb.robotOne.Orientation = "W";
            nb.ReadMovementInputRobotOne("L");
            Assert.AreEqual(0, nb.robotOne.X);
            Assert.AreEqual(0, nb.robotOne.Y);
            Assert.AreEqual("S", nb.robotOne.Orientation);
        }

        // Robot Two Turn Left

        [Test]
        public void RobotTwoTurnLeftWhenFacingNorthTest()
        {
            var nb = new NavigationBoard();
            nb.robotTwo.Orientation = "N";
            nb.ReadMovementInputRobotTwo("L");
            Assert.AreEqual(0, nb.robotTwo.X);
            Assert.AreEqual(0, nb.robotTwo.Y);
            Assert.AreEqual("W", nb.robotTwo.Orientation);
        }

        [Test]
        public void RobotTwoTurnLeftWhenFacingEastTest()
        {
            var nb = new NavigationBoard();
            nb.robotTwo.Orientation = "E";
            nb.ReadMovementInputRobotTwo("L");
            Assert.AreEqual(0, nb.robotTwo.X);
            Assert.AreEqual(0, nb.robotTwo.Y);
            Assert.AreEqual("N", nb.robotTwo.Orientation);
        }

        [Test]
        public void RobotTwoTurnLeftWhenFacingSouthTest()
        {
            var nb = new NavigationBoard();
            nb.robotTwo.Orientation = "S";
            nb.ReadMovementInputRobotTwo("L");
            Assert.AreEqual(0, nb.robotTwo.X);
            Assert.AreEqual(0, nb.robotTwo.Y);
            Assert.AreEqual("E", nb.robotTwo.Orientation);
        }

        [Test]
        public void RobotTwoTurnLeftWhenFacingWestTest()
        {
            var nb = new NavigationBoard();
            nb.robotTwo.Orientation = "W";
            nb.ReadMovementInputRobotTwo("L");
            Assert.AreEqual(0, nb.robotTwo.X);
            Assert.AreEqual(0, nb.robotTwo.Y);
            Assert.AreEqual("S", nb.robotTwo.Orientation);
        }

        // Robot One Turn Right

        [Test]
        public void RobotOneTurnRightWhenFacingNorthTest()
        {
            var nb = new NavigationBoard();
            nb.robotOne.Orientation = "N";
            nb.ReadMovementInputRobotOne("R");
            Assert.AreEqual(0, nb.robotOne.X);
            Assert.AreEqual(0, nb.robotOne.Y);
            Assert.AreEqual("E", nb.robotOne.Orientation);
        }

        [Test]
        public void RobotOneTurnRightWhenFacingEastTest()
        {
            var nb = new NavigationBoard();
            nb.robotOne.Orientation = "E";
            nb.ReadMovementInputRobotOne("R");
            Assert.AreEqual(0, nb.robotOne.X);
            Assert.AreEqual(0, nb.robotOne.Y);
            Assert.AreEqual("S", nb.robotOne.Orientation);
        }

        [Test]
        public void RobotOneTurnRightWhenFacingWestTest()
        {
            var nb = new NavigationBoard();
            nb.robotOne.Orientation = "W";
            nb.ReadMovementInputRobotOne("R");
            Assert.AreEqual(0, nb.robotOne.X);
            Assert.AreEqual(0, nb.robotOne.Y);
            Assert.AreEqual("N", nb.robotOne.Orientation);
        }

        // Robot Two Turn Right

        [Test]
        public void RobotTwoTurnRightWhenFacingNorthTest()
        {
            var nb = new NavigationBoard();
            nb.robotTwo.Orientation = "N";
            nb.ReadMovementInputRobotTwo("R");
            Assert.AreEqual(0, nb.robotTwo.X);
            Assert.AreEqual(0, nb.robotTwo.Y);
            Assert.AreEqual("E", nb.robotTwo.Orientation);
        }

        [Test]
        public void RobotTwoTurnRightWhenFacingEastTest()
        {
            var nb = new NavigationBoard();
            nb.robotTwo.Orientation = "E";
            nb.ReadMovementInputRobotTwo("R");
            Assert.AreEqual(0, nb.robotTwo.X);
            Assert.AreEqual(0, nb.robotTwo.Y);
            Assert.AreEqual("S", nb.robotTwo.Orientation);
        }

        [Test]
        public void RobotTwoTurnRightWhenFacingSouthTest()
        {
            var nb = new NavigationBoard();
            nb.robotTwo.Orientation = "S";
            nb.ReadMovementInputRobotTwo("R");
            Assert.AreEqual(0, nb.robotTwo.X);
            Assert.AreEqual(0, nb.robotTwo.Y);
            Assert.AreEqual("W", nb.robotTwo.Orientation);
        }

        [Test]
        public void RobotTwoTurnRightWhenFacingWestTest()
        {
            var nb = new NavigationBoard();
            nb.robotTwo.Orientation = "W";
            nb.ReadMovementInputRobotTwo("R");
            Assert.AreEqual(0, nb.robotTwo.X);
            Assert.AreEqual(0, nb.robotTwo.Y);
            Assert.AreEqual("N", nb.robotTwo.Orientation);
        }

        // Robot One Move

        [Test]
        public void RobotOneMoveWhenFacingNorthTest()
        {
            var nb = new NavigationBoard();
            nb.ReadUpperRightCoordinates("5 5");
            nb.robotOne.Orientation = "N";
            nb.ReadMovementInputRobotOne("M");
            Assert.AreEqual(0, nb.robotOne.X);
            Assert.AreEqual(1, nb.robotOne.Y);
            Assert.AreEqual("N", nb.robotOne.Orientation);
        }

        [Test]
        public void RobotOneMoveWhenFacingEastTest()
        {
            var nb = new NavigationBoard();
            nb.ReadUpperRightCoordinates("5 5");
            nb.robotOne.Orientation = "E";
            nb.ReadMovementInputRobotOne("M");
            Assert.AreEqual(1, nb.robotOne.X);
            Assert.AreEqual(0, nb.robotOne.Y);
            Assert.AreEqual("E", nb.robotOne.Orientation);
        }

        [Test]
        public void RobotOneMoveWhenFacingSouthTest()
        {
            var nb = new NavigationBoard();
            nb.ReadUpperRightCoordinates("5 5");
            nb.robotOne.X = 1;
            nb.robotOne.Y = 1;
            nb.robotOne.Orientation = "S";
            nb.ReadMovementInputRobotOne("M");
            Assert.AreEqual(1, nb.robotOne.X);
            Assert.AreEqual(0, nb.robotOne.Y);
            Assert.AreEqual("S", nb.robotOne.Orientation);
        }

        [Test]
        public void RobotOneMoveWhenFacingWestTest()
        {
            var nb = new NavigationBoard();
            nb.ReadUpperRightCoordinates("5 5");
            nb.robotOne.X = 1;
            nb.robotOne.Y = 1;
            nb.robotOne.Orientation = "W";
            nb.ReadMovementInputRobotOne("M");
            Assert.AreEqual(0, nb.robotOne.X);
            Assert.AreEqual(1, nb.robotOne.Y);
            Assert.AreEqual("W", nb.robotOne.Orientation);
        }

        // Robot Two Move

        [Test]
        public void RobotTwoMoveWhenFacingNorthTest()
        {
            var nb = new NavigationBoard();
            nb.ReadUpperRightCoordinates("5 5");
            nb.robotTwo.Orientation = "N";
            nb.ReadMovementInputRobotTwo("M");
            Assert.AreEqual(0, nb.robotTwo.X);
            Assert.AreEqual(1, nb.robotTwo.Y);
            Assert.AreEqual("N", nb.robotTwo.Orientation);
        }

        [Test]
        public void RobotTwoMoveWhenFacingEastTest()
        {
            var nb = new NavigationBoard();
            nb.ReadUpperRightCoordinates("5 5");
            nb.robotTwo.Orientation = "E";
            nb.ReadMovementInputRobotTwo("M");
            Assert.AreEqual(1, nb.robotTwo.X);
            Assert.AreEqual(0, nb.robotTwo.Y);
            Assert.AreEqual("E", nb.robotTwo.Orientation);
        }

        [Test]
        public void RobotTwoMoveWhenFacingSouthTest()
        {
            var nb = new NavigationBoard();
            nb.ReadUpperRightCoordinates("5 5");
            nb.robotTwo.X = 1;
            nb.robotTwo.Y = 1;
            nb.robotTwo.Orientation = "S";
            nb.ReadMovementInputRobotTwo("M");
            Assert.AreEqual(1, nb.robotTwo.X);
            Assert.AreEqual(0, nb.robotTwo.Y);
            Assert.AreEqual("S", nb.robotTwo.Orientation);
        }

        [Test]
        public void RobotTwoMoveWhenFacingWestTest()
        {
            var nb = new NavigationBoard();
            nb.ReadUpperRightCoordinates("5 5");
            nb.robotTwo.X = 1;
            nb.robotTwo.Y = 1;
            nb.robotTwo.Orientation = "W";
            nb.ReadMovementInputRobotTwo("M");
            Assert.AreEqual(0, nb.robotTwo.X);
            Assert.AreEqual(1, nb.robotTwo.Y);
            Assert.AreEqual("W", nb.robotTwo.Orientation);
        }

        // Robot One Move Arena Boundary Test
        
        [Test]
        public void RobotOneMoveWhenFacingNorthArenaBoundaryTest()
        {
            var nb = new NavigationBoard();
            nb.ReadUpperRightCoordinates("2 2");
            nb.ReadPositionInputRobotOne("0 2 N");
            nb.ReadMovementInputRobotOne("M");
            Assert.AreEqual(0, nb.robotOne.X);
            Assert.AreEqual(nb.maxTop, nb.robotOne.Y);
            Assert.AreEqual("N", nb.robotOne.Orientation);
        }

        [Test]
        public void RobotOneMoveWhenFacingEastArenaBoundaryTest()
        {
            var nb = new NavigationBoard();
            nb.ReadUpperRightCoordinates("2 2");
            nb.ReadPositionInputRobotOne("2 0 E");
            nb.ReadMovementInputRobotOne("M");
            Assert.AreEqual(nb.maxRight, nb.robotOne.X);
            Assert.AreEqual(0, nb.robotOne.Y);
            Assert.AreEqual("E", nb.robotOne.Orientation);
        }

        [Test]
        public void RobotOneMoveWhenFacingSouthArenaBoundaryTest()
        {
            var nb = new NavigationBoard();
            nb.ReadUpperRightCoordinates("2 2");
            nb.ReadPositionInputRobotOne("2 0 S");
            nb.ReadMovementInputRobotOne("M");
            Assert.AreEqual(2, nb.robotOne.X);
            Assert.AreEqual(0, nb.robotOne.Y);
            Assert.AreEqual("S", nb.robotOne.Orientation);
        }

        [Test]
        public void RobotOneMoveWhenFacingWestArenaBoundaryTest()
        {
            var nb = new NavigationBoard();
            nb.ReadUpperRightCoordinates("2 2");
            nb.ReadPositionInputRobotOne("0 0 W");
            nb.ReadMovementInputRobotOne("M");
            Assert.AreEqual(0, nb.robotOne.X);
            Assert.AreEqual(0, nb.robotOne.Y);
            Assert.AreEqual("W", nb.robotOne.Orientation);
        }

        // Robot Two Move Arena Boundary Test

        [Test]
        public void RobotTwoMoveWhenFacingNorthArenaBoundaryTest()
        {
            var nb = new NavigationBoard();
            nb.ReadUpperRightCoordinates("2 2");
            nb.ReadPositionInputRobotTwo("0 2 N");
            nb.ReadMovementInputRobotTwo("M");
            Assert.AreEqual(0, nb.robotTwo.X);
            Assert.AreEqual(nb.maxTop, nb.robotTwo.Y);
            Assert.AreEqual("N", nb.robotTwo.Orientation);
        }

        [Test]
        public void RobotTwoMoveWhenFacingEastArenaBoundaryTest()
        {
            var nb = new NavigationBoard();
            nb.ReadUpperRightCoordinates("2 2");
            nb.ReadPositionInputRobotTwo("2 0 E");
            nb.ReadMovementInputRobotTwo("M");
            Assert.AreEqual(nb.maxRight, nb.robotTwo.X);
            Assert.AreEqual(0, nb.robotTwo.Y);
            Assert.AreEqual("E", nb.robotTwo.Orientation);
        }

        [Test]
        public void RobotTwoMoveWhenFacingSouthArenaBoundaryTest()
        {
            var nb = new NavigationBoard();
            nb.ReadUpperRightCoordinates("2 2");
            nb.ReadPositionInputRobotTwo("2 0 S");
            nb.ReadMovementInputRobotTwo("M");
            Assert.AreEqual(2, nb.robotTwo.X);
            Assert.AreEqual(0, nb.robotTwo.Y);
            Assert.AreEqual("S", nb.robotTwo.Orientation);
        }

        [Test]
        public void RobotTwoMoveWhenFacingWestArenaBoundaryTest()
        {
            var nb = new NavigationBoard();
            nb.ReadUpperRightCoordinates("2 2");
            nb.ReadPositionInputRobotTwo("0 0 W");
            nb.ReadMovementInputRobotTwo("M");
            Assert.AreEqual(0, nb.robotTwo.X);
            Assert.AreEqual(0, nb.robotTwo.Y);
            Assert.AreEqual("W", nb.robotTwo.Orientation);
        }

        // Robot One Move Collision Robot Two

        [Test]
        public void RobotOneMoveWhenFacingNorthCollisionTest()
        {
            var nb = new NavigationBoard();
            nb.ReadUpperRightCoordinates("2 2");
            nb.ReadPositionInputRobotOne("0 0 N");
            nb.ReadPositionInputRobotTwo("0 1 N");
            nb.ReadMovementInputRobotOne("M");
            Assert.AreEqual(0, nb.robotOne.X);
            Assert.AreEqual(0, nb.robotOne.Y);
            Assert.AreEqual("N", nb.robotOne.Orientation);
            Assert.AreEqual(0, nb.robotTwo.X);
            Assert.AreEqual(1, nb.robotTwo.Y);
            Assert.AreEqual("N", nb.robotTwo.Orientation);
        }

        [Test]
        public void RobotOneMoveWhenFacingEastCollisionTest()
        {
            var nb = new NavigationBoard();
            nb.ReadUpperRightCoordinates("2 2");
            nb.ReadPositionInputRobotOne("0 0 E");
            nb.ReadPositionInputRobotTwo("1 0 N");
            nb.ReadMovementInputRobotOne("M");
            Assert.AreEqual(0, nb.robotOne.X);
            Assert.AreEqual(0, nb.robotOne.Y);
            Assert.AreEqual("E", nb.robotOne.Orientation);
            Assert.AreEqual(1, nb.robotTwo.X);
            Assert.AreEqual(0, nb.robotTwo.Y);
            Assert.AreEqual("N", nb.robotTwo.Orientation);
        }

        [Test]
        public void RobotOneMoveWhenFacingSouthCollisionTest()
        {
            var nb = new NavigationBoard();
            nb.ReadUpperRightCoordinates("2 2");
            nb.ReadPositionInputRobotOne("0 1 S");
            nb.ReadPositionInputRobotTwo("0 0 N");
            nb.ReadMovementInputRobotOne("M");
            Assert.AreEqual(0, nb.robotOne.X);
            Assert.AreEqual(1, nb.robotOne.Y);
            Assert.AreEqual("S", nb.robotOne.Orientation);
            Assert.AreEqual(0, nb.robotTwo.X);
            Assert.AreEqual(0, nb.robotTwo.Y);
            Assert.AreEqual("N", nb.robotTwo.Orientation);
        }

        [Test]
        public void RobotOneMoveWhenFacingWestCollisionTest()
        {
            var nb = new NavigationBoard();
            nb.ReadUpperRightCoordinates("2 2");
            nb.ReadPositionInputRobotOne("1 0 W");
            nb.ReadPositionInputRobotTwo("0 0 N");
            nb.ReadMovementInputRobotOne("M");
            Assert.AreEqual(1, nb.robotOne.X);
            Assert.AreEqual(0, nb.robotOne.Y);
            Assert.AreEqual("W", nb.robotOne.Orientation);
            Assert.AreEqual(0, nb.robotTwo.X);
            Assert.AreEqual(0, nb.robotTwo.Y);
            Assert.AreEqual("N", nb.robotTwo.Orientation);
        }

        // Robot Two Move Collision Robot One

        [Test]
        public void RobotTwoMoveWhenFacingNorthCollisionTest()
        {
            var nb = new NavigationBoard();
            nb.ReadUpperRightCoordinates("2 2");
            nb.ReadPositionInputRobotTwo("0 0 N");
            nb.ReadPositionInputRobotOne("0 1 N");
            nb.ReadMovementInputRobotTwo("M");
            Assert.AreEqual(0, nb.robotTwo.X);
            Assert.AreEqual(0, nb.robotTwo.Y);
            Assert.AreEqual("N", nb.robotTwo.Orientation);
            Assert.AreEqual(0, nb.robotOne.X);
            Assert.AreEqual(1, nb.robotOne.Y);
            Assert.AreEqual("N", nb.robotOne.Orientation);
        }

        [Test]
        public void RobotTwoMoveWhenFacingEastCollisionTest()
        {
            var nb = new NavigationBoard();
            nb.ReadUpperRightCoordinates("2 2");
            nb.ReadPositionInputRobotTwo("0 0 E");
            nb.ReadPositionInputRobotOne("1 0 N");
            nb.ReadMovementInputRobotTwo("M");
            Assert.AreEqual(0, nb.robotTwo.X);
            Assert.AreEqual(0, nb.robotTwo.Y);
            Assert.AreEqual("E", nb.robotTwo.Orientation);
            Assert.AreEqual(1, nb.robotOne.X);
            Assert.AreEqual(0, nb.robotOne.Y);
            Assert.AreEqual("N", nb.robotOne.Orientation);
        }

        [Test]
        public void RobotTwoMoveWhenFacingSouthCollisionTest()
        {
            var nb = new NavigationBoard();
            nb.ReadUpperRightCoordinates("2 2");
            nb.ReadPositionInputRobotTwo("0 1 S");
            nb.ReadPositionInputRobotOne("0 0 N");
            nb.ReadMovementInputRobotTwo("M");
            Assert.AreEqual(0, nb.robotTwo.X);
            Assert.AreEqual(1, nb.robotTwo.Y);
            Assert.AreEqual("S", nb.robotTwo.Orientation);
            Assert.AreEqual(0, nb.robotOne.X);
            Assert.AreEqual(0, nb.robotOne.Y);
            Assert.AreEqual("N", nb.robotOne.Orientation);
        }

        [Test]
        public void RobotTwoMoveWhenFacingWestCollisionTest()
        {
            var nb = new NavigationBoard();
            nb.ReadUpperRightCoordinates("2 2");
            nb.ReadPositionInputRobotTwo("1 0 W");
            nb.ReadPositionInputRobotOne("0 0 N");
            nb.ReadMovementInputRobotTwo("M");
            Assert.AreEqual(1, nb.robotTwo.X);
            Assert.AreEqual(0, nb.robotTwo.Y);
            Assert.AreEqual("W", nb.robotTwo.Orientation);
            Assert.AreEqual(0, nb.robotOne.X);
            Assert.AreEqual(0, nb.robotOne.Y);
            Assert.AreEqual("N", nb.robotOne.Orientation);
        }

        [Test]
        public void RobotOneMultipleMovementCommands()
        {
            var nb = new NavigationBoard();
            nb.ReadUpperRightCoordinates("5 5");
            nb.ReadPositionInputRobotOne("1 2 N");
            nb.ReadMovementInputRobotOne("LMLMLMLMM");
            Assert.AreEqual(1, nb.robotOne.X);
            Assert.AreEqual(3, nb.robotOne.Y);
            Assert.AreEqual("N", nb.robotOne.Orientation);
        }

        [Test]
        public void RobotTwoMultipleMovementCommands()
        {
            var nb = new NavigationBoard();
            nb.ReadUpperRightCoordinates("5 5");
            nb.ReadPositionInputRobotTwo("3 3 E");
            nb.ReadMovementInputRobotTwo("MMRMMRMRRM");
            Assert.AreEqual(5, nb.robotTwo.X);
            Assert.AreEqual(1, nb.robotTwo.Y);
            Assert.AreEqual("E", nb.robotTwo.Orientation);
        }
    }
}