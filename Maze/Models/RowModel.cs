using System.Collections.Generic;

namespace Maze.Models
{
    class RowModel
    {

        private readonly List<CellModel> _cells;

        public RowModel()
        {
            _cells = new List<CellModel>();
        }

        public RowModel(int size)
        {
            _cells = new List<CellModel>(size);
        }

        public void Add(CellModel cell)
        {
            _cells.Add(cell);
        }

        public CellModel Get(int position)
        {
            return _cells[position];
        }

        public void Remove(CellModel cell)
        {
            _cells.Remove(cell);
        }

        public int Size()
        {
            return _cells.Count;
        }
    }
}
