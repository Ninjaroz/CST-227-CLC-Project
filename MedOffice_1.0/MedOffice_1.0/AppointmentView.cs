using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace MedOffice_1._0
{
    public partial class AppointmentView : Form
    {
        OleDbConnection conn = new OleDbConnection();
        public AppointmentView()
        {
            InitializeComponent();
            conn.ConnectionString = OurConnection.Conn;
        }

        private void AppointmentView_Load(object sender, EventArgs e)
        {

        }

        private void apptButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string patientAppt = "";
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;
                comm.CommandText = "SELECT * FROM OurPatients WHERE AppointmentDate BETWEEN '"
                    + startDateBox.Text + "' and '" + endDateBox.Text + "'";
                OleDbDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    patientAppt = (reader["PatientLast"].ToString()) + ", "
                        + (reader["PatientFirst"].ToString())
                        + (reader["AppointmentDate"].ToString());
                    apptBox.Items.Add(patientAppt);
                }
                conn.Close();
            }
            catch (OleDbException f)
            {
                Console.WriteLine("Please ensure that you have selected a start and end date.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            apptBox.Items.Clear();
        }
    }
}
