namespace UchetMaterialov_Kharin
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=localhost;Database=Kharin;Trusted_Connection=True;";
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Вход в программу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_btn_Click(object sender, EventArgs e)
        {
            authorization.Login(Txt_login.Text, Txt_password.Text);
        }

        /// <summary>
        /// Выход из программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlQueries.StartConnection(connectionString);

            //TODO
            Txt_login.Text = "Пользователь";
            Txt_password.Text = "654321";
        }
    }
}