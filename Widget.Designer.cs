namespace Job_Application_Dashboard
{
    partial class JobDashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            emailButton = new Button();
            passwordButton = new Button();
            address1Button = new Button();
            address2Button = new Button();
            zipcodeButton = new Button();
            cityButton = new Button();
            githubButton = new Button();
            linkedinButton = new Button();
            coverLetterBodyText = new Button();
            coverLetterNameButton = new Button();
            jobNameTextbox = new TextBox();
            companyLocationTextbox = new TextBox();
            companyNameTextbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            clearButton = new Button();
            groupBox1 = new GroupBox();
            phoneButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // emailButton
            // 
            emailButton.Location = new Point(66, 12);
            emailButton.Name = "emailButton";
            emailButton.Size = new Size(87, 33);
            emailButton.TabIndex = 0;
            emailButton.Text = "Email";
            emailButton.UseVisualStyleBackColor = true;
            emailButton.Click += emailButton_Click;
            // 
            // passwordButton
            // 
            passwordButton.Location = new Point(66, 51);
            passwordButton.Name = "passwordButton";
            passwordButton.Size = new Size(87, 33);
            passwordButton.TabIndex = 1;
            passwordButton.Text = "Password";
            passwordButton.UseVisualStyleBackColor = true;
            passwordButton.Click += passwordButton_Click;
            // 
            // address1Button
            // 
            address1Button.Location = new Point(66, 160);
            address1Button.Name = "address1Button";
            address1Button.Size = new Size(87, 33);
            address1Button.TabIndex = 2;
            address1Button.Text = "Address 1";
            address1Button.UseVisualStyleBackColor = true;
            address1Button.Click += address1Button_Click;
            // 
            // address2Button
            // 
            address2Button.Location = new Point(66, 199);
            address2Button.Name = "address2Button";
            address2Button.Size = new Size(87, 33);
            address2Button.TabIndex = 3;
            address2Button.Text = "Address 2";
            address2Button.UseVisualStyleBackColor = true;
            address2Button.Click += address2Button_Click;
            // 
            // zipcodeButton
            // 
            zipcodeButton.Location = new Point(66, 277);
            zipcodeButton.Name = "zipcodeButton";
            zipcodeButton.Size = new Size(87, 33);
            zipcodeButton.TabIndex = 5;
            zipcodeButton.Text = "Zipcode";
            zipcodeButton.UseVisualStyleBackColor = true;
            zipcodeButton.Click += zipcodeButton_Click;
            // 
            // cityButton
            // 
            cityButton.Location = new Point(66, 238);
            cityButton.Name = "cityButton";
            cityButton.Size = new Size(87, 33);
            cityButton.TabIndex = 4;
            cityButton.Text = "City";
            cityButton.UseVisualStyleBackColor = true;
            cityButton.Click += cityButton_Click;
            // 
            // githubButton
            // 
            githubButton.Location = new Point(66, 391);
            githubButton.Name = "githubButton";
            githubButton.Size = new Size(87, 33);
            githubButton.TabIndex = 7;
            githubButton.Text = "GitHub";
            githubButton.UseVisualStyleBackColor = true;
            githubButton.Click += githubButton_Click;
            // 
            // linkedinButton
            // 
            linkedinButton.Location = new Point(66, 352);
            linkedinButton.Name = "linkedinButton";
            linkedinButton.Size = new Size(87, 33);
            linkedinButton.TabIndex = 6;
            linkedinButton.Text = "LinkedIn";
            linkedinButton.UseVisualStyleBackColor = true;
            linkedinButton.Click += linkedinButton_Click;
            // 
            // coverLetterBodyText
            // 
            coverLetterBodyText.Location = new Point(49, 223);
            coverLetterBodyText.Name = "coverLetterBodyText";
            coverLetterBodyText.Size = new Size(87, 33);
            coverLetterBodyText.TabIndex = 9;
            coverLetterBodyText.Text = "CV Body";
            coverLetterBodyText.UseVisualStyleBackColor = true;
            coverLetterBodyText.Click += coverLetterBodyText_Click;
            // 
            // coverLetterNameButton
            // 
            coverLetterNameButton.Location = new Point(49, 184);
            coverLetterNameButton.Name = "coverLetterNameButton";
            coverLetterNameButton.Size = new Size(87, 33);
            coverLetterNameButton.TabIndex = 8;
            coverLetterNameButton.Text = "CV File Name";
            coverLetterNameButton.UseVisualStyleBackColor = true;
            coverLetterNameButton.Click += coverLetterNameButton_Click;
            // 
            // jobNameTextbox
            // 
            jobNameTextbox.Location = new Point(29, 75);
            jobNameTextbox.Name = "jobNameTextbox";
            jobNameTextbox.Size = new Size(136, 23);
            jobNameTextbox.TabIndex = 13;
            // 
            // companyLocationTextbox
            // 
            companyLocationTextbox.Location = new Point(29, 119);
            companyLocationTextbox.Name = "companyLocationTextbox";
            companyLocationTextbox.Size = new Size(136, 23);
            companyLocationTextbox.TabIndex = 14;
            // 
            // companyNameTextbox
            // 
            companyNameTextbox.Location = new Point(29, 31);
            companyNameTextbox.Name = "companyNameTextbox";
            companyNameTextbox.Size = new Size(136, 23);
            companyNameTextbox.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Location = new Point(46, 13);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 13;
            label1.Text = "Company Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Location = new Point(60, 57);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 14;
            label2.Text = "Job Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Location = new Point(46, 101);
            label3.Name = "label3";
            label3.Size = new Size(111, 15);
            label3.TabIndex = 15;
            label3.Text = "Company Location:";
            // 
            // clearButton
            // 
            clearButton.BackColor = SystemColors.WindowFrame;
            clearButton.Location = new Point(58, 146);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 16;
            clearButton.Text = "clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(clearButton);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(companyNameTextbox);
            groupBox1.Controls.Add(companyLocationTextbox);
            groupBox1.Controls.Add(jobNameTextbox);
            groupBox1.Controls.Add(coverLetterBodyText);
            groupBox1.Controls.Add(coverLetterNameButton);
            groupBox1.Location = new Point(12, 448);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(202, 270);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cover Letter";
            // 
            // phoneButton
            // 
            phoneButton.Location = new Point(66, 121);
            phoneButton.Name = "phoneButton";
            phoneButton.Size = new Size(87, 33);
            phoneButton.TabIndex = 18;
            phoneButton.Text = "Phone";
            phoneButton.UseVisualStyleBackColor = true;
            phoneButton.Click += phoneButton_Click;
            // 
            // JobDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(231, 731);
            Controls.Add(phoneButton);
            Controls.Add(groupBox1);
            Controls.Add(githubButton);
            Controls.Add(linkedinButton);
            Controls.Add(zipcodeButton);
            Controls.Add(cityButton);
            Controls.Add(address2Button);
            Controls.Add(address1Button);
            Controls.Add(passwordButton);
            Controls.Add(emailButton);
            Name = "JobDashboard";
            Text = "Job Dashboard";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button emailButton;
        private Button passwordButton;
        private Button address1Button;
        private Button address2Button;
        private Button zipcodeButton;
        private Button cityButton;
        private Button githubButton;
        private Button linkedinButton;
        private Button coverLetterBodyText;
        private Button coverLetterNameButton;
        private TextBox jobNameTextbox;
        private TextBox companyLocationTextbox;
        private TextBox companyNameTextbox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button clearButton;
        private GroupBox groupBox1;
        private Button phoneButton;
    }
}