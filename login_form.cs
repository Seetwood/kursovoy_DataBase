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
using static System.Windows.Forms.DataFormats;
using test1.Properties;
using System.Text.RegularExpressions;

namespace test1
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
            this.Text = "Вход в систему";

            this.MinimumSize = new Size(640, 480); // задаем минимальный размер для формы
            panel2.Location = new Point(
            this.ClientSize.Width / 2 - panel2.Size.Width / 2,
            this.ClientSize.Height / 2 - panel2.Size.Height / 2);
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.Gray; // меняем цвет панели авторизации
        }
        //public static string usLogin = "123";
        private void show_pass_CheckedChanged(object sender, EventArgs e)
        {
            //CheckBox checkBox = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox
            if (show_pass.Checked)
                input_pass.UseSystemPasswordChar = false;
            else
                input_pass.UseSystemPasswordChar = true;
        }

        private void login_acc_Click(object sender, EventArgs e)
        {
            try
            {
                string loginUser = input_login.Text;
                string passUser = input_pass.Text;

                BD bd = new BD();

                DataTable table = new DataTable();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();

                // формирование запроса к БД
                string querry = "SELECT * FROM users WHERE login = @input_L AND password = @input_P";

                // комадна проверки логина и пароля пользователя
                NpgsqlCommand command = new NpgsqlCommand(querry, bd.GetConnection());

                //устанавливаем значения вместо заглушек
                command.Parameters.Add("@input_L", NpgsqlTypes.NpgsqlDbType.Varchar).Value = loginUser;
                command.Parameters.Add("@input_P", NpgsqlTypes.NpgsqlDbType.Varchar).Value = passUser;

                adapter.SelectCommand = command; // вызываем команду command
                adapter.Fill(table); // трансформируем внутрь объекта table

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Вы успешно авторизовались", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.Hide();
                    main_form mForm = new main_form(); // создаем объект формы основного окна
                    mForm.Show(); // вызываем метод, который отображает окно
                    Settings.Default["login_user"] = loginUser;
                    Settings.Default.Save();
    }
                else
                    MessageBox.Show("Такого пользователя не существует", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Нет подключения к базе данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void reg_button_Click(object sender, EventArgs e) // кнопка перехода на окно регистрации
        {
            this.Hide();
            registration_form regForm = new registration_form(); // создаем объект формы регистрации
            regForm.Show(); // вызываем метод, который отображает окно        
        }

        // событие кнопки reg_button при наведении курсора
        private void reg_button_MouseEnter(object sender, EventArgs e)
        {
            // меняем стиль label на жирный
            reg_button.Font = new Font(reg_button.Font, reg_button.Font.Style | FontStyle.Bold);
        }

        // событие кнопки reg_button при отпускании курсора
        private void reg_button_MouseLeave(object sender, EventArgs e)
        {
            // меняем стиль label на стандартный
            reg_button.Font = new Font(reg_button.Font, reg_button.Font.Style | FontStyle.Regular);

        }

        private void login_form_FormClosed(object sender, FormClosedEventArgs e) // событие при закрытии формы
        {
            Application.Exit(); // выход из приложения
        }
    }
}
