using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LightGame
{
    class Board
    {
        private Cell[,] board;
        private readonly int rows;
        private readonly int columns;

        public Board(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;

        }

        public event EventHandler<CellEventArgs> CellFlipped;
        public int Rows
        {
            get { return this.rows; }
        }

        public int Columns
        {
            get { return this.columns; }
        }


        public void Initialize()
        {
            board = new Cell[rows, columns];
            
        }

        public void FlipCell(int row, int col) 
        {
            CellFlipped.Raise(this, new CellEventArgs(row, col));
            FlipAdjacentCells(row, col);
        }

        private void FlipAdjacentCells(int row, int col) 
        {
            if (CheckBounds( row + 1 , col))
            {
                CellFlipped.Raise(this, new CellEventArgs(row + 1, col));
            }
            if (CheckBounds(row - 1, col))
            {
                CellFlipped.Raise(this, new CellEventArgs(row - 1, col));
            }
            if (CheckBounds(row , col + 1))
            {
                CellFlipped.Raise(this, new CellEventArgs(row, col + 1));
            }
            if (CheckBounds(row , col -1))
            {
                CellFlipped.Raise(this, new CellEventArgs(row, col - 1));
            }

        }


        private IEnumerable<Point> GetAdjacentCells(int row, int col)
        {
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (!(i == 0 && j == 0) && CheckBounds(row + i, col + j))
                        yield return new Point(row + i, col + j);
                }
            }
        }

        private bool CheckBounds(int row, int col)
        {
            return row >= 0 && row < rows && col >= 0 && col < columns;
        }
    }
}
