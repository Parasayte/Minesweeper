namespace minesweeper
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelbombcounter = new System.Windows.Forms.Label();
            this.labelflag = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(346, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "🙂";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 778);
            this.panel1.TabIndex = 1;
            // 
            // labelbombcounter
            // 
            this.labelbombcounter.AutoSize = true;
            this.labelbombcounter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelbombcounter.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbombcounter.ForeColor = System.Drawing.Color.Red;
            this.labelbombcounter.Location = new System.Drawing.Point(183, 7);
            this.labelbombcounter.Name = "labelbombcounter";
            this.labelbombcounter.Size = new System.Drawing.Size(35, 40);
            this.labelbombcounter.TabIndex = 2;
            this.labelbombcounter.Text = "0";
            // 
            // labelflag
            // 
            this.labelflag.AutoSize = true;
            this.labelflag.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelflag.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelflag.ForeColor = System.Drawing.Color.Red;
            this.labelflag.Location = new System.Drawing.Point(509, 7);
            this.labelflag.Name = "labelflag";
            this.labelflag.Size = new System.Drawing.Size(35, 40);
            this.labelflag.TabIndex = 3;
            this.labelflag.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(739, 886);
            this.Controls.Add(this.labelflag);
            this.Controls.Add(this.labelbombcounter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelbombcounter;
        private System.Windows.Forms.Label labelflag;
    }
}

