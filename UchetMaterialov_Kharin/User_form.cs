namespace UchetMaterialov_Kharin
{
    public partial class User_form : Form
    {
        public User_form()
        {
            InitializeComponent();
        }

        private void Materials_btn_Click(object sender, EventArgs e)
        {
            Materials_form materials_form = new Materials_form();
            materials_form.Show();
            foreach(Control control in materials_form.Controls)
            {
                if (control.GetType().ToString() == "System.Windows.Forms.Button")
                {
                    control.Visible = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
