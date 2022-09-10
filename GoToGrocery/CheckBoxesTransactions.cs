using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoToGrocery
{
    internal class CheckboxesTransactions
    {
        private string _transactionid = "transactionid";
        private string _memberid = "memberid";
        private string _purchasedate = "purchasedate";

        public CheckboxesTransactions() { }

        public string TransactionId { get { return _transactionid; } }
        public string MemberId { get { return _memberid; } }
        public string PurchaseDate { get { return _purchasedate; } }
    }
}
