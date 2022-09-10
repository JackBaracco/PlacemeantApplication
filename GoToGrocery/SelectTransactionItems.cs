using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoToGrocery
{
    internal class SelectTransactionItems : SelectStatements
    {
        private string _start = "select transactionid, memberid, memberfullname, itemid, itemname, itembrand, price, purchasequantity, price*purchasequantity as total from transactionitems ";
        private string _joins = "natural join items natural join transactions natural join members ";
        private string _order = "order by transactionid desc";

        public SelectTransactionItems() : base() { }

        public override string FormatStatement()
        {
            return $"{_start}{_joins}{_order}";
        }

        public override string FormatStatement(List<string> searchContents, List<string> searchParameter)
        {
            string query = $"{_start}{_joins} where ";

            string additional = "";
            for (int i = 0; i < searchContents.Count; i++)
            {
                //Replacing 'LIKE' with '=' for any parameters that are integer in database
                if (searchContents[i].ToLower().Equals("transactionid") || searchContents[i].ToLower().Equals("memberid") || searchContents[i].ToLower().Equals("itemid") || searchContents[i].ToLower().Equals("total"))
                {
                    additional += $"{searchContents[i]} = '{searchParameter[i]}' ";
                }
                else
                {
                    additional += $"{searchContents[i]} LIKE '%{searchParameter[i]}%' ";
                }

                if (i != searchContents.Count - 1)
                {
                    additional += "AND ";
                }
            }

            return query + additional + _order;
        }
    }
}
