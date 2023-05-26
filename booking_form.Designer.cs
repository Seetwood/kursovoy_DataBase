namespace test1
{
    partial class booking_form
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
            this.comboBox_property = new System.Windows.Forms.ComboBox();
            this.check_in_date = new System.Windows.Forms.DateTimePicker();
            this.eviction_date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.final_price = new System.Windows.Forms.Label();
            this.priceFrom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.priceUp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rating = new System.Windows.Forms.CheckBox();
            this.checkedListBox_city = new System.Windows.Forms.CheckedListBox();
            this.input_filter = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.checkedListBox_service = new System.Windows.Forms.CheckedListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.housingTable = new System.Windows.Forms.DataGridView();
            this.property_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_of_the_property = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_per_day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_service = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rent_a_property = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.housingTable)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_property
            // 
            this.comboBox_property.BackColor = System.Drawing.Color.White;
            this.comboBox_property.FormattingEnabled = true;
            this.comboBox_property.Location = new System.Drawing.Point(13, 197);
            this.comboBox_property.Name = "comboBox_property";
            this.comboBox_property.Size = new System.Drawing.Size(179, 28);
            this.comboBox_property.TabIndex = 3;
            // 
            // check_in_date
            // 
            this.check_in_date.Location = new System.Drawing.Point(15, 68);
            this.check_in_date.Name = "check_in_date";
            this.check_in_date.Size = new System.Drawing.Size(179, 27);
            this.check_in_date.TabIndex = 4;
            // 
            // eviction_date
            // 
            this.eviction_date.Location = new System.Drawing.Point(14, 122);
            this.eviction_date.Name = "eviction_date";
            this.eviction_date.Size = new System.Drawing.Size(179, 27);
            this.eviction_date.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Дата заселения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Дата выселения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Тип недвижимости";
            // 
            // final_price
            // 
            this.final_price.AutoSize = true;
            this.final_price.Location = new System.Drawing.Point(277, 383);
            this.final_price.Name = "final_price";
            this.final_price.Size = new System.Drawing.Size(57, 20);
            this.final_price.TabIndex = 9;
            this.final_price.Text = "Итого: ";
            // 
            // priceFrom
            // 
            this.priceFrom.Location = new System.Drawing.Point(12, 260);
            this.priceFrom.Name = "priceFrom";
            this.priceFrom.Size = new System.Drawing.Size(75, 27);
            this.priceFrom.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "-";
            // 
            // priceUp
            // 
            this.priceUp.Location = new System.Drawing.Point(117, 260);
            this.priceUp.Name = "priceUp";
            this.priceUp.Size = new System.Drawing.Size(75, 27);
            this.priceUp.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Цена за сутки";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "руб";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Удобства";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(89, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "ФИЛЬТР";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.rating);
            this.panel1.Controls.Add(this.checkedListBox_city);
            this.panel1.Controls.Add(this.input_filter);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.checkedListBox_service);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.check_in_date);
            this.panel1.Controls.Add(this.eviction_date);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.comboBox_property);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.priceUp);
            this.panel1.Controls.Add(this.priceFrom);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(1, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 472);
            this.panel1.TabIndex = 21;
            // 
            // rating
            // 
            this.rating.AutoSize = true;
            this.rating.Location = new System.Drawing.Point(14, 303);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(152, 24);
            this.rating.TabIndex = 24;
            this.rating.Text = "Высокий рейтинг";
            this.rating.UseVisualStyleBackColor = true;
            this.rating.CheckedChanged += new System.EventHandler(this.rating_CheckedChanged);
            // 
            // checkedListBox_city
            // 
            this.checkedListBox_city.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.checkedListBox_city.FormattingEnabled = true;
            this.checkedListBox_city.Location = new System.Drawing.Point(10, 469);
            this.checkedListBox_city.Name = "checkedListBox_city";
            this.checkedListBox_city.Size = new System.Drawing.Size(175, 70);
            this.checkedListBox_city.TabIndex = 24;
            // 
            // input_filter
            // 
            this.input_filter.Location = new System.Drawing.Point(36, 599);
            this.input_filter.Name = "input_filter";
            this.input_filter.Size = new System.Drawing.Size(163, 29);
            this.input_filter.TabIndex = 21;
            this.input_filter.Text = "Применить фильтры";
            this.input_filter.UseVisualStyleBackColor = true;
            this.input_filter.Click += new System.EventHandler(this.input_filter_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 446);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Города";
            // 
            // checkedListBox_service
            // 
            this.checkedListBox_service.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.checkedListBox_service.FormattingEnabled = true;
            this.checkedListBox_service.Location = new System.Drawing.Point(9, 358);
            this.checkedListBox_service.Name = "checkedListBox_service";
            this.checkedListBox_service.Size = new System.Drawing.Size(175, 70);
            this.checkedListBox_service.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(269, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Доступное жилье";
            // 
            // housingTable
            // 
            this.housingTable.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.housingTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.housingTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.property_id,
            this.name_of_the_property,
            this.city,
            this.price_per_day,
            this.name_service,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewButtonColumn1});
            this.housingTable.Location = new System.Drawing.Point(267, 33);
            this.housingTable.Name = "housingTable";
            this.housingTable.RowHeadersWidth = 51;
            this.housingTable.RowTemplate.Height = 29;
            this.housingTable.Size = new System.Drawing.Size(927, 331);
            this.housingTable.TabIndex = 23;
            this.housingTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.housingTable_CellContentClick);
            // 
            // property_id
            // 
            this.property_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.property_id.HeaderText = "ID недвижимости";
            this.property_id.MinimumWidth = 6;
            this.property_id.Name = "property_id";
            // 
            // name_of_the_property
            // 
            this.name_of_the_property.HeaderText = "Наименование недвижимости";
            this.name_of_the_property.MinimumWidth = 6;
            this.name_of_the_property.Name = "name_of_the_property";
            this.name_of_the_property.Width = 125;
            // 
            // city
            // 
            this.city.HeaderText = "Город";
            this.city.MinimumWidth = 6;
            this.city.Name = "city";
            this.city.Width = 133;
            // 
            // price_per_day
            // 
            this.price_per_day.HeaderText = "Цена за 1 день";
            this.price_per_day.MinimumWidth = 6;
            this.price_per_day.Name = "price_per_day";
            this.price_per_day.Width = 125;
            // 
            // name_service
            // 
            this.name_service.HeaderText = "Наименование услуги";
            this.name_service.Items.AddRange(new object[] {
            "Показать всё"});
            this.name_service.MinimumWidth = 6;
            this.name_service.Name = "name_service";
            this.name_service.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.FillWeight = 80F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Рейтинг";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Бронирование";
            this.dataGridViewButtonColumn1.MinimumWidth = 6;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Text = "Выбрать";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn1.Width = 125;
            // 
            // rent_a_property
            // 
            this.rent_a_property.Location = new System.Drawing.Point(277, 421);
            this.rent_a_property.Name = "rent_a_property";
            this.rent_a_property.Size = new System.Drawing.Size(113, 38);
            this.rent_a_property.TabIndex = 25;
            this.rent_a_property.Text = "Арендовать";
            this.rent_a_property.UseVisualStyleBackColor = true;
            this.rent_a_property.Click += new System.EventHandler(this.rent_a_property_Click);
            // 
            // booking_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1194, 483);
            this.Controls.Add(this.rent_a_property);
            this.Controls.Add(this.housingTable);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.final_price);
            this.MaximumSize = new System.Drawing.Size(1212, 530);
            this.MinimumSize = new System.Drawing.Size(1212, 530);
            this.Name = "booking_form";
            this.Text = "booking_form";
            this.Load += new System.EventHandler(this.booking_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.housingTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox comboBox_property;
        private DateTimePicker check_in_date;
        private DateTimePicker eviction_date;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label final_price;
        private TextBox priceFrom;
        private Label label5;
        private TextBox priceUp;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Panel panel1;
        private Button input_filter;
        private Label label10;
        private DataGridView housingTable;
        private CheckedListBox checkedListBox_city;
        private Label label11;
        private CheckedListBox checkedListBox_service;
        private CheckBox rating;
        private Button rent_a_property;
        private DataGridViewTextBoxColumn property_id;
        private DataGridViewTextBoxColumn name_of_the_property;
        private DataGridViewTextBoxColumn city;
        private DataGridViewTextBoxColumn price_per_day;
        private DataGridViewComboBoxColumn name_service;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
    }
}