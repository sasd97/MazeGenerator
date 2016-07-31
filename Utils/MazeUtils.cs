using Maze.Constants;
using Maze.Models;

namespace Maze.Utils
{
    static class MazeUtils
    {

        public static CellModel[,] GenerateEmptyMaze(int height, int width)
        {
            CellModel[,] maze = new CellModel[height, width];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    maze[i, j] = new CellModel { Y = i, X = j, VisitState = CellConstants.Unknown};
                    if (i % 2 != 0 && j % 2 != 0 && IsInMaze(height, width, i, j))
                    {
                        maze[i, j].Type = CellConstants.Cell;
                        continue;
                    }

                    maze[i, j].Type = CellConstants.Wall;
                }
            }

            return maze;
        }

        public static CellModel GetStartCell(this CellModel[,] maze) {
            CellModel start = maze[MazeConstants.StartPosition, MazeConstants.StartPosition];
            start.VisitState = CellConstants.Visited;
            start.IsStart = true;
            return start;
        }

        private static bool IsInMaze(int mazeHeight, int mazeWidth, int cellX, int cellY)
        {
            return (cellX < mazeHeight - 1 && cellY < mazeWidth - 1);
        }
    }
}
