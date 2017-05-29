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
    public partial class Login : Form
    {
        OleDbConnection conn = new OleDbConnection();
        string permission = "";
                
        public Login()
        {
            InitializeComponent();
            conn.ConnectionString = OurConnection.Conn;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;

            try
            {
                conn.Open();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;
                comm.CommandText = "SELECT PermissionType FROM Logins WHERE Username= '"
                    + username + "' and Password= '" + password + "'";
                OleDbDataReader reader = comm.ExecuteReader();

               while (reader.Read())
                {
                    permission = (reader["PermissionType"].ToString());
                }
                switch (permission)
                {
                    //Medical Assistant
                    case "7":
                        Main_Menu mMDI = new Main_Menu(false, true, false);
                        mMDI.Show();
                        usernameBox.Text = username = passwordBox.Text = password = permission = "";
                        break;

                    //Clerical login page 2 is Clerical groupID
                    case "2":
                    //Creates and opens the MDI and sets Clerical form to true
                    Main_Menu cMDI = new Main_Menu(true, false, true);
                    //Opens Clerical form
                    cMDI.Show();
                    //Clears username, password, and permission in Login menu for variables and text fields
                    usernameBox.Text = username = passwordBox.Text = password = permission = "";
                    break;

                    case "1":
                    Main_Menu aMDI = new Main_Menu(true, true, true);
                    aMDI.Show();
                    usernameBox.Text = username = passwordBox.Text = password = permission = "";
                    break;
                    
                    /* If permissionType is not found for passed in credentials the user does not exist because
                     * permissionType is a required field for every user
                     */
                    default:
                        MessageBox.Show("Invalid username or password.","Invalid Login Credentials", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        break;

                }
                conn.Close();
            }
            //Message that is displayed if user is unable to access DB.
            catch (Exception)
            {
                MessageBox.Show("Unable to access DB. Please check your DB connectivity settings.", "Unable to connect to DB",MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }  
        }
    }
}
