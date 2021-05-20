using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightGame
{
    class MainPresenter : IMainPresenter
    {
        private Board board;
        private readonly IMainView mainView;

        public MainPresenter(IMainView mainView)
        {
            this.mainView = mainView;
        }

        public void NewGame()
        {
            mainView.Rows = 5;
            mainView.Columns = 5;
            mainView.ShowBoard();
            board = new Board(5, 5);
            AddBoardEvents();
            board.Initialize();
        }

        private void AddBoardEvents()
        {
            board.CellFlipped +=OnClickCell;
          
        }

        public void FlipCell(int row, int col)
        {
            board.FlipCell(row, col);
        }

        private void OnClickCell(object sender,CellEventArgs e) 
        {
            mainView.ChangeCell(e.Row, e.Column);
        }
    }
}
