using MySql.Data.MySqlClient;
using System.Data;
using ClassicModels.Properties;

namespace ClassicModels;

internal class Database
{
    private MySqlConnection? _myConn = null;
    private MySqlCommand _myCommand = new MySqlCommand();
    private MySqlDataAdapter _myDataAdapter = new MySqlDataAdapter();
    private DataTable? _dataTable = new DataTable();
    private MySqlDataReader _mySqlDataReader = null;
    private const string Conn = @"server=localhost;userid=root;password=123456;database=classicmodels";

    internal void InitiateAdminUser()
    {
        try
        {
            _myConn = new MySqlConnection(Conn);

            if (_myConn.State == ConnectionState.Open) return;
            _myConn.Open();

            if (_myConn.State != ConnectionState.Open) return;
            //check if login table has any records
            const string check = "SELECT count(*) AS Record FROM login";
            var query = new MySqlCommand(check, _myConn);
            var loginCount = Convert.ToInt32(query.ExecuteScalar());
            if (loginCount > 0) return;
            
            var credentials = new Credentials();
            var password = credentials.HashPassword("admin", out var salt);
            const string insertCommand = "INSERT INTO login (username, password_hash, salt) VALUES (@username, @password_hash, @salt)";
                    
            var insertInitialAdmin = new MySqlCommand(insertCommand, _myConn);
            insertInitialAdmin.Parameters.AddWithValue("@username", "admin");
            insertInitialAdmin.Parameters.AddWithValue("@password_hash", password);
            insertInitialAdmin.Parameters.AddWithValue("@salt", Convert.ToHexString(salt));
        }
        catch (Exception e)
        {
            MessageBox.Show(Resources.Database_Authentication_Error_message_is__ + e.Message);
        }
    }

    public bool Authentication(string username, string passwordHash, string salt)
    {
        try
        {
            _myConn = new MySqlConnection(Conn);

            if (_myConn.State != ConnectionState.Open)
            {
                _myConn.Open();

                if (_myConn.State == ConnectionState.Open)
                {
                    const string query = "SELECT count(*) AS Record FROM login WHERE username=@username AND password_hash=@password_hash AND salt=@salt";

                    var dataAdapter = new MySqlDataAdapter(query, _myConn);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@username", username);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@password_hash", passwordHash);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@salt", salt);

                    var dataSet = new DataSet();

                    dataAdapter.Fill(dataSet, "login");

                    _dataTable = dataSet.Tables["login"];
                    
                    if (_dataTable is null) return false;

                    var recordCount = Convert.ToInt32(_dataTable.Rows[0]["Record"]);
                    return recordCount == 1 ? true : false;
                }
            }
        }
        catch (Exception e)
        {
            MessageBox.Show(Resources.Database_Authentication_Error_message_is__ + e.Message);
        }

        return false;
    }

}
