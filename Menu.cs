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
            int mines = TextBoxInputs(MinesText);
            int width = TextBoxInputs(WedthText);
            int height = TextBoxInputs(HeightText);

            
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
        private int TextBoxInputs(TextBox t)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(t.Text))
                {
                    MessageBox.Show("Input cannot be empty. Please enter a number between 1 and 70.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return 0;
                }

                if (int.TryParse(t.Text, out int number))
                {
                    if (number > 0 && number <= 70)
                    {
                        return number;
                    }
                    else
                    {
                        MessageBox.Show("Invalid input. Please enter a number between 1 and 70.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input. Please enter a valid number.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}");
            }

            return 0;
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
