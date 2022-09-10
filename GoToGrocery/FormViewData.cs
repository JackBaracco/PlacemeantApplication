using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* To Note:
 * If a variable or field property begins with c, t, r, or f. It is referring to it being:
 *          c: CheckBox
 *          t: TextBox
 *          r: RadioButton
 *          f: Parameters associated with finding specific data (only used in FormEditData) for update statements
 */

namespace GoToGrocery
{
    public partial class FormViewData : Form
    {
        List<RadioButton> _headings = new List<RadioButton>();
        
        List<RadioButton> _memberRadioButtons = new List<RadioButton>();
        List<CheckBox> _memberCheckBoxes = new List<CheckBox>();
        List<TextBox> _memberTextBoxes = new List<TextBox>();

        List<RadioButton> _shopStockRadioButtons = new List<RadioButton>();
        List<CheckBox> _shopStockCheckBoxes = new List<CheckBox>();
        List<TextBox> _shopStockTextBoxes = new List<TextBox>();

        List<RadioButton> _transactionsRadioButtons = new List<RadioButton>();
        List<CheckBox> _transactionsCheckBoxes = new List<CheckBox>();
        List<TextBox> _transactionsTextBoxes = new List<TextBox>();

        List<RadioButton> _purchasedItemsRadionButtons = new List<RadioButton>();
        List<CheckBox> _purchasedItemsCheckBoxes = new List<CheckBox>();
        List<TextBox> _purchasedItemsTextBoxes = new List<TextBox>();

        List<RadioButton> _favouriteItemsRadionButtons = new List<RadioButton>();
        List<CheckBox> _favouriteItemsCheckBoxes = new List<CheckBox>();
        List<TextBox> _favouriteItemsTextBoxes = new List<TextBox>();

        UserInputHandler input = new UserInputHandler();
        CheckBoxesAll all = new CheckBoxesAll();
        DataTable dt = new DataTable();

        public FormViewData()
        {
            InitializeComponent();

            FillLists();
            
            SetRadioButtons(false);
            EnableAll(false);
        }

        private void bGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //===== FILLING LISTS =====
        //Headings
        private void AddHeadingRadioButtons()
        {
            _headings.Add(rMembersHeading);
            _headings.Add(rShopStockHeading);
            _headings.Add(rTransactionsHeading);
            _headings.Add(rPurchasedItemsHeading);
            _headings.Add(rFavouriteItemsHeading);
        }

        //Members
        private void AddMemberRadioButtons()
        {
            _memberRadioButtons.Add(rAllMembers);
            _memberRadioButtons.Add(rSpecificMembers);
        }

        private void AddMemberCheckBoxes()
        {
            _memberCheckBoxes.Add(cMemMemberID);
            _memberCheckBoxes.Add(cMemMemberFullName);
            _memberCheckBoxes.Add(cMemStreetNumber);
            _memberCheckBoxes.Add(cMemUnitNumber);
            _memberCheckBoxes.Add(cMemStreetName);
            _memberCheckBoxes.Add(cMemSuburb);
            _memberCheckBoxes.Add(cMemPostcode);
            _memberCheckBoxes.Add(cMemCity);
            _memberCheckBoxes.Add(cMemPhoneNumber);
        }

        private void AddMemberTextBoxes()
        {
            _memberTextBoxes.Add(tMemMemberId);
            _memberTextBoxes.Add(tMemMemberFullName);
            _memberTextBoxes.Add(tMemStreetNumber);
            _memberTextBoxes.Add(tMemUnitNumber);
            _memberTextBoxes.Add(tMemStreetName);
            _memberTextBoxes.Add(tMemSuburb);
            _memberTextBoxes.Add(tMemPostcode);
            _memberTextBoxes.Add(tMemCity);
            _memberTextBoxes.Add(tMemPhoneNumber);
        }

        //Shop Stock
        private void AddShopStockRadioButtons()
        {
            _shopStockRadioButtons.Add(rAllShopStock);
            _shopStockRadioButtons.Add(rSpecificShopStock);
        }

        private void AddShopStockCheckBoxes()
        {
            _shopStockCheckBoxes.Add(cShopItemID);
            _shopStockCheckBoxes.Add(cShopItemName);
            _shopStockCheckBoxes.Add(cShopBrand);
            _shopStockCheckBoxes.Add(cShopCategory);
            _shopStockCheckBoxes.Add(cShopQuantity);
        }

