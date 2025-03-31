
using MarsRover.Model;

namespace MarsRoverTestProject;

public class MarsRoverMovesToExpectedDestinationTest
{
    [Test]
    public void MarsRoverFacesNorthTurnsRightFacesEast()
    {
        Rover marsRover = new Rover(0, 0, "N");
        marsRover.TakeInstructions("R");

        Assert.IsTrue(marsRover.Direction == "E");
    }

    [Test]
    public void MarsRoverFacesEastTurnsRightFacesSouth()
    {
        Rover marsRover = new Rover(0, 0, "E");
        marsRover.TakeInstructions("R");

        Assert.IsTrue(marsRover.Direction == "S");
    }

    [Test]
    public void MarsRoverFacesSouthTurnsRightFacesWest()
    {
        Rover marsRover = new Rover(0, 0, "S");
        marsRover.TakeInstructions("R");

        Assert.IsTrue(marsRover.Direction == "W");
    }

    [Test]
    public void MarsRoverFacesWestTurnsRightFacesNorth()
    {
        Rover marsRover = new Rover(0, 0, "W");
        marsRover.TakeInstructions("R");

        Assert.IsTrue(marsRover.Direction == "N");
    }

    [Test]
    public void MarsRoverFacesNorthTurnsLeftFacesWest()
    {
        Rover marsRover = new Rover(0, 0, "N");
        marsRover.TakeInstructions("L");

        Assert.IsTrue(marsRover.Direction == "W");
    }

    [Test]
    public void MarsRoverFacesWestTurnsLeftFacesSouth()
    {
        Rover marsRover = new Rover(0, 0, "W");
        marsRover.TakeInstructions("L");

        Assert.IsTrue(marsRover.Direction == "S");
    }

    [Test]
    public void MarsRoverFacesSouthTurnsLeftFacesEast()
    {
        Rover marsRover = new Rover(0, 0, "S");
        marsRover.TakeInstructions("L");

        Assert.IsTrue(marsRover.Direction == "E");
    }

    [Test]
    public void MarsRoverFacesEastTurnsLeftFacesNorth()
    {
        Rover marsRover = new Rover(0, 0, "E");
        marsRover.TakeInstructions("L");

        Assert.IsTrue(marsRover.Direction == "N");
    }

    [Test]
    public void MarsRoverFacesNorthMovesForwardIncrementedYCoordinate()
    {
        Rover marsRover = new Rover(0, 0, "N");
        marsRover.TakeInstructions("F");
        Assert.IsTrue(marsRover.Y == 1);
    }

    [Test]
    public void MarsRoverFacesSouthMovesForwardDecrementedYCoordinate()
    {
        Rover marsRover = new Rover(0, 0, "S");
        marsRover.TakeInstructions("F");
        Assert.IsTrue(marsRover.Y == -1);
    }

    [Test]
    public void MarsRoverFacesEastMovesForwardIncrementXCoordinate()
    {
        Rover marsRover = new Rover(0, 0, "E");
        marsRover.TakeInstructions("F");
        Assert.IsTrue(marsRover.X == 1);
    }

    [Test]
    public void MarsRoverFacesWestMovesForwardDecrementXCoordinate()
    {
        Rover marsRover = new Rover(0, 0, "W");
        marsRover.TakeInstructions("F");
        Assert.IsTrue(marsRover.X == -1);
    }

    [Test]
    public void MarsRoverFacesNorthTurnsRightAndMovesForwardIncrementXCoordinateDirectionEast()
    {
        Rover marsRover = new Rover(0, 0, "N");
        marsRover.TakeInstructions("RF");
        Assert.IsTrue(marsRover.X == 1);
        Assert.IsTrue(marsRover.Direction == "E");
    }

    [Test]
    public void MarsRoverFacesNorthTurnsLeftAndMovesForwardDecrementXCoordinateDirectionWest()
    {
        Rover marsRover = new Rover(0, 0, "N");
        marsRover.TakeInstructions("LF");
        Assert.IsTrue(marsRover.X == -1);
        Assert.IsTrue(marsRover.Direction == "W");
    }

}

