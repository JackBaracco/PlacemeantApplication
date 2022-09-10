using ConsoleTables;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GoToGrocery
{
    public abstract class Statements
    {
        protected ConnectionDetails _conn;

        public Statements()
        {
            _conn = new ConnectionDetails();
        }
        
        public void PrintStatementToConsole(string statement)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(statement, _conn.Conn);
                if (_conn.Conn.State != ConnectionState.Open)
                {
                    _conn.Conn.Open();
                }
                //Executing select statement
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                ConsoleTable table = new ConsoleTable();
                List<string> headings = new List<string>();


                dt.Load(reader);

                int Limit = dt.Rows.Count;

                foreach (DataColumn col in dt.Columns)
                {
                    headings.Add(col.ColumnName);
                }

                table.AddColumn(headings);

                foreach (DataRow dataRow in dt.Rows)
                {
                    if (Limit-- <= 0)
                    {
                        break;
                    }

                    table.AddRow(dataRow.ItemArray);
                }

                //Alternative format removes count at bottom of table
                table.Write(Format.Alternative);
                _conn.Conn.Close();
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }

        public DataTable PrintStatement(string statement)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(statement, _conn.Conn);
                if (_conn.Conn.State != ConnectionState.Open)
                {
                    _conn.Conn.Open();
                }
                //executing select statement
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Load(reader);
                _conn.Conn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public string PrintConfirmation(string statement)
        {
            //executing insert + update
            try
            {
                MySqlCommand cmd = new MySqlCommand(statement, _conn.Conn);
                if (_conn.Conn.State != ConnectionState.Open)
                {
                    _conn.Conn.Open();
                }
                if (cmd.ExecuteNonQuery() != 0)
                {
                    _conn.Conn.Close();

                    string[] temp = statement.Split(" ");

                    if(temp[0].ToLower().Equals("insert"))
                    {
                        return "Insert completed successfully";
                    }
                    return "Update completed successfully";
                }
                else return "Failed to run the query, double check inputs";
            }
            catch (Exception ex)
            {
                return "Failed to run the query, double check inputs";
            }
        }
    }     
}
