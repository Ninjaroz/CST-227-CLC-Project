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
        //Class level variable
        OleDbConnection conn = new OleDbConnection();
                
        public Login()
        {
            InitializeComponent();
            conn.ConnectionString = OurConnection.Conn;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string permission = "";
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

                    //Admin login page 1 is Admin group ID has rights to all forms
                    case "1":
                    //Creates and opens the MDI and sets all forms to true
                    Main_Menu aMDI = new Main_Menu(username, true,true,true,true);
                    aMDI.Show();
                    //Clears username, password, and permission in Login menu for variables and text fields
                    usernameBox.Text = username = passwordBox.Text = password = permission = "";
                    break;
                    
                    //Clerical login page 2 is Clerical groupID only has access to Clerical form
                    case "2":
                    //Creates and opens the MDI and sets Clerical form to true
                    Main_Menu cMDI = new Main_Menu(username,true,false,true,false);
                    cMDI.Show();
                    //Clears username, password, and permission in Login menu for variables and text fields
                    usernameBox.Text = username = passwordBox.Text = password = permission = "";
                    break;
                    
                    case "4":
                    //Creates and opens the MDI and sets only Office_Manager_Form to true
                    Main_Menu oMDI = new Main_Menu(username, false,true,false,false);
                    oMDI.Show();
                    //Clears username, password, and permission in Login menu for variables and text fields
                    usernameBox.Text = username = passwordBox.Text = password = permission = "";
                    break;

                    case "5":
                    //Creates and opens the MDI and sets only Medical Assistant form form to true
                    Main_Menu mMDI = new Main_Menu(username, false, false, false,true);
                    mMDI.Show();
                    //Clears username, password, and permission in Login menu for variables and text fields
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

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
