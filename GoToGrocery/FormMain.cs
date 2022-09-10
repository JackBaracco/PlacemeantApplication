using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoToGrocery
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormViewData select = new FormViewData();
            select.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormEditData select = new FormEditData();
            select.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAddData select = new FormAddData();
            select.Show();
        }
    }
}
