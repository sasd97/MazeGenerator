using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
