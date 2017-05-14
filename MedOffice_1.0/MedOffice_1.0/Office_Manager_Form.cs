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
    public partial class Office_Manager_Form : Form
    {
        //Class level variable
        OleDbConnection conn = new OleDbConnection();
        String Weekends = "Yes";

        public Office_Manager_Form()
        {
            InitializeComponent();
            //Gets DB connectionString from the connectionString class
            conn.ConnectionString = OurConnection.Conn;
        }
        //Currently only loads the cboEmployees combobox with employees names and value member of User_ID
        private void Office_Manager_Form_Load(object sender, EventArgs e)
        {
           //Loads cboEmployees combobox with employees in DB. 
            try
            {
                conn.Open();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;
                comm.CommandText = "SELECT User_ID, Username FROM Logins";
                String cmd = "SELECT User_ID, Username FROM Logins";
                OleDbDataAdapter da = new OleDbDataAdapter(cmd, conn);
                DataTable ds = new DataTable();
               da.Fill(ds);
               cboEmployees.DataSource = ds;
               cboEmployees.DisplayMember = "Username";
               cboEmployees.ValueMember = "User_ID";
               comm.ExecuteNonQuery();
               conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to access DB. Please check your DB connectivity settings.", "Unable to connect to DB", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        //Adds schedule to employee
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;
                //  SQL command to add schedule to employee record in database
                comm.CommandText =
                    "UPDATE Logins SET Schedule=" + "'" + cboSchedule.SelectedItem.ToString() + "'" +
                ", Work_Weekends=" + Weekends + " WHERE USER_ID=" + cboEmployees.SelectedValue.ToString();

                comm.ExecuteNonQuery();

                conn.Close(); //close connection
            }
            catch(Exception)
            {
                MessageBox.Show("Unable to access DB. Please check your DB connectivity settings.", "Unable to connect to DB", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        //Updates Weekends to Yes or No 
        private void cbWeekends_CheckedChanged(object sender, EventArgs e)
        {
            if (cbWeekends.Checked)
            {
                Weekends = "Yes";
            }else{
                Weekends = "No";
            }
        }
       
        //Displays all of the users and their schedules in the listview
        private void btnViewSchedule_Click(object sender, EventArgs e)
        {
            lstAllSchedules.View = View.Details;
            try
            {
                lstAllSchedules.Items.Clear();
                conn.Open();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;
                //  SQL command to add schedule to employee record in Logins table
                String aCommand = "Select Username, Schedule, Work_Weekends FROM Logins";
                OleDbCommand com = new OleDbCommand(aCommand, conn);
                DataSet ds = new DataSet();
                OleDbDataAdapter OleDba = new OleDbDataAdapter(com);
                OleDba.Fill(ds, "Logins");
                conn.Close();
                DataTable dt = ds.Tables["Logins"];
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    lstAllSchedules.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                    lstAllSchedules.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                    lstAllSchedules.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to access DB. Please check your DB connectivity settings.", "Unable to connect to DB", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    
    }
}
