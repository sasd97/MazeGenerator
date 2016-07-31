using Maze.Constants;

namespace Maze.Models
{
    class CellModel
    {

        public CellModel()
        {
        }

        public CellModel(int x, int y)
        {
            X = x;
            Y = y;
        }

        public CellModel(int x,
                        int y,
                        int type,
                        bool visited,
                        bool isStart = false,
                        bool isFinish = false)
        {
            X = x;
            Y = y;
            Type = type;
            VisitState = visited ? CellConstants.Visited : CellConstants.Unknown;
            IsStart = isStart;
            IsFinish = isFinish;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public int Type { get; set; }

        public int VisitState { get; set; }

        public bool IsStart { get; set; } = false;

        public bool IsFinish { get; set; } = false;

        public bool In(int width, int height)
        {
            return X > 0 && X < width && Y > 0 && Y < height;
        }

        public bool IsWall()
        {
            return Type == CellConstants.Wall;
        }

        public bool IsVisited()
        {
            return VisitState == CellConstants.Visited;
        }
    }
}
