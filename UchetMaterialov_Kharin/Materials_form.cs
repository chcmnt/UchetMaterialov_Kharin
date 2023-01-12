namespace UchetMaterialov_Kharin
{
    public partial class Materials_form : Form
    {
        public Materials_form()
        {
            InitializeComponent();
        }

        private void Materials_Load(object sender, EventArgs e)
        {
            Material_dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Material_dataGrid.DataSource = SqlQueries.ShowMaterials();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
