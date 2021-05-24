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
            createButtons();
        }

        
        private void ResetTableStyles()
        {
            boardPanel.Controls.Clear();
            boardPanel.RowStyles.Clear();
            boardPanel.ColumnStyles.Clear();

            boardPanel.RowCount = Rows;
            boardPanel.ColumnCount = Columns;

            for (int i = 0; i < Rows; i++) // enchance for loop
            {
                boardPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            }
            for (int j = 0; j < Columns; j++)
            {
                boardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            }
        }

        private void buttonMouseDown(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            Point location = (Point)button.Tag;
            if (e.Button == MouseButtons.Left)
            {
                presenter.FlipCell(location.X, location.Y);
            }
        }

       
        private void createButtons()
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
                    button.MouseDown += buttonMouseDown;
                    boardPanel.Controls.Add(button, j, i);
                }
            }
        }


        private void start_Click_1(object sender, EventArgs e)
        {
            presenter.NewGame();
        }

        public void changeCell(int row, int col)
        {
            var button = (Button)boardPanel.GetControlFromPosition(col, row);

            var buttonColor = button.BackColor;

            var active = Color.DarkGreen;
            var inactive = Color.Lime;

            if (buttonColor == active) 
            {
                button.BackColor = inactive;
            }
            if (buttonColor == inactive)
            {
                button.BackColor = active;
            }


        }
    }
}
