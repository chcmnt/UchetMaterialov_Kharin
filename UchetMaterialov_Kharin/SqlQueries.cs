using System.Data;
using System.Data.SqlClient;

namespace UchetMaterialov_Kharin
{
    public static class SqlQueries
    {
        static SqlConnection? connection { get; set; }

        /// <summary>
        /// Подключение к бд и открытие соединения
        /// </summary>
        /// <param name="connectionString"></param>
        public static void StartConnection(string connectionString)
        {
            connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            //connection.Open();
            try
            {
                //Открыть подключение
                connection.Open();
            }
            catch (SqlException ex)
            {
                // Протоколировать исключение
                MessageBox.Show(ex.Message);
            }
        }

        public static DataTable ShowMaterials()
        {
            var query = "Select Nazvanie\t as 'Название', Ed_izm as 'Ед.Изм', Nazv as 'Поставщик', Kolichestvo as 'Количество' from Material, Postavshik\r\nwhere Postavshik = Postavshik.id";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);

            return dataSet.Tables[0];
        }
    }
}
