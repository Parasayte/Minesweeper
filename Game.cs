using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using minesweeper.Properties;

namespace minesweeper
{
    public partial class Game : Form
    {
       
        int time = 0;
        int bomb=minesweeper.Menu.MineNo;
        int GridX=minesweeper.Menu.Gridwidth;
        int GridY =minesweeper.Menu.Gridheight;
        int flagAmount=minesweeper.Menu.MineNo ;
        Random random = new Random();
        Button[,] buttons = new Button[30,30]; 
        
        public Game()
        {
            InitializeComponent();
          timer1.Start();

        } 
        private void BombPlacer()
        {
          
            labelflag.Text = flagAmount.ToString();
            ClearGrid();
            for(int k = 0; k < bomb; k++)
            {
                int i = random.Next(0, GridX);
                int j = random.Next(0, GridY);

                if (buttons[i, j].Text != "-1")
                { 
                  
                    buttons[i, j].Tag = "-1";
                    buttons[i, j].BackColor = Color.Crimson;
                 
                }  
                flagAmount = bomb ;
            }
            LoopForBombChecker();
            HideGrid();
        }  
        private void CheckWin()
        {
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    Button btn = buttons[i, j];

                   
                    if (btn.Tag.ToString() != "-1" && btn.Text == "")
                    {
                        return; 
                    }
                }
            }
            timer1.Stop();
            ShowBombs(); 
            MessageBox.Show($"Congratulations!\nYou finished at : {time} second", "You Win", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ButtonClick(Button b, object sender, EventArgs e, int x, int y)
        {
            if (b.Tag == "-1"&&b.Text != "🚩")
            {
                b.BackColor = Color.Crimson;
                ShowBombs();
                timer1.Stop();
                MessageBox.Show("Game Over!", "BOOOM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
             BombPlacer();   
            }
            else if(b.Text!="🚩")
            {
                EmptyButtonChecker(x, y);
                b.Text = (string)b.Tag;  
                b.ForeColor=Color.Black;
                ColorPick(b);           
                CheckWin();             
            }
        }
        private void ClearGrid()
        {
            time = 0;
            labelbombcounter.Text = time.ToString();
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    buttons[i,j].Text = "";
                    buttons[i, j].Tag = "0";
                    buttons[i, j].ForeColor=Color.Black;
                    buttons[i, j].BackColor = Color.FromArgb(33,33,33);
                    buttons[i, j].FlatStyle= FlatStyle.Popup;

                }
            }

        }
        private void CheckBombs(Button b, int x, int y)
        {
            int BombCounter = 0;

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    if (i == 0 && j == 0)
                        continue;

                    if (x + j >= 0 && x + j < buttons.GetLength(0) && y + i >= 0 && y + i < buttons.GetLength(1))
                    {
                        if (buttons[x + j, y + i].Tag != null && buttons[x + j, y + i].Tag.ToString() == "-1")
                        {
                            BombCounter++;
                        }
                    }
                }
            }

            if (b.Tag.ToString() != "-1" && BombCounter != 0)
            {
                b.Tag = BombCounter.ToString();
            }
        }
        private void EmptyButtonChecker(int x, int y)
        {
           
            if (x < 0 || x >= buttons.GetLength(0) || y < 0 || y >= buttons.GetLength(1))
                return;

            Button b = buttons[x, y];
 
           
           
            if (b.Text != "" || b.Tag.ToString() == "-1")
                return;

           
           
            b.Text = b.Tag.ToString();
         
           ColorPick(b);

            if (b.Tag.ToString() != "0")
                return;

         
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                  
                    if (i == 0 && j == 0)
                        continue;
                   
                    EmptyButtonChecker(x + i, y + j);
                }
            }

        }
        private void ColorPick(Button b)
        {
            string tagValue = b.Tag.ToString();

            switch (tagValue)
            {
                case "0": 
                    b.BackColor = Color.FromArgb(22, 22, 33); 
                    break;
                case "1": 
                    b.BackColor = Color.Indigo; 
                    break;
                case "2": 
                    b.BackColor = Color.Teal; 
                    break;
                case "3": 
                    b.BackColor = Color.Turquoise; 
                    break;
                case "4": 
                    b.BackColor = Color.YellowGreen; 
                    break;
                case "5": 
                    b.BackColor = Color.LightSalmon; 
                    break;
                case "6": 
                    b.BackColor = Color.DarkGoldenrod; 
                    break;
                case "7":
                    b.BackColor = Color.Brown; 
                    break;
                case "8": 
                    b.BackColor = Color.DarkRed; 
                    break;
               
            }
        }
        private void RightClick(object sender, MouseEventArgs e,Button b)
        {
           
            if (e.Button == MouseButtons.Right)
            {
                if(flagAmount>0&&b.Text!="🚩"&&b.Text=="")
                {  
                    b.Text = "🚩";
                    b.ForeColor=Color.Red;
                  
                    flagAmount--;
                    labelflag.Text=flagAmount.ToString();
                }
                else if (b.Text == "🚩")
                {
                    b.Text = "";
                    
                    b.ForeColor=Color.Black;
                  
                    flagAmount++;
                    labelflag.Text=flagAmount.ToString();
                }
            }
            labelflag.Text = flagAmount.ToString();
        }
        private void PrintGrid()
        {
            timer1.Start();
            int x = 0;
            int y = 0;
            int ButtonsWed =600/GridX;
           labelbombcounter.Text =bomb.ToString();
            labelflag.Text = flagAmount.ToString();
            buttons = new Button[GridX, GridY];
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++) 
                {
                    int row=i, col=j;
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = ButtonsWed;
                    buttons[i, j].Height = ButtonsWed;
                    buttons[i, j].BackColor = Color.FromArgb(43,43,53);
                    buttons[i, j].Left = x;
                    buttons[i, j].Top = y;
                    buttons[i, j].Tag = "0";
                    panel1.Controls.Add(buttons[i, j]);
                    buttons[i, j].Click += (sender, e) => ButtonClick( buttons[row,col],sender, e,row,col);
                    buttons[i, j].MouseDown += (sender, e) => RightClick(sender, e, buttons[row, col]); x += ButtonsWed;
                }
                y += ButtonsWed;
                x = 0;
            }

            BombPlacer();
          
        }
        private void LoopForBombChecker() {
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    CheckBombs(buttons[i, j], i, j);
                }
            }
        }
        private void ShowBombs()
        {
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    if (buttons[i, j].Tag == "-1")
                    { 
                        buttons[i, j].BackColor = Color.Crimson;
                        buttons[i, j].ForeColor = Color.Black;
                        buttons[i,j].Text = "💣";
                    }
                }
            }
        }
        private void HideGrid()
        {
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    buttons[i, j].Text = "";
                    buttons[i, j].BackColor = Color.FromArgb(33,33,33);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PrintGrid();
           
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            
          
            labelbombcounter.Text=time.ToString();
            time++;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Menu m=new Menu();
            m.Show();
            Hide();
        }

        private void player_pictureBox_Click(object sender, EventArgs e)
        {
            BombPlacer();
            timer1.Start();
        }
    }
}
