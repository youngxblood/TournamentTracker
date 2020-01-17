using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class createTeamForm : Form
    {
        public createTeamForm()
        {
            InitializeComponent();
        }

        // This event creates a team member based on the text inputs above
        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();
                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAdress = emailValue.Text;
                p.PhoneNumber = phoneNumberValue.Text;

                GlobalConfig.Connection.CreatePerson(p);

                // Defaults text values after information is captured
                firstNameValue.Text = "";
                lastNameValue.Text = "";
                phoneNumberValue.Text = "";
                emailValue.Text = "";
                

            } else
            {
                MessageBox.Show("Please recheck your values and try again!");
            }
        }

        // Look at making a function for this? See "FormValidationHelpers.cs"
        private bool ValidateForm()
        {
            bool output = true;

            if (firstNameValue.Text.Length == 0)
            {
                output = false;
            }

            if (lastNameValue.Text.Length == 0)
            {
                output = false;
            }

            // Need to check if this is a valid email adress as well
            if (emailValue.Text.Length == 0)
            {
                output = false;
            }

            if (phoneNumberValue.Text.Length == 0)
            {
                output = false;
            }
            int phoneNumberNumericValue = 0;
            bool phoneNumberIsNumeric = int.TryParse(phoneNumberValue.Text, out phoneNumberNumericValue);

            if (!phoneNumberIsNumeric)
            {
                output = false;
            }

            return output;
        }
    }
}
