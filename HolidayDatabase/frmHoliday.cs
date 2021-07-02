using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Name:Indre Macernyte
// City & Guilds Number: BZF0320
// Date: 11/05/2021

namespace HolidayDatabase
{
    public partial class frmHoliday : Form
    {
        public frmHoliday()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Will display the text provided and todays date
            this.Text = "Task A Indre Macernyte" + " " + DateTime.Now.ToShortDateString();

            try
            {
                // TODO: This line of code loads data into the 'travelDataSet.tblHoliday' table. You can move, or remove it, as needed.
                this.tblHolidayTableAdapter.Fill(this.travelDataSet.tblHoliday);
            }
            catch
            {
                MessageBox.Show("Sorry cold not connect to the database. Please try again");
                buttonPrint.Enabled = false; //Will disable the print button if can't connect.
            }

            this.UpdateRecordCounter();

            ToolTip toolTip = new ToolTip();
            //will display a message if you hover over certain textboxes
            toolTip.SetToolTip(this.textBoxDestination, "Please enter the destination.");
            toolTip.SetToolTip(this.textBoxCost, "Please enter the cost of the holiday.");
            toolTip.SetToolTip(this.textBoxDepartureDate, "Please enter the departure date in the format dd//mm//yyyy.");

        }

        private void buttonFirst_Click_1(object sender, EventArgs e)
        {
            tblHolidayBindingSource.MoveFirst();
            this.UpdateRecordCounter();
        }

        private void buttonPrevious_Click_1(object sender, EventArgs e)
        {
            tblHolidayBindingSource.MovePrevious();
            this.UpdateRecordCounter();
        }

        private void buttonNext_Click_1(object sender, EventArgs e)
        {
            tblHolidayBindingSource.MoveNext();
            this.UpdateRecordCounter();
        }

        private void buttonLast_Click_1(object sender, EventArgs e)
        {
            tblHolidayBindingSource.MoveLast();
            this.UpdateRecordCounter();
        }
        private void UpdateRecordCounter() //method that updates the record counter.
        {
            //gets the position + 1(because the initial value is 0) and the total record from the binding source
            textBoxRecordCount.Text = (tblHolidayBindingSource.Position + 1) + " of " + tblHolidayBindingSource.Count;
        }

        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                tblHolidayBindingSource.EndEdit();

                //Using the TableAdapter update database with any changes made to the dataset "travelDataSet"
                //Update method returns the count of the number of records updated in the database
                int numberOfRecordsUpdated = tblHolidayTableAdapter.Update(travelDataSet);
                MessageBox.Show($"You have succesfully updated the database. You have updated {numberOfRecordsUpdated} record(s).");
            }
            catch
            {
                MessageBox.Show("This holiday number already exists, please enter a different number.");
            }
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                tblHolidayBindingSource.AddNew(); //All fields will be cleared              
                checkBoxAvailable.CheckState = CheckState.Unchecked; // Set the available check box as unchecked
                this.UpdateRecordCounter();
            }
            catch
            {
                MessageBox.Show("Could not add the record to the database.");
            }

        }
    
        private void buttonDelete_Click_1(object sender, EventArgs e)
        {

        //will remove the curent record in the database but only if there is a record to be removed 
            if (tblHolidayBindingSource.Count > 0)
            {
                tblHolidayBindingSource.RemoveCurrent();
                this.UpdateRecordCounter();
             }
            else
             {
            MessageBox.Show("We could not find a record to delete.");
            }
        }
        private void buttonPrint_Click_1(object sender, EventArgs e)
        {
            frmPrint formPrint = new frmPrint(this); //creates a new object of frmPrint            
            formPrint.Show(); //this shows the form "frmPrint"         
            this.Hide(); //and this hides the form
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            tblHolidayBindingSource.CancelEdit(); //cancels any changes that you have temporaraly made
            travelDataSet.RejectChanges(); // Removes all changes made to the form
            this.UpdateRecordCounter();
        }

        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit(); //Exits application
        }

        private void textBoxHolidayNo_Validating(object sender, CancelEventArgs e)
        {
            bool NumberRange = int.TryParse(textBoxHolidayNo.Text, out int HolidayNo);

            if (HolidayNo < 200 || HolidayNo > 1000)
            {
                e.Cancel = true;
                textBoxHolidayNo.Focus(); // focuses on the specific textbox "textBoxHolidayNo"
                errorProvider1.SetError(textBoxHolidayNo, "Holiday number must be in range 200 to 1000.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBoxHolidayNo, null);
            }
        }
    }
}



  