using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minesweeper
{
    public partial class Form1 : Form
    {
       static int bomb =100;
        int GridX = 30;
        int GridY = 30;
        int flagAmount = bomb/3;
        Random random = new Random();
        Button[,] buttons = new Button[30,30]; 


        public Form1()
        {
            InitializeComponent();
          

        } 
        private void BombPlacer()
        {
            flagAmount = bomb / 3;
            labelflag.Text = flagAmount.ToString();
            ClearGrid();
            for(int k = 0; k < bomb; k++)
            {
                int i = random.Next(0, GridX);
                int j = random.Next(0, GridY);

                if (buttons[i, j].Text != "-1")
                { 
                    buttons[i,j].Text = "-1";
                    buttons[i, j].Tag = "-1";
                    buttons[i, j].BackColor = Color.Crimson;
                 
                }
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

          
            MessageBox.Show("Congratulations!", "You Win", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowBombs(); 
        }

        private void ButtonClick(Button b, object sender, EventArgs e, int x, int y)
        {
            if (b.Tag == "-1")
            {
                b.BackColor = Color.Crimson;
                ShowBombs();
                MessageBox.Show("Game Over!", "BOOOM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
             BombPlacer();   
            }
            else
            {
                EmptyButtonChecker(x, y);
                b.Text = (string)b.Tag;  
                ColorPick(b);           
                CheckWin();             
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BombPlacer();
        } 
        private void ClearGrid()
        {
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

            Button btn = buttons[x, y];

           
            if (btn.Text != "" || btn.Tag.ToString() == "-1")
                return;

            
            ColorPick(btn);
           
            btn.Text = btn.Tag.ToString();
           


            if (btn.Tag.ToString() != "0")
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
                if(flagAmount>0&&b.FlatStyle!=FlatStyle.Standard)
                {  
                    b.Text = "🚩";
                    b.Tag = "🚩";
                    b.ForeColor=Color.Red;
                  
                    flagAmount--;
                    labelflag.Text=flagAmount.ToString();
                }
            }
            labelflag.Text = flagAmount.ToString();
        }
        private void PrintGrid()
        {
            int x = 0;
            int y = 0;
            int ButtonsWed = 20;
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
    }
}
