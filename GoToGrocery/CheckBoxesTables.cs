using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoToGrocery
{
    internal class CheckBoxesTables
    {
        private string _items = "items";
        private string _members = "members";
        private string _transactions = "transactions";
        private string _transactionitems = "transactionitems";

        public CheckBoxesTables() { }

        public string Items { get { return _items; }}
        public string Members { get { return _members; }}
        public string Transactions { get { return _transactions; }}
        public string Transactionitems { get { return _transactionitems; }}
    }
}
