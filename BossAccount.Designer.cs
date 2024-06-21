namespace تطبيق_أبو_أحمد_العقاري
{
    partial class BossAccount
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
            button3 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button3
            // 
            button3.AccessibleName = "";
            button3.BackColor = SystemColors.Highlight;
            button3.Font = new Font("Swis721 BlkCn BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(283, 121);
            button3.Name = "button3";
            button3.Size = new Size(233, 59);
            button3.TabIndex = 8;
            button3.Text = "Appointments";
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.AccessibleName = "";
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Swis721 BlkCn BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(283, 251);
            button1.Name = "button1";
            button1.Size = new Size(233, 59);
            button1.TabIndex = 9;
            button1.Text = "Employees status";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(268, 12);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(270, 32);
            textBox1.TabIndex = 10;
            textBox1.TabStop = false;
            textBox1.Text = "Welcome back Boss";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button2
            // 
            button2.Location = new Point(713, 12);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // BossAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(button3);
            Name = "BossAccount";
            Text = "تطبيق أبو أحمد العقاري";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3;
        private Button button1;
        private TextBox textBox1;
        private Button button2;
    }
}