

namespace MarsRover.Model;

public class Rover
{
    public Rover(int x, int y, string direction)
    {
        Direction = direction;
    }

    public string Direction { get; set; }

    public int Y { get; set; }

    public int X { get; set; }

    public void TakeInstructions(string instructionSet)
    {
        if (instructionSet == "R")
        {
            ChangeDirectionRight();
        }
        else if (instructionSet == "L")
        {
            ChangeDirectionLeft();
        }
        else if(instructionSet == "F")
        {
            if(Direction == "N" || Direction == "S")
            {
                ChangeCoordinateY(Direction);
            }
            else if (Direction == "E" || Direction == "W")
            {
                ChangeCoordinateX(Direction);
            }
        }
    }

    private void ChangeCoordinateX(string direction)
    {
        if (direction == "E")
        {
            X++;
        }
        else if (direction == "W")
        {
            X--;
        }
    }

    private void ChangeCoordinateY(string direction)
    {
        if(direction == "N")
        {
            Y++;
        }
        else if (direction == "S")
        {
            Y--;
        }
    }

    private void ChangeDirectionLeft()
    {
        switch (Direction)
        {
            case "N":
                Direction = "W";
                break;
            case "E":
                Direction = "N";
                break;
            case "S":
                Direction = "E";
                break;
            case "W":
                Direction = "S";
                break;
        }
    }

    private void ChangeDirectionRight()
    {
        switch (Direction)
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
