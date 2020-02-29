using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace Menuer
{
    class DBOps
    {
        private static string ConnectionString = "Data Source=dbase.db;Version=3;";
        private static SQLiteConnection connection = new SQLiteConnection(ConnectionString);
        public static DataTable ReadDB(string SQLQuery)
        {
            try
            {
                
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(SQLQuery, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                
                return dataTable;

            }
            catch (SQLiteException e)
            {
                MessageBox.Show($"Ошибка чтения DB.\n{e.ToString()}", "Внимание!", MessageBoxButtons.OK);
                return null;
                
            }
        }
        public static void WriteDB(string SQLQuery)
        {
            try
            {
                connection.Open();
                SQLiteCommand sqlcmd = new SQLiteCommand(connection);
                sqlcmd.CommandText = SQLQuery;
                sqlcmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (SQLiteException e)
            {
                connection.Close();
                MessageBox.Show($"Ошибка записи DB.\n{e.ToString()}", "Внимание!", MessageBoxButtons.OK);
            }
        }
        public static void DeleteFromDB(string SQLQuery)
        {
            try
            {
                connection.Open();
                SQLiteCommand sqlcmd = new SQLiteCommand(connection);
                sqlcmd.CommandText = SQLQuery;
                sqlcmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (SQLiteException e)
            {
                connection.Close();
                MessageBox.Show($"Ошибка записи DB.\n{e.ToString()}", "Внимание!", MessageBoxButtons.OK);
            }
        }
        public static bool isInteger(string s)
        {
            if (int.TryParse(s, out int c)) return true; else return false;
        }
        public static bool isReal(string s)
        {
            if (double.TryParse(s, out double c)) return true; else return false;
        }

    }
}
