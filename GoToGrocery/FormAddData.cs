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
    public partial class FormAddData : Form
    {
        List<RadioButton> _headings = new List<RadioButton>();

        List<CheckBox> _memberCheckBoxes = new List<CheckBox>();
        List<TextBox> _memberTextBoxes = new List<TextBox>();

        List<CheckBox> _shopStockCheckBoxes = new List<CheckBox>();
        List<TextBox> _shopStockTextBoxes = new List<TextBox>();

        List<CheckBox> _transactionsCheckBoxes = new List<CheckBox>();
        List<TextBox> _transactionsTextBoxes = new List<TextBox>();

        List<CheckBox> _purchasedItemsCheckBoxes = new List<CheckBox>();
        List<TextBox> _purchasedItemsTextBoxes = new List<TextBox>();

        UserInputHandler input = new UserInputHandler();
        CheckBoxesAll all = new CheckBoxesAll();
        InsertStatements insert = new InsertStatements();

        SelectMembers selectMembers = new SelectMembers();
        SelectItems selectItems = new SelectItems();
        SelectTransactions selectTransactions = new SelectTransactions();
        SelectTransactionItems selectTransactionItems = new SelectTransactionItems();

        public FormAddData()
        {
            InitializeComponent();

            FillLists();

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
        }

        //Members
        private void AddMemberCheckBoxes()
        {
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
        private void AddShopStockCheckBoxes()
        {
            _shopStockCheckBoxes.Add(cShopItemName);
            _shopStockCheckBoxes.Add(cShopBrand);
            _shopStockCheckBoxes.Add(cShopCategory);
            _shopStockCheckBoxes.Add(cShopQuantity);
        }

        private void AddShopStockTextBoxes()
        {
            _shopStockTextBoxes.Add(tShopItemName);
            _shopStockTextBoxes.Add(tShopBrand);
            _shopStockTextBoxes.Add(tShopCategory);
            _shopStockTextBoxes.Add(tShopQuantity);
        }

        //Transactions
        private void AddTransactionsCheckBoxes()
        {
            _transactionsCheckBoxes.Add(cTranMemberID);
            _transactionsCheckBoxes.Add(cTranPurchaseDate);
        }

        private void AddTransactionsTextBoxes()
        {
            _transactionsTextBoxes.Add(tTranMemberID);
            _transactionsTextBoxes.Add(tTranPurchaseDate);
        }

        //Purchased Items
        private void AddPurchasedItemsCheckBoxes()
        {
            _purchasedItemsCheckBoxes.Add(cPurTransactionID);
            _purchasedItemsCheckBoxes.Add(cPurItemID);
            _purchasedItemsCheckBoxes.Add(cPurPrice);
            _purchasedItemsCheckBoxes.Add(cPurQuantity);
        }

        private void AddPurchasedItemsTextBoxes()
        {
            _purchasedItemsTextBoxes.Add(tPurTransactionID);
            _purchasedItemsTextBoxes.Add(tPurItemID);
            _purchasedItemsTextBoxes.Add(tPurPrice);
            _purchasedItemsTextBoxes.Add(tPurQuantity);
        }

        public void FillLists()
        {
            AddHeadingRadioButtons();
            AddMemberCheckBoxes();
            AddMemberTextBoxes();
            AddShopStockCheckBoxes();
            AddShopStockTextBoxes();
            AddTransactionsCheckBoxes();
            AddTransactionsTextBoxes();
            AddPurchasedItemsCheckBoxes();
            AddPurchasedItemsTextBoxes();
        }
        //==========================

        //Setters for all checked values for headings radiobuttons
        private void SetHeadingRadioButtons(bool value)
        {
            foreach (RadioButton radioButton in _headings)
            {
                radioButton.Checked = value;
            }
        }

        //Setters for all checked values for checkboxes
        private void SetCheckBoxes(bool value)
        {
            foreach (CheckBox checkBox in _memberCheckBoxes)
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
        }

        //Clearing all text boxes
        private void ClearTextBoxes()
        {
            foreach (TextBox textBox in _memberTextBoxes)
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
        }


        //===== ENABLING/DISABLING CHECKBOXES, TEXTBOXES AND BUTTONS FOR EACH QUERY =====
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

        //Enable/Disable checkboxes related to Transactions Details
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

        //Enable/Disable Submit and Reset buttons
        private void EnableSubmitReset(bool value)
        {
            bSubmitSelect.Enabled = value;
            bResetSelect.Enabled = value;
        }

        //Setter for enabling/disabling all radiobuttons, checkboxes and textboxes
        private void EnableAll(bool value)
        {
            EnableMemberCT(value);

            EnableShopStockCT(value);

            EnableTransactionsCT(value);

            EnablePurchasedItemsCT(value);

            EnableSubmitReset(value);
        }
        //==========================


        //===== CHECK BOX BEHAVIOURS =====
        //If a checkbox becomes unchecked, the correspoonding textbox will be set to an empty string
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

        private void cTranMemberID_CheckedChanged(object sender, EventArgs e)
        {
            if (!cTranMemberID.Checked) tTranMemberID.Text = "";
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
            if (!cPurItemID.Checked) tPurItemID.Text = "";
        }

        private void cPurPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (!cPurPrice.Checked) tPurPrice.Text = "";
        }

        private void cPurQuantity_CheckedChanged(object sender, EventArgs e)
        {
            if (!cPurQuantity.Checked) tPurQuantity.Text = "";
        }
        //==========================


        //===== RADIO BUTTON BEHAVIOURS =====
        private void ResetHeadings()
        {
            EnableAll(false);
            SetCheckBoxes(false);
        }
        //Members
        private void rMembersHeading_CheckedChanged(object sender, EventArgs e)
        {
            ResetHeadings();
            EnableMemberCT(true);
            EnableSubmitReset(true);

            //Print current table to grid
            selectOutputs.DataSource = selectMembers.PrintStatement(selectMembers.FormatStatement());
        }

        //Shop Stock
        private void rShopStockHeading_CheckedChanged(object sender, EventArgs e)
        {
            ResetHeadings();
            EnableShopStockCT(true);
            EnableSubmitReset(true);

            //Print current table to grid
            selectOutputs.DataSource = selectItems.PrintStatement(selectItems.FormatStatement());
        }

        //Transactions
        private void rTransactionsHeading_CheckedChanged(object sender, EventArgs e)
        {
            ResetHeadings();
            EnableTransactionsCT(true);
            EnableSubmitReset(true);

            //Print current table to grid
            selectOutputs.DataSource = selectTransactions.PrintStatement(selectTransactions.FormatStatement());
        }

        //Purchased Items
        private void rPurchasedItemsHeading_CheckedChanged(object sender, EventArgs e)
        {
            ResetHeadings();
            EnablePurchasedItemsCT(true);
            EnableSubmitReset(true);

            //Print current table to grid
            selectOutputs.DataSource = selectTransactionItems.PrintStatement(selectTransactionItems.FormatStatement());
        }
        //==========================


        //===== CREATING QUERIES =====
        //Members
        private string SelectMembers()
        {
            if (rMembersHeading.Checked)
            {
                input.ClearLists();

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
                if (cMemPostcode.Checked && !tMemPostcode.Text.Equals(""))
                {
                    input.AddChecked(all.Members.Postcode);
                    input.AddUserInput(tMemPostcode.Text);
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

                return insert.PrintConfirmation(insert.FormatStatement(all.Tables.Members, input.Checked, input.Input));
            }
            return "Please fill out specifics";
        }

        //Shop Stock
        private string SelectShopStock()
        {
            if (rShopStockHeading.Checked)
            {
                input.ClearLists();

                if (cShopItemName.Checked && !tShopItemName.Text.Equals(""))
                {
                    input.AddChecked(all.Items.Itemname);
                    input.AddUserInput(tShopItemName.Text);
                }
                if (cShopBrand.Checked && !tShopBrand.Text.Equals(""))
                {
                    input.AddChecked(all.Items.Itembrand);
                    input.AddUserInput(tShopBrand.Text);
                }
                if (cShopCategory.Checked && !tShopCategory.Text.Equals(""))
                {
                    input.AddChecked(all.Items.Category);
                    input.AddUserInput(tShopCategory.Text);
                }
                if (cShopQuantity.Checked && !tShopQuantity.Text.Equals(""))
                {
                    input.AddChecked(all.Items.ItemQuantity);
                    input.AddUserInput(tShopQuantity.Text);
                }

                return insert.PrintConfirmation(insert.FormatStatement(all.Tables.Items, input.Checked, input.Input));
            }
            return "Please fill out specifics";
        }

        //Transactions
        private string SelectTransactions()
        {
            if (rTransactionsHeading.Checked)
            {
                input.ClearLists();

                if (cTranMemberID.Checked && !tTranMemberID.Text.Equals(""))
                {
                    input.AddChecked(all.Members.MemberId);
                    input.AddUserInput(tTranMemberID.Text);
                }
                if (cTranPurchaseDate.Checked && !tTranPurchaseDate.Text.Equals(""))
                {
                    input.AddChecked(all.Transactions.PurchaseDate);
                    input.AddUserInput(tTranPurchaseDate.Text);
                }

                return insert.PrintConfirmation(insert.FormatStatement(all.Tables.Transactions, input.Checked, input.Input));
            }
            return "Please fill out specifics";
        }

        //Purchased Items
        private string SelectPurchasedItems()
        {
            if (rPurchasedItemsHeading.Checked)
            {
                input.ClearLists();

                if (cPurTransactionID.Checked && !tPurTransactionID.Text.Equals(""))
                {
                    input.AddChecked(all.TransactionItems.TransactionId);
                    input.AddUserInput(tPurTransactionID.Text);
                }
                if (cPurItemID.Checked && !tPurItemID.Text.Equals(""))
                {
                    input.AddChecked(all.TransactionItems.ItemID);
                    input.AddUserInput(tPurItemID.Text);
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

                return insert.PrintConfirmation(insert.FormatStatement(all.Tables.Transactionitems, input.Checked, input.Input));
            }
            return "Please fill out specifics";
        }
        //==========================


        //===== SUBMIT AND RESET BUTTON BEHAVIOURS
        //Reset
        private void bResetSelect_Click(object sender, EventArgs e)
        {
            SetCheckBoxes(false);
            SetHeadingRadioButtons(false);
            ClearTextBoxes();
            EnableAll(false);
        }

        //Submit
        private void bSubmitSelect_Click(object sender, EventArgs e)
        {
            selectOutputs.DataSource = null;

            if (rMembersHeading.Checked)
            {
                selectErrorMessage.Text = SelectMembers();
                selectOutputs.DataSource = selectMembers.PrintStatement(selectMembers.FormatStatement());
            }

            else if (rShopStockHeading.Checked)
            {
                selectErrorMessage.Text = SelectShopStock();
                selectOutputs.DataSource = selectItems.PrintStatement(selectItems.FormatStatement());
            }

            else if (rTransactionsHeading.Checked)
            {
                selectErrorMessage.Text = SelectTransactions();
                selectOutputs.DataSource = selectTransactions.PrintStatement(selectTransactions.FormatStatement());
            }

            else if (rPurchasedItemsHeading.Checked)
            {
                selectErrorMessage.Text = SelectPurchasedItems();
                selectOutputs.DataSource = selectTransactionItems.PrintStatement(selectTransactionItems.FormatStatement());
            }
        }
        //==========================
    }
}
