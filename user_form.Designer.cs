namespace test1
{
    partial class user_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user_form));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonEditData = new System.Windows.Forms.Label();
            this.buttonDeleteAcc = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.edit_birthDay = new System.Windows.Forms.DateTimePicker();
            this.clear_historyBooking = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ЛИЧНЫЕ ДАННЫЕ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ваш логин";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Фамилия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Имя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Отчество";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Дата рождения";
            // 
            // buttonEditData
            // 
            this.buttonEditData.AutoSize = true;
            this.buttonEditData.Location = new System.Drawing.Point(293, 289);
            this.buttonEditData.Name = "buttonEditData";
            this.buttonEditData.Size = new System.Drawing.Size(78, 20);
            this.buttonEditData.TabIndex = 7;
            this.buttonEditData.Text = "Изменить";
            this.buttonEditData.Click += new System.EventHandler(this.buttonEditData_Click);
            this.buttonEditData.MouseEnter += new System.EventHandler(this.buttonEditData_MouseEnter);
            this.buttonEditData.MouseLeave += new System.EventHandler(this.buttonEditData_MouseLeave);
            // 
            // buttonDeleteAcc
            // 
            this.buttonDeleteAcc.AutoSize = true;
            this.buttonDeleteAcc.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteAcc.Location = new System.Drawing.Point(271, 309);
            this.buttonDeleteAcc.Name = "buttonDeleteAcc";
            this.buttonDeleteAcc.Size = new System.Drawing.Size(114, 17);
            this.buttonDeleteAcc.TabIndex = 8;
            this.buttonDeleteAcc.Text = "удалить аккаунт";
            this.buttonDeleteAcc.Click += new System.EventHandler(this.buttonDeleteAcc_Click);
            this.buttonDeleteAcc.MouseEnter += new System.EventHandler(this.buttonDeleteAcc_MouseEnter);
            this.buttonDeleteAcc.MouseLeave += new System.EventHandler(this.buttonDeleteAcc_MouseLeave);
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxSurname.Location = new System.Drawing.Point(123, 146);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(108, 27);
            this.textBoxSurname.TabIndex = 9;
            this.textBoxSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSurname_KeyPress);
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxName.Location = new System.Drawing.Point(123, 187);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(108, 27);
            this.textBoxName.TabIndex = 10;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxPatronymic.Location = new System.Drawing.Point(123, 223);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(108, 27);
            this.textBoxPatronymic.TabIndex = 11;
            this.textBoxPatronymic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPatronymic_KeyPress);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.AutoSize = true;
            this.textBoxLogin.Location = new System.Drawing.Point(123, 57);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(83, 20);
            this.textBoxLogin.TabIndex = 13;
            this.textBoxLogin.Text = "Ваш логин";
            // 
            // textBoxPass
            // 
            this.textBoxPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxPass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxPass.Location = new System.Drawing.Point(123, 88);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(108, 27);
            this.textBoxPass.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(261, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // edit_birthDay
            // 
            this.edit_birthDay.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.edit_birthDay.CalendarTitleBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.edit_birthDay.CustomFormat = "yyyy-MM-dd";
            this.edit_birthDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.edit_birthDay.Location = new System.Drawing.Point(121, 266);
            this.edit_birthDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edit_birthDay.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.edit_birthDay.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.edit_birthDay.Name = "edit_birthDay";
            this.edit_birthDay.Size = new System.Drawing.Size(110, 27);
            this.edit_birthDay.TabIndex = 16;
            // 
            // clear_historyBooking
            // 
            this.clear_historyBooking.Location = new System.Drawing.Point(47, 303);
            this.clear_historyBooking.Name = "clear_historyBooking";
            this.clear_historyBooking.Size = new System.Drawing.Size(159, 29);
            this.clear_historyBooking.TabIndex = 17;
            this.clear_historyBooking.Text = "Очистить историю";
            this.clear_historyBooking.UseVisualStyleBackColor = true;
            this.clear_historyBooking.Click += new System.EventHandler(this.clear_historyBooking_Click);
            // 
            // user_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(402, 333);
            this.Controls.Add(this.clear_historyBooking);
            this.Controls.Add(this.edit_birthDay);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxPatronymic);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.buttonDeleteAcc);
            this.Controls.Add(this.buttonEditData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(420, 380);
            this.Name = "user_form";
            this.Text = "user_form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label buttonEditData;
        private Label buttonDeleteAcc;
        private TextBox textBoxSurname;
        private TextBox textBoxName;
        private TextBox textBoxPatronymic;
        private Label textBoxLogin;
        private TextBox textBoxPass;
        private PictureBox pictureBox1;
        private DateTimePicker edit_birthDay;
        private Button clear_historyBooking;
    }
}