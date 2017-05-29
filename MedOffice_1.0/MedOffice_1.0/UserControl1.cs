using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MedOffice_1._0
{
    public partial class Clerical : Form
    {
        OleDbConnection conn = new OleDbConnection();
        //OleDbConnection conn2 = new OleDbConnection();
        public string patientLast, patientFirst, ins, dob, fullPatient, age;

        private void checkInButton_Click(object sender, EventArgs e)
        {
            string checkIn = "Yes";
            try
            {
                conn.Open();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;
                comm.CommandText = "UPDATE OurPatients SET Checked_In = '" + checkIn + "' WHERE PatientLast= '"
                    + patientLast + "' and PatientFirst = '" + patientFirst + "'";
                comm.ExecuteNonQuery();
                MessageBox.Show("Patient checked in successfully");
                conn.Close();
            }

            catch (OleDbException f)
            {
                MessageBox.Show("Please select a patient to check in.");
            }
        }

        private void apptSave_Click(object sender, EventArgs e)
        {
            string date = apptDateBox.Text;
            try
            {
                conn.Open();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;
                comm.CommandText = "UPDATE OurPatients SET AppointmentDate= '"
                    + date + "' WHERE PatientLast= '" + patientLast
                    + "' and PatientFirst= '" + patientFirst + "' and PatientAge= '" + age + "'";
                comm.ExecuteNonQuery();
                MessageBox.Show("Appointment set for " + date);
                conn.Close();
                firstNameBox.Clear();
                lastNameBox.Clear();
                patientBox.Items.Clear();
                ageBox.Clear();
                dobBox.Clear();
                patientBox.Items.Clear();
            }
            catch (OleDbException f)
            {
                MessageBox.Show("Unable to save appointment, please ensure that the name, date, and age are filled in.");
            }
        }

        private void viewApptButton_Click(object sender, EventArgs e)
        {
            AppointmentView apView = new AppointmentView();
            apView.Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            patientLast = lastNameBox.Text;
            patientFirst = firstNameBox.Text;
            dob = dobBox.Text;
            ins = insBox.Text;
            age = ageBox.Text;

            try
            {
                conn.Open();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;
                comm.CommandText = "INSERT INTO OurPatients(PatientLast, PatientFirst, PatientAge"
                    + ", PatientDOB, PatientIns)" +
                         "VALUES ('" + patientLast + "', '" + patientFirst
                         + "', '" + age + "', '" + dob + "', '"
                         + ins + "')";
                comm.Parameters.AddWithValue("@PatientLast", patientLast);
                comm.Parameters.AddWithValue("@PatientFirst", patientFirst);
                comm.Parameters.AddWithValue("@PatientAge", age);
                comm.Parameters.AddWithValue("@PatientDOB", dob);
                comm.Parameters.AddWithValue("@PatientIns", ins);

                comm.ExecuteNonQuery();

                conn.Close();
            }
            catch (OleDbException f)
            {
                MessageBox.Show("Please ensure all fields are filled in.");
            }
        }

        private void Clerical_Load(object sender, EventArgs e)
        {
            insBox.Items.Add("Selfpay");
            insBox.Items.Add("BCBS");
            insBox.Items.Add("UHC");
            insBox.Items.Add("Medicare");
            insBox.Items.Add("Aflac");
            insBox.Items.Add("Medicaid");
        }

        public Clerical()
        {
            InitializeComponent();
            conn.ConnectionString = OurConnection.Conn;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            patientBox.Items.Clear();
            patientLast = lastNameBox.Text;
            patientFirst = firstNameBox.Text;
            dob = dobBox.Text;
            ins = insBox.Text;
            age = ageBox.Text;

            try
            {
                conn.Open();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;

                comm.CommandText = "SELECT * FROM OurPatients WHERE PatientLast= '"
                    + patientLast + "' or PatientFirst= '" + patientFirst
                    + "'";
                OleDbDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    patientLast = (reader["PatientLast"].ToString());
                    patientFirst = (reader["PatientFirst"].ToString());
                    age = (reader["PatientAge"].ToString());
                    dob = (reader["PatientDOB"].ToString());
                    ins = (reader["Insurance_ID"].ToString());
                    fullPatient = ("" + patientLast + "," + patientFirst + " age "
                        + age + " " + dob + " " + ins);
                    patientBox.Items.Add(fullPatient);
                }

                conn.Close();
            }
            catch (OleDbException f)
            {
                MessageBox.Show("Please enter a first or last name.");
            }
        }
    }
}