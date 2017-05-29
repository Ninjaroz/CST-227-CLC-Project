using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace MedOffice_1._0
{
    public static class OurConnection
    {
        //Edit and add your connection to the DB here
        private static string conn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Robbie\Documents\GitHub\CST-227-CLC-Project\MedOfficeDB_Test_13May.mdb;
                                     Persist Security Info=False;";
        
        //Get and Set for connection string
        public static string Conn 
        {
            get
            {
                return conn;
            }
            set
            {
                conn = value;
            }
        }
    }
}
