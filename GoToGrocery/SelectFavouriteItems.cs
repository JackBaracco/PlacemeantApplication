using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoToGrocery
{
    internal class SelectFavouriteItems : SelectStatements
    {
        private string _start = "select memberid, memberfullname, itemname, sum(purchasequantity) as total from transactionitems ";
        private string _joins = "natural join transactions natural join items natural join members ";
        private string _groups = "group by itemid, memberid order by total desc";
        
        public SelectFavouriteItems() : base() { }

        public override string FormatStatement()
        {
            return $"{_start}{_joins}{_groups}";
        }

        public override string FormatStatement(List<string> searchContents, List<string> searchParameter)
        {
            string query = $"{_start}{_joins} where ";

            string additional = "";
            for (int i = 0; i < searchContents.Count; i++)
            {
                additional += $"{searchContents[i]} LIKE '%{searchParameter[i]}%' ";
                if (i != searchContents.Count - 1)
                {
                    additional += "AND ";
                }
            }

            return query + additional + _groups;
        }
    }
}
