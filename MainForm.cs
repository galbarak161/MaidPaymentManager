using System.Windows.Forms;

namespace MaidPaymentManager
{
    public partial class MainForm : Form
    {
        private const int DateColumnIndex = 0;
        private const int NumberOfHoursColumnIndex = 1;
        private const int CommentsColumnIndex = 2;

        private readonly INewWorkValidator _newWorkValidator; // Injected new work validator

        private DateTimePicker dateTimePicker;

        public MainForm(INewWorkValidator newWorkValidator)
        {
            _newWorkValidator = newWorkValidator; // Assign the injected validator

            InitializeComponent();
            LoadStatistics();
            LoadWorkDetails();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AddDateTimePickerToGrid();
            ConfigureDataGridViewColumns();
        }

        private void LoadStatistics()
        {
            UpdateSummary();
        }

        private void LoadWorkDetails()
        {
            // Always keep an empty row for adding new work
            dataGridViewWorkDetails.Rows.Add();
        }

        private void AddDateTimePickerToGrid()
        {
            dateTimePicker = new DateTimePicker();
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Visible = false;
            dateTimePicker.ValueChanged += new EventHandler(DateTimePicker_ValueChanged);

            dataGridViewWorkDetails.Controls.Add(dateTimePicker);
            dataGridViewWorkDetails.Scroll += (sender, e) => dateTimePicker.Visible = false;
        }

        private void ConfigureDataGridViewColumns()
        {
            foreach (DataGridViewColumn column in dataGridViewWorkDetails.Columns)
            {
                // Set all columns to fill the available space equally
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                // Set the minimum width based on the column header's content
                column.MinimumWidth = TextRenderer.MeasureText(column.HeaderText, dataGridViewWorkDetails.Font).Width + 20;
            }
        }

        private void dataGridViewWorkDetails_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == DateColumnIndex && e.RowIndex >= 0)
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

        private void dataGridViewWorkDetails_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox textBox = e.Control as TextBox;
            if (textBox != null)
            {
                textBox.KeyPress -= NumericTextBox_KeyPress; // Remove handler to avoid multiple subscriptions

                // Check if the current cell is in the "NumberOfHours" column (index 1)
                if (dataGridViewWorkDetails.CurrentCell.ColumnIndex == NumberOfHoursColumnIndex)
                {
                    textBox.KeyPress += NumericTextBox_KeyPress; // Allow only numeric input
                }
            }
        }

        private void dataGridViewWorkDetails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Hide the DateTimePicker if it was visible
            dateTimePicker.Visible = false;

            // Clear previous validation messages
            lblValidationMessage.Text = "";
        }

        private void dataGridViewWorkDetails_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            var row = dataGridViewWorkDetails.Rows[e.RowIndex];
            var dateValue = row.Cells[DateColumnIndex].Value?.ToString();
            var numberOfHoursValue = row.Cells[NumberOfHoursColumnIndex].Value?.ToString();

            var isValidRow = false;

            // Validate the date and number of hours before allowing the row to be added or edited
            if (string.IsNullOrWhiteSpace(dateValue) || !_newWorkValidator.ValidateDate(dateValue))
            {
                lblValidationMessage.Text = "Date must be a valid date in the current month.";
            }
            else if (string.IsNullOrWhiteSpace(numberOfHoursValue) || !_newWorkValidator.ValidateNumberOfHours(numberOfHoursValue))
            {
                lblValidationMessage.Text = "Number of Hours must be a positive number between 1 and 5.";
            }
            else
            {
                isValidRow = true;
                lblValidationMessage.Text = ""; // Clear validation message if validation passes
                UpdateSummary();
            }

            if (!isValidRow)
            {
                e.Cancel = true; // Prevent UI actions until row is valid or deleted
            }
        }

        private void dataGridViewWorkDetails_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            UpdateSummary();
        }

        private void dataGridViewWorkDetails_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            UpdateSummary();
        }

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control keys
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dataGridViewWorkDetails.CurrentCell.Value = dateTimePicker.Value.ToShortDateString();
        }

        private void UpdateSummary()
        {
            int totalDays = 0;
            double totalHours = 0;

            foreach (DataGridViewRow row in dataGridViewWorkDetails.Rows)
            {
                if (row.IsNewRow) continue;

                var dateValue = row.Cells[DateColumnIndex].Value?.ToString();
                var numberOfHoursValue = row.Cells[NumberOfHoursColumnIndex].Value?.ToString();

                if (!string.IsNullOrWhiteSpace(dateValue) && !string.IsNullOrWhiteSpace(numberOfHoursValue))
                {
                    totalDays++;
                    totalHours += double.Parse(numberOfHoursValue);
                }
            }

            lblWorkedDays.Text = $"Worked Days: {totalDays}";
            lblTotalHours.Text = $"Total Hours: {totalHours}";
            lblTotalPayment.Text = $"Total Payment: ${totalHours * 10}";
        }

        #region buttons
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

        #endregion
    }
}
