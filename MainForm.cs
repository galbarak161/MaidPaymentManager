namespace MaidPaymentManager
{
    public partial class MainForm : Form
    {
        private DataGridViewTextBoxColumn dateColumn;
        private DataGridViewTextBoxColumn numberOfHoursColumn;
        private DataGridViewTextBoxColumn commentsColumn;
        private DateTimePicker dateTimePicker;

        public MainForm()
        {
            InitializeComponent();
            LoadStatistics();
            LoadWorkDetails();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AddDateTimePickerToGrid();
        }

        private void LoadStatistics()
        {
            // Mock data for demonstration
            lblWorkedDays.Text = "Worked Days: 5";
            lblTotalHours.Text = "Total Hours: 40";
            lblTotalPayment.Text = "Total Payment: $400";
        }

        private void LoadWorkDetails()
        {
            // Mock data for the current month's work details
            dataGridViewWorkDetails.Rows.Add("2024-10-01", 8, "General cleaning");
            dataGridViewWorkDetails.Rows.Add("2024-10-02", 7, "Deep cleaning");

            // Always keep an empty row for adding new work
            dataGridViewWorkDetails.Rows.Add();
        }

        private void btnMaidSettings_Click(object sender, EventArgs e)
        {
            MaidSettingsForm maidSettingsForm = new MaidSettingsForm();
            maidSettingsForm.ShowDialog();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            StatisticsForm statisticsForm = new StatisticsForm();
            statisticsForm.ShowDialog();
        }

        private void btnEmployerContributions_Click(object sender, EventArgs e)
        {
            EmployerContributionsForm employerContributionsForm = new EmployerContributionsForm();
            employerContributionsForm.ShowDialog();
        }

        private void AddDateTimePickerToGrid()
        {
            dateTimePicker = new DateTimePicker();
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Visible = false;
            dateTimePicker.ValueChanged += new EventHandler(DateTimePicker_ValueChanged);
            dataGridViewWorkDetails.Controls.Add(dateTimePicker);
            dataGridViewWorkDetails.CellBeginEdit += dataGridViewWorkDetails_CellBeginEdit;
            dataGridViewWorkDetails.Scroll += dataGridViewWorkDetails_Scroll;
        }

        private void dataGridViewWorkDetails_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // Check if the column being edited is the Date column (using index 0)
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                Rectangle rect = dataGridViewWorkDetails.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                dateTimePicker.Location = rect.Location;
                dateTimePicker.Size = rect.Size;
                dateTimePicker.Visible = true;

                if (dataGridViewWorkDetails.CurrentCell.Value != null && DateTime.TryParse(dataGridViewWorkDetails.CurrentCell.Value.ToString(), out DateTime dateValue))
                {
                    dateTimePicker.Value = dateValue;
                }
                else
                {
                    dateTimePicker.Value = DateTime.Today;
                }
            }
            else
            {
                dateTimePicker.Visible = false;
            }
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dataGridViewWorkDetails.CurrentCell.Value = dateTimePicker.Value.ToShortDateString();
        }

        private void dataGridViewWorkDetails_Scroll(object sender, ScrollEventArgs e)
        {
            dateTimePicker.Visible = false;
        }


        private void dataGridViewWorkDetails_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox textBox = e.Control as TextBox;
            if (textBox != null)
            {
                textBox.KeyPress -= TextBox_KeyPress; // Remove handler to avoid multiple subscriptions

                // Check if the current cell is in the "NumberOfHours" column (index 1)
                if (dataGridViewWorkDetails.CurrentCell.ColumnIndex == 1)
                {
                    textBox.KeyPress += TextBox_KeyPress; // Allow only numeric input
                }
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control keys
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridViewWorkDetails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dateTimePicker.Visible = false; // Hide the DateTimePicker if it was visible

            lblValidationMessage.Text = "";

            // Validate "NumberOfHours" column (index 1) for positive integer
            if (e.ColumnIndex == 1) // Assuming NumberOfHours is at index 1
            {
                var value = dataGridViewWorkDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (value == null || !int.TryParse(value.ToString(), out int hours) || hours <= 0)
                {
                    lblValidationMessage.Text = "Number of Hours must be a positive integer.";
                }
            }

            // Validate "Comments" column (index 2) for maximum length of 50 characters
            if (e.ColumnIndex == 2) // Assuming Comments is at index 2
            {
                var value = dataGridViewWorkDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (value != null && value.ToString().Length > 50)
                {
                    lblValidationMessage.Text = "Comments cannot exceed 50 characters.";
                }
            }
        }
    }

}
