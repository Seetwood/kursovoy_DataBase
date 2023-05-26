namespace test1
{
    partial class admin_panel
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
            this.dataGridProperty = new System.Windows.Forms.DataGridView();
            this.property_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_of_the_property = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_per_day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_service = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_nameServiceCreate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_property_id = new System.Windows.Forms.ComboBox();
            this.comboBox_nameServices = new System.Windows.Forms.ComboBox();
            this.delete_serviceProperty = new System.Windows.Forms.Button();
            this.delete_service = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_nameServiceDelete = new System.Windows.Forms.TextBox();
            this.add_new_service = new System.Windows.Forms.Button();
            this.create_service = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.insertProperty = new System.Windows.Forms.Button();
            this.UpdateProperty = new System.Windows.Forms.Button();
            this.deleteProperty = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProperty)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridProperty
            // 
            this.dataGridProperty.ColumnHeadersHeight = 25;
            this.dataGridProperty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridProperty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.property_id,
            this.name_of_the_property,
            this.price_per_day,
            this.city,
            this.name_service,
            this.rating});
            this.dataGridProperty.Location = new System.Drawing.Point(7, 29);
            this.dataGridProperty.Name = "dataGridProperty";
            this.dataGridProperty.RowHeadersWidth = 51;
            this.dataGridProperty.RowTemplate.Height = 29;
            this.dataGridProperty.Size = new System.Drawing.Size(699, 175);
            this.dataGridProperty.TabIndex = 0;
            this.dataGridProperty.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridProperty_RowHeaderMouseClick);
            // 
            // property_id
            // 
            this.property_id.HeaderText = "Property_id";
            this.property_id.MinimumWidth = 6;
            this.property_id.Name = "property_id";
            this.property_id.Width = 90;
            // 
            // name_of_the_property
            // 
            this.name_of_the_property.HeaderText = "Наименование недвижимости";
            this.name_of_the_property.MinimumWidth = 6;
            this.name_of_the_property.Name = "name_of_the_property";
            this.name_of_the_property.Width = 125;
            // 
            // price_per_day
            // 
            this.price_per_day.HeaderText = "Цена за сутки";
            this.price_per_day.MinimumWidth = 6;
            this.price_per_day.Name = "price_per_day";
            this.price_per_day.Width = 80;
            // 
            // city
            // 
            this.city.HeaderText = "Город";
            this.city.MinimumWidth = 6;
            this.city.Name = "city";
            this.city.Width = 125;
            // 
            // name_service
            // 
            this.name_service.HeaderText = "Список услуг";
            this.name_service.MinimumWidth = 6;
            this.name_service.Name = "name_service";
            this.name_service.Width = 125;
            // 
            // rating
            // 
            this.rating.HeaderText = "Рейтинг";
            this.rating.MinimumWidth = 6;
            this.rating.Name = "rating";
            this.rating.Width = 80;
            // 
            // textBox_nameServiceCreate
            // 
            this.textBox_nameServiceCreate.Location = new System.Drawing.Point(6, 59);
            this.textBox_nameServiceCreate.Name = "textBox_nameServiceCreate";
            this.textBox_nameServiceCreate.Size = new System.Drawing.Size(110, 27);
            this.textBox_nameServiceCreate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Добавление услуги";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "ID недвижимости";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Наименование услуги";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Панель дополнительных услуг";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox_property_id);
            this.panel1.Controls.Add(this.comboBox_nameServices);
            this.panel1.Controls.Add(this.delete_serviceProperty);
            this.panel1.Controls.Add(this.delete_service);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox_nameServiceDelete);
            this.panel1.Controls.Add(this.add_new_service);
            this.panel1.Controls.Add(this.create_service);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox_nameServiceCreate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(7, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 215);
            this.panel1.TabIndex = 16;
            // 
            // comboBox_property_id
            // 
            this.comboBox_property_id.FormattingEnabled = true;
            this.comboBox_property_id.Location = new System.Drawing.Point(239, 59);
            this.comboBox_property_id.Name = "comboBox_property_id";
            this.comboBox_property_id.Size = new System.Drawing.Size(132, 28);
            this.comboBox_property_id.TabIndex = 17;
            // 
            // comboBox_nameServices
            // 
            this.comboBox_nameServices.FormattingEnabled = true;
            this.comboBox_nameServices.Location = new System.Drawing.Point(241, 116);
            this.comboBox_nameServices.Name = "comboBox_nameServices";
            this.comboBox_nameServices.Size = new System.Drawing.Size(130, 28);
            this.comboBox_nameServices.TabIndex = 17;
            // 
            // delete_serviceProperty
            // 
            this.delete_serviceProperty.Location = new System.Drawing.Point(241, 181);
            this.delete_serviceProperty.Name = "delete_serviceProperty";
            this.delete_serviceProperty.Size = new System.Drawing.Size(132, 29);
            this.delete_serviceProperty.TabIndex = 21;
            this.delete_serviceProperty.Text = "Удалить услугу";
            this.delete_serviceProperty.UseVisualStyleBackColor = true;
            this.delete_serviceProperty.Click += new System.EventHandler(this.delete_serviceProperty_Click);
            // 
            // delete_service
            // 
            this.delete_service.Location = new System.Drawing.Point(122, 115);
            this.delete_service.Name = "delete_service";
            this.delete_service.Size = new System.Drawing.Size(76, 29);
            this.delete_service.TabIndex = 20;
            this.delete_service.Text = "Удалить";
            this.delete_service.UseVisualStyleBackColor = true;
            this.delete_service.Click += new System.EventHandler(this.delete_service_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Удаление услуги";
            // 
            // textBox_nameServiceDelete
            // 
            this.textBox_nameServiceDelete.Location = new System.Drawing.Point(6, 116);
            this.textBox_nameServiceDelete.Name = "textBox_nameServiceDelete";
            this.textBox_nameServiceDelete.Size = new System.Drawing.Size(110, 27);
            this.textBox_nameServiceDelete.TabIndex = 18;
            // 
            // add_new_service
            // 
            this.add_new_service.Location = new System.Drawing.Point(241, 146);
            this.add_new_service.Name = "add_new_service";
            this.add_new_service.Size = new System.Drawing.Size(132, 29);
            this.add_new_service.TabIndex = 17;
            this.add_new_service.Text = "Внести услугу";
            this.add_new_service.UseVisualStyleBackColor = true;
            this.add_new_service.Click += new System.EventHandler(this.add_new_service_Click);
            // 
            // create_service
            // 
            this.create_service.Location = new System.Drawing.Point(122, 58);
            this.create_service.Name = "create_service";
            this.create_service.Size = new System.Drawing.Size(76, 29);
            this.create_service.TabIndex = 16;
            this.create_service.Text = "Создать";
            this.create_service.UseVisualStyleBackColor = true;
            this.create_service.Click += new System.EventHandler(this.create_service_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Просмотр и добавление недвижимости";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 18;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(16, 88);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 27);
            this.textBox3.TabIndex = 19;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(16, 127);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 27);
            this.textBox4.TabIndex = 20;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(16, 164);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(125, 27);
            this.textBox5.TabIndex = 21;
            // 
            // insertProperty
            // 
            this.insertProperty.Location = new System.Drawing.Point(162, 64);
            this.insertProperty.Name = "insertProperty";
            this.insertProperty.Size = new System.Drawing.Size(94, 29);
            this.insertProperty.TabIndex = 22;
            this.insertProperty.Text = "Добавить";
            this.insertProperty.UseVisualStyleBackColor = true;
            this.insertProperty.Click += new System.EventHandler(this.insertProperty_Click);
            // 
            // UpdateProperty
            // 
            this.UpdateProperty.Location = new System.Drawing.Point(162, 100);
            this.UpdateProperty.Name = "UpdateProperty";
            this.UpdateProperty.Size = new System.Drawing.Size(94, 29);
            this.UpdateProperty.TabIndex = 23;
            this.UpdateProperty.Text = "Изменить";
            this.UpdateProperty.UseVisualStyleBackColor = true;
            this.UpdateProperty.Click += new System.EventHandler(this.UpdateProperty_Click);
            // 
            // deleteProperty
            // 
            this.deleteProperty.Location = new System.Drawing.Point(162, 136);
            this.deleteProperty.Name = "deleteProperty";
            this.deleteProperty.Size = new System.Drawing.Size(94, 29);
            this.deleteProperty.TabIndex = 24;
            this.deleteProperty.Text = "Удалить";
            this.deleteProperty.UseVisualStyleBackColor = true;
            this.deleteProperty.Click += new System.EventHandler(this.deleteProperty_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.deleteProperty);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.UpdateProperty);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.insertProperty);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Location = new System.Drawing.Point(427, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 215);
            this.panel2.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Панель недвижимости";
            // 
            // admin_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 433);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridProperty);
            this.Name = "admin_panel";
            this.Text = "admin_panel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProperty)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridProperty;
        private TextBox textBox_nameServiceCreate;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label3;
        private Panel panel1;
        private Button add_new_service;
        private Button create_service;
        private Button delete_service;
        private Label label6;
        private TextBox textBox_nameServiceDelete;
        private Button delete_serviceProperty;
        private ComboBox comboBox_nameServices;
        private ComboBox comboBox_property_id;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button insertProperty;
        private Button UpdateProperty;
        private Button deleteProperty;
        private Panel panel2;
        private DataGridViewTextBoxColumn property_id;
        private DataGridViewTextBoxColumn name_of_the_property;
        private DataGridViewTextBoxColumn price_per_day;
        private DataGridViewTextBoxColumn city;
        private DataGridViewComboBoxColumn name_service;
        private DataGridViewTextBoxColumn rating;
        private Label label8;
    }
}