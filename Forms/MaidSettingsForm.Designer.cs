
namespace MaidPaymentManager
{
    partial class MaidSettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBack = new Button();
            personalDetailsPanel = new Panel();
            lblPhoneNumber = new Label();
            lblDialingCode = new Label();
            lblYearOfBirth = new Label();
            lblIdNumber = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            btnCopyPhoneNumber = new Button();
            btnCopyDialingCode = new Button();
            btnCopyYearOfBirth = new Button();
            btnCopyIdNumber = new Button();
            btnCopyLastName = new Button();
            btnCopyFirstName = new Button();
            txtPhoneNumber = new TextBox();
            txtDialingCode = new TextBox();
            txtYearOfBirth = new TextBox();
            txtIdNumber = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            workAgreementPanel = new Panel();
            lblStartEmploymentDate = new Label();
            lblTravelRefund = new Label();
            btnEditWorkAgreement = new Button();
            lblHourlyPrice = new Label();
            txtTravelRefund = new TextBox();
            txtHourlyPrice = new TextBox();
            txtStartEmploymentDate = new TextBox();
            personalDetailsPanel.SuspendLayout();
            workAgreementPanel.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.LightSteelBlue;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnBack.Location = new Point(10, 10);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 30);
            btnBack.TabIndex = 0;
            btnBack.Text = "חזרה";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // personalDetailsPanel
            // 
            personalDetailsPanel.BorderStyle = BorderStyle.FixedSingle;
            personalDetailsPanel.Controls.Add(lblPhoneNumber);
            personalDetailsPanel.Controls.Add(lblDialingCode);
            personalDetailsPanel.Controls.Add(lblYearOfBirth);
            personalDetailsPanel.Controls.Add(lblIdNumber);
            personalDetailsPanel.Controls.Add(lblLastName);
            personalDetailsPanel.Controls.Add(lblFirstName);
            personalDetailsPanel.Controls.Add(btnCopyPhoneNumber);
            personalDetailsPanel.Controls.Add(btnCopyDialingCode);
            personalDetailsPanel.Controls.Add(btnCopyYearOfBirth);
            personalDetailsPanel.Controls.Add(btnCopyIdNumber);
            personalDetailsPanel.Controls.Add(btnCopyLastName);
            personalDetailsPanel.Controls.Add(btnCopyFirstName);
            personalDetailsPanel.Controls.Add(txtPhoneNumber);
            personalDetailsPanel.Controls.Add(txtDialingCode);
            personalDetailsPanel.Controls.Add(txtYearOfBirth);
            personalDetailsPanel.Controls.Add(txtIdNumber);
            personalDetailsPanel.Controls.Add(txtLastName);
            personalDetailsPanel.Controls.Add(txtFirstName);
            personalDetailsPanel.Location = new Point(12, 51);
            personalDetailsPanel.Name = "personalDetailsPanel";
            personalDetailsPanel.Size = new Size(272, 316);
            personalDetailsPanel.TabIndex = 1;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblPhoneNumber.ForeColor = Color.DarkSlateGray;
            lblPhoneNumber.Location = new Point(177, 270);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(91, 19);
            lblPhoneNumber.TabIndex = 17;
            lblPhoneNumber.Text = "מספר טלפון";
            // 
            // lblDialingCode
            // 
            lblDialingCode.AutoSize = true;
            lblDialingCode.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblDialingCode.ForeColor = Color.DarkSlateGray;
            lblDialingCode.Location = new Point(210, 220);
            lblDialingCode.Name = "lblDialingCode";
            lblDialingCode.Size = new Size(58, 19);
            lblDialingCode.TabIndex = 16;
            lblDialingCode.Text = "קידומת";
            // 
            // lblYearOfBirth
            // 
            lblYearOfBirth.AutoSize = true;
            lblYearOfBirth.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblYearOfBirth.ForeColor = Color.DarkSlateGray;
            lblYearOfBirth.Location = new Point(193, 170);
            lblYearOfBirth.Name = "lblYearOfBirth";
            lblYearOfBirth.Size = new Size(75, 19);
            lblYearOfBirth.TabIndex = 15;
            lblYearOfBirth.Text = "שנת לידה";
            // 
            // lblIdNumber
            // 
            lblIdNumber.AutoSize = true;
            lblIdNumber.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblIdNumber.ForeColor = Color.DarkSlateGray;
            lblIdNumber.Location = new Point(178, 120);
            lblIdNumber.Name = "lblIdNumber";
            lblIdNumber.Size = new Size(90, 19);
            lblIdNumber.TabIndex = 14;
            lblIdNumber.Text = "תעודת זהות";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblLastName.ForeColor = Color.DarkSlateGray;
            lblLastName.Location = new Point(179, 70);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(89, 19);
            lblLastName.TabIndex = 13;
            lblLastName.Text = "שם משפחה";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblFirstName.ForeColor = Color.DarkSlateGray;
            lblFirstName.Location = new Point(198, 20);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(70, 19);
            lblFirstName.TabIndex = 12;
            lblFirstName.Text = "שם פרטי";
            // 
            // btnCopyPhoneNumber
            // 
            btnCopyPhoneNumber.BackColor = Color.LightSteelBlue;
            btnCopyPhoneNumber.FlatAppearance.BorderSize = 0;
            btnCopyPhoneNumber.FlatStyle = FlatStyle.Flat;
            btnCopyPhoneNumber.Font = new Font("Arial", 7F, FontStyle.Bold);
            btnCopyPhoneNumber.Location = new Point(12, 270);
            btnCopyPhoneNumber.Name = "btnCopyPhoneNumber";
            btnCopyPhoneNumber.Size = new Size(50, 27);
            btnCopyPhoneNumber.TabIndex = 6;
            btnCopyPhoneNumber.Text = "העתק";
            btnCopyPhoneNumber.UseVisualStyleBackColor = false;
            // 
            // btnCopyDialingCode
            // 
            btnCopyDialingCode.BackColor = Color.LightSteelBlue;
            btnCopyDialingCode.FlatAppearance.BorderSize = 0;
            btnCopyDialingCode.FlatStyle = FlatStyle.Flat;
            btnCopyDialingCode.Font = new Font("Arial", 7F, FontStyle.Bold);
            btnCopyDialingCode.Location = new Point(12, 220);
            btnCopyDialingCode.Name = "btnCopyDialingCode";
            btnCopyDialingCode.Size = new Size(50, 27);
            btnCopyDialingCode.TabIndex = 5;
            btnCopyDialingCode.Text = "העתק";
            btnCopyDialingCode.UseVisualStyleBackColor = false;
            // 
            // btnCopyYearOfBirth
            // 
            btnCopyYearOfBirth.BackColor = Color.LightSteelBlue;
            btnCopyYearOfBirth.FlatAppearance.BorderSize = 0;
            btnCopyYearOfBirth.FlatStyle = FlatStyle.Flat;
            btnCopyYearOfBirth.Font = new Font("Arial", 7F, FontStyle.Bold);
            btnCopyYearOfBirth.Location = new Point(12, 170);
            btnCopyYearOfBirth.Name = "btnCopyYearOfBirth";
            btnCopyYearOfBirth.Size = new Size(50, 27);
            btnCopyYearOfBirth.TabIndex = 4;
            btnCopyYearOfBirth.Text = "העתק";
            btnCopyYearOfBirth.UseVisualStyleBackColor = false;
            // 
            // btnCopyIdNumber
            // 
            btnCopyIdNumber.BackColor = Color.LightSteelBlue;
            btnCopyIdNumber.FlatAppearance.BorderSize = 0;
            btnCopyIdNumber.FlatStyle = FlatStyle.Flat;
            btnCopyIdNumber.Font = new Font("Arial", 7F, FontStyle.Bold);
            btnCopyIdNumber.Location = new Point(12, 120);
            btnCopyIdNumber.Name = "btnCopyIdNumber";
            btnCopyIdNumber.Size = new Size(50, 27);
            btnCopyIdNumber.TabIndex = 3;
            btnCopyIdNumber.Text = "העתק";
            btnCopyIdNumber.UseVisualStyleBackColor = false;
            // 
            // btnCopyLastName
            // 
            btnCopyLastName.BackColor = Color.LightSteelBlue;
            btnCopyLastName.FlatAppearance.BorderSize = 0;
            btnCopyLastName.FlatStyle = FlatStyle.Flat;
            btnCopyLastName.Font = new Font("Arial", 7F, FontStyle.Bold);
            btnCopyLastName.Location = new Point(12, 70);
            btnCopyLastName.Name = "btnCopyLastName";
            btnCopyLastName.Size = new Size(50, 27);
            btnCopyLastName.TabIndex = 2;
            btnCopyLastName.Text = "העתק";
            btnCopyLastName.UseVisualStyleBackColor = false;
            // 
            // btnCopyFirstName
            // 
            btnCopyFirstName.BackColor = Color.LightSteelBlue;
            btnCopyFirstName.FlatAppearance.BorderSize = 0;
            btnCopyFirstName.FlatStyle = FlatStyle.Flat;
            btnCopyFirstName.Font = new Font("Arial", 7F, FontStyle.Bold);
            btnCopyFirstName.Location = new Point(12, 20);
            btnCopyFirstName.Name = "btnCopyFirstName";
            btnCopyFirstName.Size = new Size(50, 27);
            btnCopyFirstName.TabIndex = 1;
            btnCopyFirstName.Text = "העתק";
            btnCopyFirstName.UseVisualStyleBackColor = false;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Enabled = false;
            txtPhoneNumber.Location = new Point(71, 270);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.ReadOnly = true;
            txtPhoneNumber.Size = new Size(100, 27);
            txtPhoneNumber.TabIndex = 13;
            // 
            // txtDialingCode
            // 
            txtDialingCode.Enabled = false;
            txtDialingCode.Location = new Point(71, 221);
            txtDialingCode.Name = "txtDialingCode";
            txtDialingCode.ReadOnly = true;
            txtDialingCode.Size = new Size(100, 27);
            txtDialingCode.TabIndex = 12;
            // 
            // txtYearOfBirth
            // 
            txtYearOfBirth.Enabled = false;
            txtYearOfBirth.Location = new Point(71, 170);
            txtYearOfBirth.Name = "txtYearOfBirth";
            txtYearOfBirth.ReadOnly = true;
            txtYearOfBirth.Size = new Size(100, 27);
            txtYearOfBirth.TabIndex = 11;
            // 
            // txtIdNumber
            // 
            txtIdNumber.Enabled = false;
            txtIdNumber.Location = new Point(71, 120);
            txtIdNumber.Name = "txtIdNumber";
            txtIdNumber.ReadOnly = true;
            txtIdNumber.Size = new Size(100, 27);
            txtIdNumber.TabIndex = 10;
            // 
            // txtLastName
            // 
            txtLastName.Enabled = false;
            txtLastName.Location = new Point(71, 70);
            txtLastName.Name = "txtLastName";
            txtLastName.ReadOnly = true;
            txtLastName.Size = new Size(100, 27);
            txtLastName.TabIndex = 9;
            // 
            // txtFirstName
            // 
            txtFirstName.Enabled = false;
            txtFirstName.Location = new Point(71, 20);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.ReadOnly = true;
            txtFirstName.Size = new Size(100, 27);
            txtFirstName.TabIndex = 8;
            // 
            // workAgreementPanel
            // 
            workAgreementPanel.BorderStyle = BorderStyle.FixedSingle;
            workAgreementPanel.Controls.Add(lblStartEmploymentDate);
            workAgreementPanel.Controls.Add(lblTravelRefund);
            workAgreementPanel.Controls.Add(btnEditWorkAgreement);
            workAgreementPanel.Controls.Add(lblHourlyPrice);
            workAgreementPanel.Controls.Add(txtTravelRefund);
            workAgreementPanel.Controls.Add(txtHourlyPrice);
            workAgreementPanel.Controls.Add(txtStartEmploymentDate);
            workAgreementPanel.Location = new Point(313, 51);
            workAgreementPanel.Name = "workAgreementPanel";
            workAgreementPanel.Size = new Size(236, 223);
            workAgreementPanel.TabIndex = 2;
            // 
            // lblStartEmploymentDate
            // 
            lblStartEmploymentDate.AutoSize = true;
            lblStartEmploymentDate.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblStartEmploymentDate.ForeColor = Color.DarkSlateGray;
            lblStartEmploymentDate.Location = new Point(124, 20);
            lblStartEmploymentDate.Name = "lblStartEmploymentDate";
            lblStartEmploymentDate.Size = new Size(107, 19);
            lblStartEmploymentDate.TabIndex = 20;
            lblStartEmploymentDate.Text = "תחילת העסקה";
            // 
            // lblTravelRefund
            // 
            lblTravelRefund.AutoSize = true;
            lblTravelRefund.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblTravelRefund.ForeColor = Color.DarkSlateGray;
            lblTravelRefund.Location = new Point(133, 120);
            lblTravelRefund.Name = "lblTravelRefund";
            lblTravelRefund.Size = new Size(99, 19);
            lblTravelRefund.TabIndex = 19;
            lblTravelRefund.Text = "החזרי נסיעות";
            // 
            // btnEditWorkAgreement
            // 
            btnEditWorkAgreement.BackColor = Color.LightSteelBlue;
            btnEditWorkAgreement.FlatAppearance.BorderSize = 0;
            btnEditWorkAgreement.FlatStyle = FlatStyle.Flat;
            btnEditWorkAgreement.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnEditWorkAgreement.Location = new Point(76, 167);
            btnEditWorkAgreement.Name = "btnEditWorkAgreement";
            btnEditWorkAgreement.Size = new Size(80, 33);
            btnEditWorkAgreement.TabIndex = 7;
            btnEditWorkAgreement.Text = "עריכה";
            btnEditWorkAgreement.UseVisualStyleBackColor = false;
            btnEditWorkAgreement.Click += btnEditWorkAgreement_Click;
            // 
            // lblHourlyPrice
            // 
            lblHourlyPrice.AutoSize = true;
            lblHourlyPrice.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblHourlyPrice.ForeColor = Color.DarkSlateGray;
            lblHourlyPrice.Location = new Point(153, 70);
            lblHourlyPrice.Name = "lblHourlyPrice";
            lblHourlyPrice.Size = new Size(79, 19);
            lblHourlyPrice.TabIndex = 18;
            lblHourlyPrice.Text = "שכר שעתי";
            // 
            // txtTravelRefund
            // 
            txtTravelRefund.Enabled = false;
            txtTravelRefund.Location = new Point(19, 120);
            txtTravelRefund.Name = "txtTravelRefund";
            txtTravelRefund.ReadOnly = true;
            txtTravelRefund.Size = new Size(100, 27);
            txtTravelRefund.TabIndex = 16;
            // 
            // txtHourlyPrice
            // 
            txtHourlyPrice.Enabled = false;
            txtHourlyPrice.Location = new Point(19, 70);
            txtHourlyPrice.Name = "txtHourlyPrice";
            txtHourlyPrice.ReadOnly = true;
            txtHourlyPrice.Size = new Size(100, 27);
            txtHourlyPrice.TabIndex = 15;
            // 
            // txtStartEmploymentDate
            // 
            txtStartEmploymentDate.Enabled = false;
            txtStartEmploymentDate.Location = new Point(19, 20);
            txtStartEmploymentDate.Name = "txtStartEmploymentDate";
            txtStartEmploymentDate.ReadOnly = true;
            txtStartEmploymentDate.Size = new Size(100, 27);
            txtStartEmploymentDate.TabIndex = 14;
            // 
            // MaidSettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 468);
            Controls.Add(workAgreementPanel);
            Controls.Add(personalDetailsPanel);
            Controls.Add(btnBack);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MaidSettingsForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "ניהול תשלומים לעוזרת בית";
            Load += MaidSettingsForm_Load;
            personalDetailsPanel.ResumeLayout(false);
            personalDetailsPanel.PerformLayout();
            workAgreementPanel.ResumeLayout(false);
            workAgreementPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
        private Panel personalDetailsPanel;
        private Button btnCopyPhoneNumber;
        private Button btnCopyDialingCode;
        private Button btnCopyYearOfBirth;
        private Button btnCopyIdNumber;
        private Button btnCopyLastName;
        private Button btnCopyFirstName;
        private TextBox txtPhoneNumber;
        private TextBox txtDialingCode;
        private TextBox txtYearOfBirth;
        private TextBox txtIdNumber;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Panel workAgreementPanel;
        private TextBox txtTravelRefund;
        private TextBox txtHourlyPrice;
        private TextBox txtStartEmploymentDate;
        private Button btnEditWorkAgreement;
        private Label lblPhoneNumber;
        private Label lblDialingCode;
        private Label lblYearOfBirth;
        private Label lblIdNumber;
        private Label lblLastName;
        private Label lblFirstName;
        private Label lblStartEmploymentDate;
        private Label lblTravelRefund;
        private Label lblHourlyPrice;
    }
}