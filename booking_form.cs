using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test1.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace test1
{
    public partial class booking_form : Form
    {
        private BD bd = null;
        private NpgsqlDataAdapter adapter = null;
        private NpgsqlCommand command = null;

        public booking_form()
        {
            InitializeComponent();
            this.Text = "Бронирование";
        }

        private void booking_form_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            try
            {
                BD bd = new BD();
                bd.OpenConnection(); // открывем соединение c БД

                string querry_property = "SELECT DISTINCT name_of_the_property FROM property"; // запрос к таблице "Недвижимость"
                command = new NpgsqlCommand(querry_property, bd.GetConnection()); // выполнение запроса
                command.CommandType = CommandType.Text;
                adapter = new NpgsqlDataAdapter(command);
                // заполнение фильтра "Тип недвижимости" из базы данных
                DataTable table_property = new DataTable();
                adapter.Fill(table_property);
                comboBox_property.DisplayMember = "name_of_the_property";
                comboBox_property.ValueMember = "property_id";
                comboBox_property.DataSource = table_property;

                string querry_city = "SELECT DISTINCT city FROM property"; // запрос к таблице "Недвижимость"
                command = new NpgsqlCommand(querry_city, bd.GetConnection()); // выполнение запроса
                //command.CommandType = CommandType.Text;
                adapter = new NpgsqlDataAdapter(command);
                // заполнение фильтра "Город" из базы данных
                DataTable table_city = new DataTable();
                adapter.Fill(table_city);
                checkedListBox_city.ValueMember = "property_id";
                checkedListBox_city.DataSource = table_city;
                checkedListBox_city.DisplayMember = "city";

                // заполнение фильтра "Удобства" из базы данных
                string querry_services = "SELECT name_service FROM \"additional services\""; // запрос к таблице "Дополнительные услуги"
                command = new NpgsqlCommand(querry_services, bd.GetConnection()); // выполнение запроса
                List<string> list = new List<string>();
                command.CommandType = CommandType.Text;
                adapter = new NpgsqlDataAdapter(command);
                DataTable table1_services = new DataTable();
                adapter.Fill(table1_services);
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                    list.Add(reader.GetString(0));
                for (int i = 0; i < list.Count; i++)
                    checkedListBox_service.Items.Add(list[i]);
                reader.Close();

                // устанавливаем минимальное значение и максимальное из БД
                string querry_price_min = "SELECT MIN(property.price_per_day) FROM property";
                command = new NpgsqlCommand(querry_price_min, bd.GetConnection());
                priceFrom.Text = command.ExecuteScalar().ToString();

                string querry_price_max = "SELECT MAX(property.price_per_day) FROM property";
                command = new NpgsqlCommand(querry_price_max, bd.GetConnection());
                priceUp.Text = command.ExecuteScalar().ToString();

                bd.CloseConnection();  // закрываем соединение к БД
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // фильтрация данных по рейтингу
        private string hight_rating = "";
        private void rating_CheckedChanged(object sender, EventArgs e)
        {
            if (rating.Checked) // если пользователь выбрал "Высокий рейтинг"
                hight_rating = "GROUP BY property.property_id HAVING rating > 4";
            else
                hight_rating = "";
        }

        private int dayCount; // количество дней проживания
        // применение фильтров
        private void input_filter_Click(object sender, EventArgs e)
        {
            try
            {
                bd = new BD(); // создание экземпляра класса БД
                bd.OpenConnection();

                //Срок аренды недвижимости
                DateTime day1 = check_in_date.Value; // дата заселения
                DateTime day2 = eviction_date.Value; // дата выселения

                TimeSpan x = day2 - day1; // нахождение разницы
                if (Convert.ToInt64(((int)x.TotalDays).ToString()) > 20 || Convert.ToInt64(((int)x.TotalDays).ToString()) < 0 || check_in_date.Value.Date == eviction_date.Value.Date)
                {
                    MessageBox.Show("Невозможно арендовать на такой срок", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dayCount = Convert.ToInt32(x.Days.ToString()) + 1;

  
                //////////////////////////
                string filter_service = null;
                foreach (string s in checkedListBox_service.CheckedItems)
                    filter_service +="\"additional services\" = " + s + " AND ";
                //////////////////////////
                

                string priceFilter = " AND price_per_day BETWEEN " + priceFrom.Text + " AND " + priceUp.Text + ";";

                command.Parameters.Add("@input_fk_property", NpgsqlTypes.NpgsqlDbType.Integer).Value = rent_property_id;
                command.Parameters.Add("@input_check_in_date", NpgsqlTypes.NpgsqlDbType.Date).Value = check_in_date.Value.Date;
                command.Parameters.Add("@input_eviction_date", NpgsqlTypes.NpgsqlDbType.Date).Value = eviction_date.Value.Date;

                housingTable.Rows.Clear();
                string querry = "SELECT *FROM property WHERE name_of_the_property ='" + comboBox_property.Text + "' " + priceFilter + hight_rating;
                adapter = new NpgsqlDataAdapter(querry, bd.GetConnection());
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                NpgsqlDataAdapter adapter1;
                DataTable dt1;

                ArrayList arrayList = new ArrayList();

                foreach (DataRow item in dt.Rows)
                {
                    int n = housingTable.Rows.Add();
                    DataGridViewComboBoxCell cellСomboBox = new DataGridViewComboBoxCell();
                    housingTable.Rows[n].Cells[0].Value = item["property_id"].ToString();  // заполнение столбца "ID недвижимости"
                    housingTable.Rows[n].Cells[1].Value = item["name_of_the_property"].ToString();  // заполнение столбца "Наименование недвижимости"
                    housingTable.Rows[n].Cells[2].Value = item["city"].ToString();  // заполнение столбца "Город"
                    housingTable.Rows[n].Cells[3].Value = item["price_per_day"].ToString();  // заполнение столбца "Цена за 1 день"
                    string querry_nameService = "SELECT name_service, property_additionalservices.property_id, property.property_id FROM property_additionalservices INNER JOIN \"additional services\" ON property_additionalservices.service_id = \"additional services\".service_id INNER JOIN \"property\" ON property_additionalservices.property_id = \"property\".property_id WHERE property_additionalservices.property_id =" + item["property_id"].ToString();
                    adapter1 = new NpgsqlDataAdapter(querry_nameService, bd.GetConnection());
                    dt1 = new DataTable();
                    adapter1.Fill(dt1);

                    arrayList.Clear(); // очищаем массив строк перед новым comboBox
                    arrayList.Add("Показать всё");
                    foreach (DataRow item1 in dt1.Rows)
                    {
                        arrayList.Add(item1["name_service"].ToString());
                    }
                    cellСomboBox.DataSource = arrayList;

                    housingTable.Rows[n].Cells[4] = cellСomboBox; // заполняем ячейку comboBox данными
                    cellСomboBox.Value = cellСomboBox.Items[0].ToString(); // делаем первый элемент comboBox выбранным
                    housingTable.Rows[n].Cells[5].Value = item["rating"].ToString(); // заполнение столбца "Рейтинг"
                }
                housingTable.Refresh();
                bd.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int rent_property_id = 0;
        private void housingTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = housingTable.Rows[e.RowIndex];
                if (housingTable[e.ColumnIndex, e.RowIndex].Value == "Выбрать")
                {
                    final_price.Text = "Итого:  " + Convert.ToString(Convert.ToInt32(housingTable[3, e.RowIndex].Value) * dayCount) + "₽";
                    rent_property_id = Convert.ToInt32(housingTable.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("При выборе недвижимости произошла ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rent_a_property_Click(object sender, EventArgs e)
        {
            if(rent_property_id == 0)
            {
                MessageBox.Show("Вы не выбрали недвижимость для бронирования", "Ошибкa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (checkbooking())
            {
                return;
            }
            try
            {
                if (MessageBox.Show("Забронировать недвижимость?", "Бронирование", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            == DialogResult.Yes)
                {
                    bd = new BD();
                    bd.OpenConnection();
                    string querry_booking = "CALL insert_new_booking(@login, @check_in_date, @eviction_date, @property)";
                    NpgsqlCommand command = new NpgsqlCommand(querry_booking, bd.GetConnection());

                    command.Parameters.Add("@login", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Settings.Default["login_user"].ToString();
                    command.Parameters.Add("@check_in_date", NpgsqlTypes.NpgsqlDbType.Date).Value = check_in_date.Value.Date;
                    command.Parameters.Add("@eviction_date", NpgsqlTypes.NpgsqlDbType.Date).Value = eviction_date.Value.Date;
                    command.Parameters.Add("@property", NpgsqlTypes.NpgsqlDbType.Integer).Value = rent_property_id;
                    if (command.ExecuteNonQuery() == 1) // если команда успешно выполнилась
                    {
                        MessageBox.Show("Произошла ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else 
                        MessageBox.Show("Вы успешно забронировали недвижимость", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    bd.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Boolean checkbooking()
        {
            BD bd = new BD();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable table = new DataTable();

            string querry = "SELECT checking_the_date(@input_old_data1,@input_old_data2, @input_new_data1, @input_new_data2, @input_fk_property) WHERE checking_the_date(@input_old_data1,@input_old_data2, @input_new_data1, @input_new_data2, @input_fk_property) = true";
            NpgsqlCommand command = new NpgsqlCommand(querry, bd.GetConnection());
            command.Parameters.Add("@input_fk_property", NpgsqlTypes.NpgsqlDbType.Integer).Value = rent_property_id;
            command.Parameters.Add("@input_old_data1", NpgsqlTypes.NpgsqlDbType.Date).Value = check_in_date.Value.Date;
            command.Parameters.Add("@input_old_data2", NpgsqlTypes.NpgsqlDbType.Date).Value = eviction_date.Value.Date;
            command.Parameters.Add("@input_new_data1", NpgsqlTypes.NpgsqlDbType.Date).Value = check_in_date.Value.Date;
            command.Parameters.Add("@input_new_data2", NpgsqlTypes.NpgsqlDbType.Date).Value = eviction_date.Value.Date;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("На данный период недвижимость уже забронирована", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
