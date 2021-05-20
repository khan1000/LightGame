using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightGame
{
    interface IMainView
    {
        int Rows { get; set; }
        int Columns { get; set; }

        void ShowBoard();

        void ChangeCell(int row , int col);
    }
}
