namespace test1
{
    partial class main_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableUsers = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.забронироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зайтиВЛичныйКабинетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.администрированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableUsers)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tableUsers);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 293);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "История бронирования";
            // 
            // tableUsers
            // 
            this.tableUsers.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableUsers.Location = new System.Drawing.Point(0, 66);
            this.tableUsers.Name = "tableUsers";
            this.tableUsers.ReadOnly = true;
            this.tableUsers.RowHeadersWidth = 51;
            this.tableUsers.RowTemplate.Height = 29;
            this.tableUsers.Size = new System.Drawing.Size(930, 194);
            this.tableUsers.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действияToolStripMenuItem,
            this.администрированиеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(922, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьТаблицуToolStripMenuItem,
            this.забронироватьToolStripMenuItem,
            this.зайтиВЛичныйКабинетToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // обновитьТаблицуToolStripMenuItem
            // 
            this.обновитьТаблицуToolStripMenuItem.Name = "обновитьТаблицуToolStripMenuItem";
            this.обновитьТаблицуToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.обновитьТаблицуToolStripMenuItem.Text = "Обновить таблицу";
            this.обновитьТаблицуToolStripMenuItem.Click += new System.EventHandler(this.обновитьТаблицуToolStripMenuItem_Click);
            // 
            // забронироватьToolStripMenuItem
            // 
            this.забронироватьToolStripMenuItem.Name = "забронироватьToolStripMenuItem";
            this.забронироватьToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.забронироватьToolStripMenuItem.Text = "Забронировать";
            this.забронироватьToolStripMenuItem.Click += new System.EventHandler(this.забронироватьToolStripMenuItem_Click);
            // 
            // зайтиВЛичныйКабинетToolStripMenuItem
            // 
            this.зайтиВЛичныйКабинетToolStripMenuItem.Name = "зайтиВЛичныйКабинетToolStripMenuItem";
            this.зайтиВЛичныйКабинетToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.зайтиВЛичныйКабинетToolStripMenuItem.Text = "Зайти в личный кабинет";
            this.зайтиВЛичныйКабинетToolStripMenuItem.Click += new System.EventHandler(this.зайтиВЛичныйКабинетToolStripMenuItem_Click);
            // 
            // администрированиеToolStripMenuItem
            // 
            this.администрированиеToolStripMenuItem.Name = "администрированиеToolStripMenuItem";
            this.администрированиеToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.администрированиеToolStripMenuItem.Text = "Администрирование";
            this.администрированиеToolStripMenuItem.Click += new System.EventHandler(this.администрированиеToolStripMenuItem_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 293);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(940, 340);
            this.Name = "main_form";
            this.Text = "main_form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.main_form_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableUsers)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView tableUsers;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem действияToolStripMenuItem;
        private ToolStripMenuItem обновитьТаблицуToolStripMenuItem;
        private ToolStripMenuItem забронироватьToolStripMenuItem;
        private ToolStripMenuItem зайтиВЛичныйКабинетToolStripMenuItem;
        private ToolStripMenuItem администрированиеToolStripMenuItem;
    }
}