﻿using System;
using System.Windows.Forms;
using Schedlify.Controllers;
using Schedlify.Global;

namespace Schedlify.WinForm
{
    public partial class LoginForm : Form
    {
        private UsersController _usersController;

        public LoginForm()
        {
            InitializeComponent();
            _usersController = new UsersController();  // Ініціалізація контролера для користувачів
        }

        // Обробник події для кнопки "Увійти"
        private void authButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;   // Отримуємо логін з поля
            string password = passwordTextBox.Text;  // Отримуємо пароль з поля

            // Перевірка на порожні поля
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Будь ласка, введіть логін і пароль.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;  // Виходимо, якщо хоча б одне з полів порожнє
            }

            // Викликаємо метод Login з UsersController для перевірки введених даних
            var user = _usersController.Login(login, password);

            if (user != null)
            {
                // Авторизація успішна
                UserSession.CurrentUser = user;
                MessageBox.Show("Успішний вхід! Ласкаво просимо.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Переходимо до UniDepGroupForm
                UniDepGroupForm uniDepGroupForm = new UniDepGroupForm();
                uniDepGroupForm.Show();
                this.Close(); // Закриваємо форму після успішного входу
            }
            else
            {
                // Авторизація не вдалася (логін/пароль некоректні)
                MessageBox.Show("Невірний логін або пароль. Спробуйте ще раз.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}