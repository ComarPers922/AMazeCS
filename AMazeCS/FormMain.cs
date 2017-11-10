using System;
using System.Drawing;
using System.Windows.Forms;

namespace AMazeCS
{
    public partial class FormMain : Form
    {
        private MazeData Maze = new MazeData(97);
        private readonly int TileSize = 5;
        private readonly SolidBrush WallBrush = new SolidBrush(Color.Blue);
        private readonly SolidBrush RoadBrush = new SolidBrush(Color.White);
        private readonly SolidBrush PathBrush = new SolidBrush(Color.Yellow);

        public FormMain()
        {
            InitializeComponent();
        }

        private void Panel_Game_Paint(object sender, PaintEventArgs e)
        {
            for (int x = 0; x < Maze.Size; x++)
            {
                for (int y = 0; y < Maze.Size; y++)
                {
                    var rect = new Rectangle(x * TileSize, y * TileSize, TileSize, TileSize);
                    switch (Maze.Maze[x,y])
                    {
                        case TileType.Road:
                            e.Graphics.FillRectangle(RoadBrush, rect);
                            break;
                        case TileType.Wall:
                            e.Graphics.FillRectangle(WallBrush, rect);
                            break;
                        default:
                            break;
                    }
                    if(Maze.IsPath[x,y])
                    {
                        e.Graphics.FillRectangle(PathBrush, rect);
                    }
                }
            }
        }

        private void Button_Generate_Click(object sender, EventArgs e)
        {
            Maze.Reset();
            Panel_Game.Invalidate();
        }

        private void Button_Solve_Click(object sender, EventArgs e)
        {
            try
            {
                Maze.Solve();
                Panel_Game.Invalidate();
            }
            catch
            {
                MessageBox.Show("迷宫无解！！！");
            }
        }
    }
}
