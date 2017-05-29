using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MedOffice_1._0
{
    public partial class Patients_Invoices : Form
    {
        //Class level variables
        OleDbConnection conn = new OleDbConnection(OurConnection.Conn);

        public Patients_Invoices()
        {
            InitializeComponent();
        }

        //Will call SearchOption method so depending on the filled fills in the form it will pull appropriate data
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Clears all Data in DataGridView before new data is loaded
            dgvInvoices.Rows.Clear();
            SearchOption();
            //Clears all fields except the listview
            ClearFields();
        }

        //Will pull all invoices based on patients first or last name
        private void SearchByPatientName()
        {
            try
            {
                conn.Open();
                OleDbCommand comm = new OleDbCommand()
                {
                    //Pulls Datagrid information from database based on patient name
                    Connection = conn,
                    CommandText = "SELECT Patient_Invoices.Invoice_ID, Patient_Invoices.Patient_ID, Patient_Invoices.Insurance_ID, " +
                    "Patient_Invoices.Balance_Due, Patient_Invoices.Ins_Due, Patient_Invoices.Patient_Due, Patient_Invoices.Last_Payment_Date, " + 
                    "OurPatients.PatientFirst, OurPatients.PatientLast, Insurance_Types.Company_Name " +
                    "FROM (Insurance_Types INNER JOIN Patient_Invoices ON Insurance_Types.[Ins_cID] = Patient_Invoices.[Insurance_ID]) INNER JOIN " +
                    "OurPatients ON Patient_Invoices.Patient_ID = OurPatients.PatientNumber " +
                    "WHERE (((Patient_Invoices.Insurance_ID)=[Insurance_Types].[Ins_cID] And (Patient_Invoices.Insurance_ID)=[Insurance_Types].[Ins_cID] " +
                    "And (Patient_Invoices.Insurance_ID)=[Insurance_Types].[Ins_cID]) AND ([OurPatients].[PatientFirst]='"  + txtPatientName.Text + 
                    "') OR ([ourPatients].[PatientLast]='"  + txtPatientName.Text +
                    "') AND ((OurPatients.PatientNumber)=[Patient_Invoices].[Patient_ID] And (OurPatients.PatientNumber)=[Patient_Invoices].[Patient_ID] And " +
                    "(OurPatients.PatientNumber)=[Patient_Invoices].[Patient_ID]));"


                };

                OleDbDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvInvoices);
                    row.Cells[0].Value = reader["Invoice_ID"].ToString();
                    row.Cells[1].Value = reader["PatientFirst"].ToString() + " " + reader["PatientLast"].ToString();
                    row.Cells[2].Value = reader["Company_Name"].ToString();
                    row.Cells[3].Value = string.Format("{0:C}", Convert.ToDecimal(reader["Ins_Due"].ToString()));
                    row.Cells[4].Value = string.Format("{0:C}", Convert.ToDecimal(reader["Patient_Due"].ToString()));
                    row.Cells[5].Value = string.Format("{0:C}", Convert.ToDecimal(reader["Balance_Due"].ToString()));
                    row.Cells[6].Value = reader["Last_Payment_Date"].ToString();
                    row.Cells[7].Value = "Delete";
                    row.Cells[8].Value = "Email";
                    dgvInvoices.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please check DB connection and patient name" + ex);
            }

            //Closes DB connection
            conn.Close();            
        }

        //Will pull all invoices based on a combination of the patients first, last name, and date range selected
        private void SearchByPatientNameAndDate()
        {
            try
            {
                conn.Open();
                OleDbCommand comm = new OleDbCommand()
                {
                    //pulls data from database based on patient name and date range selected 
                    Connection = conn,
                    CommandText = "SELECT Patient_Invoices.Invoice_ID, Patient_Invoices.Patient_ID, Patient_Invoices.Insurance_ID, " +
                    "Patient_Invoices.Balance_Due, Patient_Invoices.Ins_Due, Patient_Invoices.Patient_Due, Patient_Invoices.Last_Payment_Date, " +
                    "OurPatients.PatientFirst, OurPatients.PatientLast, Insurance_Types.Company_Name " +
                    "FROM (Insurance_Types INNER JOIN Patient_Invoices ON Insurance_Types.[Ins_cID] = Patient_Invoices.[Insurance_ID]) " +
                    "INNER JOIN OurPatients ON Patient_Invoices.Patient_ID = OurPatients.PatientNumber " +
                    "WHERE (((Patient_Invoices.Insurance_ID)=[Insurance_Types].[Ins_cID] And (Patient_Invoices.Insurance_ID)=[Insurance_Types].[Ins_cID] " +
                    "And (Patient_Invoices.Insurance_ID)=[Insurance_Types].[Ins_cID]) AND ((Patient_Invoices.Last_Payment_Date) Between #"+ dtpPatientFrom.Value.ToShortDateString() +
                    "# And #"+ dtpPatientFrom.Value.ToShortDateString() +"#) AND ((OurPatients.PatientFirst)='"+txtPatientName.Text +
                    "') AND ((OurPatients.PatientNumber)=[Patient_Invoices].[Patient_ID] And (OurPatients.PatientNumber)=[Patient_Invoices].[Patient_ID] " +
                    "And (OurPatients.PatientNumber)=[Patient_Invoices].[Patient_ID])) OR (((OurPatients.PatientLast)='"+ txtPatientName.Text+"'));"


                };

                OleDbDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvInvoices);
                    row.Cells[0].Value = reader["Invoice_ID"].ToString();
                    row.Cells[1].Value = reader["PatientFirst"].ToString() + " " + reader["PatientLast"].ToString();
                    row.Cells[2].Value = reader["Company_Name"].ToString();
                    row.Cells[3].Value = string.Format("{0:C}", Convert.ToDecimal(reader["Ins_Due"].ToString()));
                    row.Cells[4].Value = string.Format("{0:C}", Convert.ToDecimal(reader["Patient_Due"].ToString()));
                    row.Cells[5].Value = string.Format("{0:C}", Convert.ToDecimal(reader["Balance_Due"].ToString()));
                    row.Cells[6].Value = reader["Last_Payment_Date"].ToString();
                    row.Cells[7].Value = "Delete";
                    row.Cells[8].Value = "Email";
                    dgvInvoices.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please check DB connectio, date ranges, and patient name. " + ex);
            }

            //Closes DB connection
            conn.Close(); 
        }

        //Will pull all records in date range if a patient name is not specified in the textbox
        private void SearchAllRecordsByDate()
        {
            try
            {
                conn.Open();
                OleDbCommand comm = new OleDbCommand()
                {
                    //Pulls all records based on date range selected
                    Connection = conn,
                    CommandText = "SELECT Patient_Invoices.Invoice_ID, Patient_Invoices.Patient_ID, Patient_Invoices.Insurance_ID, " +
                    "Patient_Invoices.Balance_Due, Patient_Invoices.Ins_Due, Patient_Invoices.Patient_Due, Patient_Invoices.Last_Payment_Date, " +
                    "OurPatients.PatientFirst, OurPatients.PatientLast, Insurance_Types.Company_Name " +
                    "FROM (Insurance_Types INNER JOIN Patient_Invoices ON Insurance_Types.[Ins_cID] = Patient_Invoices.[Insurance_ID]) " +
                    "INNER JOIN OurPatients ON Patient_Invoices.Patient_ID = OurPatients.PatientNumber " +
                    "WHERE (((Patient_Invoices.Insurance_ID)=[Insurance_Types].[Ins_cID] And (Patient_Invoices.Insurance_ID)=[Insurance_Types].[Ins_cID] " +
                    "And (Patient_Invoices.Insurance_ID)=[Insurance_Types].[Ins_cID]) AND ((Patient_Invoices.Last_Payment_Date) Between #" + 
                    dtpPatientFrom.Value.ToShortDateString()+ "# And #" + dtpPatientTo.Value.ToShortDateString()+"#) AND " +
                    "((OurPatients.PatientNumber)=[Patient_Invoices].[Patient_ID] And (OurPatients.PatientNumber)=[Patient_Invoices].[Patient_ID] " +
                    "And (OurPatients.PatientNumber)=[Patient_Invoices].[Patient_ID]));"

                };

                OleDbDataReader reader = comm.ExecuteReader();
                
                while (reader.Read())
                {
                DataGridViewRow row = new DataGridViewRow();
                 row.CreateCells(dgvInvoices);
                 row.Cells[0].Value = reader["Invoice_ID"].ToString();
                 row.Cells[1].Value = reader["PatientFirst"].ToString() + " " + reader["PatientLast"].ToString();
                 row.Cells[2].Value = reader["Company_Name"].ToString();
                 row.Cells[3].Value = string.Format("{0:C}", Convert.ToDecimal(reader["Ins_Due"].ToString()));
                 row.Cells[4].Value = string.Format("{0:C}", Convert.ToDecimal(reader["Patient_Due"].ToString()));
                 row.Cells[5].Value = string.Format("{0:C}", Convert.ToDecimal(reader["Balance_Due"].ToString()));
                 row.Cells[6].Value = reader["Last_Payment_Date"].ToString();
                 row.Cells[7].Value = "Delete";
                 row.Cells[8].Value = "Email";
                 dgvInvoices.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please check DB connection and date ranges." + ex);
            }

            //Closes DB connection
            conn.Close();
        }

        /*Will determine what search option method to call based on the filled out fields in the form and clear them
         *after generating report */
        private void SearchOption()
        {

            //Check if only Date fields have values and call the SearchAllRecordsByDate() method
            if (dtpPatientFrom.ShowCheckBox == true &&
                dtpPatientTo.ShowCheckBox == true && txtPatientName.Text.Equals("")){
                
                SearchAllRecordsByDate();

             //If only the txtPatientName field has a value call the SearchByPatientName() method
            }else if (dtpPatientFrom.ShowCheckBox == false &&
                      dtpPatientTo.ShowCheckBox == false && !txtPatientName.Text.Equals("")){

                SearchByPatientName();

             //If all fields have values in the form call the SearchByPatientNameAndDate() method
            }else if (dtpPatientFrom.ShowCheckBox == true &&
               dtpPatientTo.ShowCheckBox == true && !txtPatientName.Text.Equals("")){
                
                SearchByPatientNameAndDate();

             //Display an error box that none of the fields have data
            }else{

                MessageBox.Show("Please ensure that a name, date range, or both is entered.", "No fields have input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        //Sets show check box to true for dtpPatientFrom
        private void dtpPatientFrom_ValueChanged(object sender, EventArgs e)
        {
            dtpPatientFrom.ShowCheckBox = true;
        }
        
        //Sets show check box to true for dtpPatientTo
        private void dtpPatientTo_ValueChanged(object sender, EventArgs e)
        {
            dtpPatientTo.ShowCheckBox = true;
        }
    
        //Clear all fields after Search button is pressed
        private void ClearFields()
        {
            dtpPatientFrom.ShowCheckBox = false;
            dtpPatientTo.ShowCheckBox = false;
            txtPatientName.Text = null;
        }
        
        //Depending on button clicked will delete a row or send an email to whom ever owes a balance
        private void dgvInvoices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Calls the DeleteInvoice method to delete the invoice from the DB and remove from datagridview
            if (e.ColumnIndex == dgvInvoices.Columns["cDelete"].Index && e.RowIndex >= 0) {
                DeleteInvoice((String)dgvInvoices[0, e.RowIndex].Value, e.RowIndex);  
            }
            //Calls the Email method to email the appropriate parties that owe a balance on the invoice
            else if (e.ColumnIndex == dgvInvoices.Columns["cEmail"].Index && e.RowIndex >= 0){
                Email((String)dgvInvoices[0, e.RowIndex].Value); 
            }

        }      
    
        //Delete invoice
        private void DeleteInvoice(String invoiceID, int rowIndex)
        {
            try
            {
                conn.Open();
                OleDbCommand comm = new OleDbCommand()
                {
                    //Pulls all records based on date range selected
                    Connection = conn,
                    CommandText = "DELETE FROM Patient_Invoices " +
                                  "WHERE Invoice_ID = " + invoiceID

                };

                OleDbDataReader reader = comm.ExecuteReader();

                //Removes row from Datagridview
                dgvInvoices.Rows.RemoveAt(rowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please check DB connection. " + ex);
            }

            //Closes DB connection
            conn.Close();   
        }

        //Email parties that owe a balance
        private void Email(String invoiceID)
        {
            //Patient and Insurance email local variables
            String pEmail = "", iEmail = "";
            decimal pDue = 0, iDue = 0;
            try
            {
                conn.Open();
                OleDbCommand comm = new OleDbCommand()
                {
                    //Pulls all records based on date range selected
                    Connection = conn,
                    CommandText = "SELECT Patient_Invoices.Patient_ID, Patient_Invoices.Insurance_ID, OurPatients.Email, Insurance_Types.Email, Patient_Invoices.Patient_Due, Patient_Invoices.Ins_Due " +
                    "FROM Insurance_Types INNER JOIN (OurPatients INNER JOIN Patient_Invoices ON OurPatients.PatientNumber = Patient_Invoices.Patient_ID) ON Insurance_Types.Ins_cID = Patient_Invoices.Insurance_ID " +
                    "WHERE (([Patient_Invoices].[Patient_ID]="+ invoiceID +") AND ([OurPatients].[PatientNumber]=[Patient_Invoices].[Patient_ID]) AND ([Insurance_Types].[Ins_cID]=[Patient_Invoices].[Patient_ID]));"

                };

                OleDbDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    pEmail = reader["OurPatients.Email"].ToString();
                    iEmail = reader["Insurance_Types.Email"].ToString();
                    pDue = Convert.ToDecimal(reader["Patient_Due"].ToString());
                    iDue = Convert.ToDecimal(reader["Ins_Due"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please check DB connection and row index selected it may have been deleted." + ex);
            }

            //Closes DB connection
            conn.Close();

            //Send emails to parties that owe a balance
            if (pDue > 0 && iDue > 0)
            {
                MessageBox.Show("Email sent to " + pEmail + " regarding $" + pDue + " balance.", "Email sent to Patient");
            } 
            if (iDue > 0)
            {
                MessageBox.Show("Email sent to " + iEmail + " regarding $" + iDue + " balance.", "Email sent to Insurance Company");
            }
        }
    
    }
}
