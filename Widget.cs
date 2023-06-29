namespace Job_Application_Dashboard
{
    public partial class JobDashboard : Form
    {
        public JobDashboard()
        {
            InitializeComponent();
        }
        string email = "";
        string password = "";
        string phoneNumber = "";
        string address1 = "";
        string address2 = "";
        string city = "";
        string zipcode = "";
        string linkedin = "https://www.linkedin.com/in/tahnihresko";
        string github = "https://github.com/tahnijae";



        private void emailButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(email);
        }

        private void passwordButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(password);
        }

        private void phoneButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(phoneNumber);
        }

        private void address1Button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(address1);
        }

        private void address2Button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(address2);
        }

        private void cityButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(city);
        }

        private void zipcodeButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(zipcode);
        }

        private void linkedinButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(linkedin);
        }

        private void githubButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(github);
        }

        private void coverLetterNameButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(GenerateCoverLetterFileName(companyNameTextbox.Text));
        }

        private void coverLetterBodyText_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(GenerateCoverLetterBody(companyNameTextbox.Text, jobNameTextbox.Text, companyLocationTextbox.Text));
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            jobNameTextbox.Clear();
            companyLocationTextbox.Clear();
            companyNameTextbox.Clear();
        }

        private string GenerateCoverLetterFileName(string companyName)
        {
            return $"{companyName.Replace(" ", "_")}_CV";
        }

        private string GenerateCoverLetterBody(string companyName, string jobName, string companyLocation)
        {
            return $"{DateTime.Now.ToString("MMMM d, yyyy")}\r\n\r\n{companyName}\r\n{companyLocation}\r\n\r\nDear Hiring Manager,\r\n\r\n" + 

                $"PASTE YOUR COVER LETTER IN HERE! YOU CAN USE {companyName} AND {jobName} IN HERE TO PERSONALIZE" 
  
                + "\r\n\r\nWith gratitude,\r\nTahni Hresko\r\n";

        }
    }
}