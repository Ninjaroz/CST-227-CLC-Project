using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedOffice_1._0
{
    public partial class Main_Menu : Form
    {
        /*Enables forms based on user Permissions passed in
         * If adding another form please go back to login.cs and add form values to each permission in the switch 
        */
        public Main_Menu(String username, Boolean cForm, Boolean oForm, Boolean aForm, Boolean mForm)
        {
            InitializeComponent();
            Welcomelbl.Text = "Welcome " + username;
            //Enables the forms the users have access to
            clericalFormToolStripMenuItem.Enabled = cForm;
            staffingFormToolStripMenuItem.Enabled = oForm;
            addClientAppointmentToolStripMenuItem.Enabled = aForm;
            medicalAssistantFormToolStripMenuItem.Enabled = mForm;

        }
       
        //file menu option exit to close MDI
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Clerical form
        private void clericalFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clerical nClerical = new Clerical();
            //Opens nClerical form in the MDI container
            nClerical.MdiParent = this;
            nClerical.Show();
        }

        //Print button under file
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Brings up Print dialog to print application screen
            PrintDialog nPD = new PrintDialog();
            nPD.ShowDialog();
        }

        //Staffing Form
        private void staffingFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Office_Manager_Form nOMF = new Office_Manager_Form();
            //Opens nClerical form in the MDI container
            nOMF.MdiParent = this;
            nOMF.Show();
        }

        private void addClientAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAppointment nAMF = new AddAppointment();
            //Opens nClerical form in the MDI container
            nAMF.MdiParent = this;
            nAMF.Show();
        }

        //Medical Assistant Form
        private void medicalAssistantFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medical_Assistant_Form nMMF = new Medical_Assistant_Form();
            //Opens nClerical form in the MDI container
            nMMF.MdiParent = this;
            nMMF.Show();
        }
    }
}
