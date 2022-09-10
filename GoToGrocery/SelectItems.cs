using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoToGrocery
{
    internal class SelectItems : SelectStatements
    {
        public SelectItems() : base() { }

        public override string FormatStatement()
        {
            return "select * from items";
        }

        public override string FormatStatement(List<string> searchContents, List<string> searchParameter)
        {
            string query = $"{FormatStatement()} where ";

            string additional = "";
            for(int i = 0; i < searchContents.Count; i++)
            {
                //Replacing 'LIKE' with '=' for any parameters that are integer in database
                if (searchContents[i].ToLower().Equals("itemid") || searchContents[i].ToLower().Equals("itemquantity"))
                {
                    additional += $"{searchContents[i]} = '{searchParameter[i]}' ";
                }
                else
                {
                    additional += $"{searchContents[i]} LIKE '%{searchParameter[i]}%' ";
                }

                if(i != searchContents.Count - 1)
                {
                    additional += "AND ";
                }
            }
            return query + additional;
        }
    }
}
