using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightGame
{
    public partial class MainGame : Form , IMainView
    {
        private readonly IMainPresenter presenter;
        public MainGame()
        {
            InitializeComponent();
            presenter = new MainPresenter(this);
        }

        public int Rows { get; set; }
        public int Columns { get; set; }

        public void ShowBoard()
        {
            ResetTableStyles();
            CreateButtons();
        }

        
        private void ResetTableStyles()
        {
            boardPanel.Controls.Clear();
            boardPanel.RowStyles.Clear();
            boardPanel.ColumnStyles.Clear();

            boardPanel.RowCount = Rows;
            boardPanel.ColumnCount = Columns;

            for (int i = 0; i < Rows; i++)
            {
                boardPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            }
            for (int j = 0; j < Columns; j++)
            {
                boardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            }
        }

        private void button_MouseDown(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            Point location = (Point)button.Tag;
            if (e.Button == MouseButtons.Left)
            {
                presenter.FlipCell(location.X, location.Y);
            }
        }

       
        private void CreateButtons()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    var button = new Button
                    {
                        BackColor = Color.DarkGreen,
                        Dock = DockStyle.Fill,
                        Margin = Padding.Empty,
                        Tag = new Point(i, j),
                        BackgroundImageLayout = ImageLayout.Stretch
                    };
                    button.MouseDown += button_MouseDown;
                    boardPanel.Controls.Add(button, j, i);
                }
            }
        }


        private void start_Click_1(object sender, EventArgs e)
        {
            presenter.NewGame();

        }

        public void ChangeCell(int row, int col)
        {
            var button = (Button)boardPanel.GetControlFromPosition(col, row);

            var bColor = button.BackColor;

            if(bColor == Color.DarkGreen) 
            {
                button.BackColor = Color.Lime;
            }
            if (bColor == Color.Lime)
            {
                button.BackColor = Color.DarkGreen;
            }


        }
    }
}
