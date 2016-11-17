using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public class Database
    {
        string SQLConnect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + @"C:\Users\zEz\Source\Repos\INFDEV03-5\Assignment 1\Assignment 1\assignment1.mdf" + @";Integrated Security=True";
        SqlConnection connection;
        SqlDataReader sql_reader;
        SqlCommand sql_command;
        public Database()
        {
            try
            {
                connection = new SqlConnection(SQLConnect);
                sql_command = connection.CreateCommand();
                connection.Open();
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Can't connect to database");
            }
        }
        public List<object> Select(string query)
        {
            sql_command.CommandText = query;
            connection.Open();
            sql_reader = sql_command.ExecuteReader();
            object[] column = new object[sql_reader.FieldCount];
            List<object> result_list = new List<object>();
            while (sql_reader.Read())
            {
                Dictionary<string, object> temp_list = new Dictionary<string, object>();
                for (int i = 0; i < sql_reader.GetValues(column); i++)
                {
                    temp_list.Add(sql_reader.GetName(i), column[i]);
                }
                result_list.Add(temp_list);
            }

            connection.Close();
             
            return result_list;
        }
        public void Insert(string query)
        {
            sql_command.CommandText = query;
            connection.Open();
            sql_command.ExecuteNonQuery();
            connection.Close();
        }
        public void Update(string query)
        {
            sql_command.CommandText = query;
            connection.Open();
            sql_command.ExecuteNonQuery();
            connection.Close();
        }
        public void Delete(string query)
        {
            sql_command.CommandText = query;
            connection.Open();
            sql_command.ExecuteNonQuery();
            connection.Close();
        }
        public int amount_rows(string tabel)
        {
            int amount = 0;
            sql_command.CommandText = "SELECT COUNT(*) as amount FROM " + tabel; ;
            connection.Open();
            sql_reader = sql_command.ExecuteReader();
            sql_reader.Read();
            if (sql_reader.HasRows)
            {
                return Convert.ToInt16(sql_reader[0]);
            }
            else
            {
                MessageBox.Show("Table is empty"); 
            }

            connection.Close();
            return amount;
        }
    }
}
