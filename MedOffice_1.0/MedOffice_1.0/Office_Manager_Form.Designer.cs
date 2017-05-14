namespace MedOffice_1._0
{
    partial class Office_Manager_Form
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
            this.cboEmployees = new System.Windows.Forms.ComboBox();
            this.loginsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medOfficeDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medOfficeDBDataSet = new MedOffice_1._0.MedOfficeDBDataSet();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.loginsTableAdapter = new MedOffice_1._0.MedOfficeDBDataSetTableAdapters.LoginsTableAdapter();
            this.btnViewSchedule = new System.Windows.Forms.Button();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.cboSchedule = new System.Windows.Forms.ComboBox();
            this.cbWeekends = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.loginsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lstAllSchedules = new System.Windows.Forms.ListView();
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Schedule = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Work_Weekends = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medOfficeDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medOfficeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboEmployees
            // 
            this.cboEmployees.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.loginsBindingSource, "User_ID", true));
            this.cboEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmployees.FormattingEnabled = true;
            this.cboEmployees.Location = new System.Drawing.Point(69, 12);
            this.cboEmployees.Name = "cboEmployees";
            this.cboEmployees.Size = new System.Drawing.Size(173, 21);
            this.cboEmployees.TabIndex = 0;
            // 
            // loginsBindingSource
            // 
            this.loginsBindingSource.DataMember = "Logins";
            this.loginsBindingSource.DataSource = this.medOfficeDBDataSetBindingSource;
            // 
            // medOfficeDBDataSetBindingSource
            // 
            this.medOfficeDBDataSetBindingSource.DataSource = this.medOfficeDBDataSet;
            this.medOfficeDBDataSetBindingSource.Position = 0;
            // 
            // medOfficeDBDataSet
            // 
            this.medOfficeDBDataSet.DataSetName = "MedOfficeDBDataSet";
            this.medOfficeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(7, 15);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(56, 13);
            this.lblEmployee.TabIndex = 1;
            this.lblEmployee.Text = "Employee:";
            // 
            // loginsTableAdapter
            // 
            this.loginsTableAdapter.ClearBeforeFill = true;
            // 
            // btnViewSchedule
            // 
            this.btnViewSchedule.Location = new System.Drawing.Point(249, 13);
            this.btnViewSchedule.Name = "btnViewSchedule";
            this.btnViewSchedule.Size = new System.Drawing.Size(75, 37);
            this.btnViewSchedule.TabIndex = 3;
            this.btnViewSchedule.Text = "View Schedules";
            this.btnViewSchedule.UseVisualStyleBackColor = true;
            this.btnViewSchedule.Click += new System.EventHandler(this.btnViewSchedule_Click);
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.Location = new System.Drawing.Point(10, 61);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(55, 13);
            this.lblSchedule.TabIndex = 4;
            this.lblSchedule.Text = "Schedule:";
            // 
            // cboSchedule
            // 
            this.cboSchedule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSchedule.FormattingEnabled = true;
            this.cboSchedule.Items.AddRange(new object[] {
            "Morning",
            "Evening",
            "Graveyard"});
            this.cboSchedule.Location = new System.Drawing.Point(71, 58);
            this.cboSchedule.Name = "cboSchedule";
            this.cboSchedule.Size = new System.Drawing.Size(171, 21);
            this.cboSchedule.TabIndex = 5;
            // 
            // cbWeekends
            // 
            this.cbWeekends.AutoSize = true;
            this.cbWeekends.Location = new System.Drawing.Point(69, 85);
            this.cbWeekends.Name = "cbWeekends";
            this.cbWeekends.Size = new System.Drawing.Size(78, 17);
            this.cbWeekends.TabIndex = 7;
            this.cbWeekends.Text = "Weekends";
            this.cbWeekends.UseVisualStyleBackColor = true;
            this.cbWeekends.CheckedChanged += new System.EventHandler(this.cbWeekends_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(248, 56);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // loginsBindingSource1
            // 
            this.loginsBindingSource1.DataMember = "Logins";
            this.loginsBindingSource1.DataSource = this.medOfficeDBDataSetBindingSource;
            // 
            // lstAllSchedules
            // 
            this.lstAllSchedules.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Username,
            this.Schedule,
            this.Work_Weekends});
            this.lstAllSchedules.Location = new System.Drawing.Point(10, 108);
            this.lstAllSchedules.Name = "lstAllSchedules";
            this.lstAllSchedules.Size = new System.Drawing.Size(310, 203);
            this.lstAllSchedules.TabIndex = 9;
            this.lstAllSchedules.UseCompatibleStateImageBehavior = false;
            this.lstAllSchedules.View = System.Windows.Forms.View.Details;
            // 
            // Username
            // 
            this.Username.Text = "Username";
            this.Username.Width = 107;
            // 
            // Schedule
            // 
            this.Schedule.Text = "Schedule";
            this.Schedule.Width = 98;
            // 
            // Work_Weekends
            // 
            this.Work_Weekends.Text = "Work_Weekends";
            this.Work_Weekends.Width = 100;
            // 
            // Office_Manager_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 319);
            this.Controls.Add(this.lstAllSchedules);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbWeekends);
            this.Controls.Add(this.cboSchedule);
            this.Controls.Add(this.lblSchedule);
            this.Controls.Add(this.btnViewSchedule);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.cboEmployees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Office_Manager_Form";
            this.Text = "Staffing Form";
            this.Load += new System.EventHandler(this.Office_Manager_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medOfficeDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medOfficeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboEmployees;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.BindingSource medOfficeDBDataSetBindingSource;
        private MedOfficeDBDataSet medOfficeDBDataSet;
        private System.Windows.Forms.BindingSource loginsBindingSource;
        private MedOfficeDBDataSetTableAdapters.LoginsTableAdapter loginsTableAdapter;
        private System.Windows.Forms.Button btnViewSchedule;
        private System.Windows.Forms.Label lblSchedule;
        private System.Windows.Forms.ComboBox cboSchedule;
        private System.Windows.Forms.CheckBox cbWeekends;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource loginsBindingSource1;
        private System.Windows.Forms.ListView lstAllSchedules;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader Schedule;
        private System.Windows.Forms.ColumnHeader Work_Weekends;
    }
}