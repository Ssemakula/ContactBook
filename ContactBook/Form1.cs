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
using static SsCommon.CommonProcs;

namespace ContactBook
{
    public partial class ContactForm : Form
    {
        bool isEditingRecord = false;

        public ContactForm()
        {
            InitializeComponent();
        }

        private void record_display()
        {
            long rec_count, rec_select;

            rec_count = this.phone_book_tableBindingSource.Count;
            rec_select = this.phone_book_tableBindingSource.Position;
            update_counters();
            this.diplayCountLable.Text = String.Format("Selected record {0} of {1}", rec_select + 1, rec_count);
        }

        private void recordUpdateDisplay(object sender, EventArgs e)
        {
            long rec_count, rec_select;

            rec_count = this.phone_book_tableBindingSource.Count;
            rec_select = this.phone_book_tableBindingSource.Position;
            update_counters();
            this.diplayCountLable.Text = String.Format("Selected record {0} of {1}", rec_select+1, rec_count);
        }

        private void disable_Save_Cancel()
        {
            isEditingRecord = false;
            this.saveToolButton.Enabled = false;
            this.cancelToolButton.Enabled = false;
            if (this.phonebook_ds.phone_book_table.Rows.Count == 0)
            {
                this.editToolButton.Enabled = false;
                this.deleteToolButton.Enabled = false;
            }
            else
            {
                this.editToolButton.Enabled = true;
                this.deleteToolButton.Enabled = true;
            }
            this.newToolButton.Enabled = true;
            //this.exitToolButton.Enabled = true;
            this.search_DataGridView.Enabled = true;
            this.details_GroupBox.Enabled = false;
            this.phoneBookToolStrip.Enabled = true;
            this.exitToolStripButton.Enabled = true;
            update_counters() ;
        }

        private void disable4Edit()
        {
            isEditingRecord = true;
            this.editToolButton.Enabled = false;
            this.newToolButton.Enabled = false;
            this.deleteToolButton.Enabled = false;
            this.saveToolButton.Enabled = true;
            this.cancelToolButton.Enabled = true;
            //this.exitToolButton.Enabled = false;
            this.search_DataGridView.Enabled = false;
            this.details_GroupBox.Enabled = true;
            this.phoneBookToolStrip.Enabled = false;
            this.exitToolStripButton.Enabled = false;
        }


        private void ContactForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phonebook_ds.phone_book_table' table. You can move, or remove it, as needed.
            this.phone_book_tableTableAdapter.Fill_all(this.phonebook_ds.phone_book_table);
            disable_Save_Cancel();
            record_display();
            update_counters();


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
            this.phone_book_tableBindingSource.AddNew();
            this.customer_image_box.Image.Dispose();
            this.customer_image_box.Image = null;
            
        }

        private void editToolButton_Click(object sender, EventArgs e)
        {
            if (is_record_Empty())
            {
                return;
            }
            disable4Edit();
            
            
        }

        private void saveToolButton_Click(object sender, EventArgs e)
        {
            this.details_GroupBox.Enabled = false;
            this.search_DataGridView.Enabled = true;
            this.phone_book_tableBindingSource.EndEdit();
            this.phone_book_tableTableAdapter.Update(this.phonebook_ds.phone_book_table); // returns 0 on fail ??Error check
            disable_Save_Cancel();
            //record_display();
        }

        private void cancelToolButton_Click(object sender, EventArgs e)
        {
            this.details_GroupBox.Enabled = false;
            this.search_DataGridView.Enabled = true;
            this.phonebook_ds.phone_book_table.RejectChanges();
            this.phone_book_tableBindingSource.CancelEdit();
            disable_Save_Cancel();
            record_display();
        }

        private void deleteToolButton_Click(object sender, EventArgs e)
        {
            this.editToolButton.Enabled = false;
            this.newToolButton.Enabled = false;
            this.search_DataGridView.Enabled = true;
            this.saveToolButton.Enabled = true;
            this.cancelToolButton.Enabled = true;
            //this.exitToolButton.Enabled = false;
            this.exitToolStripButton.Enabled = false;
            this.phone_book_tableBindingSource.RemoveCurrent(); // delete current record
            //record_display() ;
        }

        private bool is_record_Empty()
        {
            if(this.phonebook_ds.phone_book_table.Rows.Equals(null))
            {
                MyBeep();
                return true;
            }
            else { return false; }
        }

        private void reducedInfoButton_Click(object sender, EventArgs e)
        {
            this.phone_book_tableTableAdapter.FillBy_info(phonebook_ds.phone_book_table);
        }

        private void firstToolStipButton_Click(object sender, EventArgs e)
        {
            this.phone_book_tableBindingSource.MoveFirst();
            update_counters();
        }

        private void prevToolStipButton_Click(object sender, EventArgs e)
        {
            this.phone_book_tableBindingSource.MovePrevious();
            update_counters();
        }

        private void nextToolStipButton_Click(object sender, EventArgs e)
        {
            this.phone_book_tableBindingSource.MoveNext();
            update_counters();
        }

        private void lastToolStipButton_Click(object sender, EventArgs e)
        {
            this.phone_book_tableBindingSource.MoveLast();
            update_counters();
        }

        private void update_counters()
        {
            int countrecs, positionrec;

            countrecs = this.phone_book_tableBindingSource.Count;
            positionrec = this.phone_book_tableBindingSource.Position + 1;
            this.positionTextBoxStrip.Text = positionrec.ToString();
            this.countToolStripLabel.Text = countrecs.ToString();
            if (countrecs < 2) //have one or no records
            { // Disable prev and first
                this.prevToolStipButton.Enabled = false;
                this.firstToolStipButton.Enabled=false;
                this.nextToolStipButton.Enabled = false;
                this.lastToolStipButton.Enabled = false;
                return; // No need to check other things
            }
            if(positionrec > 1) // Not at first record
            {
                this.prevToolStipButton.Enabled = true;
                this.firstToolStipButton.Enabled = true;
            }
            else // At first record
            {
                this.prevToolStipButton.Enabled = false;
                this.firstToolStipButton.Enabled = false;
            }
            if(countrecs == positionrec) //At last record 
            {
                this.nextToolStipButton.Enabled = false;
                this.lastToolStipButton.Enabled = false;
            }
            else //Not at last record
            {
                this.nextToolStipButton.Enabled = true;
                this.lastToolStipButton.Enabled = true;
            }
        }
        private void changeRecPosition(object sender, EventArgs e)
        {
            int curposs = this.phone_book_tableBindingSource.Position;

            if(int.TryParse(this.positionTextBoxStrip.Text, out int intentposs))
            {
                this.phone_book_tableBindingSource.Position = intentposs-1;
            }
            
        }

        private void changeimage(object sender, EventArgs e)
        {
            if (!isEditingRecord)
                return;

            OpenFileDialog ofd = new OpenFileDialog();
            string fn; //Don't think I need this

            ofd.Filter = "Image files | *.png;*.bmp;*.jpg;*.gif";
            if(ofd.ShowDialog() == DialogResult.OK )
            {
                //fn = ofd.FileName;
                this.customer_image_box.Image = Image.FromFile(ofd.FileName);
            }
            else
            {
                MyBeep();
            }
        }
    }
  
}
