using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoToGrocery
{
    internal class SelectTransactions : SelectStatements
    {
        private string _start = "select transactions.transactionid, memberid, memberfullname, purchasedate, sum(price*purchasequantity) as totalpurchase from transactions ";
        private string _joins = "natural join members left join transactionitems on transactions.transactionid = transactionitems.transactionid ";
        private string _groups = "group by transactionid order by transactionid desc";
        
        public SelectTransactions() : base() { }

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
                //Replacing 'LIKE' with '=' for any parameters that are integer in database
                if (searchContents[i].ToLower().Equals("transactionid") || searchContents[i].ToLower().Equals("memberid") || searchContents[i].ToLower().Equals("totalpurchase"))
                {
                    additional += $"{searchContents[i]} = '{searchParameter[i]}' ";
                }
                else
                {
                    additional += $"{searchContents[i]} LIKE '%{searchParameter[i]}%' ";
                }
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
