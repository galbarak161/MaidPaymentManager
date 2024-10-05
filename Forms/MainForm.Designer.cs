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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblWorkedDaysTitle = new Label();
            lblTotalHoursTitle = new Label();
            lblTotalPaymentTitle = new Label();
            lblValidationMessage = new Label();
            btnMaidSettings = new Button();
            btnStatistics = new Button();
            btnEmployerContributions = new Button();
            dataGridViewWorkDetails = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            lblGreeting = new Label();
            lblCurrentMonthTitle = new Label();
            lblCurrentMonth = new Label();
            lblWorkedDays = new Label();
            lblTotalHours = new Label();
            lblTotalPayment = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWorkDetails).BeginInit();
            SuspendLayout();
            // 
            // lblWorkedDaysTitle
            // 
            lblWorkedDaysTitle.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblWorkedDaysTitle.ForeColor = Color.DarkSlateGray;
            lblWorkedDaysTitle.Location = new Point(26, 94);
            lblWorkedDaysTitle.Name = "lblWorkedDaysTitle";
            lblWorkedDaysTitle.Size = new Size(175, 19);
            lblWorkedDaysTitle.TabIndex = 2;
            lblWorkedDaysTitle.Text = "סה\"כ ימי עבודה:";
            // 
            // lblTotalHoursTitle
            // 
            lblTotalHoursTitle.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblTotalHoursTitle.ForeColor = Color.DarkSlateGray;
            lblTotalHoursTitle.Location = new Point(26, 119);
            lblTotalHoursTitle.Name = "lblTotalHoursTitle";
            lblTotalHoursTitle.Size = new Size(175, 19);
            lblTotalHoursTitle.TabIndex = 3;
            lblTotalHoursTitle.Text = "סה\"כ שעות שדווחו:";
            // 
            // lblTotalPaymentTitle
            // 
            lblTotalPaymentTitle.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblTotalPaymentTitle.ForeColor = Color.DarkSlateGray;
            lblTotalPaymentTitle.Location = new Point(26, 144);
            lblTotalPaymentTitle.Name = "lblTotalPaymentTitle";
            lblTotalPaymentTitle.Size = new Size(175, 19);
            lblTotalPaymentTitle.TabIndex = 4;
            lblTotalPaymentTitle.Text = "סה\"כ לתשלום:";
            // 
            // lblValidationMessage
            // 
            lblValidationMessage.Font = new Font("Arial", 9F, FontStyle.Italic);
            lblValidationMessage.ForeColor = Color.Red;
            lblValidationMessage.Location = new Point(26, 289);
            lblValidationMessage.Name = "lblValidationMessage";
            lblValidationMessage.Size = new Size(448, 21);
            lblValidationMessage.TabIndex = 5;
            lblValidationMessage.Text = "הודעת שגיאה";
            // 
            // btnMaidSettings
            // 
            btnMaidSettings.BackColor = Color.LightSteelBlue;
            btnMaidSettings.FlatAppearance.BorderSize = 0;
            btnMaidSettings.FlatStyle = FlatStyle.Flat;
            btnMaidSettings.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnMaidSettings.Location = new Point(26, 310);
            btnMaidSettings.Margin = new Padding(3, 2, 3, 2);
            btnMaidSettings.Name = "btnMaidSettings";
            btnMaidSettings.Size = new Size(131, 29);
            btnMaidSettings.TabIndex = 3;
            btnMaidSettings.Text = "הגדרות עובד";
            btnMaidSettings.UseVisualStyleBackColor = false;
            btnMaidSettings.Click += btnMaidSettings_Click;
            // 
            // btnStatistics
            // 
            btnStatistics.BackColor = Color.LightSteelBlue;
            btnStatistics.FlatAppearance.BorderSize = 0;
            btnStatistics.FlatStyle = FlatStyle.Flat;
            btnStatistics.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnStatistics.Location = new Point(186, 310);
            btnStatistics.Margin = new Padding(3, 2, 3, 2);
            btnStatistics.Name = "btnStatistics";
            btnStatistics.Size = new Size(131, 29);
            btnStatistics.TabIndex = 4;
            btnStatistics.Text = "סטטיסטיקות";
            btnStatistics.UseVisualStyleBackColor = false;
            btnStatistics.Click += btnStatistics_Click;
            // 
            // btnEmployerContributions
            // 
            btnEmployerContributions.BackColor = Color.LightSteelBlue;
            btnEmployerContributions.FlatAppearance.BorderSize = 0;
            btnEmployerContributions.FlatStyle = FlatStyle.Flat;
            btnEmployerContributions.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnEmployerContributions.Location = new Point(343, 310);
            btnEmployerContributions.Margin = new Padding(3, 2, 3, 2);
            btnEmployerContributions.Name = "btnEmployerContributions";
            btnEmployerContributions.Size = new Size(131, 29);
            btnEmployerContributions.TabIndex = 5;
            btnEmployerContributions.Text = "הגדרות מעסיק";
            btnEmployerContributions.UseVisualStyleBackColor = false;
            btnEmployerContributions.Click += btnEmployerContributions_Click;
            // 
            // dataGridViewWorkDetails
            // 
            dataGridViewWorkDetails.BackgroundColor = Color.WhiteSmoke;
            dataGridViewWorkDetails.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Navy;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewWorkDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewWorkDetails.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridViewWorkDetails.GridColor = Color.LightGray;
            dataGridViewWorkDetails.Location = new Point(26, 175);
            dataGridViewWorkDetails.Margin = new Padding(3, 2, 3, 2);
            dataGridViewWorkDetails.Name = "dataGridViewWorkDetails";
            dataGridViewWorkDetails.RowHeadersVisible = false;
            dataGridViewWorkDetails.Size = new Size(448, 108);
            dataGridViewWorkDetails.TabIndex = 6;
            dataGridViewWorkDetails.CellBeginEdit += dataGridViewWorkDetails_CellBeginEdit;
            dataGridViewWorkDetails.EditingControlShowing += dataGridViewWorkDetails_EditingControlShowing;
            dataGridViewWorkDetails.RowValidating += dataGridViewWorkDetails_RowValidating;
            dataGridViewWorkDetails.UserAddedRow += dataGridViewWorkDetails_UserAddedRow;
            dataGridViewWorkDetails.UserDeletedRow += dataGridViewWorkDetails_UserDeletedRow;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "תאריך";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "מספר שעות";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "הערות";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // lblGreeting
            // 
            lblGreeting.AutoSize = true;
            lblGreeting.Font = new Font("Arial", 16F, FontStyle.Bold);
            lblGreeting.ForeColor = Color.DarkSlateBlue;
            lblGreeting.Location = new Point(107, 20);
            lblGreeting.Name = "lblGreeting";
            lblGreeting.Size = new Size(268, 26);
            lblGreeting.TabIndex = 1;
            lblGreeting.Text = "תוכנת ניהול תשלומים לעוזרת";
            lblGreeting.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurrentMonthTitle
            // 
            lblCurrentMonthTitle.AutoSize = true;
            lblCurrentMonthTitle.Font = new Font("Arial", 12F);
            lblCurrentMonthTitle.ForeColor = Color.DarkCyan;
            lblCurrentMonthTitle.Location = new Point(107, 58);
            lblCurrentMonthTitle.Name = "lblCurrentMonthTitle";
            lblCurrentMonthTitle.Size = new Size(77, 18);
            lblCurrentMonthTitle.TabIndex = 0;
            lblCurrentMonthTitle.Text = "חודש נוכחי:";
            lblCurrentMonthTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurrentMonth
            // 
            lblCurrentMonth.AutoSize = true;
            lblCurrentMonth.Font = new Font("Arial", 12F);
            lblCurrentMonth.ForeColor = Color.DarkCyan;
            lblCurrentMonth.Location = new Point(302, 58);
            lblCurrentMonth.Name = "lblCurrentMonth";
            lblCurrentMonth.Size = new Size(73, 18);
            lblCurrentMonth.TabIndex = 7;
            lblCurrentMonth.Text = "חודש נוכחי";
            lblCurrentMonth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWorkedDays
            // 
            lblWorkedDays.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblWorkedDays.ForeColor = Color.DarkSlateGray;
            lblWorkedDays.Location = new Point(154, 94);
            lblWorkedDays.Name = "lblWorkedDays";
            lblWorkedDays.Size = new Size(175, 19);
            lblWorkedDays.TabIndex = 8;
            lblWorkedDays.Text = "0";
            // 
            // lblTotalHours
            // 
            lblTotalHours.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblTotalHours.ForeColor = Color.DarkSlateGray;
            lblTotalHours.Location = new Point(154, 119);
            lblTotalHours.Name = "lblTotalHours";
            lblTotalHours.Size = new Size(175, 19);
            lblTotalHours.TabIndex = 9;
            lblTotalHours.Text = "0";
            // 
            // lblTotalPayment
            // 
            lblTotalPayment.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblTotalPayment.ForeColor = Color.DarkSlateGray;
            lblTotalPayment.Location = new Point(154, 144);
            lblTotalPayment.Name = "lblTotalPayment";
            lblTotalPayment.Size = new Size(175, 19);
            lblTotalPayment.TabIndex = 10;
            lblTotalPayment.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(495, 351);
            Controls.Add(lblWorkedDays);
            Controls.Add(lblTotalHours);
            Controls.Add(lblTotalPayment);
            Controls.Add(lblValidationMessage);
            Controls.Add(lblCurrentMonth);
            Controls.Add(lblCurrentMonthTitle);
            Controls.Add(lblGreeting);
            Controls.Add(lblWorkedDaysTitle);
            Controls.Add(lblTotalHoursTitle);
            Controls.Add(lblTotalPaymentTitle);
            Controls.Add(btnMaidSettings);
            Controls.Add(btnStatistics);
            Controls.Add(btnEmployerContributions);
            Controls.Add(dataGridViewWorkDetails);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ניהול תשלומים לעוזרת בית";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewWorkDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWorkedDaysTitle;
        private Label lblTotalHoursTitle;
        private Label lblTotalPaymentTitle;
        private Label lblValidationMessage;
        private Button btnMaidSettings;
        private Button btnStatistics;
        private Button btnEmployerContributions;
        private DataGridView dataGridViewWorkDetails;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Label lblGreeting;
        private Label lblCurrentMonthTitle;
        private Label lblCurrentMonth;
        private Label lblWorkedDays;
        private Label lblTotalHours;
        private Label lblTotalPayment;
    }
}
