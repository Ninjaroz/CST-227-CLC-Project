namespace MedOffice_1._0
{
    partial class Clerical
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveButton = new System.Windows.Forms.Button();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.dobBox = new System.Windows.Forms.TextBox();
            this.insBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.patientBox = new System.Windows.Forms.ListBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.medicationRadio = new System.Windows.Forms.RadioButton();
            this.diseaseRadio = new System.Windows.Forms.RadioButton();
            this.allergyRadio = new System.Windows.Forms.RadioButton();
            this.textBox_Allergies_Diseases_Meds = new System.Windows.Forms.TextBox();
            this.label_address = new System.Windows.Forms.Label();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.label_phoneNumber = new System.Windows.Forms.Label();
            this.label_ethnicity = new System.Windows.Forms.Label();
            this.label_gender = new System.Windows.Forms.Label();
            this.textBox_phoneNumber = new System.Windows.Forms.TextBox();
            this.textBox_ethnicity = new System.Windows.Forms.TextBox();
            this.textBox_gender = new System.Windows.Forms.TextBox();
            this.checkinBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.cboSelectTestResult = new System.Windows.Forms.ComboBox();
            this.lblTestResult = new System.Windows.Forms.Label();
            this.lblPatientTestResult = new System.Windows.Forms.Label();
            this.lblPercentageTestResult = new System.Windows.Forms.Label();
            this.txtTestPercentage = new System.Windows.Forms.TextBox();
            this.cboPatientResult = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(14, 459);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(112, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save New Patient";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(120, 64);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameBox.TabIndex = 2;
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(226, 64);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(100, 20);
            this.ageBox.TabIndex = 3;
            // 
            // dobBox
            // 
            this.dobBox.Location = new System.Drawing.Point(332, 64);
            this.dobBox.Name = "dobBox";
            this.dobBox.Size = new System.Drawing.Size(100, 20);
            this.dobBox.TabIndex = 4;
            // 
            // insBox
            // 
            this.insBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.insBox.FormattingEnabled = true;
            this.insBox.Location = new System.Drawing.Point(438, 64);
            this.insBox.Name = "insBox";
            this.insBox.Size = new System.Drawing.Size(121, 21);
            this.insBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welcome, clerical staff";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "D.O.B, mm/dd/yyyy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(471, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Insurance";
            // 
            // patientBox
            // 
            this.patientBox.FormattingEnabled = true;
            this.patientBox.Location = new System.Drawing.Point(297, 91);
            this.patientBox.Name = "patientBox";
            this.patientBox.Size = new System.Drawing.Size(262, 147);
            this.patientBox.TabIndex = 11;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(14, 64);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "First Name";
            // 
            // medicationRadio
            // 
            this.medicationRadio.AutoSize = true;
            this.medicationRadio.Location = new System.Drawing.Point(12, 314);
            this.medicationRadio.Name = "medicationRadio";
            this.medicationRadio.Size = new System.Drawing.Size(82, 17);
            this.medicationRadio.TabIndex = 40;
            this.medicationRadio.TabStop = true;
            this.medicationRadio.Text = "Medications";
            this.medicationRadio.UseVisualStyleBackColor = true;
            // 
            // diseaseRadio
            // 
            this.diseaseRadio.AutoSize = true;
            this.diseaseRadio.Location = new System.Drawing.Point(12, 291);
            this.diseaseRadio.Name = "diseaseRadio";
            this.diseaseRadio.Size = new System.Drawing.Size(68, 17);
            this.diseaseRadio.TabIndex = 39;
            this.diseaseRadio.TabStop = true;
            this.diseaseRadio.Text = "Diseases";
            this.diseaseRadio.UseVisualStyleBackColor = true;
            // 
            // allergyRadio
            // 
            this.allergyRadio.AutoSize = true;
            this.allergyRadio.Location = new System.Drawing.Point(12, 268);
            this.allergyRadio.Name = "allergyRadio";
            this.allergyRadio.Size = new System.Drawing.Size(64, 17);
            this.allergyRadio.TabIndex = 38;
            this.allergyRadio.TabStop = true;
            this.allergyRadio.Text = "Allergies";
            this.allergyRadio.UseVisualStyleBackColor = true;
            // 
            // textBox_Allergies_Diseases_Meds
            // 
            this.textBox_Allergies_Diseases_Meds.Location = new System.Drawing.Point(103, 268);
            this.textBox_Allergies_Diseases_Meds.Multiline = true;
            this.textBox_Allergies_Diseases_Meds.Name = "textBox_Allergies_Diseases_Meds";
            this.textBox_Allergies_Diseases_Meds.Size = new System.Drawing.Size(188, 162);
            this.textBox_Allergies_Diseases_Meds.TabIndex = 33;
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Location = new System.Drawing.Point(15, 153);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(45, 13);
            this.label_address.TabIndex = 37;
            this.label_address.Text = "Address";
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(12, 172);
            this.textBox_address.Multiline = true;
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(279, 58);
            this.textBox_address.TabIndex = 32;
            // 
            // label_phoneNumber
            // 
            this.label_phoneNumber.AutoSize = true;
            this.label_phoneNumber.Location = new System.Drawing.Point(189, 100);
            this.label_phoneNumber.Name = "label_phoneNumber";
            this.label_phoneNumber.Size = new System.Drawing.Size(78, 13);
            this.label_phoneNumber.TabIndex = 36;
            this.label_phoneNumber.Text = "Phone Number";
            // 
            // label_ethnicity
            // 
            this.label_ethnicity.AutoSize = true;
            this.label_ethnicity.Location = new System.Drawing.Point(72, 100);
            this.label_ethnicity.Name = "label_ethnicity";
            this.label_ethnicity.Size = new System.Drawing.Size(47, 13);
            this.label_ethnicity.TabIndex = 35;
            this.label_ethnicity.Text = "Ethnicity";
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.Location = new System.Drawing.Point(12, 100);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(42, 13);
            this.label_gender.TabIndex = 34;
            this.label_gender.Text = "Gender";
            // 
            // textBox_phoneNumber
            // 
            this.textBox_phoneNumber.Location = new System.Drawing.Point(189, 119);
            this.textBox_phoneNumber.Name = "textBox_phoneNumber";
            this.textBox_phoneNumber.Size = new System.Drawing.Size(100, 20);
            this.textBox_phoneNumber.TabIndex = 31;
            // 
            // textBox_ethnicity
            // 
            this.textBox_ethnicity.Location = new System.Drawing.Point(72, 119);
            this.textBox_ethnicity.Name = "textBox_ethnicity";
            this.textBox_ethnicity.Size = new System.Drawing.Size(100, 20);
            this.textBox_ethnicity.TabIndex = 30;
            // 
            // textBox_gender
            // 
            this.textBox_gender.Location = new System.Drawing.Point(12, 119);
            this.textBox_gender.Name = "textBox_gender";
            this.textBox_gender.Size = new System.Drawing.Size(42, 20);
            this.textBox_gender.TabIndex = 29;
            // 
            // checkinBox
            // 
            this.checkinBox.AutoSize = true;
            this.checkinBox.Location = new System.Drawing.Point(477, 437);
            this.checkinBox.Name = "checkinBox";
            this.checkinBox.Size = new System.Drawing.Size(68, 17);
            this.checkinBox.TabIndex = 43;
            this.checkinBox.Text = "Check in";
            this.checkinBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(474, 460);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(139, 460);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 41;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // cboSelectTestResult
            // 
            this.cboSelectTestResult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectTestResult.FormattingEnabled = true;
            this.cboSelectTestResult.Location = new System.Drawing.Point(400, 269);
            this.cboSelectTestResult.Name = "cboSelectTestResult";
            this.cboSelectTestResult.Size = new System.Drawing.Size(121, 21);
            this.cboSelectTestResult.TabIndex = 44;
            this.cboSelectTestResult.SelectedIndexChanged += new System.EventHandler(this.cboSelectTestResult_SelectedIndexChanged);
            // 
            // lblTestResult
            // 
            this.lblTestResult.AutoSize = true;
            this.lblTestResult.Location = new System.Drawing.Point(297, 272);
            this.lblTestResult.Name = "lblTestResult";
            this.lblTestResult.Size = new System.Drawing.Size(97, 13);
            this.lblTestResult.TabIndex = 45;
            this.lblTestResult.Text = "Select Test Result:";
            // 
            // lblPatientTestResult
            // 
            this.lblPatientTestResult.AutoSize = true;
            this.lblPatientTestResult.Location = new System.Drawing.Point(297, 305);
            this.lblPatientTestResult.Name = "lblPatientTestResult";
            this.lblPatientTestResult.Size = new System.Drawing.Size(100, 13);
            this.lblPatientTestResult.TabIndex = 46;
            this.lblPatientTestResult.Text = "Patient Test Result:";
            // 
            // lblPercentageTestResult
            // 
            this.lblPercentageTestResult.AutoSize = true;
            this.lblPercentageTestResult.Location = new System.Drawing.Point(297, 331);
            this.lblPercentageTestResult.Name = "lblPercentageTestResult";
            this.lblPercentageTestResult.Size = new System.Drawing.Size(190, 13);
            this.lblPercentageTestResult.TabIndex = 47;
            this.lblPercentageTestResult.Text = "% Of Other Patients With Same Result:";
            // 
            // txtTestPercentage
            // 
            this.txtTestPercentage.Location = new System.Drawing.Point(493, 328);
            this.txtTestPercentage.Name = "txtTestPercentage";
            this.txtTestPercentage.ReadOnly = true;
            this.txtTestPercentage.Size = new System.Drawing.Size(28, 20);
            this.txtTestPercentage.TabIndex = 49;
            // 
            // cboPatientResult
            // 
            this.cboPatientResult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPatientResult.FormattingEnabled = true;
            this.cboPatientResult.Location = new System.Drawing.Point(400, 301);
            this.cboPatientResult.Name = "cboPatientResult";
            this.cboPatientResult.Size = new System.Drawing.Size(121, 21);
            this.cboPatientResult.TabIndex = 50;
            // 
            // Clerical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(560, 483);
            this.Controls.Add(this.cboPatientResult);
            this.Controls.Add(this.txtTestPercentage);
            this.Controls.Add(this.lblPercentageTestResult);
            this.Controls.Add(this.lblPatientTestResult);
            this.Controls.Add(this.lblTestResult);
            this.Controls.Add(this.cboSelectTestResult);
            this.Controls.Add(this.checkinBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.medicationRadio);
            this.Controls.Add(this.diseaseRadio);
            this.Controls.Add(this.allergyRadio);
            this.Controls.Add(this.textBox_Allergies_Diseases_Meds);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.label_phoneNumber);
            this.Controls.Add(this.label_ethnicity);
            this.Controls.Add(this.label_gender);
            this.Controls.Add(this.textBox_phoneNumber);
            this.Controls.Add(this.textBox_ethnicity);
            this.Controls.Add(this.textBox_gender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.patientBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insBox);
            this.Controls.Add(this.dobBox);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Clerical";
            this.Load += new System.EventHandler(this.Clerical_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.TextBox dobBox;
        private System.Windows.Forms.ComboBox insBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox patientBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton medicationRadio;
        private System.Windows.Forms.RadioButton diseaseRadio;
        private System.Windows.Forms.RadioButton allergyRadio;
        private System.Windows.Forms.TextBox textBox_Allergies_Diseases_Meds;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.Label label_phoneNumber;
        private System.Windows.Forms.Label label_ethnicity;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.TextBox textBox_phoneNumber;
        private System.Windows.Forms.TextBox textBox_ethnicity;
        private System.Windows.Forms.TextBox textBox_gender;
        private System.Windows.Forms.CheckBox checkinBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox cboSelectTestResult;
        private System.Windows.Forms.Label lblTestResult;
        private System.Windows.Forms.Label lblPatientTestResult;
        private System.Windows.Forms.Label lblPercentageTestResult;
        private System.Windows.Forms.TextBox txtTestPercentage;
        private System.Windows.Forms.ComboBox cboPatientResult;
    }
}
