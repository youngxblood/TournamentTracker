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
        // Initializes the "availableTeamMembers" PersonModel
        // list with all of the objects in the sql db.
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

        public createTeamForm()
        {
            InitializeComponent();

            /*CreateSampleData();*/

            WireUpLists();
        }


        /// <summary>
        /// Temporary method to make sample data.
        /// </summary>
        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Ana", LastName = "Finch" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Jeff", LastName = "King" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Ana", LastName = "Finch" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Jeff", LastName = "King" });
        }

        private void WireUpLists()
        {
            selectTeamMemberDropdown.DataSource = null;

            selectTeamMemberDropdown.DataSource = availableTeamMembers;
            selectTeamMemberDropdown.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;

            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";
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

                p = GlobalConfig.Connection.CreatePerson(p);

                // Adds and updates team member list
                // With newly created team member.
                selectedTeamMembers.Add(p);
                WireUpLists();

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

        // TODO: Need to add more form validation for "Add New Member" form.
        // * Checking for and trimming extra whitespace
        // * Ensuring that the email address is a valid format
        // * Ensuring that the phone number is a valid format (maybe make 3 fields?)
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

        private void addTeamMemberButton_Click(object sender, EventArgs e)
        {
            // "Casting" this to make sure that it is
            // specified as a PersonModel.
            PersonModel p = (PersonModel)selectTeamMemberDropdown.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);
                WireUpLists(); 
            }
        }

        private void deleteSelectedMember_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;


            if (p != null)
            {
                availableTeamMembers.Add(p);
                selectedTeamMembers.Remove(p);
                WireUpLists(); 
            }
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();

            t.TeamName = teamNameValue.Text;
            t.TeamMembers = selectedTeamMembers;

            t = GlobalConfig.Connection.CreateTeam(t);

            // TODO: Empty text boxes if we don't close the form
        }
    }
}
