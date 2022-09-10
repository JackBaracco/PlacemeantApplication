using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoToGrocery
{
    internal class CheckBoxesAll
    {
        CheckBoxesTables _tables = new CheckBoxesTables();
        CheckBoxesItems _items = new CheckBoxesItems();
        CheckBoxesMembers _members = new CheckBoxesMembers();
        CheckboxesTransactions _transactions = new CheckboxesTransactions();
        CheckboxesTransactionItems _transactionItems = new CheckboxesTransactionItems();

        public CheckBoxesAll() { }

        public CheckBoxesTables Tables
        {
            get { return _tables; }
        }

        public CheckBoxesItems Items
        {
            get { return _items; }
        }

        public CheckBoxesMembers Members
        {
            get { return _members; }
        }

        public CheckboxesTransactions Transactions
        {
            get { return _transactions; }
        }

        public CheckboxesTransactionItems TransactionItems
        {
            get { return _transactionItems; }
        }
    }
}
