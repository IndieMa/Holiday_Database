using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

// Name:Indre Macernyte
// City & Guilds Number: BZF0320
// Date: 11/05/2021

namespace HolidayDatabase
{
    public partial class frmPrint : Form
    {

        //reference to a holiday form object
        private frmHoliday holidayForm;

        public frmPrint()
        {
            InitializeComponent();
        }
        //overloaded constructor
        public frmPrint(frmHoliday holidayForm)
        {
            InitializeComponent();

            this.holidayForm = holidayForm;
        }

        private void frmPrint_Load(object sender, EventArgs e)
        {
            this.Text = "Task A Indre Macernyte" + " " + DateTime.Now.ToShortDateString();

            // TODO: This line of code loads data into the 'travelDataSet.tblHoliday' table. You can move, or remove it, as needed.
            this.tblHolidayTableAdapter.Fill(this.travelDataSet.tblHoliday);
        }
  
        private void buttonPrint1_Click_1(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Downton Travel";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.ToShortDateString());
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = true;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(dataGridView1);
        }

        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            this.Close(); //closes this form

            holidayForm.Show(); //shows "holidayForm"
        }
        //incase the user clicks the x button on the form we want to ensures that the holidayForm will show again
        private void frmPrint_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            holidayForm.Show();
        }

        private void dataGridView1_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // formatting the available collumn to yes/no
            if (e.ColumnIndex == 4)
            {
                if (e.Value is bool)
                {
                    bool value = (bool)e.Value;
                    e.Value = (value) ? "Yes" : "No";
                    e.FormattingApplied = true;
                }

            }
        }
    }
}
