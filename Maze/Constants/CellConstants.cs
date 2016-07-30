using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.Constants
{
    abstract class CellConstants
    {
        public const int Wall = 0;
        public const int Cell = 1;

        public const int Visited = 0;
        public const int Unknown = 1;
    }
}
