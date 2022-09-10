using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoToGrocery
{
    internal class CheckBoxesItems
    {
        private string _itemid = "itemid";
        private string _itemname = "itemname";
        private string _itembrand = "itembrand";
        private string _category = "category";
        private string _itemquantity = "itemquantity";

        public CheckBoxesItems() { }

        public string ItemId { get { return _itemid; } }
        public string Itemname { get { return _itemname; } }
        public string Itembrand { get { return _itembrand; } }
        public string Category { get { return _category; } }
        public string ItemQuantity { get { return _itemquantity; } }
    }
}
