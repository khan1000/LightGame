using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightGame
{
    interface IMainPresenter
    {
        void NewGame();
        void FlipCell(int row, int col);

    }
}
