using System.Data.SqlClient;


namespace Miliardezry
{
    class ClassPlayer
    {
        
        /// <summary>
        /// Metoda zapisująca do bazy danych o nazwie miliarderzy nick gracza.
        /// </summary>
        /// <param name="EnterNick"></param>
        public void SaveNick(string EnterNick) {
            SqlConnection connection = new SqlConnection(@"Data Source = YOU; database = miliarderzy ; Trusted_Connection=Yes");
            SqlCommand cmd = new SqlCommand();
            SqlCommand comand = new SqlCommand();

            cmd.CommandType = System.Data.CommandType.Text;
            comand.CommandText = $"DELETE FROM TableGamers WHERE nick ='" + EnterNick + "' ";
            cmd.CommandText = $"INSERT INTO TableGamers(nick,money) VALUES ('" + EnterNick + "','zero zł')";
            comand.Connection = connection;
            cmd.Connection = connection;

            connection.Open();
            comand.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            connection.Close();

        }
        /// <summary>
        /// Metoda zapisująca do bazy danych wartość pieniędzy, które gracz zdobył.
        /// </summary>
        /// <param name="EnsureMoney"></param>
        /// <param name="Nick"></param>
        public void SaveMoney(string EnsureMoney,string Nick)
        {
            SqlConnection sqlConnect = new SqlConnection(@"Data Source = YOU; database = miliarderzy; Trusted_Connection=Yes");
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"UPDATE TableGamers SET money = '"+EnsureMoney+ "'  WHERE nick = '" + Nick + "' ; ";

            cmd.Connection = sqlConnect;

            sqlConnect.Open();
            cmd.ExecuteNonQuery();
            sqlConnect.Close();
        }

    }
}
