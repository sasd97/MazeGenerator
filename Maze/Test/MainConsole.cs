using Maze.Constants;
using Maze.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maze.Models;
using Maze.Service;

namespace Maze
{
    class Program
    {
        static void Main(string[] args)
        {

            CellModel[,] maze = MazeUtils.GenerateEmptyMaze(MazeConstants.Height, MazeConstants.Width);
            HelpUtils.PrintMaze(maze, MazeConstants.Height, MazeConstants.Width, (item, isNewLine) =>
            {
                if (isNewLine)
                {
                    Console.WriteLine("\n");
                    return;
                }
                char symb = item.Type == CellConstants.Wall ? '#' : '0';
                if (item.VisitState == CellConstants.Visited) symb = '1';
                Console.Write($"{symb} ");
            });

            Console.WriteLine("----------------------------------------------------");
            maze = MazeService.GenerateMaze(maze, MazeConstants.Height, MazeConstants.Width);

            HelpUtils.PrintMaze(maze, MazeConstants.Height, MazeConstants.Width, (item, isNewLine) =>
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

            Console.ReadKey();
        }
    }
}
