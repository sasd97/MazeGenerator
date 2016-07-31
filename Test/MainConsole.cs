using Maze.Constants;
using Maze.Utils;
using System;
using Maze.Models;

namespace Maze
{
    class Program
    {
        static void Main(string[] args)
        {
            CellModel[,] maze = OptionsUtils
                                    .StartConfig()
                                        .Height(MazeConstants.Height)
                                        .Width(MazeConstants.Width)
                                        //.CustomFinishCoordinates(new int[]{MazeConstants.Width - 2, MazeConstants.Height - 2})
                                        //.CustomStartCoordinates(new int[]{3,3})
                                    .EndConfig()
                                    .Create();
                                
            maze.PrintMaze(MazeConstants.Height, MazeConstants.Width, (item, isNewLine) =>
            {
                if (isNewLine)
                {
                    Console.WriteLine("\n");
                    return;
                }
                char symb = item.Type == CellConstants.Wall ? '#' : '0';
                if (item.VisitState == CellConstants.Visited) symb = '1';
                if (item.IsStart) symb = '0';
                if (item.IsFinish) symb = '2';
                Console.Write($"{symb} ");
            });                   
        }
    }
}
