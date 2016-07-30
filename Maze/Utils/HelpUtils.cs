using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maze.Constants;
using Maze.Models;

namespace Maze.Utils
{
    static class HelpUtils
    {

        public static void PrintMaze(CellModel[,] maze, int height, int width, Action<CellModel, bool> print)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    print(maze[i, j], false);
                }
                print(new CellModel(), true);
            }
        }
    }
}
