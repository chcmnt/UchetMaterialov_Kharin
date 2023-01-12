namespace UchetMaterialov_Kharin
{
    public static class authorization 
    {
        const string AdminLogin = "Администратор";
        const string AdminPassword = "123456";

        const string UserLogin = "Пользователь";
        const string UserPassword = "654321";

        /// <summary>
        /// Вход в программу
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        public static void Login(string login, string password)
        {
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль");
                return;
            }

            if (login == AdminLogin && password == AdminPassword) 
            {
                // TODO: Открыть форму в режиме администратора
            }

            else if (login == UserLogin && password == UserPassword)
            {
                User_form main_form = new User_form();
                main_form.Show();
            }

            else
            {
                MessageBox.Show("Неправильный логин или пароль");
                return;
            }
        }
    }
}