using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaidPaymentManager
{
    public partial class MaidSettingsForm : Form
    {
        public MaidSettingsForm()
        {
            InitializeComponent();

            InitializeCopyToClipboardButtons();
        }

        private void MaidSettingsForm_Load(object sender, EventArgs e)
        {
            // Mock personal details
            txtFirstName.Text = "Sarah";
            txtLastName.Text = "Levi";
            txtIdNumber.Text = "123456789";
            txtYearOfBirth.Text = "1990";
            txtDialingCode.Text = "+972";
            txtPhoneNumber.Text = "555123456";

            // Mock work agreement settings
            txtStartEmploymentDate.Text = DateTime.Today.AddYears(-1).ToShortDateString();
            txtHourlyPrice.Text = "10";
            txtTravelRefund.Text = "5";

            // Mock National Insurance settings
            txtNationalInsuranceIdentifier.Text = "10156";
            txtNationalInsuranceDeductionFile.Text = "5456468";

        }

        private void InitializeCopyToClipboardButtons()
        {
            btnCopyFirstName.Click += (s, e) => CopyToClipboard(s, e);
            btnCopyFirstName.Tag = txtFirstName;

            btnCopyLastName.Click += (s, e) => CopyToClipboard(s, e);
            btnCopyLastName.Tag = txtLastName;

            btnCopyIdNumber.Click += (s, e) => CopyToClipboard(s, e);
            btnCopyIdNumber.Tag = txtIdNumber;

            btnCopyDialingCode.Click += (s, e) => CopyToClipboard(s, e);
            btnCopyDialingCode.Tag = txtDialingCode;

            btnCopyPhoneNumber.Click += (s, e) => CopyToClipboard(s, e);
            btnCopyPhoneNumber.Tag = txtPhoneNumber;

            btnCopyNationalInsuranceIdentifier.Click += (s, e) => CopyToClipboard(s, e);
            btnCopyNationalInsuranceIdentifier.Tag = txtNationalInsuranceIdentifier;

            btnCopyNationalInsuranceDeductionFile.Click += (s, e) => CopyToClipboard(s, e);
            btnCopyNationalInsuranceDeductionFile.Tag = txtNationalInsuranceDeductionFile;
        }

        private void CopyToClipboard(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is TextBox textBox && !string.IsNullOrEmpty(textBox.Text))
            {
                Clipboard.SetText(textBox.Text);
            }
            else
            {
                MessageBox.Show("Failed to copy to clipboard", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditWorkAgreement_Click(object sender, EventArgs e)
        {
            txtHourlyPrice.Enabled = true;
            txtHourlyPrice.ReadOnly = false;

            txtTravelRefund.Enabled = true;
            txtTravelRefund.ReadOnly = false;
        }
    }
}
