using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightGame
{
    class CellEventArgs : EventArgs
    {
        public CellEventArgs(int row, int column)
        {
            this.Row = row;
            this.Column = column;
        }

        public int Row { get; private set; }
        public int Column { get; private set; }

    }
}
