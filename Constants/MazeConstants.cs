namespace Maze.Constants
{
    abstract class MazeConstants
    {
        /*
        Value must be odd.
        For more conveniet solution use HelpUtils class to validate create and manipulate data.
        */
        public const int Height = 101;
        public const int Width = 101;

        public const int StartPosition = 1;
        public const int Distance = 2;
        public const int NeighbourSize = 4;
    }
}
