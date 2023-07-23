using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactBook
{
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }


        private void ContactForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phonebook_ds.phone_book_table' table. You can move, or remove it, as needed.
            this.phone_book_tableTableAdapter.Fill_all(this.phonebook_ds.phone_book_table);
        }

        private void phone_book_tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phone_book_tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.phonebook_ds);

        }
    }
}
