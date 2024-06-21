namespace تطبيق_أبو_أحمد_العقاري
{
    partial class EmployeeAccount
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
            title = new TextBox();
            btnEmployee = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // title
            // 
            title.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            title.BackColor = SystemColors.Menu;
            title.BorderStyle = BorderStyle.None;
            title.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            title.Location = new Point(263, 12);
            title.Name = "title";
            title.ReadOnly = true;
            title.Size = new Size(187, 32);
            title.TabIndex = 3;
            title.TabStop = false;
            title.Text = "Welcome back";
            title.TextAlign = HorizontalAlignment.Center;
            // 
            // btnEmployee
            // 
            btnEmployee.AccessibleName = "";
            btnEmployee.Anchor = AnchorStyles.None;
            btnEmployee.BackColor = SystemColors.Highlight;
            btnEmployee.Font = new Font("Swis721 BlkCn BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmployee.ForeColor = SystemColors.ButtonFace;
            btnEmployee.Location = new Point(219, 120);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(270, 68);
            btnEmployee.TabIndex = 4;
            btnEmployee.Text = "Schedule";
            btnEmployee.UseVisualStyleBackColor = false;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // button1
            // 
            button1.AccessibleName = "";
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Swis721 BlkCn BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(219, 200);
            button1.Name = "button1";
            button1.Size = new Size(270, 68);
            button1.TabIndex = 5;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AccessibleName = "";
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = SystemColors.Highlight;
            button2.Font = new Font("Swis721 BlkCn BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(219, 280);
            button2.Name = "button2";
            button2.Size = new Size(270, 68);
            button2.TabIndex = 6;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // EmployeeAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 474);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnEmployee);
            Controls.Add(title);
            Name = "EmployeeAccount";
            Text = "EmployeeAccount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox title;
        private Button btnEmployee;
        private Button button1;
        private Button button2;
    }
}