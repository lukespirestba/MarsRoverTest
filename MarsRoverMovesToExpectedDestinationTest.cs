
namespace MarsRoverTestProject
{
    public class MarsRoverMovesToExpectedDestinationTest
    {
        [Test]
        public void MarsRoverFacesNorthTurnsRightFacesEast()
        {
            MarsRover marsRover = new MarsRover(0, 0, "N");
            marsRover.TakeInstructions("R");

            Assert.IsTrue(marsRover.Direction == "E");
        }

        [Test]
        public void MarsRoverFacesEastTurnsRightFacesSouth()
        {
            MarsRover marsRover = new MarsRover(0, 0, "E");
            marsRover.TakeInstructions("R");

            Assert.IsTrue(marsRover.Direction == "S");
        }

        [Test]
        public void MarsRoverFacesSouthTurnsRightFacesWest()
        {
            MarsRover marsRover = new MarsRover(0, 0, "S");
            marsRover.TakeInstructions("R");

            Assert.IsTrue(marsRover.Direction == "W");
        }

        [Test]
        public void MarsRoverFacesWestTurnsRightFacesNorth()
        {
            MarsRover marsRover = new MarsRover(0, 0, "W");
            marsRover.TakeInstructions("R");

            Assert.IsTrue(marsRover.Direction == "N");
        }

    }

    internal class MarsRover
    {
        public MarsRover(int x, int y, string direction)
        {
            Direction = direction;
        }

        public string Direction { get; set; }

        public void TakeInstructions(string instructionSet)
        {
            ChangeDirectionRight();
        }

        private void ChangeDirectionRight()
        {
            switch(Direction)
            {
                case "N":
                    Direction = "E";
                    break;
                case "E":
                    Direction = "S";
                    break;
                case "S":
                    Direction = "W";
                    break;
                case "W":
                    Direction = "N";
                    break;
            }
        }
    }
}