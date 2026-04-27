using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
// Elmey Nicolene Stapelberg
// Software Design & Testing with C# 
// SDT621 - Formative Assessment 1 
// Section B - Question 2
namespace HomeAffairsDigitalIdentityProcessorSectionBQ2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Set MaxLength for ID to prevent extra digits
            txtID.MaxLength = 13;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            // Check for missing data
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                lblValidationResult.ForeColor = Color.Red; // Point 3: Color Cue
                lblValidationResult.Text = "Error: Please enter an ID number.";
                return;
            }

            // Create a profile object and perform validation
            CitizenProfile profile = new CitizenProfile(txtName.Text, txtID.Text, cmbCitizenship.Text);
            string result = profile.ValidateID();
            lblValidationResult.Text = result;

            // Point 3: Success vs Error Colors
            if (result.Contains("Valid ID"))
                lblValidationResult.ForeColor = Color.Green;
            else
                lblValidationResult.ForeColor = Color.Red;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Check if name is provided and citizenship is selected
            if (string.IsNullOrWhiteSpace(txtName.Text) || cmbCitizenship.SelectedIndex == -1)
            {
                MessageBox.Show("Error: Ensure Name and Citizenship are provided.", "Missing Information");
                return;
            }

            // Create profile object
            CitizenProfile profile = new CitizenProfile(txtName.Text, txtID.Text, cmbCitizenship.Text);
            string validationStatus = profile.ValidateID();

            // Clear and build the summary in the multi-line text box
            txtSummary.Clear();
            txtSummary.AppendText("==== DIGITAL CITIZEN SUMMARY ====" + Environment.NewLine);
            txtSummary.AppendText($"Name: {profile.FullName}" + Environment.NewLine);
            txtSummary.AppendText($"ID Number: {profile.IDNumber}" + Environment.NewLine);
            txtSummary.AppendText($"Age: {profile.Age}" + Environment.NewLine);
            txtSummary.AppendText($"Citizenship: {profile.CitizenshipStatus}" + Environment.NewLine);
            txtSummary.AppendText($"Validation: {validationStatus}" + Environment.NewLine);
            txtSummary.AppendText($"Processed at: Home Affairs Digital Desk" + Environment.NewLine);
            txtSummary.AppendText($"Timestamp: {DateTime.Now:yyyy/MM/dd HH:mm:ss}");
        }

        // Point 1: Numeric-Only Restriction
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Blocks letters
            }
        }

        // Logo Bounce Animation - Hopping 3 times
        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            int originalY = pictureBox1.Location.Y;
            int hopHeight = 15; // How high it jumps
            int hopCount = 3;   // Number of hops

            for (int i = 0; i < hopCount; i++)
            {
                // Move Up
                pictureBox1.Location = new Point(pictureBox1.Location.X, originalY - hopHeight);
                await Task.Delay(100);

                // Move Down
                pictureBox1.Location = new Point(pictureBox1.Location.X, originalY);
                await Task.Delay(100);
            }
        }

        // Empty methods from your template (Leave as is)
        private void lblTitle_Click(object sender, EventArgs e) { }
        private void txtName_TextChanged(object sender, EventArgs e) { }
        private void txtID_TextChanged(object sender, EventArgs e) { }
        private void cmbCitizenship_SelectedIndexChanged(object sender, EventArgs e) { }
        private void lblValidationResult_Click(object sender, EventArgs e) { }
        private void txtSummary_TextChanged(object sender, EventArgs e) { }
    }
}