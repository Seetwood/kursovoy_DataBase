using Microsoft.VisualBasic.Logging;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test1.Properties;

namespace test1
{
    public partial class main_form : Form
    {
        // создаем и инициализируем объекты классов
        private NpgsqlCommandBuilder commandBuilder = null;
        private NpgsqlDataAdapter adapter = null;
        private DataSet dataset = null;
        private BD bd = null;
        public main_form()
        {
            InitializeComponent();
            loadData();
            this.Text = "Основное окно"; // изменение названия формы
            //Settings.Default["login_user"] = null;
        }
        private void loadData()
        {
            bd = new BD(); // создание экземпляра класса БД
            bd.OpenConnection();
            string querry = "SELECT surname AS Фамилия, name AS Имя, patronymic AS Отчество, fk_property_id AS \"ID недвижимости\", name_of_the_property AS \"Наименование недвижимости\", \"check-in_date\" AS \"Дата заселения\", \"eviction_date\" AS \"Дата выселения\" FROM booking INNER JOIN users ON users.login = booking.fk_login INNER JOIN property ON property.property_id = booking.fk_property_id WHERE users.login = '" + Settings.Default["login_user"] + "'";
            adapter = new NpgsqlDataAdapter(querry, bd.GetConnection());
            commandBuilder = new NpgsqlCommandBuilder(adapter);

            dataset = new DataSet();
            adapter.Fill(dataset, "booking");
            tableUsers.DataSource = dataset.Tables["booking"];
            bd.CloseConnection();
        }

        private void reloadData() // метод обновления таблицы 
        {
            try
            {
                bd = new BD(); // создание экземпляра класса БД
                bd.OpenConnection();
                dataset.Tables["booking"].Clear(); // очищаем dataset от данных
                adapter.Fill(dataset, "booking");
                tableUsers.DataSource = dataset.Tables["booking"];
                bd.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void main_form_FormClosed(object sender, FormClosedEventArgs e) // событие при закрытии формы
        {
            Application.Exit(); // выход из приложения
        }

        private void забронироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            booking_form booking_Form = new booking_form();
            booking_Form.Show();
        }

        private void зайтиВЛичныйКабинетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user_form userForm = new user_form();
            userForm.Show();
        }

        private void обновитьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reloadData();
        }

        private void администрированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bd.OpenConnection();
            DataTable table = new DataTable();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            string querry = "SELECT is_adm FROM users WHERE users.login = '" + Settings.Default["login_user"].ToString() + "'" + " AND is_adm = TRUE";
            NpgsqlCommand command = new NpgsqlCommand(querry, bd.GetConnection());
            adapter.SelectCommand = command; // вызываем команду command
            adapter.Fill(table); // трансформируем внутрь объекта table

            if (table.Rows.Count > 0)
            {
                admin_panel adminPanel = new admin_panel();
                adminPanel.Show();
            }
            else
                MessageBox.Show("У вас недостаточно прав", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            bd.CloseConnection();
        }
    }
}