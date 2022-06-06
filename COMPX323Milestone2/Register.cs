using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Oracle.ManagedDataAccess.Client;

namespace COMPX323Milestone2
{
    public partial class Register : Form
    {
        public OracleConnection conn;

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
            Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", RegexOptions.CultureInvariant | RegexOptions.Singleline);
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

                    if(username.Length < 5 || username.Length > 30)
                    {
                        MessageBox.Show("Username has to between 5 to 30 charcters long");
                        return;
                    }
                    if (password.Length < 5 || password.Length > 30)
                    {
                        MessageBox.Show("Password has to between 5 to 30 charcters long");
                        return;
                    }
                    if (email.Length > 50)
                    {
                        MessageBox.Show("Email max length is 50 charcters long");
                        return;
                    }
                    bool emailCheck = regex.IsMatch(email);
                    if(emailCheck == false)
                    {
                        MessageBox.Show("Invalid email format. EG abc@gmail.com");
                        return;
                    }
                    if (firstname.Length <= 0 || firstname.Length > 30)
                    {
                        MessageBox.Show("Firstname has to between 1 to 30 charcters long");
                        return;
                    }
                    if (lastname.Length <= 0 || lastname.Length > 30)
                    {
                        MessageBox.Show("Lastname has to between 1 to 30 charcters long");
                        return;
                    }

                    // If register for an organiser, get organisation and phone data
                    if (comboBoxRole.SelectedItem.ToString() == "Organizer")
                    {
                        organisation = textBoxOrganisation.Text;
                        phone = textBoxPhone.Text;

                        if (organisation.Length <= 0 || organisation.Length > 50)
                        {
                            MessageBox.Show("Organisation has to between 1 to 50 charcters long");
                            return;
                        }
                        if(phone.Length >= 11 || phone.Length < 7)
                        {
                            MessageBox.Show("Phone length too big");
                            return;
                        }
                        if (int.TryParse(phone, out int phoneInt) == false)
                        {
                            MessageBox.Show("Please enter number only for phone");
                            return;
                        }

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
                        Oracle.RegisterOrganiserMongoDB(username, email, password, firstname, lastname, organisation, phone);
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
