using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoToGrocery
{
    internal class CheckBoxesMembers
    {
        private string _memberid = "memberid";
        private string _memberfullname = "memberfullname";
        private string _streetnumber = "streetnumber";
        private string _unitnumber = "unitnumber";
        private string _streetname = "streetname";
        private string _suburb = "suburb";
        private string _postcode = "postcode";
        private string _city = "city";
        private string _phonenumber = "phonenumber";

        public CheckBoxesMembers() { }

        public string MemberId { get { return _memberid; } }
        public string MemberFullName { get { return _memberfullname; } }
        public string StreetNumber { get { return _streetnumber; } }
        public string UnitNumber { get { return _unitnumber; } }
        public string Streetnumber { get { return _streetnumber; } }
        public string StreetName { get { return _streetname; } }
        public string Suburb { get { return _suburb; } }
        public string Postcode { get { return _postcode; } }
        public string City { get { return _city; } }
        public string PhoneNumber { get { return _phonenumber; } }
    }


}