        private void AddShopStockTextBoxes()
        {
            _shopStockTextBoxes.Add(tShopItemID);
            _shopStockTextBoxes.Add(tShopItemName);
            _shopStockTextBoxes.Add(tShopBrand);
            _shopStockTextBoxes.Add(tShopCategory);
            _shopStockTextBoxes.Add(tShopQuantity);
        }

        //Transactions
        private void AddTransactionsRadioButtons()
        {
            _transactionsRadioButtons.Add(rAllTransactions);
            _transactionsRadioButtons.Add(rSpecificTransactions);
        }

        private void AddTransactionsCheckBoxes()
        {
            _transactionsCheckBoxes.Add(cTranTransactionID);
            _transactionsCheckBoxes.Add(cTranMemberID);
            _transactionsCheckBoxes.Add(cTranMemberFullName);
            _transactionsCheckBoxes.Add(cTranPurchaseDate);
        }

        private void AddTransactionsTextBoxes()
        {
            _transactionsTextBoxes.Add(tTranTransactionID);
            _transactionsTextBoxes.Add(tTranMemberID);
            _transactionsTextBoxes.Add(tTranMemberFullName);
            _transactionsTextBoxes.Add(tTranPurchaseDate);
        }

        //Purchased Items
        private void AddPurchasedItemsRadioButtons()
        {
            _purchasedItemsRadionButtons.Add(rAllPurchasedItems);
            _purchasedItemsRadionButtons.Add(rSpecificPurchasedItems);
        }

        private void AddPurchasedItemsCheckBoxes()
        {
            _purchasedItemsCheckBoxes.Add(cPurTransactionID);
            _purchasedItemsCheckBoxes.Add(cPurMemberID);
            _purchasedItemsCheckBoxes.Add(cPurMemberFullName);
            _purchasedItemsCheckBoxes.Add(cPurItemID);
            _purchasedItemsCheckBoxes.Add(cPurItemName);
            _purchasedItemsCheckBoxes.Add(cPurBrand);
            _purchasedItemsCheckBoxes.Add(cPurPrice);
            _purchasedItemsCheckBoxes.Add(cPurQuantity);
        }

        private void AddPurchasedItemsTextBoxes()
        {
            _purchasedItemsTextBoxes.Add(tPurTransactionID);
            _purchasedItemsTextBoxes.Add(tPurMemberID);
            _purchasedItemsTextBoxes.Add(tPurMemberFullName);
            _purchasedItemsTextBoxes.Add(tPurItemID);
            _purchasedItemsTextBoxes.Add(tPurItemName);
            _purchasedItemsTextBoxes.Add(tPurBrand);
            _purchasedItemsTextBoxes.Add(tPurPrice);
            _purchasedItemsTextBoxes.Add(tPurQuantity);
        }

        //Favourite Items
        private void AddFavouriteItemsRadioButtons()
        {
            _favouriteItemsRadionButtons.Add(rAllFavouriteItems);
            _favouriteItemsRadionButtons.Add(rSpecificFavouriteItems);
        }

        private void AddFavouriteItemsCheckBoxes()
        {
            _favouriteItemsCheckBoxes.Add(cFaveMemberID);
            _favouriteItemsCheckBoxes.Add(cFaveMemberFullName);
            _favouriteItemsCheckBoxes.Add(cFaveItemName);
            _favouriteItemsCheckBoxes.Add(cFaveTotalAmount);
        }

        private void AddFavouriteItemsTextBoxes()
        {
            _favouriteItemsTextBoxes.Add(tFaveMemberID);
            _favouriteItemsTextBoxes.Add(tFaveMemberFullName);
            _favouriteItemsTextBoxes.Add(tFaveItemName);
            _favouriteItemsTextBoxes.Add(tFaveTotalAmount);
        }

        public void FillLists()
        {
            AddHeadingRadioButtons();
            AddMemberRadioButtons();
            AddMemberCheckBoxes();
            AddMemberTextBoxes();
            AddShopStockRadioButtons();
            AddShopStockCheckBoxes();
            AddShopStockTextBoxes();
            AddTransactionsRadioButtons();
            AddTransactionsCheckBoxes();
            AddTransactionsTextBoxes();
            AddPurchasedItemsRadioButtons();
            AddPurchasedItemsCheckBoxes();
            AddPurchasedItemsTextBoxes();
            AddFavouriteItemsRadioButtons();
            AddFavouriteItemsCheckBoxes();
            AddFavouriteItemsTextBoxes();
        }
        //==========================


