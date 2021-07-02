
namespace HolidayDatabase
{
    partial class frmHoliday
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoliday));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.textBoxRecordCount = new System.Windows.Forms.TextBox();
            this.checkBoxAvailable = new System.Windows.Forms.CheckBox();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.textBoxNoOfDays = new System.Windows.Forms.TextBox();
            this.textBoxDepartureDate = new System.Windows.Forms.TextBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.textBoxHolidayNo = new System.Windows.Forms.TextBox();
            this.labelAvailable = new System.Windows.Forms.Label();
            this.labelNoOfDays = new System.Windows.Forms.Label();
            this.labelDepDate = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelDestination = new System.Windows.Forms.Label();
            this.labelHolidayNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.travelDataSet = new HolidayDatabase.TravelDataSet();
            this.tblHolidayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblHolidayTableAdapter = new HolidayDatabase.TravelDataSetTableAdapters.tblHolidayTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHolidayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(491, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonExit.Location = new System.Drawing.Point(491, 356);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(116, 44);
            this.buttonExit.TabIndex = 41;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click_1);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonCancel.Location = new System.Drawing.Point(491, 308);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(116, 44);
            this.buttonCancel.TabIndex = 40;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click_1);
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonPrint.Location = new System.Drawing.Point(491, 260);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(116, 44);
            this.buttonPrint.TabIndex = 39;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click_1);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonDelete.Location = new System.Drawing.Point(491, 212);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(116, 44);
            this.buttonDelete.TabIndex = 38;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click_1);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonAdd.Location = new System.Drawing.Point(491, 164);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(116, 44);
            this.buttonAdd.TabIndex = 37;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click_1);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonUpdate.Location = new System.Drawing.Point(491, 116);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(116, 44);
            this.buttonUpdate.TabIndex = 36;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click_1);
            // 
            // buttonLast
            // 
            this.buttonLast.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonLast.Location = new System.Drawing.Point(384, 361);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(85, 39);
            this.buttonLast.TabIndex = 35;
            this.buttonLast.Text = ">>";
            this.buttonLast.UseVisualStyleBackColor = false;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click_1);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonNext.Location = new System.Drawing.Point(293, 361);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(85, 39);
            this.buttonNext.TabIndex = 34;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click_1);
            // 
            // textBoxRecordCount
            // 
            this.textBoxRecordCount.Location = new System.Drawing.Point(221, 374);
            this.textBoxRecordCount.Name = "textBoxRecordCount";
            this.textBoxRecordCount.Size = new System.Drawing.Size(66, 20);
            this.textBoxRecordCount.TabIndex = 33;
            // 
            // checkBoxAvailable
            // 
            this.checkBoxAvailable.AutoSize = true;
            this.checkBoxAvailable.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblHolidayBindingSource, "Available", true));
            this.checkBoxAvailable.Location = new System.Drawing.Point(165, 316);
            this.checkBoxAvailable.Name = "checkBoxAvailable";
            this.checkBoxAvailable.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAvailable.TabIndex = 29;
            this.checkBoxAvailable.UseVisualStyleBackColor = true;
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonPrevious.Location = new System.Drawing.Point(129, 361);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(85, 39);
            this.buttonPrevious.TabIndex = 32;
            this.buttonPrevious.Text = "<";
            this.buttonPrevious.UseVisualStyleBackColor = false;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click_1);
            // 
            // buttonFirst
            // 
            this.buttonFirst.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonFirst.Location = new System.Drawing.Point(38, 361);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(85, 39);
            this.buttonFirst.TabIndex = 31;
            this.buttonFirst.Text = "<<";
            this.buttonFirst.UseVisualStyleBackColor = false;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click_1);
            // 
            // textBoxNoOfDays
            // 
            this.textBoxNoOfDays.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblHolidayBindingSource, "NoOfDays", true));
            this.textBoxNoOfDays.Location = new System.Drawing.Point(165, 276);
            this.textBoxNoOfDays.Name = "textBoxNoOfDays";
            this.textBoxNoOfDays.Size = new System.Drawing.Size(59, 20);
            this.textBoxNoOfDays.TabIndex = 27;
            // 
            // textBoxDepartureDate
            // 
            this.textBoxDepartureDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblHolidayBindingSource, "DepartureDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.textBoxDepartureDate.Location = new System.Drawing.Point(165, 236);
            this.textBoxDepartureDate.Name = "textBoxDepartureDate";
            this.textBoxDepartureDate.Size = new System.Drawing.Size(121, 20);
            this.textBoxDepartureDate.TabIndex = 25;
            // 
            // textBoxCost
            // 
            this.textBoxCost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblHolidayBindingSource, "Cost", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.textBoxCost.Location = new System.Drawing.Point(165, 196);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(121, 20);
            this.textBoxCost.TabIndex = 23;
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblHolidayBindingSource, "Destination", true));
            this.textBoxDestination.Location = new System.Drawing.Point(165, 156);
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.Size = new System.Drawing.Size(212, 20);
            this.textBoxDestination.TabIndex = 20;
            // 
            // textBoxHolidayNo
            // 
            this.textBoxHolidayNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblHolidayBindingSource, "HolidayNo", true));
            this.textBoxHolidayNo.Location = new System.Drawing.Point(165, 116);
            this.textBoxHolidayNo.Name = "textBoxHolidayNo";
            this.textBoxHolidayNo.Size = new System.Drawing.Size(59, 20);
            this.textBoxHolidayNo.TabIndex = 19;
            this.textBoxHolidayNo.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxHolidayNo_Validating);
            // 
            // labelAvailable
            // 
            this.labelAvailable.AutoSize = true;
            this.labelAvailable.Location = new System.Drawing.Point(37, 314);
            this.labelAvailable.Name = "labelAvailable";
            this.labelAvailable.Size = new System.Drawing.Size(50, 13);
            this.labelAvailable.TabIndex = 30;
            this.labelAvailable.Text = "Available";
            // 
            // labelNoOfDays
            // 
            this.labelNoOfDays.AutoSize = true;
            this.labelNoOfDays.Location = new System.Drawing.Point(37, 275);
            this.labelNoOfDays.Name = "labelNoOfDays";
            this.labelNoOfDays.Size = new System.Drawing.Size(60, 13);
            this.labelNoOfDays.TabIndex = 28;
            this.labelNoOfDays.Text = "No of Days";
            // 
            // labelDepDate
            // 
            this.labelDepDate.AutoSize = true;
            this.labelDepDate.Location = new System.Drawing.Point(37, 236);
            this.labelDepDate.Name = "labelDepDate";
            this.labelDepDate.Size = new System.Drawing.Size(80, 13);
            this.labelDepDate.TabIndex = 26;
            this.labelDepDate.Text = "Departure Date";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(37, 197);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(28, 13);
            this.labelCost.TabIndex = 24;
            this.labelCost.Text = "Cost";
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(37, 158);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(60, 13);
            this.labelDestination.TabIndex = 22;
            this.labelDestination.Text = "Destination";
            // 
            // labelHolidayNo
            // 
            this.labelHolidayNo.AutoSize = true;
            this.labelHolidayNo.Location = new System.Drawing.Point(34, 119);
            this.labelHolidayNo.Name = "labelHolidayNo";
            this.labelHolidayNo.Size = new System.Drawing.Size(80, 13);
            this.labelHolidayNo.TabIndex = 21;
            this.labelHolidayNo.Text = "Holiday number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(136, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 35);
            this.label1.TabIndex = 18;
            this.label1.Text = "Downton Travel";
            // 
            // travelDataSet
            // 
            this.travelDataSet.DataSetName = "TravelDataSet";
            this.travelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblHolidayBindingSource
            // 
            this.tblHolidayBindingSource.DataMember = "tblHoliday";
            this.tblHolidayBindingSource.DataSource = this.travelDataSet;
            // 
            // tblHolidayTableAdapter
            // 
            this.tblHolidayTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmHoliday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(631, 419);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.textBoxRecordCount);
            this.Controls.Add(this.checkBoxAvailable);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.textBoxNoOfDays);
            this.Controls.Add(this.textBoxDepartureDate);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.textBoxDestination);
            this.Controls.Add(this.textBoxHolidayNo);
            this.Controls.Add(this.labelAvailable);
            this.Controls.Add(this.labelNoOfDays);
            this.Controls.Add(this.labelDepDate);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelDestination);
            this.Controls.Add(this.labelHolidayNo);
            this.Controls.Add(this.label1);
            this.Name = "frmHoliday";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHolidayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.TextBox textBoxRecordCount;
        private System.Windows.Forms.CheckBox checkBoxAvailable;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.TextBox textBoxNoOfDays;
        private System.Windows.Forms.TextBox textBoxDepartureDate;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.TextBox textBoxHolidayNo;
        private System.Windows.Forms.Label labelAvailable;
        private System.Windows.Forms.Label labelNoOfDays;
        private System.Windows.Forms.Label labelDepDate;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.Label labelHolidayNo;
        private System.Windows.Forms.Label label1;
        private TravelDataSet travelDataSet;
        private System.Windows.Forms.BindingSource tblHolidayBindingSource;
        private TravelDataSetTableAdapters.tblHolidayTableAdapter tblHolidayTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

