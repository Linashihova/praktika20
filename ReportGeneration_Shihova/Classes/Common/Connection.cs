using MySql.Data.MySqlClient;

namespace ReportGeneration_Shihova.Classes.Common
{
    public class Connection
    {
        public static string config = "server=127.0.0.1;uid=root;pwd=;database=journal;";
        public static MySqlConnection OpenConnection() 
        {
            MySqlConnection mySqlConnection = new MySqlConnection(config);
            mySqlConnection.Open();
            return mySqlConnection;
        }
        public static MySqlDataReader Query(string SQL, MySqlConnection mySqlConnection) 
        {
            return new MySqlCommand(SQL, mySqlConnection).ExecuteReader();
        }
        public static void CloseConnection(MySqlConnection mySqlConnection) 
        {
            mySqlConnection.Close();
            MySqlConnection.ClearPool(mySqlConnection);
        }
    }
}