        //Setters for all checked values of radio buttons (aside from heading buttons)
        private void SetRadioButtons(bool value)
        {
            foreach(RadioButton radioButton in _memberRadioButtons)
            {
                radioButton.Checked = value;
            }
            foreach(RadioButton radioButton in _shopStockRadioButtons)
            {
                radioButton.Checked = value;
            }
            foreach (RadioButton radioButton in _transactionsRadioButtons)
            {
                radioButton.Checked = value;
            }
            foreach (RadioButton radioButton in _purchasedItemsRadionButtons)
            {
                radioButton.Checked = value;
            }
            foreach (RadioButton radioButton in _favouriteItemsRadionButtons)
            {
                radioButton.Checked = value;
            }
        }

        private void SetHeadingRadioButtons(bool value)
        {
            foreach(RadioButton radioButton in _headings)
            {
                radioButton.Checked = value;
            }
        }

        //Setters for all checked values for checkboxes
        private void SetCheckBoxes(bool value)
        {
            foreach(CheckBox checkBox in _memberCheckBoxes)
            {
                checkBox.Checked = value;
            }
            foreach (CheckBox checkBox in _shopStockCheckBoxes)
            {
                checkBox.Checked = value;
            }
            foreach (CheckBox checkBox in _transactionsCheckBoxes)
            {
                checkBox.Checked = value;
            }
            foreach (CheckBox checkBox in _purchasedItemsCheckBoxes)
            {
                checkBox.Checked = value;
            }
            foreach (CheckBox checkBox in _favouriteItemsCheckBoxes)
            {
                checkBox.Checked = value;
            }
        }

        //Clearing all text boxes
        private void ClearTextBoxes()
        {
            foreach(TextBox textBox in _memberTextBoxes)
            {
                textBox.Clear();
            }
            foreach (TextBox textBox in _shopStockTextBoxes)
            {
                textBox.Clear();
            }
            foreach (TextBox textBox in _transactionsTextBoxes)
            {
                textBox.Clear();
            }
            foreach (TextBox textBox in _purchasedItemsTextBoxes)
            {
                textBox.Clear();
            }
            foreach (TextBox textBox in _favouriteItemsTextBoxes)
            {
                textBox.Clear();
            }
        }


        //===== ENABLING/DISABLING RADIO BUTTONS, CHECKBOXES, TEXTBOXES AND BUTTONS FOR EACH QUERY =====
        //Enable/Disable radiobuttons and text boxes related to Member Details
        private void EnableMemberR(bool value)
        {
            foreach (RadioButton radio in _memberRadioButtons)
            {
                radio.Enabled = value;
            }
        }

        //Enable/Disable checkboxes and text boxes related to Member Details
        private void EnableMemberCT(bool value)
            {
                foreach (CheckBox checkBox in _memberCheckBoxes)
                {
                    checkBox.Enabled = value;
                }
                foreach (TextBox textBox in _memberTextBoxes)
                {
                    textBox.Enabled = value;
                }
            }

        //Enable/Disable radiobuttons and text boxes related to Shop Stock Details
        private void EnableShopStockR(bool value)
        {
            foreach (RadioButton radio in _shopStockRadioButtons)
            {
                radio.Enabled = value;
            }
        }

        //Enable/Disable checkboxes related to Shop Stock Details
        private void EnableShopStockCT(bool value)
        {
            foreach (CheckBox checkBox in _shopStockCheckBoxes)
            {
                checkBox.Enabled = value;
            }
            foreach (TextBox textBox in _shopStockTextBoxes)
            {
                textBox.Enabled = value;
            }
        }

        //Enable/Disable radiobuttons and text boxes related to Transactions details
        private void EnableTransactionsR(bool value)
        {
            foreach (RadioButton radio in _transactionsRadioButtons)
            {
                radio.Enabled = value;
            }
        }

        //Enable/Disable checkboxes to Transactions Details
        private void EnableTransactionsCT(bool value)
        {
            foreach (CheckBox checkBox in _transactionsCheckBoxes)
            {
                checkBox.Enabled = value;
            }
            foreach (TextBox textBox in _transactionsTextBoxes)
            {
                textBox.Enabled = value;
            }
        }

