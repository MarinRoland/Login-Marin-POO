namespace Login
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            button_login = new Button();
            button_clear = new Button();
            button_exit = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("OCR A Extended", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(261, 74);
            label1.Name = "label1";
            label1.Size = new Size(80, 24);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("OCR A Extended", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(214, 110);
            label2.Name = "label2";
            label2.Size = new Size(63, 13);
            label2.TabIndex = 1;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("OCR A Extended", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(213, 156);
            label3.Name = "label3";
            label3.Size = new Size(63, 13);
            label3.TabIndex = 2;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_username.Location = new Point(213, 125);
            txt_username.MinimumSize = new Size(180, 33);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(180, 33);
            txt_username.TabIndex = 3;
            txt_username.TextChanged += txt_username_TextChanged;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_password.Location = new Point(214, 170);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(180, 24);
            txt_password.TabIndex = 4;
            // 
            // button_login
            // 
            button_login.BackColor = Color.DarkSlateBlue;
            button_login.FlatStyle = FlatStyle.Flat;
            button_login.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_login.ForeColor = SystemColors.Control;
            button_login.Location = new Point(213, 200);
            button_login.Name = "button_login";
            button_login.Size = new Size(178, 27);
            button_login.TabIndex = 5;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += button_login_Click;
            // 
            // button_clear
            // 
            button_clear.BackColor = Color.DarkSlateBlue;
            button_clear.FlatAppearance.BorderSize = 0;
            button_clear.FlatStyle = FlatStyle.Flat;
            button_clear.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_clear.ForeColor = SystemColors.Control;
            button_clear.Location = new Point(213, 233);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(178, 26);
            button_clear.TabIndex = 6;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = false;
            button_clear.Click += button_clear_Click;
            // 
            // button_exit
            // 
            button_exit.BackColor = Color.MidnightBlue;
            button_exit.FlatStyle = FlatStyle.Flat;
            button_exit.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point);
            button_exit.ForeColor = Color.White;
            button_exit.Location = new Point(9, 8);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(50, 29);
            button_exit.TabIndex = 7;
            button_exit.Text = "X";
            button_exit.UseVisualStyleBackColor = false;
            button_exit.Click += button_exit_Click;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(200, 64);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(205, 206);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(609, 354);
            Controls.Add(button_exit);
            Controls.Add(button_clear);
            Controls.Add(button_login);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_username;
        private TextBox txt_password;
        private Button button_login;
        private Button button_clear;
        private Button button_exit;
        private Button button1;
    }
}