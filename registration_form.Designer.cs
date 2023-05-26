namespace test1
{
    partial class registration_form
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label_surname = new System.Windows.Forms.Label();
            this.log_button = new System.Windows.Forms.Label();
            this.input_surname = new System.Windows.Forms.TextBox();
            this.label_pass = new System.Windows.Forms.Label();
            this.input_patronymic = new System.Windows.Forms.TextBox();
            this.label_login = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_birthDay = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_patronymic = new System.Windows.Forms.Label();
            this.reg_acc = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.show_pass = new System.Windows.Forms.CheckBox();
            this.input_name = new System.Windows.Forms.TextBox();
            this.input_birthDay = new System.Windows.Forms.DateTimePicker();
            this.input_login = new System.Windows.Forms.TextBox();
            this.input_pass = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 453);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label_surname);
            this.panel2.Controls.Add(this.log_button);
            this.panel2.Controls.Add(this.input_surname);
            this.panel2.Controls.Add(this.label_pass);
            this.panel2.Controls.Add(this.input_patronymic);
            this.panel2.Controls.Add(this.label_login);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label_birthDay);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label_patronymic);
            this.panel2.Controls.Add(this.reg_acc);
            this.panel2.Controls.Add(this.label_name);
            this.panel2.Controls.Add(this.show_pass);
            this.panel2.Controls.Add(this.input_name);
            this.panel2.Controls.Add(this.input_birthDay);
            this.panel2.Controls.Add(this.input_login);
            this.panel2.Controls.Add(this.input_pass);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 459);
            this.panel2.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Courier New", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(76, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(622, 47);
            this.label2.TabIndex = 21;
            this.label2.Text = "РЕГИСТРАЦИЯ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Location = new System.Drawing.Point(70, 65);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(73, 20);
            this.label_surname.TabIndex = 14;
            this.label_surname.Text = "Фамилия";
            // 
            // log_button
            // 
            this.log_button.AutoSize = true;
            this.log_button.BackColor = System.Drawing.Color.Gray;
            this.log_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.log_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_button.Location = new System.Drawing.Point(330, 424);
            this.log_button.Name = "log_button";
            this.log_button.Size = new System.Drawing.Size(101, 20);
            this.log_button.TabIndex = 20;
            this.log_button.Text = "Есть аккаунт?";
            this.log_button.Click += new System.EventHandler(this.log_button_Click);
            this.log_button.MouseEnter += new System.EventHandler(this.log_button_MouseEnter);
            this.log_button.MouseLeave += new System.EventHandler(this.log_button_MouseLeave);
            // 
            // input_surname
            // 
            this.input_surname.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input_surname.Location = new System.Drawing.Point(70, 88);
            this.input_surname.Name = "input_surname";
            this.input_surname.Size = new System.Drawing.Size(201, 38);
            this.input_surname.TabIndex = 1;
            this.input_surname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_surname_KeyPress);
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Location = new System.Drawing.Point(418, 152);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(62, 20);
            this.label_pass.TabIndex = 19;
            this.label_pass.Text = "Пароль";
            // 
            // input_patronymic
            // 
            this.input_patronymic.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input_patronymic.Location = new System.Drawing.Point(70, 238);
            this.input_patronymic.Name = "input_patronymic";
            this.input_patronymic.Size = new System.Drawing.Size(201, 38);
            this.input_patronymic.TabIndex = 2;
            this.input_patronymic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_patronymic_KeyPress);
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Location = new System.Drawing.Point(418, 65);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(52, 20);
            this.label_login.TabIndex = 18;
            this.label_login.Text = "Логин";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::test1.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(350, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label_birthDay
            // 
            this.label_birthDay.AutoSize = true;
            this.label_birthDay.Location = new System.Drawing.Point(70, 291);
            this.label_birthDay.Name = "label_birthDay";
            this.label_birthDay.Size = new System.Drawing.Size(116, 20);
            this.label_birthDay.TabIndex = 17;
            this.label_birthDay.Text = "Дата рождения";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::test1.Properties.Resources.password;
            this.pictureBox2.Location = new System.Drawing.Point(351, 168);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label_patronymic
            // 
            this.label_patronymic.AutoSize = true;
            this.label_patronymic.Location = new System.Drawing.Point(70, 215);
            this.label_patronymic.Name = "label_patronymic";
            this.label_patronymic.Size = new System.Drawing.Size(192, 20);
            this.label_patronymic.TabIndex = 16;
            this.label_patronymic.Text = "Отчество (необязательно)";
            // 
            // reg_acc
            // 
            this.reg_acc.BackColor = System.Drawing.Color.Green;
            this.reg_acc.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reg_acc.Location = new System.Drawing.Point(226, 357);
            this.reg_acc.Name = "reg_acc";
            this.reg_acc.Size = new System.Drawing.Size(310, 62);
            this.reg_acc.TabIndex = 5;
            this.reg_acc.Text = "Зарегистрироваться";
            this.reg_acc.UseVisualStyleBackColor = false;
            this.reg_acc.Click += new System.EventHandler(this.reg_acc_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(70, 135);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(39, 20);
            this.label_name.TabIndex = 15;
            this.label_name.Text = "Имя";
            // 
            // show_pass
            // 
            this.show_pass.AutoSize = true;
            this.show_pass.Location = new System.Drawing.Point(625, 182);
            this.show_pass.Name = "show_pass";
            this.show_pass.Size = new System.Drawing.Size(150, 24);
            this.show_pass.TabIndex = 6;
            this.show_pass.Text = "Показать пароль";
            this.show_pass.UseVisualStyleBackColor = true;
            this.show_pass.CheckedChanged += new System.EventHandler(this.show_pass_CheckedChanged);
            // 
            // input_name
            // 
            this.input_name.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input_name.Location = new System.Drawing.Point(70, 158);
            this.input_name.Name = "input_name";
            this.input_name.Size = new System.Drawing.Size(201, 38);
            this.input_name.TabIndex = 8;
            this.input_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_name_KeyPress);
            // 
            // input_birthDay
            // 
            this.input_birthDay.CustomFormat = "yyyy-MM-dd";
            this.input_birthDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.input_birthDay.Location = new System.Drawing.Point(70, 314);
            this.input_birthDay.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.input_birthDay.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.input_birthDay.Name = "input_birthDay";
            this.input_birthDay.Size = new System.Drawing.Size(201, 27);
            this.input_birthDay.TabIndex = 13;
            // 
            // input_login
            // 
            this.input_login.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input_login.Location = new System.Drawing.Point(418, 88);
            this.input_login.Name = "input_login";
            this.input_login.Size = new System.Drawing.Size(201, 38);
            this.input_login.TabIndex = 10;
            // 
            // input_pass
            // 
            this.input_pass.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input_pass.Location = new System.Drawing.Point(418, 175);
            this.input_pass.Name = "input_pass";
            this.input_pass.Size = new System.Drawing.Size(201, 38);
            this.input_pass.TabIndex = 11;
            this.input_pass.UseSystemPasswordChar = true;
            // 
            // registration_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.panel1);
            this.Name = "registration_form";
            this.Text = "registration_form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.registration_form_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox input_name;
        private CheckBox show_pass;
        private Button reg_acc;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox input_patronymic;
        private TextBox input_surname;
        private TextBox input_pass;
        private TextBox input_login;
        private DateTimePicker input_birthDay;
        private Label label_pass;
        private Label label_login;
        private Label label_birthDay;
        private Label label_patronymic;
        private Label label_name;
        private Label label_surname;
        private Label log_button;
        private Panel panel2;
        private Label label2;
    }
}