        //Enable/Disable radiobuttons and text boxes related to Purchased Items details
        private void EnablePurchasedItemsR(bool value)
        {
            foreach (RadioButton radio in _purchasedItemsRadionButtons)
            {
                radio.Enabled = value;
            }
        }

        //Enable/Disable checkboxes related to Purchased Items Details
        private void EnablePurchasedItemsCT(bool value)
        {
            foreach (CheckBox checkBox in _purchasedItemsCheckBoxes)
            {
                checkBox.Enabled = value;
            }
            foreach (TextBox textBox in _purchasedItemsTextBoxes)
            {
                textBox.Enabled = value;
            }
        }

        //Enable/Disable radiobuttons and text boxes related to Favourite Items details
        private void EnableFavouriteItemsR(bool value)
        {
            foreach (RadioButton radio in _favouriteItemsRadionButtons)
            {
                radio.Enabled = value;
            }
        }
        //Enable/Disable checkboxes related to Favourite Items Details
        private void EnableFavouriteItemsCT(bool value)
        {
            foreach (CheckBox checkBox in _favouriteItemsCheckBoxes)
            {
                checkBox.Enabled = value;
            }
            foreach (TextBox textBox in _favouriteItemsTextBoxes)
            {
                textBox.Enabled = value;
            }
        }

        //Enable/Disable Submit and Reset buttons
        private void EnableSubmitReset(bool value)
        {
            bSubmitSelect.Enabled = value;
            bResetSelect.Enabled = value;
        }

        //Setter for all enabling/disabling radiobuttons, checkboxes and textboxes
        private void EnableAll(bool value)
        {
            EnableMemberR(value);
            EnableMemberCT(value);

            EnableShopStockR(value);
            EnableShopStockCT(value);

            EnableTransactionsR(value);
            EnableTransactionsCT(value);

            EnablePurchasedItemsR(value);
            EnablePurchasedItemsCT(value);

            EnableFavouriteItemsR(value);
            EnableFavouriteItemsCT(value);

            EnableSubmitReset(value);
        }
        //==========================


        //===== CHECK BOX BEHAVIOURS =====
        private void cMemMemberID_CheckedChanged(object sender, EventArgs e)
        {
            if (!cMemMemberID.Checked) tMemMemberId.Text = "";
        }

        private void cMemMemberFullName_CheckedChanged(object sender, EventArgs e)
        {
            if (!cMemMemberFullName.Checked) tMemMemberFullName.Text = "";
        }

        private void cMemStreetNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (!cMemStreetNumber.Checked) tMemStreetNumber.Text = "";
        }

