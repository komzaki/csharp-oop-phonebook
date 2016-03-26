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
    public partial class Form_Main : Form
    {
        Phonebook phonebook;

        public Form_Main()
        {
            InitializeComponent();
            phonebook = new Phonebook();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {



            Contact newcontact = new Contact();

            Address newaddress = new Address();

            newaddress.brgy = textBox_barangay.Text;
            newaddress.city = textBox_city.Text;
            newaddress.country = textBox_country.Text;
            newaddress.number = Convert.ToInt32(textBox_number.Text);
            newaddress.street = textBox_street.Text;
            newaddress.zip = textBox_zip.Text;

            newcontact.address.Add(newaddress);
            newcontact.emailAds.Add(textBox_email.Text);
            newcontact.contactnumbers.Add(textBox_contactnum.Text);
            newcontact.name = textBox_name.Text;

            Contact ExistContact = FindContact(textBox_name.Text);
            if (ExistContact != null)
            {
                phonebook.AddContactInfo(newcontact);
                MessageBox.Show("Added info to existing contact!", "Same name detected");
            }
            else {

                phonebook.AddContact(newcontact);
                MessageBox.Show("Added new contact");
            }



            RefreshPhonebook();
        }

        private void RefreshPhonebook()
        {

            dataGridView1.DataSource = GetResultsTable();
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[0].FillWeight = 200;

        }

        public DataTable GetResultsTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Name".ToString());
            for (int i = 0; i < phonebook.Contacts.Count; i++)
            {
                DataRow dr = table.NewRow();
                dr["Name"] = phonebook.Contacts[i].name;
                table.Rows.Add(dr);
            }


            return table;
        }

        private void button_view_Click(object sender, EventArgs e)
        {
            string SelectedName;
            if (dataGridView1.SelectedCells.Count > 0)
            {
                SelectedName = dataGridView1.SelectedCells[0].Value.ToString();

                Contact F = FindContact(SelectedName);
                if (F != null)
                {
                    Details ViewDetailsForm = new Details(F);
                    ViewDetailsForm.ShowDialog();

                    phonebook.EditContact(ViewDetailsForm.contact);

                }

            }
            RefreshPhonebook();

        }

        private Contact FindContact(string name)
        {
            foreach (Contact C in phonebook.Contacts)
            {
                if (C.name == name)
                {
                    return C;
                }
            }
            return null;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string SelectedName;
            if (dataGridView1.SelectedCells.Count > 0)
            {
                SelectedName = dataGridView1.SelectedCells[0].Value.ToString();

                Contact F = FindContact(SelectedName);
                if (F != null)
                {
                    phonebook.DeleteContact(F);
                }
                MessageBox.Show(SelectedName + " is now Deleted!");
            }
            RefreshPhonebook();
        }
    }
}
