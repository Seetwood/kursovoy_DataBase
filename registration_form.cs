using Microsoft.VisualBasic;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using test1.Properties;

namespace test1
{
    public partial class registration_form : Form
    {
        public registration_form()
        {
            InitializeComponent();
            this.Text = "Регистрация"; // изменение названия формы

            this.MinimumSize = new Size(800, 500); // задаем минимальный размер для формы
            panel2.Location = new Point(
            this.ClientSize.Width / 2 - panel2.Size.Width / 2,
            this.ClientSize.Height / 2 - panel2.Size.Height / 2);
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.Gray; // меняем цвет панели авторизации
        }

        private void reg_acc_Click(object sender, EventArgs e) // кнопка регистрации нового аккаунта
        {
            try
            {
                if (checkuser())
                {
                    return;
                }
                BD bd = new BD();
                string querry = "INSERT INTO public.users (login, password, surname, name, patronymic, birth_day)" +
                    "VALUES (@Login, @Password, @Surname, @Name, @Patronymic, @BirthDay)"; // формирование запроса
                NpgsqlCommand command = new NpgsqlCommand(querry, bd.GetConnection()); // передаем запрос в command

                //устанавливаем значения вместо заглушек
                command.Parameters.Add("@Login", NpgsqlTypes.NpgsqlDbType.Varchar).Value = input_login.Text;
                command.Parameters.Add("@Password", NpgsqlTypes.NpgsqlDbType.Varchar).Value = input_pass.Text;
                command.Parameters.Add("@Surname", NpgsqlTypes.NpgsqlDbType.Varchar).Value = input_surname.Text;
                command.Parameters.Add("@Name", NpgsqlTypes.NpgsqlDbType.Varchar).Value = input_name.Text;
                command.Parameters.Add("@Patronymic", NpgsqlTypes.NpgsqlDbType.Varchar).Value = input_patronymic.Text;
                command.Parameters.Add("@BirthDay", NpgsqlTypes.NpgsqlDbType.Date).Value = input_birthDay.Value.Date;

                bd.OpenConnection(); // открываем соединение
                if (command.ExecuteNonQuery() == 1) // если команда успешно выполнилась
                {
                    Settings.Default["login_user"] = input_login.Text;
                    Settings.Default.Save();
                    MessageBox.Show("Аккаунт успешно зарегистрирован", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.Hide();
                    main_form mainForm = new main_form(); // создаем объект формы основного окна
                    mainForm.Show(); // вызываем метод, который отображает окно
                }
                else // если команда не выполнилась
                    MessageBox.Show("Ошибка при регистрации аккаунта", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
                bd.CloseConnection(); // закрываем соединение
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void show_pass_CheckedChanged(object sender, EventArgs e) // chekbox показать пароль
        {
            CheckBox checkBox = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox
            if (checkBox.Checked)
            {
                input_pass.UseSystemPasswordChar = false;
            }
            else
                input_pass.UseSystemPasswordChar = true;
        }

        private void registration_form_FormClosed(object sender, FormClosedEventArgs e) // событие при закрытии формы
        {
            Application.Exit(); // выход из приложения
        }

        private void log_button_MouseEnter(object sender, EventArgs e)
        {
            // меняем стиль label на жирный
            log_button.Font = new Font(log_button.Font, log_button.Font.Style | FontStyle.Bold);
        }

        private void log_button_MouseLeave(object sender, EventArgs e)
        {
            // меняем стиль label на стандартный
            log_button.Font = new Font(log_button.Font, log_button.Font.Style | FontStyle.Regular);
        }

        private void log_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            login_form logForm = new login_form(); // создаем объект формы логина
            logForm.Show(); // вызываем метод, который отображает новое окно  
        }

        private void input_surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsLetter(ch) && ch != 8) //Если символ, введенный с клавы - не цифра (IsDigit),
            {
                e.Handled = true;// то событие не обрабатывается. ch!=8 (8 - это Backspace)
            }
        }

        private void input_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsLetter(ch) && ch != 8) //Если символ, введенный с клавы - не цифра (IsDigit),
            {
                e.Handled = true;// то событие не обрабатывается. ch!=8 (8 - это Backspace)
            }
        }

        private void input_patronymic_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsLetter(ch) && ch != 8) //Если символ, введенный с клавы - не цифра (IsDigit),
            {
                e.Handled = true;// то событие не обрабатывается. ch!=8 (8 - это Backspace)
            }
        }

        // проверка существующего пользоваталя
        public Boolean checkuser()
        {
            BD bd = new BD();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable table = new DataTable();

            string querry = "SELECT * FROM users WHERE login = @input_L";
            NpgsqlCommand command = new NpgsqlCommand(querry, bd.GetConnection());
            command.Parameters.Add("@input_L", NpgsqlTypes.NpgsqlDbType.Varchar).Value = input_login.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь с данным логином уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
