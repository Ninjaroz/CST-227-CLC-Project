using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MedOffice_1._0
{
    public partial class MedicalAssistant : Form
    {
        //Variables

        OleDbConnection conn = new OleDbConnection();
        string lastName, firstName, age, aller, med, dis, tempF, o2, bp, selectFirst, selectLast;

        //Remove buttons

        private void medRemove_Click(object sender, EventArgs e)
        {
            string selected = medBox.SelectedItem.ToString();
            if (medText.Text == "")
            {
                medBox.Items.Remove(selected);
            }
            else
            {
                string removeMed = disBox.Text;
                allBox.Items.Remove(removeMed);
            }
        }

        private void allRemove_Click(object sender, EventArgs e)
        {
            string selected = allBox.SelectedItem.ToString();
            if (allerText.Text == "")
            {
                allBox.Items.Remove(selected);
            }
            else
            {
                string removeAll = disBox.Text;
                allBox.Items.Remove(removeAll);
            }
        }

        private void disRemove_Click(object sender, EventArgs e)
        {
            string selected = disBox.SelectedItem.ToString();
            if (disText.Text == "")
            {
                disBox.Items.Remove(selected);
            }
            else
            {
                string removeDis = disBox.Text;
                disBox.Items.Remove(removeDis);
            }
        }

        private void MedicalAssistant_Load(object sender, EventArgs e)
        {

        }

        //Add buttons

        private void addDis_Click(object sender, EventArgs e)
        {
            string disAdd = disText.Text;
            disBox.Items.Add(disAdd);
            disText.Clear();
        }

        private void addAller_Click(object sender, EventArgs e)
        {
            string allerAdd = allerText.Text;
            allBox.Items.Add(allerAdd);
            allerText.Clear();
        }

        private void addMed_Click(object sender, EventArgs e)
        {
            string addedMed = medText.Text;
            medBox.Items.Add(addedMed);
            medText.Clear();
        }

        //Get meds from the meds box

        public string getMeds()
        {
            List<string> arr = new List<string>();
            string temp = "";
            med = medBox.Text;
            for (int i = 0; i < medBox.Items.Count; i++)
            {
                medBox.SetSelected(i, true);
                arr.Add(medBox.SelectedItem.ToString());
            }
            for (int j = 0; j < arr.Count; j++)
            {
                if (med == "")
                {
                    med = (arr[j].ToString());
                    temp = med;
                }
                else if (med != "")
                {
                    med = (temp + ", " + arr[j].ToString());
                    temp = med;
                }
            }
            return med;
        }

        //select patient and get info

        private void selectButton_Click(object sender, EventArgs e)
        {
            OleDbCommand comm = new OleDbCommand();
            comm.Connection = conn;
            string temp = "";
            string selected = patientList.SelectedItem.ToString();
            int ageIndex = selected.IndexOf("age");
            for (int i = 0; i < selected.Length - 1; i++)
            {
                if (selected.Substring(i, 1) == ",")
                {
                    selectLast = selected.Substring(0, i);
                    temp = selected.Replace((selectLast), "");
                    temp.Trim();
                    selectFirst = temp.Substring(2, (ageIndex - i - 2));
                }
            }
            try
            {
                conn.Open();
                comm.CommandText = "SELECT * FROM OurPatients WHERE PatientLast= '"
                    + selectLast + "' and PatientFirst= '" + selectFirst + "'";
                OleDbDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    string medicat = (reader["Medications"].ToString());
                    string allergy = (reader["Allergies"].ToString());
                    string disease = (reader["Diseases"].ToString());
                    string[] medArr = medicat.Split(',');
                    string[] allArr = allergy.Split(',');
                    string[] disArr = disease.Split(',');
                    for (int i = 0; i < medArr.Length; i++)
                    {
                        if (medArr[i] != "")
                        {
                            medBox.Items.Add(medArr[i]);
                        }
                        else
                        {
                        }
                    }
                    for (int j = 0; j < allArr.Length; j++)
                    {
                        if (allArr[j] != "")
                        {
                            allBox.Items.Add(allArr[j]);
                        }
                        else
                        {
                        }
                    }
                    for (int h = 0; h < disArr.Length; h++)
                    {
                        if (disArr[h] != "")
                        {
                            disBox.Items.Add(disArr[h]);
                        }
                        else
                        {
                        }
                    }
                }
                conn.Close();
                nameLabel.Text = selectLast + ", " + selectFirst;
            }
            catch (OleDbException f)
            {
                MessageBox.Show("Please select a patient.");
            }
        }

        //Get allergies from the allergy box

        public string getAller()
        {
            List<string> arr = new List<string>();
            string temp = "";
            aller = allBox.Text;
            for (int i = 0; i < allBox.Items.Count; i++)
            {
                allBox.SetSelected(i, true);
                arr.Add(allBox.SelectedItem.ToString());
            }
            for (int j = 0; j < arr.Count; j++)
            {
                if (aller == "")
                {
                    aller = (arr[j].ToString());
                    temp = aller;
                }
                else if (aller != "")
                {
                    aller = (temp + ", " + arr[j].ToString());
                    temp = aller;
                }
            }
            return aller;
        }

        //Get diseases from the disease box

        public string getDis()
        {
            List<string> arr = new List<string>();
            string temp = "";
            dis = disBox.Text;
            for (int i = 0; i < disBox.Items.Count; i++)
            {
                disBox.SetSelected(i, true);
                arr.Add(disBox.SelectedItem.ToString());
            }
            for (int j = 0; j < arr.Count; j++)
            {
                if (dis == "")
                {
                    dis = (arr[j].ToString());
                    temp = dis;
                }
                else if (dis != "")
                {
                    dis = (temp + ", " + arr[j].ToString());
                    temp = dis;
                }
            }
            return dis;
        }

        //Save all info to database

        private void saveButton_Click(object sender, EventArgs e)
        {
            lastName = lastBox.Text;
            firstName = firstBox.Text;
            med = medBox.Text;
            aller = allBox.Text;
            dis = disBox.Text;
            bp = sysBpBox.Text + "/" + diasBp.Text;
            tempF = tempBox.Text;
            o2 = o2Box.Text;
            string temp = "";
            List<string> arr = new List<string>();

            getMeds();
            getAller();
            getDis();

            OleDbCommand comm = new OleDbCommand();
            comm.Connection = conn;
            try
            {
                conn.Open();
                comm.CommandText = "UPDATE OurPatients SET [Allergies]= '"
                    + aller + "', [Diseases]= '" + dis + "', [Medications]= '"
                    + med + "', [BloodPressure]= '" + bp + "', [Oxygen]= '"
                    + o2 + "', [Temperature]= '" + tempF + "' WHERE PatientLast= '"
                    + selectLast + "' and PatientFirst= '"
                    + selectFirst + "'";
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (OleDbException f)
            {
                MessageBox.Show("Unable to update information, please ensure you have filled out the patient name.");
            }
        }

        public MedicalAssistant()
        {
            InitializeComponent();
            conn.ConnectionString = OurConnection.Conn;
            Size = new Size(800, 600);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            patientList.Items.Clear();
            medBox.Items.Clear();
            allBox.Items.Clear();
            disBox.Items.Clear();
            try
            {
                conn.Open();
                lastName = lastBox.Text;
                firstName = firstBox.Text;
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;
                comm.CommandText = "SELECT * FROM OurPatients WHERE PatientLast= '"
                    + lastName + "' or PatientFirst= '" + firstName + "'";
                OleDbDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    lastName = (reader["PatientLast"].ToString());
                    firstName = (reader["PatientFirst"].ToString());
                    age = (reader["PatientAge"].ToString());

                }
                patientList.Items.Add(lastName + ", " + firstName + " age " + age);
                conn.Close();
            }
            catch (OleDbException f)
            {
                MessageBox.Show("Please enter a first or last name to search.");
            }
        }
    }
}
