using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MedOffice_1._0
{
    public partial class Clerical : Form
    {
        //Class level variables
        OleDbConnection conn = new OleDbConnection();
        string patientLast, patientFirst, ins, dob, age, fullPatient, checkin;
        //string , address, allergies, disease, medication, gender, ethnicity, phone;
        int testResultID;

        private static Clerical _instance;

        public static Clerical Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Clerical();
                return _instance;
            }
        }
        
        //Adds new patient to the Database
        private void saveButton_Click(object sender, EventArgs e)
        {
            patientLast = lastNameBox.Text;
            patientFirst = firstNameBox.Text;
            dob = dobBox.Text;
            ins = insBox.Text;
            age = ageBox.Text;
            //gender = textBox_gender.Text;
            //ethnicity = textBox_ethnicity.Text;
            //phone = textBox_phoneNumber.Text;
            //address = textBox_address.Text;
            //allergies = textBox_Allergies_Diseases_Meds.Text;
            //disease = textBox_Allergies_Diseases_Meds.Text;
            //medication = textBox_Allergies_Diseases_Meds.Text;

            //open connection
            conn.Open();
            OleDbCommand comm = new OleDbCommand();
            comm.Connection = conn;

            //  SQL command add to database
            comm.CommandText = "INSERT INTO OurPatients(PatientLast, PatientFirst, PatientAge"
                + ", PatientDOB, PatientIns, Gender, Ethnicity, PhoneNumber, Address, Allergies, Diseases, Medications)" +
                     "VALUES ('" + patientLast + "', '" + patientFirst
                     + "', '" + age + "','" + dob + "', '"
                     + ins + "')";

            comm.Parameters.AddWithValue("@PatientLast", patientLast);
            comm.Parameters.AddWithValue("@PatientFirst", patientFirst);
            comm.Parameters.AddWithValue("@PatientAge", age);
            comm.Parameters.AddWithValue("@PatientDOB", dob);
            comm.Parameters.AddWithValue("@PatientIns", ins);
            //comm.Parameters.AddWithValue("@Gender", gender);
            //comm.Parameters.AddWithValue("@Ethnicity", ethnicity);
            //comm.Parameters.AddWithValue("@PhoneNumber", phone);
            //comm.Parameters.AddWithValue("@Address", address);
            //comm.Parameters.AddWithValue("@Allergies", allergies);
            //comm.Parameters.AddWithValue("@Diseases", disease);
            //comm.Parameters.AddWithValue("@Medications", medication);

            comm.ExecuteNonQuery();

            conn.Close();
        }

        private void Clerical_Load(object sender, EventArgs e)
        {
            //Adds items for dropdownlist combo boxes
            insBox.Items.Add("Selfpay");
            insBox.Items.Add("Insurance");
            cboSelectTestResult.Items.Add("Glucose Test");
            cboSelectTestResult.Items.Add("Blood Test");
            cboSelectTestResult.Items.Add("Stool Sample Test");
            cboSelectTestResult.Items.Add("X Ray Test Result");
            cboSelectTestResult.Items.Add("Physical Health Test");
            cboPatientResult.Items.Add("Excellent");
            cboPatientResult.Items.Add("Poor");
            cboPatientResult.Items.Add("Average");
            cboPatientResult.Items.Add("Good");
        }

        public Clerical()
        {
            InitializeComponent();
            conn.ConnectionString = OurConnection.Conn;
        }

        private void checkinButton_Click(object sender, EventArgs e)
        {
            patientLast = lastNameBox.Text;
            patientFirst = firstNameBox.Text;
            checkin = "yes";

            if (checkinBox.Checked)
            {
                conn.Open();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;
                checkin = "Yes";

                //  SQL command add to database
                comm.CommandText = "UPDATE OurPatients SET CheckedIn=[CheckedIn] +'" + checkin
                    + "'WHERE PatientLast= '" + patientLast + "' and PatientFirst= '" + patientFirst + "'";

                comm.ExecuteNonQuery();

                conn.Close(); //close connection

                MessageBox.Show(fullPatient + " successfully checked in.");
            }
        }
       
        //Changes values for cboPatientResult based on what the selected test result is
        private void cboSelectTestResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(testResultID.ToString());
            //pulls the appropriate value for the cboPatientResult based on the selected index of the cboSelectTestResult

            switch (cboSelectTestResult.SelectedItem.ToString())
            {
                //Looks up the test result for Glucose Test and sets the PatientResult to the approporiate result
                case "Glucose Test":
                    //Calls getTestResultsPercentage to assign the txtTestPercentage the appropriate percentage
                    getTestResultsPercentage("Glucose_Test");
                    break;

                //Looks up the test result for Blood Test and sets the PatientResult to the approporiate result
                case "Blood Test":
                    //Calls getTestResultsPercentage to assign the txtTestPercentage the appropriate percentage
                    getTestResultsPercentage("Blood_Test");
                    break;

                //Looks up the test result for Stool Sample and sets the PatientResult to the approporiate result
                case "Stool Sample Test":
                    //Calls getTestResultsPercentage to assign the txtTestPercentage the appropriate percentage
                    getTestResultsPercentage("Stool_Sample");
                    break;

                //Looks up the test result for X Ray and sets the PatientResult to the approporiate result
                case "X Ray Test Result":
                    //Calls getTestResultsPercentage to assign the txtTestPercentage the appropriate percentage
                    getTestResultsPercentage("X_Ray_Result");
                    break;

                //Looks up the test result for Physical Health and sets the PatientResult to the approporiate result
                case "Physical Health Test":
                    //Calls getTestResultsPercentage to assign the txtTestPercentage the appropriate percentage
                    getTestResultsPercentage("Physical_Health");
                    break;

                /* Displays an error message letting the user know they need to select a test result and sets focus
                * to the cboSelectTestResult combobox.  */
                default:
                    MessageBox.Show("Please select a test from the Select Test Result dropdownlist", "No test selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Sets focus to the test result combobox so user can select an option
                    cboSelectTestResult.Focus();
                    break;
            }          
        }

       //Pulls up patient record by searching for it based on first and last name
        private void searchButton_Click(object sender, EventArgs e)
        {
            //Gets the entered patient last name and patient first name to use for patient search
            patientLast = lastNameBox.Text;
            patientFirst = firstNameBox.Text;
            try
            {
                conn.Open();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;
                comm.CommandText = "SELECT * FROM OurPatients WHERE PatientLast= '"
                    + patientLast + "' and PatientFirst= '" + patientFirst
                    + "'";
                OleDbDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    age = (reader["PatientAge"].ToString());
                    dob = (reader["PatientDOB"].ToString());
                    ins = (reader["PatientIns"].ToString());
                    //gender = (reader["Gender"].ToString());
                    //ethnicity = (reader["Ethnicity"].ToString());
                    //phone = (reader["PhoneNumber"].ToString());
                    //address = (reader["Address"].ToString());
                    //allergies = (reader["Allergies"].ToString());
                    //disease = (reader["Diseases"].ToString());
                    //medication = (reader["Medications"].ToString());
                    testResultID = int.Parse(reader["Test_Results_ID"].ToString());
                }

                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to access DB. Please check your DB connectivity settings.", "Unable to connect to DB", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            //Assigns values to appropriate form fields that were pulled from the DB
            ageBox.Text = age;
            dobBox.Text = dob;
            insBox.Text = ins;
            //textBox_gender.Text = gender;
            //textBox_ethnicity.Text = ethnicity;
            //textBox_phoneNumber.Text = phone;
            //textBox_address.Text = address;
            //textBox_Allergies_Diseases_Meds.Text = disease;
            fullPatient = patientLast + ", " + patientFirst + ", " + age;
            patientBox.Items.Add(fullPatient);
        }

        //assigns txtTestPercentage the appropriate percentage amount for that test type based on the patients test results
        private void getTestResultsPercentage(String tType)
        {
            try
            {
                conn.Open();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;

                /*changes cboPatientResult combo box to the appropriate index depending on what the test result is for 
                the patient for the test type selected */
                comm.CommandText = "Select " + tType + " From TestResults WHERE TestID = " + testResultID;
                using (OleDbDataReader odr = comm.ExecuteReader())
                {
                    while (odr.Read())
                    {
                        cboPatientResult.SelectedIndex = cboPatientResult.FindStringExact(odr[0].ToString());
                    }
                }
                
                //local variables
                int numOfTests = 0, numOfPatientResults = 0;
                
                //Counts all records for the test and assigns it to numOfTests
                comm.CommandText = "SELECT Count(" + tType + ") AS Expr1 FROM TestResults;";
                using (OleDbDataReader odr = comm.ExecuteReader())
                {
                    while (odr.Read())
                    {
                        //Gets the total number of tests for the test type passed into this method.
                        numOfTests = int.Parse(odr[0].ToString());
                    }
                }
                //Counts the number of tests that are the same as the current patients and assigns it to numOfPatientResults
                comm.CommandText = "SELECT Count(" + tType+ ") AS Expr1 FROM TestResults WHERE " + tType + "= '" + cboSelectTestResult.SelectedItem.ToString() + "'";
                using (OleDbDataReader odr = comm.ExecuteReader())
                {
                    while (odr.Read())
                    {
                        //Gets the total number of patients with the same result as the current patient
                        numOfPatientResults = int.Parse(odr[0].ToString());
                    }
                }

                //Calculates the percentage of tests that match the patients and assigns it to txtTestPercentage
                txtTestPercentage.Text = ((numOfPatientResults / numOfTests) * 100).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to access DB. Please check your DB connectivity settings.", "Unable to connect to DB", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            conn.Close();
        }
    }
}
