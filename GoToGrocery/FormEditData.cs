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
    public partial class FormEditData : Form
    {
        List<RadioButton> _headings = new List<RadioButton>();

        List<CheckBox> _memberCheckBoxes = new List<CheckBox>();
        List<TextBox> _memberTextBoxes = new List<TextBox>();
        List<RadioButton> _fmemberRadioButtons = new List<RadioButton>();
        List<TextBox> _fmemberTextBoxes = new List<TextBox>();

        List<CheckBox> _shopStockCheckBoxes = new List<CheckBox>();
        List<TextBox> _shopStockTextBoxes = new List<TextBox>();
        List<RadioButton> _fshopStockRadioButtons = new List<RadioButton>();
        List<TextBox> _fshopStockTextBoxes = new List<TextBox>();

        List<CheckBox> _transactionsCheckBoxes = new List<CheckBox>();
        List<TextBox> _transactionsTextBoxes = new List<TextBox>();
        List<RadioButton> _ftransactionsRadioButtons = new List<RadioButton>();
        List<TextBox> _ftransactionsTextBoxes = new List<TextBox>();

        List<CheckBox> _purchasedItemsCheckBoxes = new List<CheckBox>();
        List<TextBox> _purchasedItemsTextBoxes = new List<TextBox>();
        List<RadioButton> _fpurchasedItemsRadioButtons = new List<RadioButton>();
        List<TextBox> _fpurchasedItemsTextBoxes = new List<TextBox>();


        UserInputHandler input = new UserInputHandler();
        UserInputHandler where = new UserInputHandler();
        CheckBoxesAll all = new CheckBoxesAll();
        UpdateStatements update = new UpdateStatements();

        public FormEditData()
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
            //New Data section
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
            //New Data section
            _memberTextBoxes.Add(tMemMemberFullName);
            _memberTextBoxes.Add(tMemStreetNumber);
            _memberTextBoxes.Add(tMemUnitNumber);
            _memberTextBoxes.Add(tMemStreetName);
            _memberTextBoxes.Add(tMemSuburb);
            _memberTextBoxes.Add(tMemPostcode);
            _memberTextBoxes.Add(tMemCity);
            _memberTextBoxes.Add(tMemPhoneNumber);

            //Update section
            _fmemberTextBoxes.Add(tfMemMemberID);
            _fmemberTextBoxes.Add(tfMemMemberFullName);
            _fmemberTextBoxes.Add(tfMemStreetNumber);
            _fmemberTextBoxes.Add(tfMemUnitNumber);
            _fmemberTextBoxes.Add(tfMemStreetName);
            _fmemberTextBoxes.Add(tfMemSuburb);
            _fmemberTextBoxes.Add(tfMemPostcode);
            _fmemberTextBoxes.Add(tfMemCity);
            _fmemberTextBoxes.Add(tfMemPhoneNumber);
        }

        private void AddMemberRadioButtons()
        {
            //Update section
            _fmemberRadioButtons.Add(rfMemMemberID);
            _fmemberRadioButtons.Add(rfMemMemberFullName);
            _fmemberRadioButtons.Add(rfMemStreetNumber);
            _fmemberRadioButtons.Add(rfMemUnitNumber);
            _fmemberRadioButtons.Add(rfMemStreetName);
            _fmemberRadioButtons.Add(rfMemSuburb);
            _fmemberRadioButtons.Add(rfMemPostcode);
            _fmemberRadioButtons.Add(rfMemCity);
            _fmemberRadioButtons.Add(rfMemPhoneNumber);
        }

        //Shop Stock
        private void AddShopStockCheckBoxes()
        {
            //New Data Section
            _shopStockCheckBoxes.Add(cShopItemName);
            _shopStockCheckBoxes.Add(cShopBrand);
            _shopStockCheckBoxes.Add(cShopCategory);
            _shopStockCheckBoxes.Add(cShopQuantity);
        }

        private void AddShopStockTextBoxes()
        {
            //New Data Section
            _shopStockTextBoxes.Add(tShopItemName);
            _shopStockTextBoxes.Add(tShopBrand);
            _shopStockTextBoxes.Add(tShopCategory);
            _shopStockTextBoxes.Add(tShopQuantity);

            //Update section
            _fshopStockTextBoxes.Add(tfShopItemID);
            _fshopStockTextBoxes.Add(tfShopItemName);
            _fshopStockTextBoxes.Add(tfShopBrand);
            _fshopStockTextBoxes.Add(tfShopCategory);
            _fshopStockTextBoxes.Add(tfShopQuantity);
        }

        private void AddShopStockRadioButtons()
        {
            //Update section
            _fshopStockRadioButtons.Add(rfShopItemID);
            _fshopStockRadioButtons.Add(rfShopItemName);
            _fshopStockRadioButtons.Add(rfShopBrand);
            _fshopStockRadioButtons.Add(rfShopCategory);
            _fshopStockRadioButtons.Add(rfShopQuantity);
        }

        //Transactions
        private void AddTransactionsCheckBoxes()
        {
            _transactionsCheckBoxes.Add(cTranMemberID);
            _transactionsCheckBoxes.Add(cTranPurchaseDate);
        }

        private void AddTransactionsTextBoxes()
        {
            //New Data Section
            _transactionsTextBoxes.Add(tTranMemberID);
            _transactionsTextBoxes.Add(tTranPurchaseDate);

            //Update section
            _ftransactionsTextBoxes.Add(tfTranTransactionID);
            _ftransactionsTextBoxes.Add(tfTranMemberID);
            _ftransactionsTextBoxes.Add(tfTranPurchaseDate);
        }

        private void AddTransactionsRadioButtons()
        {
            //Update section
            _ftransactionsRadioButtons.Add(rfTranTransactionID);
            _ftransactionsRadioButtons.Add(rfTranMemberID);
            _ftransactionsRadioButtons.Add(rfTranPurchaseDate);
        }

        //Purchased Items
        private void AddPurchasedItemsCheckBoxes()
        {
            //New Data Section
            _purchasedItemsCheckBoxes.Add(cPurPrice);
            _purchasedItemsCheckBoxes.Add(cPurQuantity);
        }

        private void AddPurchasedItemsTextBoxes()
        {
            //New Data Section
            _purchasedItemsTextBoxes.Add(tPurPrice);
            _purchasedItemsTextBoxes.Add(tPurQuantity);

            //Update section
            _fpurchasedItemsTextBoxes.Add(tfPurTransactionID);
            _fpurchasedItemsTextBoxes.Add(tfPurItemID);
            _fpurchasedItemsTextBoxes.Add(tfPurPrice);
            _fpurchasedItemsTextBoxes.Add(tfPurQuantity);
        }

        private void AddPurchasedItemsRadioButtons()
        {
            //Update section
            _fpurchasedItemsRadioButtons.Add(rfPurTransactionID);
            _fpurchasedItemsRadioButtons.Add(rfPurItemID);
            _fpurchasedItemsRadioButtons.Add(rfPurPrice);
            _fpurchasedItemsRadioButtons.Add(rfPurQuantity);
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
            AddMemberRadioButtons();
            AddShopStockRadioButtons();
            AddTransactionsRadioButtons();
            AddPurchasedItemsRadioButtons();
        }
        //============================================================================


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

        //Setters for all checked values Radio Buttons
        private void SetRadioButtons(bool value)
        {
            foreach(RadioButton radioButton in _fmemberRadioButtons)
            {
                radioButton.Checked = value;
            }
            foreach (RadioButton radioButton in _fshopStockRadioButtons)
            {
                radioButton.Checked = value;
            }
            foreach (RadioButton radioButton in _ftransactionsRadioButtons)
            {
                radioButton.Checked = value;
            }
            foreach (RadioButton radioButton in _fpurchasedItemsRadioButtons)
            {
                radioButton.Checked = (radioButton.Text.ToLower().Equals("transaction id") || radioButton.Text.ToLower().Equals("item id")) ? true : value;
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


        //===== ENABLING/DISABLING RADIO BUTTONS, CHECKBOXES, TEXTBOXES AND BUTTONS FOR EACH QUERY =====
        //Enable/Disable checkboxes and text boxes related to Member Details in New Data Section
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

        //Enable/Disable radio buttons and text boxes related to Member Details in Update Section
        private void EnableMemberRT(bool value)
        {
            foreach (RadioButton radioButton in _fmemberRadioButtons)
            {
                radioButton.Enabled = value;
            }
            foreach (TextBox textBox in _fmemberTextBoxes)
            {
                textBox.Enabled = value;
            }
        }

        //Enable/Disable checkboxes related to Shop Stock Details in New Data Section
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

        //Enable/Disable radio buttons and text boxes related to Shop Stock in Update section
        private void EnableShopStockRT(bool value)
        {
            foreach (RadioButton radioButton in _fshopStockRadioButtons)
            {
                radioButton.Enabled = value;
            }
            foreach (TextBox textBox in _fshopStockTextBoxes)
            {
                textBox.Enabled = value;
            }
        }

        //Enable/Disable checkboxes to Transactions Details in New Data Section
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

        //Enable/Disable radio buttons and text boxes related to Transactions in Update section
        private void EnableTransactionsRT(bool value)
        {
            foreach (RadioButton radioButton in _ftransactionsRadioButtons)
            {
                radioButton.Enabled = value;
            }
            foreach (TextBox textBox in _ftransactionsTextBoxes)
            {
                textBox.Enabled = value;
            }
        }

        //Enable/Disable checkboxes related to Purchased Items in New Data Section
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

        //Enable/Disable radio buttons and text boxes related to Purchased Items in Update section
        private void EnablePurchasedItemsRT(bool value)
        {
            foreach (RadioButton radioButton in _fpurchasedItemsRadioButtons)
            {
                radioButton.Enabled = value;
            }
            foreach (TextBox textBox in _fpurchasedItemsTextBoxes)
            {
                textBox.Enabled = value;
            }
        }

        //Enable/Disable Submit and Reset buttons
        private void EnableSubmitReset(bool value)
        {
            bSubmitUpdate.Enabled = value;
            bResetUpdate.Enabled = value;
        }

        //Setter for all enabling/disabling radiobuttons, checkboxes and textboxes
        private void EnableAll(bool value)
        {
            EnableMemberCT(value);
            EnableMemberRT(value);

            EnableShopStockCT(value);
            EnableShopStockRT(value);

            EnableTransactionsCT(value);
            EnableTransactionsRT(value);

            EnablePurchasedItemsCT(value);
            EnablePurchasedItemsRT(value);

            EnableSubmitReset(value);
        }
        //============================================================================


        //===== CHECK BOX BEHAVIOURS =====
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

        private void cPurPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (!cPurPrice.Checked) tPurPrice.Text = "";
        }

        private void cPurQuantity_CheckedChanged(object sender, EventArgs e)
        {
            if (!cPurQuantity.Checked) tPurQuantity.Text = "";
        }
        //============================================================================


        //===== RADIO BUTTON BEHAVIOURS =====
        //HEADINGS BUTTONS
        private void ResetHeadings()
        {
            EnableAll(false);
            SetRadioButtons(false);
            SetCheckBoxes(false);
            EnableSubmitReset(false);
        }
        //Members
        private void rMembersHeading_CheckedChanged(object sender, EventArgs e)
        {
            ResetHeadings();
            EnableMemberCT(true);
            EnableMemberRT(true);
            EnableSubmitReset(true);
        }

        //Shop Stock
        private void rShopStockHeading_CheckedChanged(object sender, EventArgs e)
        {
            ResetHeadings();
            EnableShopStockCT(true);
            EnableShopStockRT(true);
            EnableSubmitReset(true);
        }

        //Transactions
        private void rTransactionsHeading_CheckedChanged(object sender, EventArgs e)
        {
            ResetHeadings();
            EnableTransactionsCT(true);
            EnableTransactionsRT(true);
            EnableSubmitReset(true);
        }

        //Purchased Items
        private void rPurchasedItemsHeading_CheckedChanged(object sender, EventArgs e)
        {
            ResetHeadings();
            EnablePurchasedItemsCT(true);
            EnablePurchasedItemsRT(true);
            EnableSubmitReset(true);
        }

        //ALL OTHER RADIO BUTTONS
        private void rfMemMemberID_CheckedChanged(object sender, EventArgs e)
        {
            if (!rfMemMemberID.Checked) tfMemMemberID.Text = "";
        }

        private void rfMemMemberFullName_CheckedChanged(object sender, EventArgs e)
        {
            if (!rfMemMemberFullName.Checked) tfMemMemberFullName.Text = "";
        }

        private void rfMemStreetNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (!rfMemStreetNumber.Checked) tfMemStreetNumber.Text = "";
        }

        private void rfMemUnitNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (!rfMemUnitNumber.Checked) tfMemUnitNumber.Text = "";
        }

        private void rfMemStreetName_CheckedChanged(object sender, EventArgs e)
        {
            if (!rfMemStreetName.Checked) tfMemStreetName.Text = "";
        }

        private void rfMemSuburb_CheckedChanged(object sender, EventArgs e)
        {
            if (!rfMemSuburb.Checked) tfMemSuburb.Text = "";
        }

        private void rfMemPostcode_CheckedChanged(object sender, EventArgs e)
        {
            if (!rfMemPostcode.Checked) tfMemPostcode.Text = "";
        }

        private void rfMemCity_CheckedChanged(object sender, EventArgs e)
        {
            if (!rfMemCity.Checked) tfMemCity.Text = "";
        }

        private void rfMemPhoneNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (!rfMemPhoneNumber.Checked) tfMemPhoneNumber.Text = "";
        }

        private void rfShopItemID_CheckedChanged(object sender, EventArgs e)
        {
            if (!rfShopItemID.Checked) tfShopItemID.Text = "";
        }

        private void rfShopItemName_CheckedChanged(object sender, EventArgs e)
        {
            if (!rfShopItemName.Checked) tfShopItemName.Text = "";
        }

        private void rfShopBrand_CheckedChanged(object sender, EventArgs e)
        {
            if (!rfShopBrand.Checked) tfShopBrand.Text = "";
        }

        private void rfShopCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (!rfShopCategory.Checked) tfShopCategory.Text = "";
        }

        private void rfShopQuantity_CheckedChanged(object sender, EventArgs e)
        {
            if (!rfShopQuantity.Checked) tfShopQuantity.Text = "";
        }

        private void rfTranTransactionID_CheckedChanged(object sender, EventArgs e)
        {
            if (!rfTranTransactionID.Checked) tfTranTransactionID.Text = "";
        }

        private void rfTranMemberID_CheckedChanged(object sender, EventArgs e)
        {
            if (!rfTranMemberID.Checked) tfTranMemberID.Text = "";
        }

        private void rfTranPurchaseDate_CheckedChanged(object sender, EventArgs e)
        {
            if (!rfTranPurchaseDate.Checked) tfTranPurchaseDate.Text = "";
        }

        private void rfPurTransactionID_CheckedChanged(object sender, EventArgs e)
        {
            if (!rfPurTransactionID.Checked) tfPurTransactionID.Text = "";
        }

        private void rfPurItemID_CheckedChanged(object sender, EventArgs e)
        {
            if (!rfPurItemID.Checked) tfPurItemID.Text = "";
        }

        private void rfPurPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (!rfPurPrice.Checked) tfPurPrice.Text = "";
        }

        private void rfPurQuantity_CheckedChanged(object sender, EventArgs e)
        {
            if (!rfPurQuantity.Checked) tfPurQuantity.Text = "";
        }
        //============================================================================

        //===== CREATING QUERIES =====
        //Members
        private string UpdateMembers()
        {
            if (rMembersHeading.Checked)
            {
                input.ClearLists();
                where.ClearLists();

                //Add all inputs to lists
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

                //Parameters for finding what to update
                if (rfMemMemberID.Checked && !tfMemMemberID.Text.Equals(""))
                {
                    where.AddChecked(all.Members.MemberId);
                    where.AddUserInput(tfMemMemberID.Text);
                }
                if (rfMemMemberFullName.Checked && !rfMemMemberFullName.Text.Equals(""))
                {
                    where.AddChecked(all.Members.MemberFullName);
                    where.AddUserInput(tfMemMemberFullName.Text);
                }
                if (rfMemStreetNumber.Checked && !tfMemStreetNumber.Text.Equals(""))
                {
                    where.AddChecked(all.Members.StreetNumber);
                    where.AddUserInput(tfMemStreetNumber.Text);
                }
                if (rfMemUnitNumber.Checked && !tfMemUnitNumber.Text.Equals(""))
                {
                    where.AddChecked(all.Members.UnitNumber);
                    where.AddUserInput(tfMemUnitNumber.Text);
                }
                if (rfMemStreetName.Checked && !tfMemStreetName.Text.Equals(""))
                {
                    where.AddChecked(all.Members.StreetName);
                    where.AddUserInput(tfMemStreetName.Text);
                }
                if (rfMemSuburb.Checked && !tfMemSuburb.Text.Equals(""))
                {
                    where.AddChecked(all.Members.Suburb);
                    where.AddUserInput(tfMemSuburb.Text);
                }
                if (rfMemPostcode.Checked && !tfMemPostcode.Text.Equals(""))
                {
                    where.AddChecked(all.Members.Postcode);
                    where.AddUserInput(tfMemPostcode.Text);
                }
                if (rfMemCity.Checked && !tfMemCity.Text.Equals(""))
                {
                    where.AddChecked(all.Members.City);
                    where.AddUserInput(tfMemCity.Text);
                }
                if (rfMemPhoneNumber.Checked && !tfMemPhoneNumber.Text.Equals(""))
                {
                    where.AddChecked(all.Members.PhoneNumber);
                    where.AddUserInput(tfMemPhoneNumber.Text);
                }

                //Failsafe to make sure only one parameter for finding what to update is selected
                if(where.Checked.Count == 1)
                {
                    return update.PrintConfirmation(update.FormatStatement(all.Tables.Members, input.Checked, input.Input, where.Checked, where.Input));
                }
            }
            return "Update query failed to be processed";
        }
        
        //Shop Stock
        private string UpdateShopStock()
        {
            if (rShopStockHeading.Checked)
            {
                input.ClearLists();
                where.ClearLists();

                //Add all inputs to lists
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

                //Parameters for finding what to update
                if(rfShopItemID.Checked && !tfShopItemID.Text.Equals(""))
                {
                    where.AddChecked(all.Items.ItemId);
                    where.AddUserInput(tfShopItemID.Text);
                }
                if (rfShopItemName.Checked && !tfShopItemName.Text.Equals(""))
                {
                    where.AddChecked(all.Items.Itemname);
                    where.AddUserInput(tShopItemName.Text);
                }
                if (rfShopBrand.Checked && !tfShopBrand.Text.Equals(""))
                {
                    where.AddChecked(all.Items.Itembrand);
                    where.AddUserInput(tShopBrand.Text);
                }
                if (rfShopCategory.Checked && !tfShopCategory.Text.Equals(""))
                {
                    where.AddChecked(all.Items.Category);
                    where.AddUserInput(tShopCategory.Text);
                }
                if (rfShopQuantity.Checked && !tfShopQuantity.Text.Equals(""))
                {
                    where.AddChecked(all.Items.Category);
                    where.AddUserInput(tShopQuantity.Text);
                }
                //Failsafe to make sure only one parameter for finding what to update is selected
                if (where.Checked.Count == 1)
                {
                    return update.PrintConfirmation(update.FormatStatement(all.Tables.Items, input.Checked, input.Input, where.Checked, where.Input));
                }
            }
            return "Update query failed to be processed";
        }

        //Transactions
        private string UpdateTransactions()
        {
            if (rTransactionsHeading.Checked)
            {
                input.ClearLists();
                where.ClearLists();

                //Add all inputs to lists
                if (cTranMemberID.Checked && !tTranMemberID.Text.Equals(""))
                {
                    input.AddChecked(all.Transactions.MemberId);
                    input.AddUserInput(tTranMemberID.Text);
                }
                if (cTranPurchaseDate.Checked && !tTranPurchaseDate.Text.Equals(""))
                {
                    input.AddChecked(all.Transactions.PurchaseDate);
                    input.AddUserInput(tTranPurchaseDate.Text);
                }

                //Parameters for finding what to update
                if (rfTranTransactionID.Checked && !tfTranTransactionID.Text.Equals(""))
                {
                    where.AddChecked(all.Transactions.TransactionId);
                    where.AddUserInput(tfTranTransactionID.Text);
                }
                if (rfTranMemberID.Checked && !tfTranMemberID.Text.Equals(""))
                {
                    where.AddChecked(all.Members.MemberId);
                    where.AddUserInput(tfTranMemberID.Text);
                }
                if (cTranMemberID.Checked && !tfTranPurchaseDate.Text.Equals(""))
                {
                    where.AddChecked(all.Transactions.PurchaseDate);
                    where.AddUserInput(tfTranPurchaseDate.Text);
                }
                //Failsafe to make sure only one parameter for finding what to update is selected
                if (where.Checked.Count == 1)
                {
                    return update.PrintConfirmation(update.FormatStatement(all.Tables.Transactions, input.Checked, input.Input, where.Checked, where.Input));
                }
            }
            return "Update query failed to be processed";
        }

        //Purchased Items
        private string UpdatePurchasedItems()
        {
            if (rPurchasedItemsHeading.Checked)
            {
                input.ClearLists();
                where.ClearLists();

                //Add all inputs to lists
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

                //Parameters for finding what to update
                if (rfPurTransactionID.Checked && !tfTranTransactionID.Text.Equals(""))
                {
                    where.AddChecked(all.TransactionItems.TransactionId);
                    where.AddUserInput(tfPurTransactionID.Text);
                }
                if (rfPurItemID.Checked && !tfPurItemID.Text.Equals(""))
                {
                    where.AddChecked(all.Items.ItemId);
                    where.AddUserInput(tfPurItemID.Text);
                }
                if (rfPurPrice.Checked && !tfPurPrice.Text.Equals(""))
                {
                    where.AddChecked(all.TransactionItems.Price);
                    where.AddUserInput(tfPurPrice.Text);
                }
                if (rfPurQuantity.Checked && !tfPurQuantity.Text.Equals(""))
                {
                    where.AddChecked(all.TransactionItems.PurchaseQuantity);
                    where.AddUserInput(tfPurQuantity.Text);
                }

                //Failsafe to make sure only one parameter for finding what to update is selected
                if (where.Checked.Count == 1)
                {
                    return update.PrintConfirmation(update.FormatStatement(all.Tables.Transactionitems, input.Checked, input.Input, where.Checked, where.Input));
                }
            }
            return "Update query failed to be processed";
        }
        //============================================================================


        //===== SUBMIT AND RESET BUTTON BEHAVIOURS
        //Reset
        private void bResetSelect_Click(object sender, EventArgs e)
        {
            SetRadioButtons(false);
            SetCheckBoxes(false);
            SetHeadingRadioButtons(false);
            ClearTextBoxes();
            EnableAll(false);
        }

        //Submit
        private void bSubmitSelect_Click(object sender, EventArgs e)
        {

            if (rMembersHeading.Checked)
            {
                updateErrorMessage.Text = UpdateMembers();
            }
            
            else if (rShopStockHeading.Checked)
            {
                updateErrorMessage.Text = UpdateShopStock();
            }
            

            else if (rTransactionsHeading.Checked)
            {
                updateErrorMessage.Text = UpdateTransactions();
            }

            else if (rPurchasedItemsHeading.Checked)
            {
                updateErrorMessage.Text = UpdatePurchasedItems();
            }
            
        }
        //============================================================================

    }
}
