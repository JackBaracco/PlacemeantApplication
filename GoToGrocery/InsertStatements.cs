using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoToGrocery
{
    internal class InsertStatements : Statements
    {
        public InsertStatements() : base() { }

        public string FormatStatement(string tableName, List<string> insertContents, List<string> insertParameters)
        {
            string statement = $"insert into {tableName} ";

            //Selected fields
            string additional = "(";
            for (int i = 0; i < insertContents.Count; i++)
            {
                additional += $"{insertContents[i]}";
                if (i != insertContents.Count - 1)
                {
                    additional += ", ";
                }
            }

            additional += ")";
            statement = statement + additional + " values ";

            //New data to insert
            additional = "(";
            for (int i = 0; i < insertParameters.Count; i++)
            {
                additional += $"'{insertParameters[i]}'";
                if (i != insertParameters.Count - 1)
                {
                    additional += ", ";
                }
            }
            additional += ")";

            return statement + additional;
        }
    }
}
