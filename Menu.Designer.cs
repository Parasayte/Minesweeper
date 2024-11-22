using System.ComponentModel;

namespace minesweeper
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.costumgame = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.MinesText = new System.Windows.Forms.TextBox();
            this.HeightText = new System.Windows.Forms.TextBox();
            this.WedthText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(183, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "MINESWEEPER ";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(12, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Made by SELAM";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(123, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 196);
            this.panel1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Location = new System.Drawing.Point(15, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 118);
            this.label8.TabIndex = 6;
            this.label8.Text = "width :\r\n\r\nheight :\r\n\r\nMines :";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(107, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 85);
            this.label4.TabIndex = 5;
            this.label4.Text = "30\r\n\r\n30\r\n\r\n100\r\n";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(40, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(66)))));
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.costumgame);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.MinesText);
            this.panel2.Controls.Add(this.HeightText);
            this.panel2.Controls.Add(this.WedthText);
            this.panel2.Location = new System.Drawing.Point(370, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 196);
            this.panel2.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(20, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 118);
            this.label9.TabIndex = 7;
            this.label9.Text = "width :\r\n\r\nheight :\r\n\r\nMines :";
            // 
            // costumgame
            // 
            this.costumgame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.costumgame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.costumgame.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costumgame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.costumgame.Location = new System.Drawing.Point(66, 159);
            this.costumgame.Name = "costumgame";
            this.costumgame.Size = new System.Drawing.Size(75, 28);
            this.costumgame.TabIndex = 7;
            this.costumgame.Text = "Start";
            this.costumgame.UseVisualStyleBackColor = false;
            this.costumgame.Click += new System.EventHandler(this.costumgame_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(47, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 27);
            this.label5.TabIndex = 6;
            // 
            // MinesText
            // 
            this.MinesText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MinesText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MinesText.Location = new System.Drawing.Point(96, 110);
            this.MinesText.Name = "MinesText";
            this.MinesText.Size = new System.Drawing.Size(77, 13);
            this.MinesText.TabIndex = 4;
            // 
            // HeightText
            // 
            this.HeightText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.HeightText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HeightText.Location = new System.Drawing.Point(96, 76);
            this.HeightText.Name = "HeightText";
            this.HeightText.Size = new System.Drawing.Size(77, 13);
            this.HeightText.TabIndex = 3;
            // 
            // WedthText
            // 
            this.WedthText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.WedthText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WedthText.Location = new System.Drawing.Point(96, 41);
            this.WedthText.Name = "WedthText";
            this.WedthText.Size = new System.Drawing.Size(77, 13);
            this.WedthText.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(163, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 45);
            this.label6.TabIndex = 5;
            this.label6.Text = "💀";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(440, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 45);
            this.label7.TabIndex = 6;
            this.label7.Text = "☠";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Crimson;
            this.label10.Location = new System.Drawing.Point(471, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 65);
            this.label10.TabIndex = 7;
            this.label10.Text = "❄";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label11.Location = new System.Drawing.Point(105, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 65);
            this.label11.TabIndex = 8;
            this.label11.Text = "❄";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label11;

        private System.Windows.Forms.Label label10;

        private System.Windows.Forms.Button costumgame;

        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.TextBox WedthText;
        private System.Windows.Forms.TextBox HeightText;
        private System.Windows.Forms.TextBox MinesText;

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}