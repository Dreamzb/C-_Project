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
    public partial class Main : Form
    {
        String Con = "Dsn=WineData;uid=COMP329_19;pwd=wxYLZQFHb4";
        public Main()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.BUYORDER' table. You can move, or remove it, as needed.
            this.bUYORDERTableAdapter1.Fill(this.dataSet2.BUYORDER);
            // TODO: This line of code loads data into the 'dataSet2.PERSON' table. You can move, or remove it, as needed.
            this.pERSONTableAdapter.Fill(this.dataSet2.PERSON);
            // TODO: This line of code loads data into the 'dataSet2.WINE' table. You can move, or remove it, as needed.
            this.wINETableAdapter1.Fill(this.dataSet2.WINE);

        }


        private void buttonBAdd_Click(object sender, EventArgs e)
        {

            string theDateCreate = dateTimeCreate.Value.ToString("dd/MM/yyyy");
            string theDateEnd= dateTimeCreate.Value.ToString("dd/MM/yyyy");

            string dbstring = "insert into Buyorder (Bid,BCreate_time,BEnd_time,bstate) values('"
                + textBoxBid.Text + "','"
                + theDateCreate + "','"
                + theDateEnd + "','"
                + comboBoxState.Text + "')";

            OdbcCommand command = new OdbcCommand(dbstring);
            using (OdbcConnection connection = new OdbcConnection(Con))
            {
                command.Connection = connection;
                OdbcDataReader reader;
                connection.Open();
                try
                {

                    reader = command.ExecuteReader();
                    MessageBox.Show("The Order has been Added!");
                    this.bUYORDERTableAdapter1.Fill(this.dataSet2.BUYORDER);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void buttonBUpdate_Click(object sender, EventArgs e)
        {
            string theDateCreate = dateTimeCreate.Value.ToString("dd/MM/yyyy");
            string theDateEnd = dateTimeCreate.Value.ToString("dd/MM/yyyy");
            string dbstring = " update Buyorder set BCreate_time = '"
                + theDateCreate
                + "', BEnd_time ='" + theDateEnd
                + "', bstate ='" + comboBoxState.Text 
                + "' WHERE Bid ='" +
                    textBoxBid.Text + "'";

            OdbcCommand command = new OdbcCommand(dbstring);
            using (OdbcConnection connection = new OdbcConnection(Con))
            {
                command.Connection = connection;
                OdbcDataReader reader;
                connection.Open();
                try
                {

                    reader = command.ExecuteReader();
                    MessageBox.Show("The Order has been updated!");
                    this.bUYORDERTableAdapter1.Fill(this.dataSet2.BUYORDER);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }


        private void buttonBDelete_Click(object sender, EventArgs e)
        {
            string dbstring = " delete from Buyorder where Bid ='" + textBoxBid.Text + "'";

            OdbcCommand command = new OdbcCommand(dbstring);
            using (OdbcConnection connection = new OdbcConnection(Con))
            {
                command.Connection = connection;
                OdbcDataReader reader;
                connection.Open();
                try
                {

                    reader = command.ExecuteReader();
                    MessageBox.Show("The Order has been deleted!");
                    this.bUYORDERTableAdapter1.Fill(this.dataSet2.BUYORDER);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }


        private void buttonWAdd_Click(object sender, EventArgs e)
        {
            string dbstring = "insert into Wine (Wid,Bid,WName,Wine_type,Wine_kinds,Price,Years) values('"
                + textBoxWid.Text + "','"
                + textBoxBid_2.Text + "','"
                + textBoxName.Text + "','"
                + textBoxType.Text + "','"
                + textBoxKind.Text + "','"
                + textBoxPrice.Text + "','"
                + textBoxYears.Text + "')";

            OdbcCommand command = new OdbcCommand(dbstring);
            using (OdbcConnection connection = new OdbcConnection(Con))
            {
                command.Connection = connection;
                OdbcDataReader reader;
                connection.Open();
                try
                {

                    reader = command.ExecuteReader();
                    MessageBox.Show("The Wine has been Added!");
                    this.wINETableAdapter1.Fill(this.dataSet2.WINE);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void buttonWUpdate_Click(object sender, EventArgs e)
        {
            string dbstring = " update Wine set Bid = '" + textBoxBid_2.Text
                + "', WName ='" + textBoxName.Text
                + "', Wine_type ='" + textBoxType.Text
                + "', Wine_kinds ='" + textBoxKind.Text
                + "', Price ='" + textBoxPrice.Text
                + "', Years ='" + textBoxYears.Text
                + "' WHERE Wid ='" + textBoxWid.Text + "'";

            OdbcCommand command = new OdbcCommand(dbstring);
            using (OdbcConnection connection = new OdbcConnection(Con))
            {
                command.Connection = connection;
                OdbcDataReader reader;
                connection.Open();
                try
                {

                    reader = command.ExecuteReader();
                    MessageBox.Show("The Wine has been updated!");
                    this.wINETableAdapter1.Fill(this.dataSet2.WINE);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }


        private void buttonWDelete_Click(object sender, EventArgs e)
        {

            string dbstring = " delete from Wine where Wid ='" + textBoxWid.Text + "'";

            OdbcCommand command = new OdbcCommand(dbstring);
            using (OdbcConnection connection = new OdbcConnection(Con))
            {
                command.Connection = connection;
                OdbcDataReader reader;
                connection.Open();
                try
                {

                    reader = command.ExecuteReader();
                    MessageBox.Show("The Wine has been deleted!");
                    this.wINETableAdapter1.Fill(this.dataSet2.WINE);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void buttonPAdd_Click(object sender, EventArgs e)
        {
            string dbstring = "insert into Person (Pid,PFName,PSName)values('"
                + textBoxPid.Text + "','"
                + textBoxFirName.Text + "','"
                + textBoxSecName.Text + "')";

            OdbcCommand command = new OdbcCommand(dbstring);
            using (OdbcConnection connection = new OdbcConnection(Con))
            {
                command.Connection = connection;
                OdbcDataReader reader;
                connection.Open();
                try
                {

                    reader = command.ExecuteReader();
                    MessageBox.Show("The Users has been Added!");
                    this.pERSONTableAdapter.Fill(this.dataSet2.PERSON);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void buttonPUpdate_Click(object sender, EventArgs e)
        {
            string dbstring = " update Person set PFName = '" + textBoxFirName.Text 
                + "', PSName ='" + textBoxSecName.Text 
                + "' WHERE Pid ='" + textBoxPid.Text + "'";

            OdbcCommand command = new OdbcCommand(dbstring);
            using (OdbcConnection connection = new OdbcConnection(Con))
            {
                command.Connection = connection;
                OdbcDataReader reader;
                connection.Open();
                try
                {

                    reader = command.ExecuteReader();
                    MessageBox.Show("The Users has been updated!");
                    this.pERSONTableAdapter.Fill(this.dataSet2.PERSON);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void buttonPDelete_Click(object sender, EventArgs e)
        {

            string dbstring = " delete from Person where Pid ='" + textBoxPid.Text + "'";

            OdbcCommand command = new OdbcCommand(dbstring);
            using (OdbcConnection connection = new OdbcConnection(Con))
            {
                command.Connection = connection;
                OdbcDataReader reader;
                connection.Open();
                try
                {

                    reader = command.ExecuteReader();
                    MessageBox.Show("The Users has been deleted!");
                    this.pERSONTableAdapter.Fill(this.dataSet2.PERSON);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        
        


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxBid.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            dateTimeCreate.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateTimeEnd.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBoxState.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxWid.Text = this.dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBoxBid_2.Text = this.dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBoxName.Text = this.dataGridView2.CurrentRow.Cells[2].Value.ToString();
            textBoxType.Text = this.dataGridView2.CurrentRow.Cells[3].Value.ToString();
            textBoxKind.Text = this.dataGridView2.CurrentRow.Cells[4].Value.ToString();
            textBoxPrice.Text = this.dataGridView2.CurrentRow.Cells[5].Value.ToString();
            textBoxYears.Text = this.dataGridView2.CurrentRow.Cells[6].Value.ToString();
        }
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxPid.Text = this.dataGridView3.CurrentRow.Cells[0].Value.ToString();
            textBoxFirName.Text = this.dataGridView3.CurrentRow.Cells[1].Value.ToString();
            textBoxSecName.Text = this.dataGridView3.CurrentRow.Cells[2].Value.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Sreach_tools s = new Sreach_tools();
            s.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        

        

        


    }
}
