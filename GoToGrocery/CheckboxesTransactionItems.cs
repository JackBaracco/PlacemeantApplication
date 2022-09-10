using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoToGrocery
{
    internal class CheckboxesTransactionItems
    {
        private string _transactionid = "transactionid";
        private string _itemid = "itemid";
        private string _price = "price";
        private string _purchasequantity = "purchasequantity";
        private string _total = "total";

        public CheckboxesTransactionItems() { }

        public string TransactionId { get { return _transactionid; } }
        public string ItemID { get { return _itemid; } }
        public string Price { get { return _price; } }
        public string PurchaseQuantity { get { return _purchasequantity; } }
        public string Total { get { return _total; } }
    }
}
