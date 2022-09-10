using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoToGrocery
{
    public class UpdateStatements : Statements
    {
        public UpdateStatements() : base() { }

        public string FormatStatement(string tableName, List<string> updateContents, List<string> updateParameters, List<string> searchContents, List<string> searchParameters)
        {
            string statement = $"UPDATE {tableName} SET ";

            string additional = "";
            for (int i = 0; i < updateContents.Count; i++)
            {
                additional += $"{updateContents[i]} = '{updateParameters[i]}'";
                if (i != updateContents.Count - 1)
                {
                    additional += ", ";
                }
            }

            string additional1 = " WHERE ";
            for (int i = 0; i < searchContents.Count; i++)
            {
                additional1 += $"{searchContents[i]} = '{searchParameters[i]}' ";
                if (i != searchContents.Count - 1)
                {
                    additional1 += "AND ";
                }
            }

            return statement + additional + additional1;
        }
    }
}
