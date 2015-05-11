namespace RoverKata.Orientations
{
    public interface IOrientation
    {
        void TurnLeft(Rover rover);
        void TurnRight(Rover rover);
        bool MoveForward(Rover rover);
        bool MoveBackward(Rover rover);
    }
}