using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook
{
    public partial class Details : Form
    {
        Contact contact;
        public Details(Contact x)
        {
            InitializeComponent();

            contact = x;
        }

        private void Details_Load(object sender, EventArgs e)
        {
            textBox_name.Text = contact.name;


            RefreshPhonebook();
        }

        private void RefreshPhonebook()
        {



            dataGridView_email.DataSource = GetResultsTableEmail();
            dataGridView_number.DataSource = GetResultsTableNumber();
            dataGridView_address.DataSource = GetResultsTableAddress();

            //dataGridView_email.Columns[0].Width = 200;
            //dataGridView_email.Columns[0].FillWeight = 200;
        }

        public DataTable GetResultsTableAddress()
        {
            DataTable table = new DataTable();
            table.Columns.Add("barangay".ToString());
            table.Columns.Add("city".ToString());
            table.Columns.Add("country".ToString());
            table.Columns.Add("number".ToString());
            table.Columns.Add("street".ToString());
            table.Columns.Add("zip".ToString());
            for (int i = 0; i < contact.address.Count; i++)
            {
                DataRow dr = table.NewRow();
                dr["barangay"] = contact.address[i].brgy;
                dr["city"] = contact.address[i].city;
                dr["country"] = contact.address[i].country;
                dr["number"] = contact.address[i].number;
                dr["street"] = contact.address[i].street;
                dr["zip"] = contact.address[i].zip;

                table.Rows.Add(dr);
            }


            return table;
        }

        public DataTable GetResultsTableNumber()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Name".ToString());
            for (int i = 0; i < contact.contactnumbers.Count; i++)
            {
                DataRow dr = table.NewRow();
                dr["Name"] = contact.contactnumbers[i];
                table.Rows.Add(dr);
            }


            return table;
        }
        public DataTable GetResultsTableEmail()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Email".ToString());
            for (int i = 0; i < contact.emailAds.Count; i++)
            {
                DataRow dr = table.NewRow();
                dr["Email"] = contact.emailAds[i];
                table.Rows.Add(dr);
            }


            return table;
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
