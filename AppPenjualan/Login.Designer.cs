namespace AppPenjualan
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            cb_showPassword = new CheckBox();
            txt_password = new TextBox();
            lbl_password = new Label();
            txt_username = new TextBox();
            lbl_username = new Label();
            subjudul_login = new Label();
            judul_login = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cb_showPassword
            // 
            cb_showPassword.AutoSize = true;
            cb_showPassword.Font = new Font("Century Gothic", 9.2F, FontStyle.Bold, GraphicsUnit.Point);
            cb_showPassword.ForeColor = SystemColors.ControlDarkDark;
            cb_showPassword.Location = new Point(440, 255);
            cb_showPassword.Margin = new Padding(3, 2, 3, 2);
            cb_showPassword.Name = "cb_showPassword";
            cb_showPassword.Size = new Size(123, 20);
            cb_showPassword.TabIndex = 15;
            cb_showPassword.Text = "Show Password";
            cb_showPassword.UseVisualStyleBackColor = true;
            cb_showPassword.CheckedChanged += cb_showPassword_CheckedChanged;
            // 
            // txt_password
            // 
            txt_password.BackColor = Color.WhiteSmoke;
            txt_password.BorderStyle = BorderStyle.None;
            txt_password.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_password.Location = new Point(440, 210);
            txt_password.Margin = new Padding(3, 2, 3, 2);
            txt_password.Multiline = true;
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(332, 32);
            txt_password.TabIndex = 14;
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_password.Location = new Point(438, 186);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(70, 17);
            lbl_password.TabIndex = 13;
            lbl_password.Text = "Password";
            // 
            // txt_username
            // 
            txt_username.BackColor = Color.WhiteSmoke;
            txt_username.BorderStyle = BorderStyle.None;
            txt_username.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_username.Location = new Point(440, 144);
            txt_username.Margin = new Padding(3, 2, 3, 2);
            txt_username.Multiline = true;
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(332, 32);
            txt_username.TabIndex = 12;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_username.Location = new Point(438, 120);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(76, 17);
            lbl_username.TabIndex = 11;
            lbl_username.Text = "Username";
            // 
            // subjudul_login
            // 
            subjudul_login.AutoSize = true;
            subjudul_login.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            subjudul_login.ForeColor = SystemColors.ControlDark;
            subjudul_login.Location = new Point(438, 63);
            subjudul_login.Name = "subjudul_login";
            subjudul_login.Size = new Size(120, 16);
            subjudul_login.TabIndex = 10;
            subjudul_login.Text = "Catatan Pelanggan";
            // 
            // judul_login
            // 
            judul_login.AutoSize = true;
            judul_login.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            judul_login.Location = new Point(438, 42);
            judul_login.Name = "judul_login";
            judul_login.Size = new Size(154, 23);
            judul_login.TabIndex = 9;
            judul_login.Text = "Starbucks Login";
            // 
            // button1
            // 
            button1.ForeColor = Color.Green;
            button1.Location = new Point(27, 388);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 16;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(27, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(363, 320);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.SeaGreen;
            button2.ForeColor = Color.Cornsilk;
            button2.Location = new Point(438, 280);
            button2.Name = "button2";
            button2.Size = new Size(334, 44);
            button2.TabIndex = 18;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(cb_showPassword);
            Controls.Add(txt_password);
            Controls.Add(lbl_password);
            Controls.Add(txt_username);
            Controls.Add(lbl_username);
            Controls.Add(subjudul_login);
            Controls.Add(judul_login);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Form1";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cb_showPassword;
        private TextBox txt_password;
        private Label lbl_password;
        private TextBox txt_username;
        private Label lbl_username;
        private Label subjudul_login;
        private Label judul_login;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
    }
}