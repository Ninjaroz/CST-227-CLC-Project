﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace MedOffice_1._0
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = new OleDbConnection();
        string permission = "";
                
        public Form1()
        {
            InitializeComponent();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\xdark\Documents\MedOfficeDB.accdb;
Persist Security Info=False;";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

       

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;

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
            if (permission.Equals("Clerical"))
            {
                Clerical clerk = new Clerical();
                clerk.Show();
            }
            else if (permission.Equals(""))
            {
                MessageBox.Show("Incorrect username or password");
            }
                        
            conn.Close();
        }
    }
}
