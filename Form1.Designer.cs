namespace تطبيق_أبو_أحمد_العقاري
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
            btnEmployee = new Button();
            btnBoss = new Button();
            title = new TextBox();
            SuspendLayout();
            // 
            // btnEmployee
            // 
            btnEmployee.AccessibleName = "";
            btnEmployee.BackColor = SystemColors.Highlight;
            btnEmployee.Font = new Font("Swis721 BlkCn BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmployee.ForeColor = SystemColors.ButtonFace;
            btnEmployee.Location = new Point(265, 158);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(233, 59);
            btnEmployee.TabIndex = 0;
            btnEmployee.Text = "Employee";
            btnEmployee.UseVisualStyleBackColor = false;
            btnEmployee.Click += button1_Click;
            // 
            // btnBoss
            // 
            btnBoss.AccessibleName = "";
            btnBoss.BackColor = SystemColors.Highlight;
            btnBoss.Cursor = Cursors.Hand;
            btnBoss.Font = new Font("Swis721 BlkCn BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBoss.ForeColor = SystemColors.ButtonFace;
            btnBoss.Location = new Point(265, 239);
            btnBoss.Name = "btnBoss";
            btnBoss.Size = new Size(233, 59);
            btnBoss.TabIndex = 1;
            btnBoss.Text = "Boss";
            btnBoss.UseVisualStyleBackColor = false;
            btnBoss.Click += button2_Click;
            // 
            // title
            // 
            title.BackColor = SystemColors.Menu;
            title.BorderStyle = BorderStyle.None;
            title.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            title.Location = new Point(247, 50);
            title.Name = "title";
            title.Size = new Size(272, 32);
            title.TabIndex = 2;
            title.Text = "Choose an Option";
            title.TextAlign = HorizontalAlignment.Center;
            title.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 450);
            Controls.Add(title);
            Controls.Add(btnBoss);
            Controls.Add(btnEmployee);
            Name = "Form1";
            Text = "تطبيق أبو أحمد العقاري";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEmployee;
        private Button btnBoss;
        private TextBox title;
    }
}