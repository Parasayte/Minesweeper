namespace minesweeper
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelbombcounter = new System.Windows.Forms.Label();
            this.labelflag = new System.Windows.Forms.Label();
            this.timer1 = new System.Timers.Timer();
            this.button2 = new System.Windows.Forms.Button();
            this.player_pictureBox = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(10, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 632);
            this.panel1.TabIndex = 1;
            // 
            // labelbombcounter
            // 
            this.labelbombcounter.AutoSize = true;
            this.labelbombcounter.BackColor = System.Drawing.Color.Transparent;
            this.labelbombcounter.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbombcounter.ForeColor = System.Drawing.Color.Purple;
            this.labelbombcounter.Location = new System.Drawing.Point(157, 6);
            this.labelbombcounter.Name = "labelbombcounter";
            this.labelbombcounter.Size = new System.Drawing.Size(27, 29);
            this.labelbombcounter.TabIndex = 2;
            this.labelbombcounter.Text = "0";
            // 
            // labelflag
            // 
            this.labelflag.AutoSize = true;
            this.labelflag.BackColor = System.Drawing.Color.Transparent;
            this.labelflag.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelflag.ForeColor = System.Drawing.Color.SlateBlue;
            this.labelflag.Location = new System.Drawing.Point(436, 6);
            this.labelflag.Name = "labelflag";
            this.labelflag.Size = new System.Drawing.Size(27, 29);
            this.labelflag.TabIndex = 3;
            this.labelflag.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000D;
            this.timer1.SynchronizingObject = this;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(523, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 37);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // player_pictureBox
            // 
            this.player_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.player_pictureBox.Image = global::minesweeper.Properties.Resources.pngegg;
            this.player_pictureBox.InitialImage = null;
            this.player_pictureBox.Location = new System.Drawing.Point(283, 1);
            this.player_pictureBox.Name = "player_pictureBox";
            this.player_pictureBox.Size = new System.Drawing.Size(51, 42);
            this.player_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player_pictureBox.TabIndex = 17;
            this.player_pictureBox.TabStop = false;
            this.player_pictureBox.Click += new System.EventHandler(this.player_pictureBox_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(800, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(757, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Lucida Sans Unicode", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.label12.Location = new System.Drawing.Point(795, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 14);
            this.label12.TabIndex = 20;
            this.label12.Text = "Mines number";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(614, 685);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.player_pictureBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelflag);
            this.Controls.Add(this.labelbombcounter);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label12;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.PictureBox player_pictureBox;

        private System.Windows.Forms.Button button2;

        private System.Timers.Timer timer1;

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelbombcounter;
        private System.Windows.Forms.Label labelflag;
    }
}

