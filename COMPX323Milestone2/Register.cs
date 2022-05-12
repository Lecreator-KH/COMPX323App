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
    }
}
