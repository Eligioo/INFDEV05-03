using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public static class TypeCaster
    {
        public static object To(this string value, Type t)
        {
            return Convert.ChangeType(value, t);
        }
    }

    public class Database<T> where T : new()
    {
        string SQLConnect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\zEz\Source\Repos\NewRepo\Assignment 1\Assignment 1\assignment1.mdf';Integrated Security=True";
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

        public List<T> Select(string query)
        {
            sql_command.CommandText = query;
            connection.Open();
            sql_reader = sql_command.ExecuteReader();

            var resultList = new List<T>();
            while (sql_reader.Read())
            {
                var item = new T();
                Type t = item.GetType();
                foreach (PropertyInfo property in t.GetProperties())
                {
                    Type type = property.PropertyType;
                    string readerValue = string.Empty;

                    if (sql_reader[property.Name] != DBNull.Value)
                    {
                        readerValue = sql_reader[property.Name].ToString();
                    }

                    if (!string.IsNullOrEmpty(readerValue))
                    {
                        property.SetValue(item, readerValue.To(type), null);
                    }

                }
                resultList.Add(item);
            }
            connection.Close();
            return resultList;
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
