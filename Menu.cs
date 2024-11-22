using System;
using System.Windows.Forms;

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
            // Check if the input is null or empty
            if (string.IsNullOrWhiteSpace(t.Text))
            {
                ShowError($"{t.Name} Input cannot be empty. Please enter a number between 1 and {limit}.");
                return 0;
            }

            // Attempt to parse the input as an integer
            if (int.TryParse(t.Text, out int number))
            {
                // Validate the range based on the provided limit
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
    }
}
