namespace MaidPaymentManager
{
    partial class MainForm
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
            lblWorkedDays = new Label();
            lblTotalHours = new Label();
            lblTotalPayment = new Label();
            lblValidationMessage = new Label();
            btnMaidSettings = new Button();
            btnStatistics = new Button();
            btnEmployerContributions = new Button();
            dataGridViewWorkDetails = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWorkDetails).BeginInit();
            SuspendLayout();
            // 
            // lblWorkedDays
            // 
            lblWorkedDays.Location = new Point(20, 20);
            lblWorkedDays.Name = "lblWorkedDays";
            lblWorkedDays.Size = new Size(200, 23);
            lblWorkedDays.TabIndex = 0;
            lblWorkedDays.Text = "Worked Days:";
            // 
            // lblTotalHours
            // 
            lblTotalHours.Location = new Point(20, 50);
            lblTotalHours.Name = "lblTotalHours";
            lblTotalHours.Size = new Size(200, 23);
            lblTotalHours.TabIndex = 1;
            lblTotalHours.Text = "Total Hours:";
            // 
            // lblTotalPayment
            // 
            lblTotalPayment.Location = new Point(20, 80);
            lblTotalPayment.Name = "lblTotalPayment";
            lblTotalPayment.Size = new Size(200, 23);
            lblTotalPayment.TabIndex = 2;
            lblTotalPayment.Text = "Total Payment:";
            // 
            // lblValidationMessage
            // 
            lblValidationMessage.ForeColor = Color.Red;
            lblValidationMessage.Location = new Point(20, 330);
            lblValidationMessage.Name = "lblValidationMessage";
            lblValidationMessage.Size = new Size(550, 23);
            lblValidationMessage.TabIndex = 3;
            // 
            // btnMaidSettings
            // 
            btnMaidSettings.Location = new Point(20, 356);
            btnMaidSettings.Name = "btnMaidSettings";
            btnMaidSettings.Size = new Size(150, 30);
            btnMaidSettings.TabIndex = 3;
            btnMaidSettings.Text = "Maid Settings";
            btnMaidSettings.Click += btnMaidSettings_Click;
            // 
            // btnStatistics
            // 
            btnStatistics.Location = new Point(200, 356);
            btnStatistics.Name = "btnStatistics";
            btnStatistics.Size = new Size(150, 30);
            btnStatistics.TabIndex = 4;
            btnStatistics.Text = "Statistics";
            btnStatistics.Click += btnStatistics_Click;
            // 
            // btnEmployerContributions
            // 
            btnEmployerContributions.Location = new Point(380, 356);
            btnEmployerContributions.Name = "btnEmployerContributions";
            btnEmployerContributions.Size = new Size(150, 30);
            btnEmployerContributions.TabIndex = 5;
            btnEmployerContributions.Text = "Employer Contributions";
            btnEmployerContributions.Click += btnEmployerContributions_Click;
            // 
            // dataGridViewWorkDetails
            // 
            dataGridViewWorkDetails.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridViewWorkDetails.Location = new Point(20, 120);
            dataGridViewWorkDetails.Name = "dataGridViewWorkDetails";
            dataGridViewWorkDetails.Size = new Size(510, 200);
            dataGridViewWorkDetails.TabIndex = 6;
            dataGridViewWorkDetails.CellBeginEdit += dataGridViewWorkDetails_CellBeginEdit;
            dataGridViewWorkDetails.CellEndEdit += dataGridViewWorkDetails_CellEndEdit;
            dataGridViewWorkDetails.EditingControlShowing += dataGridViewWorkDetails_EditingControlShowing;
            dataGridViewWorkDetails.RowValidating += dataGridViewWorkDetails_RowValidating;
            dataGridViewWorkDetails.UserAddedRow += dataGridViewWorkDetails_UserAddedRow;
            dataGridViewWorkDetails.UserDeletedRow += dataGridViewWorkDetails_UserDeletedRow;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Date";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Number of Hours";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Comments";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 412);
            Controls.Add(lblWorkedDays);
            Controls.Add(lblTotalHours);
            Controls.Add(lblTotalPayment);
            Controls.Add(lblValidationMessage);
            Controls.Add(btnMaidSettings);
            Controls.Add(btnStatistics);
            Controls.Add(btnEmployerContributions);
            Controls.Add(dataGridViewWorkDetails);
            Name = "MainForm";
            Text = "Maid Payment Manager";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewWorkDetails).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblWorkedDays;
        private Label lblTotalHours;
        private Label lblTotalPayment;
        private Label lblValidationMessage;
        private Button btnMaidSettings;
        private Button btnStatistics;
        private Button btnEmployerContributions;
        private DataGridView dataGridViewWorkDetails;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
