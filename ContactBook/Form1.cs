using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace ContactBook
{
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }

        private void disable_Save_Cancel()
        {
            this.saveToolButton.Enabled = false;
            this.cancelToolButton.Enabled = false;
            this.editToolButton.Enabled = true;
            this.deleteToolButton.Enabled = true;
            this.newToolButton.Enabled = true;
            this.exitToolButton.Enabled = true;
        }

        private void disable4Edit()
        {
            this.editToolButton.Enabled = false;
            this.newToolButton.Enabled = false;
            this.deleteToolButton.Enabled = false;
            this.saveToolButton.Enabled = true;
            this.cancelToolButton.Enabled = true;
            this.exitToolButton.Enabled = false;
        }


        private void ContactForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phonebook_ds.phone_book_table' table. You can move, or remove it, as needed.
            this.phone_book_tableTableAdapter.Fill_all(this.phonebook_ds.phone_book_table);
            disable_Save_Cancel();
            this.details_GroupBox.Enabled = false;
        }

        private void phone_book_tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phone_book_tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.phonebook_ds);

        }

        private void exitToolButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolButton_Click(object sender, EventArgs e)
        {
            disable4Edit();
            this.details_GroupBox.Enabled = true;
            this.search_DataGridView.Enabled = false;
            
        }

        private void editToolButton_Click(object sender, EventArgs e)
        {
            disable4Edit();
            this.details_GroupBox.Enabled = true;
            this.search_DataGridView.Enabled = false;
        }

        private void saveToolButton_Click(object sender, EventArgs e)
        {
            disable_Save_Cancel();
            this.details_GroupBox.Enabled = false;
            this.search_DataGridView.Enabled = true;

        }

        private void cancelToolButton_Click(object sender, EventArgs e)
        {
            disable_Save_Cancel();
            this.details_GroupBox.Enabled = false;
            this.search_DataGridView.Enabled = true;
        }
    }
}
