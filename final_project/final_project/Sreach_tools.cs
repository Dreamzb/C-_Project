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
    public partial class Sreach_tools : Form
    {
        String Con = "Dsn=WineData1;uid=COMP329_19;pwd=wxYLZQFHb4";
        List<string> dataitems = new List<string>();

        public Sreach_tools()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            string sql1;
            if (textBoxName.Text == "ALL" && comboType.Text == "ALL" && comboKind.Text == "ALL" && textBoxPrice.Text == "ALL" && textBoxYear.Text == "ALL")
            {
                sql = "SELECT * From Wine";
                DataTable dt = GetDataTAdapter(sql);
            }
            else
            {
                if (textBoxName.Text == "ALL")
                {
                    string Name = null;
                }
                else
                {

                }

                if (comboType.Text == "ALL")
                {
                    string Type = null;
                }
                else
                {

                }
                if (comboKind.Text == "ALL")
                {
                    string Kind = null;
                }
                else
                {

                }
                if (textBoxPrice.Text == "ALL")
                {
                    string Price = null;
                }
                else
                {

                }
                if (textBoxYear.Text == "ALL")
                {
                    string Year = null;
                }
                else
                {
                    
                }
                sql1 = "SELECT * From Wine where Years = '"
                + textBoxYear.Text+ "'";
                DataTable dt = GetDataTAdapter(sql1);
            }


            
            
           
        }
        public DataTable GetDataTAdapter(string queryString)
        {
            DataTable dt = new DataTable();
            using (OdbcConnection connection =
                        new OdbcConnection(Con))
            {
                using (OdbcDataAdapter adapter =
                        new OdbcDataAdapter(queryString, connection))
                {
                    connection.Open();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            return dt;
        }

        private void Sreach_tools_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.WINE' table. You can move, or remove it, as needed.
            this.wINETableAdapter1.Fill(this.dataSet2.WINE);
            // TODO: This line of code loads data into the 'dataSet1.WINE' table. You can move, or remove it, as needed.
            this.wINETableAdapter.Fill(this.dataSet1.WINE);

            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sreach_Enter(object sender, EventArgs e)
        {

        }
    }
}
