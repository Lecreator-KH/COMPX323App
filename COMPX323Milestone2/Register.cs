using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPX323Milestone2
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            labelPhone.Visible = false;
            labelOrganisation.Visible = false;
            textBoxPhone.Visible = false;
            textBoxPhone.Enabled = false;
            textBoxOrganisation.Visible = false;
            textBoxOrganisation.Enabled = false;
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBoxRole.SelectedItem.ToString());
            if(comboBoxRole.SelectedItem.ToString() == "Organizer")
            {
                labelPhone.Visible = true;
                labelOrganisation.Visible = true;
                textBoxPhone.Visible = true;
                textBoxPhone.Enabled = true;
                textBoxOrganisation.Visible = true;
                textBoxOrganisation.Enabled = true;
            }
            else
            {
                labelPhone.Visible = false;
                labelOrganisation.Visible = false;
                textBoxPhone.Visible = false;
                textBoxPhone.Enabled = false;
                textBoxOrganisation.Visible = false;
                textBoxOrganisation.Enabled = false;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string username, password, email, firstname, lastname, organisation, phone;

            try
            {
                // If role is not chosen, display message
                if (comboBoxRole.SelectedItem == null)
                {
                    MessageBox.Show("Choose your role.");               
                }
                else
                {
                    // Get data from textboxes
                    username = textBoxUsername.Text;
                    password = textBoxPassword.Text;
                    email = textBoxEmail.Text;
                    firstname = textBoxFirstname.Text;
                    lastname = textBoxLastname.Text;

                    // If register for an organiser, get organisation and phone data
                    if (comboBoxRole.SelectedItem.ToString() == "Organizer")
                    {
                        organisation = textBoxOrganisation.Text;
                        phone = textBoxPhone.Text;

                        //Debug. display datat for organisation
                        MessageBox.Show("username: " + username + "\n" +
                                        "password: " + password + "\n" +
                                        "email: " + email + "\n" +
                                        "firstname: " + firstname + "\n" +
                                        "lastname: " + lastname + "\n" +
                                         "organisation: " + organisation + "\n" +
                                        "phone: " + phone + "\n");
                        Oracle.RegisterPersonOracle(username, password, email, firstname, lastname);
                        Oracle.RegisterOrganiserOracle(username, organisation, phone);
                    }
                    else
                    {
                        //Debug. display datat for others
                        MessageBox.Show("username: " + username + "\n" +
                                        "password: " + password + "\n" +
                                        "email: " + email + "\n" +
                                        "firstname: " + firstname + "\n" +
                                        "lastname: " + lastname + "\n");
                        Oracle.RegisterPersonOracle(username, password, email, firstname, lastname);
                        Oracle.RegisterPersonMongoDB(username, password, email, firstname, lastname);
                    }

                }
                
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
