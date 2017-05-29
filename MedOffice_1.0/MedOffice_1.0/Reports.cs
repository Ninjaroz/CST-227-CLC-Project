using System;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;

namespace MedOffice_1._0
{
    public partial class Reports : Form
    {
        OleDbConnection conn = new OleDbConnection(OurConnection.Conn);

        public string patientLast, patientFirst, Test_Control, TestResults, PatientNum;
        public string GlucoseTest, BloodTest, StoolSample, XRay, PhysicalHealth;

       
        //Grabs patient data, PatientNumber, and fills the cboXrayImages combobox
        private void button_Run_Click(object sender, EventArgs e)
        { 
            //Gets patient report data
            GetPatientReport();

            //Get Patient ID
            GetPatientID();

            //Loads cboXrayImages with any existing xrays the patient has
            GetPatientXrays();
        }

        private void Main_Click(object sender, EventArgs e)
        {
            Main_Menu cMDI = new Main_Menu(true, false,true);
            //Opens Clerical form
            cMDI.Show();
            this.Hide();
        }

        public Reports()
        {
            InitializeComponent();
            conn.ConnectionString = OurConnection.Conn;
        }

        //Opens Patient_Xray form sending it the current PatientNumber
        private void btnCreateXray_Click(object sender, EventArgs e)
        {
            /* Sends current PatientNum to X-Ray Form to create new record in the Patient_Xrays table
             */
            if (PatientNum != null)
            {
                Patient_Xray pXray = new Patient_Xray(PatientNum);
                pXray.Show();
            }
            else
            {
                MessageBox.Show("Please look up a patient before creating a new Xray for a patient", "No Patient found");
                textBox_FirstName.Focus();
            }
        }

        //Gets PatientNumber from DB
        private void GetPatientID()
        {
            try
            {
                conn.Open();
                OleDbCommand comm = new OleDbCommand()
                {
                    //gets patientNumber from DB based on First and last name
                    Connection = conn,
                    CommandText = "Select PatientNumber FROM ourPatients WHERE PatientLast = '" + textBox_LastName.Text + "'" +
                    "AND PatientFirst = '" + textBox_FirstName.Text + "'"
                };

                OleDbDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    PatientNum = (reader["PatientNumber"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot get Patient ID. Please check DB settings. " + ex);
            }

            //Closes reader and connection
            conn.Close();
        }
       
        //Generates Patient Report
        private void GetPatientReport()
        {
            try
            {
                conn.Open();
                OleDbCommand comm = new OleDbCommand()
                {
                    Connection = conn,
                    CommandText = "SELECT * FROM TestResults WHERE Test_Control= '"
                   + textbox_TestControl.Text + "'and Last_Name= '" + textBox_LastName.Text + "'and First_Name='" + textBox_FirstName.Text
                   + "'"
                };

                OleDbDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    Test_Control = (reader["Test_Control"].ToString());
                    patientLast = (reader["Last_Name"].ToString());
                    patientFirst = (reader["First_Name"].ToString());
                    GlucoseTest = (reader["Glucose_Test"].ToString());
                    BloodTest = (reader["Blood_Test"].ToString());
                    StoolSample = (reader["Stool_Sample"].ToString());
                    XRay = (reader["X_Ray_Result"].ToString());
                    PhysicalHealth = (reader["Physical_Health"].ToString());


                    TestResults = (patientLast + "," + patientFirst + "/" + " Glucose Test:" + GlucoseTest + "/" + " Blood Test:" +
                        BloodTest + "/ " + " Stool Sample:" + StoolSample +
                        "/" + " Test Control Code:" + Test_Control);


                    listBox_TestResults.Items.Add(TestResults);

                    String[] seriesArray = { "GlucoseTest", "BloodTest", "StoolSample" };

                    int[] points = { 2, 3, 1 };



                    for (int i = 0; i < points.Length; i++)
                    {
                        Series series = this.chart1.Series.Add(seriesArray[i]);
                        series.Points.Add(points[i]);







                    } 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot pull up patient report. Please check DB settings. " + ex);
            }

            //Closes DB connection
            conn.Close();
        }
    
        //Grabs Patient Xray's for combobox
        private void GetPatientXrays()
        {
            DataSet ds = new DataSet();
            
            try
            {
                conn.Open();
                String XrayLookup = "SELECT XRay_ID, Xray_Title FROM Patient_Xrays WHERE Patient_ID= "
               + PatientNum + " ORDER BY Xray_Title DESC";
                OleDbDataAdapter da = new OleDbDataAdapter(XrayLookup, conn);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to populate Xray comboBox. Please check DB connectivity " + ex);
            }

            //Closes connection after running command to pull cboXrayImages data
            conn.Close();

            //Fills combobox with all Xrays the patient has

            cboXrayImages.ValueMember = "XRay_ID";
            cboXrayImages.DisplayMember = "Xray_Title";
            cboXrayImages.DataSource = ds.Tables[0];
        }
        
        //Opens Patient_Xray form sending it the current PatientNumber and Xray_ID
        private void btnOpenXray_Click(object sender, EventArgs e)
        {
            /*Send Patient_Xray Form Patient_Xrays data based on the XRay_ID selected from the ComboBox
             * and pull up that data in the Patient_Xrays form */
            if (cboXrayImages.SelectedIndex != -1) { 
            Patient_Xray pXray = new Patient_Xray(cboXrayImages.SelectedValue.ToString(), PatientNum);
            pXray.Show();
            }
            else
            {
                MessageBox.Show("Please select a record from the drop down list.", "Drop down list item not selected");
                cboXrayImages.Focus();
            }
        } 
    }
}    