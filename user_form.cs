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
    public partial class user_form : Form
    {

        private BD bd = null;
        private NpgsqlCommand command = null;
        public user_form()
        {
            InitializeComponent();
            this.Text = "Личные данные";
            loadData();
        }
        private void loadData()
        {
            try
            {
                bd = new BD();
                bd.OpenConnection(); // открывем соединение c БД

                string querry = "SELECT *FROM users WHERE login = @log";
                command = new NpgsqlCommand(querry, bd.GetConnection());

                command.Parameters.Add("@log", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Settings.Default["login_user"].ToString();
                NpgsqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    textBoxLogin.Text = reader.GetValue(0).ToString();
                    textBoxPass.Text = reader.GetValue(1).ToString();
                    textBoxSurname.Text = reader.GetValue(2).ToString();
                    textBoxName.Text = reader.GetValue(3).ToString();
                    textBoxPatronymic.Text = reader.GetValue(4).ToString();
                    edit_birthDay.Text = reader.GetValue(5).ToString();
                }

                bd.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        // кнопка удаления аккаунта пользователя
        private void buttonDeleteAcc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить аккаунт?", "Удаление", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bd = new BD();
                    bd.OpenConnection();
                    string querry = "CALL deleteUserData('" + Settings.Default["login_user"].ToString() + "')";
                    command = new NpgsqlCommand(querry, bd.GetConnection()); // формирование запроса
                    command.ExecuteNonQuery(); // выполнение запроса
                    bd.CloseConnection();
                    Application.Restart();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // кнопка редактирования данных пользователя
        private void buttonEditData_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите изменить данные?", "Редактирование данных", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bd = new BD();
                    bd.OpenConnection();
                    string querry = "CALL edit_user_data('" + Settings.Default["login_user"].ToString() + "', @upd_Pass, @upd_Sur, @upd_Name, @upd_Patr, @upd_BirthDay)";
                    command = new NpgsqlCommand(querry, bd.GetConnection()); // формирование запроса

                    //устанавливаем значения вместо заглушек
                    command.Parameters.Add("@upd_Pass", NpgsqlTypes.NpgsqlDbType.Varchar).Value = textBoxPass.Text;
                    command.Parameters.Add("@upd_Sur", NpgsqlTypes.NpgsqlDbType.Varchar).Value = textBoxSurname.Text;
                    command.Parameters.Add("@upd_Name", NpgsqlTypes.NpgsqlDbType.Varchar).Value = textBoxName.Text;
                    command.Parameters.Add("@upd_Patr", NpgsqlTypes.NpgsqlDbType.Varchar).Value = textBoxPatronymic.Text;
                    command.Parameters.Add("@upd_BirthDay", NpgsqlTypes.NpgsqlDbType.Date).Value = edit_birthDay.Value.Date;

                    if (command.ExecuteNonQuery() == 1) // если команда успешно выполнилась
                    {
                        MessageBox.Show("Вы успешно изменили данные", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    loadData();
                    bd.CloseConnection();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonEditData_MouseEnter(object sender, EventArgs e)
        {
            // меняем стиль label на жирный
            buttonEditData.Font = new Font(buttonEditData.Font, label1.Font.Style | FontStyle.Bold);
        }

        private void buttonEditData_MouseLeave(object sender, EventArgs e)
        {
            // меняем стиль label на стандартный
            buttonEditData.Font = new Font(buttonEditData.Font, label1.Font.Style | FontStyle.Regular);
        }

        private void buttonDeleteAcc_MouseEnter(object sender, EventArgs e)
        {
            // меняем стиль label на жирный
            buttonDeleteAcc.Font = new Font(buttonDeleteAcc.Font, label1.Font.Style | FontStyle.Bold);
        }

        private void buttonDeleteAcc_MouseLeave(object sender, EventArgs e)
        {
            // меняем стиль label на стандартный
            buttonDeleteAcc.Font = new Font(buttonDeleteAcc.Font, label1.Font.Style | FontStyle.Regular);
        }

        private void textBoxSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsLetter(ch) && ch != 8) //Если символ, введенный с клавы - не цифра (IsDigit),
            {
                e.Handled = true;// то событие не обрабатывается. ch!=8 (8 - это Backspace)
            }
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsLetter(ch) && ch != 8) //Если символ, введенный с клавы - не цифра (IsDigit),
            {
                e.Handled = true;// то событие не обрабатывается. ch!=8 (8 - это Backspace)
            }
        }

        private void textBoxPatronymic_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsLetter(ch) && ch != 8) //Если символ, введенный с клавы - не цифра (IsDigit),
            {
                e.Handled = true;// то событие не обрабатывается. ch!=8 (8 - это Backspace)
            }
        }

        private void clear_historyBooking_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите очистить историю бронирования?", "Предупреждение", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bd = new BD();
                    bd.OpenConnection();
                    string querry = "DELETE FROM booking WHERE fk_login = '" + Settings.Default["login_user"].ToString() + "'";
                    command = new NpgsqlCommand(querry, bd.GetConnection()); // формирование запроса
                    if (command.ExecuteNonQuery() == 1) // если команда успешно выполнилась
                    {
                        MessageBox.Show("Вы успешно очистили историю бронирования", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    bd.CloseConnection();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
