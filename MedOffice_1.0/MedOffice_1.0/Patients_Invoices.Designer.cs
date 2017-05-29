namespace MedOffice_1._0
{
    partial class Patients_Invoices
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
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.cInvoiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cInsuranceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cInsurancePaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPatientPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBalanceDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cEmail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpPatientFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpPatientTo = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cInvoiceID,
            this.cPatientName,
            this.cInsuranceName,
            this.cInsurancePaid,
            this.cPatientPaid,
            this.cBalanceDue,
            this.cPaymentDate,
            this.cDelete,
            this.cEmail});
            this.dgvInvoices.Location = new System.Drawing.Point(5, 30);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.Size = new System.Drawing.Size(860, 401);
            this.dgvInvoices.TabIndex = 6;
            this.dgvInvoices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoices_CellContentClick);
            // 
            // cInvoiceID
            // 
            this.cInvoiceID.HeaderText = "ID";
            this.cInvoiceID.Name = "cInvoiceID";
            this.cInvoiceID.ReadOnly = true;
            this.cInvoiceID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cInvoiceID.Width = 30;
            // 
            // cPatientName
            // 
            this.cPatientName.HeaderText = "Patient Name";
            this.cPatientName.Name = "cPatientName";
            this.cPatientName.ReadOnly = true;
            this.cPatientName.Width = 150;
            // 
            // cInsuranceName
            // 
            this.cInsuranceName.HeaderText = "Insurance Name";
            this.cInsuranceName.Name = "cInsuranceName";
            this.cInsuranceName.ReadOnly = true;
            this.cInsuranceName.Width = 110;
            // 
            // cInsurancePaid
            // 
            this.cInsurancePaid.HeaderText = "Insurance Due";
            this.cInsurancePaid.Name = "cInsurancePaid";
            this.cInsurancePaid.ReadOnly = true;
            this.cInsurancePaid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cPatientPaid
            // 
            this.cPatientPaid.HeaderText = "Patient Due";
            this.cPatientPaid.Name = "cPatientPaid";
            this.cPatientPaid.ReadOnly = true;
            this.cPatientPaid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cPatientPaid.Width = 90;
            // 
            // cBalanceDue
            // 
            this.cBalanceDue.HeaderText = "Balance Due";
            this.cBalanceDue.Name = "cBalanceDue";
            this.cBalanceDue.ReadOnly = true;
            this.cBalanceDue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cPaymentDate
            // 
            this.cPaymentDate.HeaderText = "Last Payment ";
            this.cPaymentDate.Name = "cPaymentDate";
            this.cPaymentDate.ReadOnly = true;
            this.cPaymentDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cPaymentDate.Width = 130;
            // 
            // cDelete
            // 
            this.cDelete.HeaderText = "Delete";
            this.cDelete.Name = "cDelete";
            this.cDelete.ReadOnly = true;
            this.cDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cDelete.Text = "Delete";
            this.cDelete.ToolTipText = "Delete invoice record.";
            this.cDelete.Width = 50;
            // 
            // cEmail
            // 
            this.cEmail.HeaderText = "Email";
            this.cEmail.Name = "cEmail";
            this.cEmail.ReadOnly = true;
            this.cEmail.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cEmail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cEmail.Text = "Email";
            this.cEmail.ToolTipText = "Email parties that owe a balance ";
            this.cEmail.Width = 50;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(2, 7);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(33, 13);
            this.lblFrom.TabIndex = 7;
            this.lblFrom.Text = "From:";
            // 
            // dtpPatientFrom
            // 
            this.dtpPatientFrom.Location = new System.Drawing.Point(41, 4);
            this.dtpPatientFrom.Name = "dtpPatientFrom";
            this.dtpPatientFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpPatientFrom.TabIndex = 1;
            this.dtpPatientFrom.ValueChanged += new System.EventHandler(this.dtpPatientFrom_ValueChanged);
            // 
            // dtpPatientTo
            // 
            this.dtpPatientTo.Location = new System.Drawing.Point(276, 4);
            this.dtpPatientTo.Name = "dtpPatientTo";
            this.dtpPatientTo.Size = new System.Drawing.Size(198, 20);
            this.dtpPatientTo.TabIndex = 2;
            this.dtpPatientTo.ValueChanged += new System.EventHandler(this.dtpPatientTo_ValueChanged);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(247, 7);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(23, 13);
            this.lblTo.TabIndex = 9;
            this.lblTo.Text = "To:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(790, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Location = new System.Drawing.Point(492, 7);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(38, 13);
            this.lblPatientName.TabIndex = 12;
            this.lblPatientName.Text = "Name:";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(536, 4);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(248, 20);
            this.txtPatientName.TabIndex = 3;
            // 
            // Patients_Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 438);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtpPatientTo);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.dtpPatientFrom);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dgvInvoices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Patients_Invoices";
            this.Text = "Invoice Management Report";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpPatientFrom;
        private System.Windows.Forms.DateTimePicker dtpPatientTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cInvoiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cInsuranceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cInsurancePaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPatientPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBalanceDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPaymentDate;
        private System.Windows.Forms.DataGridViewButtonColumn cDelete;
        private System.Windows.Forms.DataGridViewButtonColumn cEmail;
    }
}