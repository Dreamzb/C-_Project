using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _329_final_project
{
    public partial class LogIn : Form
    {
        String Con = "Dsn=WineData1;uid=COMP329_19;pwd=wxYLZQFHb4";
        public LogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           
        }


        public bool trylogin(string username, string password)
        {
            string dbstring = "SELECT * From Staff WHERE Stuname='" + username + "' and Stpd ='" + password + "';";
            OdbcCommand command = new OdbcCommand(dbstring);

            using (OdbcConnection connection = new OdbcConnection(Con))
            {
                command.Connection = connection;
                connection.Open();
                OdbcDataReader dr = command.ExecuteReader();
                if (dr.Read() != false)
                {
                    if (dr.IsDBNull(0) == true)
                    {
                        command.Connection.Close();
                        dr.Dispose();
                        command.Dispose();
                        return false;
                    }
                    else
                    {
                        command.Connection.Close();
                        dr.Dispose();
                        command.Dispose();
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
        }
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (trylogin(textUsername.Text, textPassword.Text) == true)
            {
                Main m = new Main();
                m.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Sorry, cant login");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       
    }
}
