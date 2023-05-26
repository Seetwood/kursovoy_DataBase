using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test1.Properties;

namespace test1
{
    public partial class admin_panel : Form
    {
        // создаем и инициализируем объекты классов
        private NpgsqlDataAdapter adapter = null;
        private BD bd = null;
        DataTable table = null;

        private int propertyID = 0;
        public admin_panel()
        {
            InitializeComponent();
            loadDataTable();
            loadDataComboBox();
            this.Text = "Окно администрирования"; // изменение названия формы
        }

        private void loadDataComboBox()
        {
            try
            {
                bd = new BD(); // создание экземпляра класса БД
                bd.OpenConnection();
                NpgsqlCommand command = new NpgsqlCommand();
                string querry_property_id = "SELECT property_id FROM property"; // запрос к таблице "Недвижимость"
                command = new NpgsqlCommand(querry_property_id, bd.GetConnection()); // выполнение запроса
                command.CommandType = CommandType.Text;
                adapter = new NpgsqlDataAdapter(command);
                DataTable table_property_id = new DataTable();
                adapter.Fill(table_property_id);
                comboBox_property_id.DisplayMember = "property_id";
                comboBox_property_id.DataSource = table_property_id;
                comboBox_property_id.ValueMember = "property_id";

                string querry_name_service = "SELECT name_service FROM \"additional services\""; // запрос к таблице "Недвижимость"
                command = new NpgsqlCommand(querry_name_service, bd.GetConnection()); // выполнение запроса
                command.CommandType = CommandType.Text;
                adapter = new NpgsqlDataAdapter(command);
                DataTable table_nameService = new DataTable();
                adapter.Fill(table_nameService);
                comboBox_nameServices.ValueMember = "service_id";
                comboBox_nameServices.DataSource = table_nameService;
                comboBox_nameServices.DisplayMember = "name_service";
                bd.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // загрузка данных таблицы
        private void loadDataTable()
        {
            try
            {
                bd = new BD(); // создание экземпляра класса БД
                bd.OpenConnection();
                dataGridProperty.Rows.Clear();
                string querry = "SELECT *FROM property";
                adapter = new NpgsqlDataAdapter(querry, bd.GetConnection());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                NpgsqlDataAdapter adapter1;
                DataTable dt1;
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridProperty.Rows.Add();
                    DataGridViewComboBoxCell cellСomboBox = new DataGridViewComboBoxCell();
                    dataGridProperty.Rows[n].Cells[0].Value = item["property_id"].ToString();  // заполнение столбца "ID недвижимости"
                    dataGridProperty.Rows[n].Cells[1].Value = item["name_of_the_property"].ToString();  // заполнение столбца "Наименование недвижимости"
                    dataGridProperty.Rows[n].Cells[2].Value = item["price_per_day"].ToString();  // заполнение столбца "Цена за 1 день"
                    dataGridProperty.Rows[n].Cells[3].Value = item["city"].ToString();  // заполнение столбца "Город"
                   
                    string querry_nameService = "SELECT name_service, property_additionalservices.property_id, property.property_id FROM property_additionalservices INNER JOIN \"additional services\" ON property_additionalservices.service_id = \"additional services\".service_id INNER JOIN \"property\" ON property_additionalservices.property_id = \"property\".property_id WHERE property_additionalservices.property_id =" + item["property_id"].ToString();
                    adapter1 = new NpgsqlDataAdapter(querry_nameService, bd.GetConnection());
                    dt1 = new DataTable();
                    adapter1.Fill(dt1);

                    var arrayList = new List<Tuple<int, string>>();
                    arrayList.Add(Tuple.Create(-1, "Показать всё"));
                    foreach (DataRow item1 in dt1.Rows)
                    {
                        arrayList.Add(Tuple.Create((int)item1["property_id"], item1["name_service"].ToString()));
                    }
                    var cellComboBox = ((DataGridViewComboBoxCell)dataGridProperty.Rows[n].Cells[4]);

                    cellComboBox.DataSource = arrayList;
                    cellComboBox.ValueMember = "Item1";
                    cellComboBox.DisplayMember = "Item2";
                    cellComboBox.Value = arrayList[0].Item1; /// делаем первый элемент comboBox выбранным

                    dataGridProperty.Rows[n].Cells[5].Value = item["rating"].ToString(); // заполнение столбца "Рейтинг"
                }          
                dataGridProperty.Refresh();

                bd.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
    // создание новой услуги
    private void create_service_Click(object sender, EventArgs e)
        {
            try
            {
                BD bd = new BD();
                bd.OpenConnection();
                string querry = "INSERT INTO public.\"additional services\" (name_service) VALUES (@service_name)";

                NpgsqlCommand command = new NpgsqlCommand(querry, bd.GetConnection());
                table = new DataTable();
                adapter = new NpgsqlDataAdapter();
                //устанавливаем значения вместо заглушек
                command.Parameters.Add("@service_name", NpgsqlTypes.NpgsqlDbType.Varchar).Value = textBox_nameServiceCreate.Text;

                if (command.ExecuteNonQuery() == 1)
                {
                    loadDataComboBox();
                    MessageBox.Show("Вы добавили новый тип услуги", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                bd.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // удаление услуги по имени
        private void delete_service_Click(object sender, EventArgs e)
        {
            try
            {
                BD bd = new BD();
                bd.OpenConnection();
                string querry = "DELETE FROM \"additional services\" WHERE name_service = @service_name;";

                NpgsqlCommand command = new NpgsqlCommand(querry, bd.GetConnection());
                table = new DataTable();
                adapter = new NpgsqlDataAdapter();
                //устанавливаем значения вместо заглушек
                command.Parameters.Add("@service_name", NpgsqlTypes.NpgsqlDbType.Varchar).Value = textBox_nameServiceDelete.Text;

                if (command.ExecuteNonQuery() == 1)
                {
                    loadDataComboBox();
                    MessageBox.Show("Вы успешно удалили данную услугу", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                    MessageBox.Show("Данной услуги не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bd.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Нет подключения к базе данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // добавление новой услуги в недвижимость
        private void add_new_service_Click(object sender, EventArgs e)
        {
            try
            {
                BD bd = new BD();
                bd.OpenConnection();
                string querry = "INSERT INTO public.\"property_additionalservices\" (\"property_id\", \"service_id\") VALUES (@property_id, (SELECT \"additional services\".service_id FROM \"additional services\" WHERE name_service = @nameService))";
                NpgsqlCommand command = new NpgsqlCommand(querry, bd.GetConnection());
                table = new DataTable();
                adapter = new NpgsqlDataAdapter();
                //устанавливаем значения вместо заглушек
                command.Parameters.Add("@property_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = Convert.ToInt32(comboBox_property_id.Text);
                command.Parameters.Add("@nameService", NpgsqlTypes.NpgsqlDbType.Varchar).Value = comboBox_nameServices.Text;
                if (command.ExecuteNonQuery() == 1)
                {
                    loadDataTable();
                    MessageBox.Show("Вы успешно удалили данную услугу из недвижимости ID =" + comboBox_property_id.Text, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                bd.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // удаление услуги из недвижимости
        private void delete_serviceProperty_Click(object sender, EventArgs e)
        {
            try
            {
                BD bd = new BD();
                bd.OpenConnection();
                string querry = "DELETE FROM property_additionalservices WHERE property_id = @property_id AND property_additionalservices.service_id IN (SELECT \"additional services\".service_id FROM \"additional services\" WHERE name_service = @nameService)";

                NpgsqlCommand command = new NpgsqlCommand(querry, bd.GetConnection());
                table = new DataTable();
                adapter = new NpgsqlDataAdapter();
                //устанавливаем значения вместо заглушек
                command.Parameters.Add("@property_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = Convert.ToInt32(comboBox_property_id.Text);
                command.Parameters.Add("@nameService", NpgsqlTypes.NpgsqlDbType.Varchar).Value = comboBox_nameServices.Text;
                if (command.ExecuteNonQuery() == 1)
                {
                    loadDataTable();
                    MessageBox.Show("Вы успешно удалили данную услугу из недвижимости ID =" + comboBox_property_id.Text, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                    MessageBox.Show("Данной услуги в недвижимости не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bd.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // добавление новой недвижимости
        private void insertProperty_Click(object sender, EventArgs e)
        {
            try
            {
                bd = new BD();
                bd.OpenConnection();
                string querry_booking = "INSERT INTO public.property (name_of_the_property, price_per_day, city,rating) VALUES (@name_of_the_property, @price_per_day, @city, @rating);";
                NpgsqlCommand command = new NpgsqlCommand(querry_booking, bd.GetConnection());

                command.Parameters.Add("@name_of_the_property", NpgsqlTypes.NpgsqlDbType.Varchar).Value = textBox2.Text;
                command.Parameters.Add("@price_per_day", NpgsqlTypes.NpgsqlDbType.Integer).Value = Convert.ToInt32(textBox3.Text);
                command.Parameters.Add("@city", NpgsqlTypes.NpgsqlDbType.Varchar).Value = textBox4.Text;
                command.Parameters.Add("@rating", NpgsqlTypes.NpgsqlDbType.Integer).Value = Convert.ToInt32(textBox5.Text);
                if (command.ExecuteNonQuery() == 1) // если команда успешно выполнилась
                {
                    MessageBox.Show("Вы добавили новую недвижимость", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    loadDataTable();
                    loadDataComboBox();
                    clearTextBox();
                }
                bd.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // изменение недвижимости
        private void UpdateProperty_Click(object sender, EventArgs e)
        {
            try
            {
                bd = new BD();
                bd.OpenConnection();
                string querry_booking = "UPDATE property SET name_of_the_property = @name_of_the_property, price_per_day = @price_per_day, city = @city, rating = @rating WHERE property_id =  @property_id;";
                NpgsqlCommand command = new NpgsqlCommand(querry_booking, bd.GetConnection());
                command.Parameters.Add("@property_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = propertyID;
                command.Parameters.Add("@name_of_the_property", NpgsqlTypes.NpgsqlDbType.Varchar).Value = textBox2.Text;
                command.Parameters.Add("@price_per_day", NpgsqlTypes.NpgsqlDbType.Integer).Value = Convert.ToInt32(textBox3.Text);
                command.Parameters.Add("@city", NpgsqlTypes.NpgsqlDbType.Varchar).Value = textBox4.Text;
                command.Parameters.Add("@rating", NpgsqlTypes.NpgsqlDbType.Integer).Value = Convert.ToInt32(textBox5.Text);
                if (command.ExecuteNonQuery() == 1) // если команда успешно выполнилась
                {
                    MessageBox.Show("Вы изменили данные текущей недвижимости", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    loadDataTable();
                    loadDataComboBox();
                    clearTextBox();
                }
                bd.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // удаление недвижимости
        private void deleteProperty_Click(object sender, EventArgs e)
        {
            try
            {
                if (propertyID != 0)
                {
                    bd = new BD();
                    bd.OpenConnection();
                    string querry_booking = "DELETE FROM property WHERE property_id = @property_id;";
                    NpgsqlCommand command = new NpgsqlCommand(querry_booking, bd.GetConnection());

                    command.Parameters.Add("@property_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = propertyID;
                    if (command.ExecuteNonQuery() == 1) // если команда успешно выполнилась
                    {
                        MessageBox.Show("Вы успешно удалили запись", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        loadDataTable();
                        loadDataComboBox();
                        clearTextBox();
                    }
                    bd.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // событие при клике на таблицу
        private void dataGridProperty_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            propertyID =Convert.ToInt32(dataGridProperty.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox2.Text = dataGridProperty.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridProperty.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridProperty.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox5.Text = dataGridProperty.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void clearTextBox()
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}