        private void cMemUnitNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (!cMemUnitNumber.Checked) tMemUnitNumber.Text = "";
        }

        private void cMemStreetName_CheckedChanged(object sender, EventArgs e)
        {
            if (!cMemStreetName.Checked) tMemStreetName.Text = "";
        }

        private void cMemSuburb_CheckedChanged(object sender, EventArgs e)
        {
            if (!cMemSuburb.Checked) tMemSuburb.Text = "";
        }

        private void cMemPostcode_CheckedChanged(object sender, EventArgs e)
        {
            if (!cMemPostcode.Checked) tMemPostcode.Text = "";
        }

        private void cMemCity_CheckedChanged(object sender, EventArgs e)
        {
            if (!cMemCity.Checked) tMemCity.Text = "";
        }

        private void cMemPhoneNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (!cMemPhoneNumber.Checked) tMemPhoneNumber.Text = "";
        }

        private void cShopItemID_CheckedChanged(object sender, EventArgs e)
        {
            if (!cShopItemID.Checked) tShopItemID.Text = "";
        }

        private void cShopItemName_CheckedChanged(object sender, EventArgs e)
        {
            if (!cShopItemName.Checked) tShopItemName.Text = "";
        }

        private void cShopBrand_CheckedChanged(object sender, EventArgs e)
        {
            if (!cShopBrand.Checked) tShopBrand.Text = "";
        }

        private void cShopCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (!cShopCategory.Checked) tShopCategory.Text = "";
        }

        private void cShopQuantity_CheckedChanged(object sender, EventArgs e)
        {
            if (!cShopQuantity.Checked) tShopQuantity.Text = "";
        }

        private void cTranTransactionID_CheckedChanged(object sender, EventArgs e)
        {
            if (!cTranTransactionID.Checked) tTranTransactionID.Text = "";
        }

        private void cTranMemberID_CheckedChanged(object sender, EventArgs e)
        {
            if (!cTranMemberID.Checked) tTranMemberID.Text = "";
        }

        private void cTranMemberFullName_CheckedChanged(object sender, EventArgs e)
        {
            if (!cTranMemberFullName.Checked) tTranMemberFullName.Text = "";
        }

        private void cTranPurchaseDate_CheckedChanged(object sender, EventArgs e)
        {
            if (!cTranPurchaseDate.Checked) tTranPurchaseDate.Text = "";
        }

        private void cPurTransactionID_CheckedChanged(object sender, EventArgs e)
        {
            if (!cPurTransactionID.Checked) tPurTransactionID.Text = "";
        }

        private void cPurMemberID_CheckedChanged(object sender, EventArgs e)
        {
            if (!cPurMemberID.Checked) tPurMemberID.Text = "";
        }

        private void cPurMemberFullName_CheckedChanged(object sender, EventArgs e)
        {
            if (!cPurMemberFullName.Checked) tPurMemberFullName.Text = "";
        }

        private void cPurItemID_CheckedChanged(object sender, EventArgs e)
        {
            if (!cPurItemID.Checked) tPurItemID.Text = "";
        }

        private void cPurItemName_CheckedChanged(object sender, EventArgs e)
        {
            if (!cPurItemName.Checked) tPurItemName.Text = "";
        }

        private void cPurBrand_CheckedChanged(object sender, EventArgs e)
        {
            if (!cPurBrand.Checked) tPurBrand.Text = "";
        }

        private void cPurPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (!cPurPrice.Checked) tPurPrice.Text = "";
        }

        private void cPurQuantity_CheckedChanged(object sender, EventArgs e)
        {
            if (!cPurQuantity.Checked) tPurQuantity.Text = "";
        }

        private void cFaveMemberID_CheckedChanged(object sender, EventArgs e)
        {
            if (!cFaveMemberID.Checked) tFaveMemberID.Text = "";
        }

        private void cFaveMemberFullName_CheckedChanged(object sender, EventArgs e)
        {
            if (!cFaveItemName.Checked) tFaveMemberFullName.Text = "";
        }

        private void cFaveItemName_CheckedChanged(object sender, EventArgs e)
        {
            if (!cFaveItemName.Checked) tFaveItemName.Text = "";
        }

        private void cFaveTotalAmount_CheckedChanged(object sender, EventArgs e)
        {
            if (!cFaveTotalAmount.Checked) tFaveTotalAmount.Text = "";
        }
        //==========================


        //===== RADIO BUTTON BEHAVIOURS =====
        //HEADINGS BUTTONS
        private void ResetHeadings()
        {
            EnableAll(false);
            SetRadioButtons(false);
            SetCheckBoxes(false);
            selectErrorMessage.Text = "";
        }
        //Members
        private void rMembersHeading_CheckedChanged(object sender, EventArgs e)
        {
            ResetHeadings();
            EnableMemberR(true);
        }

        //Shop Stock
        private void rShopStockHeading_CheckedChanged(object sender, EventArgs e)
        {
            ResetHeadings();
            EnableShopStockR(true);
        }

        //Transactions
        private void rTransactionsHeading_CheckedChanged(object sender, EventArgs e)
        {
            ResetHeadings();
            EnableTransactionsR(true);
        }

        //Purchased Items
        private void rPurchasedItemsHeading_CheckedChanged(object sender, EventArgs e)
        {
            ResetHeadings();
            EnablePurchasedItemsR(true);
        }

        //Favourite Items
        private void rFavouriteItemsHeading_CheckedChanged(object sender, EventArgs e)
        {
            ResetHeadings();
            EnableFavouriteItemsR(true);
        }

        //BUTTONS RELATED TO EACH SPECIFC HEADING
        //Members
        private void rAllMembers_CheckedChanged(object sender, EventArgs e)
        {
            EnableSubmitReset(true);
        }
        private void rSpecificMembers_CheckedChanged(object sender, EventArgs e)
        {
            bool value = rSpecificMembers.Checked ? true : false;
            EnableMemberCT(value);
            EnableSubmitReset(true);
        }

        //Shop Stock
        private void rAllShopStock_CheckedChanged(object sender, EventArgs e)
        {
            EnableSubmitReset(true);
        }
        private void rSpecificShopStock_CheckedChanged(object sender, EventArgs e)
        {
            bool value = rSpecificShopStock.Checked ? true : false;
            EnableShopStockCT(value);
            EnableSubmitReset(true);
        }

        //Transactions
        private void rAllTransactions_CheckedChanged(object sender, EventArgs e)
        {
            EnableSubmitReset(true);
        }
        private void rSppecificTransactions_CheckedChanged(object sender, EventArgs e)
        {
            bool value = rSpecificTransactions.Checked ? true : false;
            EnableTransactionsCT(value);
            EnableSubmitReset(true);
        }

        //Purchased Items
        private void rAllPurchasedItems_CheckedChanged(object sender, EventArgs e)
        {
            EnableSubmitReset(true);
        }
        private void rSpecificPurchasedItems_CheckedChanged(object sender, EventArgs e)
        {
            bool value = rSpecificPurchasedItems.Checked ? true : false;
            EnablePurchasedItemsCT(value);
            EnableSubmitReset(true);
        }

        //Favourite Items
        private void rAllFavouriteItems_CheckedChanged(object sender, EventArgs e)
        {
            EnableSubmitReset(true);
        }
        private void rSpecificFavouriteItems_CheckedChanged(object sender, EventArgs e)
        {
            bool value = rSpecificFavouriteItems.Checked ? true : false;
            EnableFavouriteItemsCT(value);
            EnableSubmitReset(true);
        }
        //==========================


        //===== CREATING QUERIES =====
        //Members
        private DataTable SelectMembers()
        {
            SelectMembers select = new SelectMembers();
            if (rAllMembers.Checked)
            {
                dt = select.PrintStatement(select.FormatStatement());
            }
            else if (rSpecificMembers.Checked)
            {
                input.ClearLists();

                //Add all inputs to lists
                if (cMemMemberID.Checked && !tMemMemberId.Text.Equals(""))
                {
                    input.AddChecked(all.Members.MemberId);
                    input.AddUserInput(tMemMemberId.Text);
                }
                if (cMemMemberFullName.Checked && !tMemMemberFullName.Text.Equals(""))
                {
                    input.AddChecked(all.Members.MemberFullName);
                    input.AddUserInput(tMemMemberFullName.Text);
                }
                if (cMemStreetNumber.Checked && !tMemStreetNumber.Text.Equals(""))
                {
                    input.AddChecked(all.Members.StreetNumber);
                    input.AddUserInput(tMemStreetNumber.Text);
                }
                if (cMemUnitNumber.Checked && !tMemUnitNumber.Text.Equals(""))
                {
                    input.AddChecked(all.Members.UnitNumber);
                    input.AddUserInput(tMemUnitNumber.Text);
                }
                if (cMemStreetName.Checked && !tMemStreetName.Text.Equals(""))
                {
                    input.AddChecked(all.Members.StreetName);
                    input.AddUserInput(tMemStreetName.Text);
                }
                if (cMemSuburb.Checked && !tMemSuburb.Text.Equals(""))
                {
                    input.AddChecked(all.Members.Suburb);
                    input.AddUserInput(tMemSuburb.Text);
                }
                if (cMemCity.Checked && !tMemCity.Text.Equals(""))
                {
                    input.AddChecked(all.Members.City);
                    input.AddUserInput(tMemCity.Text);
                }
                if (cMemPhoneNumber.Checked && !tMemPhoneNumber.Text.Equals(""))
                {
                    input.AddChecked(all.Members.PhoneNumber);
                    input.AddUserInput(tMemPhoneNumber.Text);
                }

                dt = select.PrintStatement(select.FormatStatement(input.Checked, input.Input));
            }
            return dt;
        }

        //Shop Stock
        private DataTable SelectShopStock()
        {
            SelectItems select = new SelectItems();
            if(rAllShopStock.Checked)
            {
                dt = select.PrintStatement(select.FormatStatement());
            }
            else if (rSpecificShopStock.Checked)
            {
                input.ClearLists();

                if(cShopItemID.Checked && !tShopItemID.Text.Equals(""))
                {
                    input.AddChecked(all.Items.ItemId);
                    input.AddUserInput(tShopItemID.Text);
                }
                if(cShopItemName.Checked && !tShopItemName.Text.Equals(""))
                {
                    input.AddChecked(all.Items.Itemname);
                    input.AddUserInput(tShopItemName.Text);
                }
                if(cShopBrand.Checked && !tShopBrand.Text.Equals(""))
                {
                    input.AddChecked(all.Items.Itembrand);
                    input.AddUserInput(tShopBrand.Text);
                }
                if(cShopCategory.Checked && !tShopCategory.Text.Equals(""))
                {
                    input.AddChecked(all.Items.Category);
                    input.AddUserInput(tShopCategory.Text);
                }
                if(cShopQuantity.Checked && !tShopQuantity.Text.Equals(""))
                {
                    input.AddChecked(all.Items.ItemQuantity);
                    input.AddUserInput(tShopQuantity.Text);
                }

                dt = select.PrintStatement(select.FormatStatement(input.Checked, input.Input));
            }
            return dt;
        }

        //Transactions
        private DataTable SelectTransactions()
        {
            SelectTransactions select = new SelectTransactions();
            if(rAllTransactions.Checked)
            {
                dt = select.PrintStatement(select.FormatStatement());
            }
            else if(rSpecificTransactions.Checked)
            {
                input.ClearLists();

                if(cTranTransactionID.Checked && !tTranTransactionID.Text.Equals(""))
                {
                    input.AddChecked(all.Transactions.TransactionId);
                    input.AddUserInput(tTranTransactionID.Text);
                }
                if(cTranMemberID.Checked && !tTranMemberID.Text.Equals(""))
                {
                    input.AddChecked(all.Members.MemberId);
                    input.AddUserInput(tTranMemberID.Text);
                }
                if(cTranMemberFullName.Checked && !tTranMemberFullName.Text.Equals(""))
                {
                    input.AddChecked(all.Members.MemberFullName);
                    input.AddUserInput(tTranMemberFullName.Text);
                }
                if(cTranPurchaseDate.Checked && !tTranPurchaseDate.Text.Equals(""))
                {
                    input.AddChecked(all.Transactions.PurchaseDate);
                    input.AddUserInput(tTranPurchaseDate.Text);
                }


                dt = select.PrintStatement(select.FormatStatement(input.Checked, input.Input));
            }
            return dt;
        }

        //Purchased Items
        private DataTable SelectPurchasedItems()
        {
            SelectTransactionItems select = new SelectTransactionItems();
            if(rAllPurchasedItems.Checked)
            {
                dt = select.PrintStatement(select.FormatStatement());
            }
            else if(rSpecificPurchasedItems.Checked)
            {
                input.ClearLists();

                if(cPurTransactionID.Checked && !tPurTransactionID.Text.Equals(""))
                {
                    input.AddChecked(all.TransactionItems.TransactionId);
                    input.AddUserInput(tPurTransactionID.Text);
                }
                if (cPurMemberID.Checked && !tPurMemberID.Text.Equals(""))
                {
                    input.AddChecked(all.Members.MemberId);
                    input.AddUserInput(tPurMemberID.Text);
                }
                if (cPurMemberFullName.Checked && !tPurMemberFullName.Text.Equals(""))
                {
                    input.AddChecked(all.Members.MemberFullName);
                    input.AddUserInput(tPurMemberFullName.Text);
                }
                if (cPurItemID.Checked && !tPurItemID.Text.Equals(""))
                {
                    input.AddChecked(all.Items.ItemId);
                    input.AddUserInput(tPurItemID.Text);
                }
                if (cPurItemName.Checked && !tPurItemName.Text.Equals(""))
                {
                    input.AddChecked(all.Items.Itemname);
                    input.AddUserInput(tPurItemName.Text);
                }
                if (cPurBrand.Checked && !cPurBrand.Text.Equals(""))
                {
                    input.AddChecked(all.Items.Itembrand);
                    input.AddUserInput(tPurBrand.Text);
                }
                if (cPurPrice.Checked && !tPurPrice.Text.Equals(""))
                {
                    input.AddChecked(all.TransactionItems.Price);
                    input.AddUserInput(tPurPrice.Text);
                }
                if (cPurQuantity.Checked && !tPurQuantity.Text.Equals(""))
                {
                    input.AddChecked(all.TransactionItems.PurchaseQuantity);
                    input.AddUserInput(tPurQuantity.Text);
                }

                dt = select.PrintStatement(select.FormatStatement(input.Checked, input.Input));
            }
            return dt;
        }

        //Favourite Items
        private DataTable SelectFavouriteItems()
        {
            SelectFavouriteItems select = new SelectFavouriteItems();
            if(rAllFavouriteItems.Checked)
            {
                dt = select.PrintStatement(select.FormatStatement());
            }
            else if(rSpecificFavouriteItems.Checked)
            {
                input.ClearLists();

                if (cFaveMemberID.Checked && !tFaveMemberID.Text.Equals(""))
                {
                    input.AddChecked(all.Members.MemberId);
                    input.AddUserInput(tFaveMemberID.Text);
                }
                if (cFaveMemberFullName.Checked && !tFaveMemberFullName.Text.Equals(""))
                {
                    input.AddChecked(all.Members.MemberFullName);
                    input.AddUserInput(tFaveMemberFullName.Text);
                }
                if (cFaveItemName.Checked && !tFaveItemName.Text.Equals(""))
                {
                    input.AddChecked(all.Items.Itemname);
                    input.AddUserInput(tFaveItemName.Text);
                }
                if (cFaveTotalAmount.Checked && !tFaveTotalAmount.Text.Equals(""))
                {
                    input.AddChecked(all.TransactionItems.Total);
                    input.AddUserInput(tFaveTotalAmount.Text);
                }

                dt = select.PrintStatement(select.FormatStatement(input.Checked, input.Input));
            }

            return dt;
        }
        //==========================


        //===== SUBMIT, RESET AND CONVERT TO CSV BUTTON BEHAVIOURS
        //Reset
        private void bResetSelect_Click(object sender, EventArgs e)
        {
            SetRadioButtons(false);
            SetCheckBoxes(false);
            SetHeadingRadioButtons(false);
            ClearTextBoxes();
            EnableAll(false);
            selectErrorMessage.Text = "";
        }

        //Submit
        private void bSubmitSelect_Click(object sender, EventArgs e)
        {
            selectOutputs.DataSource = null;

            if(rMembersHeading.Checked)
            {
                //If checkboxes have not been filled correctly
                if (SelectMembers() != null)
                {
                    selectErrorMessage.Text = "Query Executed";
                    selectOutputs.DataSource = SelectMembers();
                }
                else selectErrorMessage.Text = "Please fill out specifics";
            }

            else if(rShopStockHeading.Checked)
            {
                //If checkboxes have not been filled correctly
                if (SelectShopStock() != null)
                {
                    selectErrorMessage.Text = "Query Executed";
                    selectOutputs.DataSource = SelectShopStock();
                }
                else selectErrorMessage.Text = "Please fill out specifics";
            }

            else if(rTransactionsHeading.Checked)
            {
                //If checkboxes have not been filled correctly
                if (SelectTransactions() != null)
                {
                    selectErrorMessage.Text = "Query Executed";
                    selectOutputs.DataSource = SelectTransactions();
                }
                else selectErrorMessage.Text = "Please fill out specifics";
            }

            else if(rPurchasedItemsHeading.Checked)
            {
                //If checkboxes have not been filled correctly
                if (SelectPurchasedItems() != null)
                {
                    selectErrorMessage.Text = "Query Executed";
                    selectOutputs.DataSource = SelectPurchasedItems();
                }
                else selectErrorMessage.Text = "Please fill out specifics";
            }

            else if(rFavouriteItemsHeading.Checked)
            {
                //If checkboxes have not been filled correctly
                if (SelectFavouriteItems() != null)
                {
                    //selectErrorMessage.Text = "Query Executed";
                    selectOutputs.DataSource = SelectFavouriteItems();
                }
                else selectErrorMessage.Text = "Please fill out specifics";
            }
        }

        //Convert to CSV
        private void convertToCSV_CLick(object sender, EventArgs e)
        {
            if (dt.Columns.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.Filter = "CSV (Comma delimited)|*.csv";
                saveFileDialog.DefaultExt = "csv";
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ConvertToCSV convertToCSV = new ConvertToCSV(dt);
                    convertToCSV.ToCSV(saveFileDialog.FileName);
                }
            }
            else selectErrorMessage.Text = "Please select data to convert";
        }

    }
}
