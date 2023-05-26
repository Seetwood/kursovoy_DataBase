namespace test1
{
    partial class login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.input_login = new System.Windows.Forms.TextBox();
            this.label_pass = new System.Windows.Forms.Label();
            this.input_pass = new System.Windows.Forms.TextBox();
            this.label_login = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.login_acc = new System.Windows.Forms.Button();
            this.reg_button = new System.Windows.Forms.Label();
            this.show_pass = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 433);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.input_login);
            this.panel2.Controls.Add(this.label_pass);
            this.panel2.Controls.Add(this.input_pass);
            this.panel2.Controls.Add(this.label_login);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.login_acc);
            this.panel2.Controls.Add(this.reg_button);
            this.panel2.Controls.Add(this.show_pass);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(622, 433);
            this.panel2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Courier New", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(80, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(464, 47);
            this.label2.TabIndex = 11;
            this.label2.Text = "АВТОРИЗАЦИЯ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_login
            // 
            this.input_login.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input_login.Location = new System.Drawing.Point(223, 129);
            this.input_login.Name = "input_login";
            this.input_login.Size = new System.Drawing.Size(201, 38);
            this.input_login.TabIndex = 1;
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Location = new System.Drawing.Point(224, 185);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(62, 20);
            this.label_pass.TabIndex = 10;
            this.label_pass.Text = "Пароль";
            // 
            // input_pass
            // 
            this.input_pass.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input_pass.Location = new System.Drawing.Point(224, 209);
            this.input_pass.Name = "input_pass";
            this.input_pass.Size = new System.Drawing.Size(201, 38);
            this.input_pass.TabIndex = 2;
            this.input_pass.UseSystemPasswordChar = true;
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Location = new System.Drawing.Point(46, -15);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(52, 20);
            this.label_login.TabIndex = 9;
            this.label_login.Text = "Логин";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::test1.Properties.Resources.password;
            this.pictureBox2.Location = new System.Drawing.Point(141, 191);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::test1.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(143, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // login_acc
            // 
            this.login_acc.BackColor = System.Drawing.Color.Green;
            this.login_acc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_acc.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login_acc.Location = new System.Drawing.Point(242, 294);
            this.login_acc.Name = "login_acc";
            this.login_acc.Size = new System.Drawing.Size(158, 63);
            this.login_acc.TabIndex = 5;
            this.login_acc.Text = "Войти";
            this.login_acc.UseVisualStyleBackColor = false;
            this.login_acc.Click += new System.EventHandler(this.login_acc_Click);
            // 
            // reg_button
            // 
            this.reg_button.AutoSize = true;
            this.reg_button.BackColor = System.Drawing.Color.Gray;
            this.reg_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reg_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reg_button.Location = new System.Drawing.Point(267, 360);
            this.reg_button.Name = "reg_button";
            this.reg_button.Size = new System.Drawing.Size(105, 20);
            this.reg_button.TabIndex = 7;
            this.reg_button.Text = "Нет аккаунта?";
            this.reg_button.Click += new System.EventHandler(this.reg_button_Click);
            this.reg_button.MouseEnter += new System.EventHandler(this.reg_button_MouseEnter);
            this.reg_button.MouseLeave += new System.EventHandler(this.reg_button_MouseLeave);
            // 
            // show_pass
            // 
            this.show_pass.AutoSize = true;
            this.show_pass.Location = new System.Drawing.Point(434, 219);
            this.show_pass.Name = "show_pass";
            this.show_pass.Size = new System.Drawing.Size(150, 24);
            this.show_pass.TabIndex = 6;
            this.show_pass.Text = "Показать пароль";
            this.show_pass.UseVisualStyleBackColor = true;
            this.show_pass.CheckedChanged += new System.EventHandler(this.show_pass_CheckedChanged);
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "login_form";
            this.Text = "login_form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.login_form_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private TextBox input_pass;
        private TextBox input_login;
        private Button login_acc;
        private CheckBox show_pass;
        private Label reg_button;
        private PictureBox pictureBox1;
        private Label label_pass;
        private Label label_login;
        private Panel panel2;
        private Label label2;
    }
}