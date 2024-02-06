namespace Assignment2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(44, 210);
            button1.Name = "button1";
            button1.Size = new Size(113, 42);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(203, 210);
            button2.Name = "button2";
            button2.Size = new Size(112, 42);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(349, 210);
            button3.Name = "button3";
            button3.Size = new Size(120, 42);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(496, 210);
            button4.Name = "button4";
            button4.Size = new Size(113, 42);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(649, 210);
            button5.Name = "button5";
            button5.Size = new Size(116, 42);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(349, 398);
            button6.Name = "button6";
            button6.Size = new Size(91, 48);
            button6.TabIndex = 5;
            button6.Text = "Exit";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(222, 108);
            label1.Name = "label1";
            label1.Size = new Size(387, 40);
            label1.TabIndex = 6;
            label1.Text = "Do you know the French words for numbers 1 through 5? \n Click the buttons to see them.";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(374, 318);
            label2.Name = "frenchlbl";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 7;
            label2.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 507);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "French Nnumbers";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label1;
        private Label label2;
    }
}
