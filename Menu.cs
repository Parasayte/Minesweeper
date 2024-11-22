using System;
using System.Drawing;
using System.Windows.Forms;
using minesweeper.Properties;

namespace minesweeper
{
    public partial class Menu : Form
    {
        public static int MineNo;
        public static int Gridwidth;
        public static int Gridheight;

        private Game g;

        public Menu()
        {
            InitializeComponent();
           
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            MineNo = 100;
            Gridwidth = 30;
            Gridheight = 30;
            g = new Game();
            g.Show();
            Hide();
        }
        private void costumgame_Click(object sender, EventArgs e)
        {
            int mines = TextBoxInputs(MinesText,10000);
            int width = TextBoxInputs(WedthText,90);
            int height = TextBoxInputs(HeightText,90);

            
            if (mines > 0 && width > 0 && height > 0)
            {
                MineNo = mines;
                Gridwidth = width;
                Gridheight = height;

               
                g = new Game();
                g.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Please correct your inputs before starting the game.",
                    "Invalid Inputs",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
        private int TextBoxInputs(TextBox t, int limit)
        {
      
            if (string.IsNullOrWhiteSpace(t.Text))
            {
                ShowError($"{t.Name} Input cannot be empty. Please enter a number between 1 and {limit}.");
                return 0;
            }

            
            if (int.TryParse(t.Text, out int number))
            {
              
                if (number > 0 && number <= limit)
                {
                    return number;
                }
                else
                {
                    ShowError($"{t.Name} Enter a number between 1 and {limit}.");
                }
            }
            else
            {
                ShowError("Enter a valid number.");
            }

            return 0;
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MineNo = 30;
            Gridwidth = 20;
            Gridheight = 20;
            g = new Game();
            g.Show();
            Hide();
        }

        private void ImageControler(Label l,Image img)
        {
            l.BackgroundImage= img;
            l.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            ImageControler(label11,Resources.pngwing);
            ImageControler(label10,Resources.pngwing);
            ImageControler(label6,Resources.pngwing1);
            ImageControler(label13,Resources.pngwing2);
            ImageControler(label7,Resources._5a2411fc6003f508dd5d5b37);
            
        }
    }
}
