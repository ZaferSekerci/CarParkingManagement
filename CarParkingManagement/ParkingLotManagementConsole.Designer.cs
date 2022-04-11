
namespace CarParkingManagement
{
    partial class ParkingLotManagementConsole
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
            this.gbEntrySection = new System.Windows.Forms.GroupBox();
            this.txtEmptyParkSlot = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSaveCustomer = new System.Windows.Forms.Button();
            this.cmbCarType = new System.Windows.Forms.ComboBox();
            this.mtxtCarPlate = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpCheckInTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPaymentSection = new System.Windows.Forms.GroupBox();
            this.btnCalculateParkingPrice = new System.Windows.Forms.Button();
            this.dtpCheckOutTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvListOfInsideCars = new System.Windows.Forms.DataGridView();
            this.CarPlate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckInTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.gbEntrySection.SuspendLayout();
            this.gbPaymentSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOfInsideCars)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEntrySection
            // 
            this.gbEntrySection.Controls.Add(this.txtEmptyParkSlot);
            this.gbEntrySection.Controls.Add(this.label5);
            this.gbEntrySection.Controls.Add(this.btnSaveCustomer);
            this.gbEntrySection.Controls.Add(this.cmbCarType);
            this.gbEntrySection.Controls.Add(this.mtxtCarPlate);
            this.gbEntrySection.Controls.Add(this.label3);
            this.gbEntrySection.Controls.Add(this.dtpCheckInTime);
            this.gbEntrySection.Controls.Add(this.label2);
            this.gbEntrySection.Controls.Add(this.label1);
            this.gbEntrySection.Location = new System.Drawing.Point(12, 12);
            this.gbEntrySection.Name = "gbEntrySection";
            this.gbEntrySection.Size = new System.Drawing.Size(232, 190);
            this.gbEntrySection.TabIndex = 0;
            this.gbEntrySection.TabStop = false;
            this.gbEntrySection.Text = "Entry Section";
            // 
            // txtEmptyParkSlot
            // 
            this.txtEmptyParkSlot.Enabled = false;
            this.txtEmptyParkSlot.Location = new System.Drawing.Point(191, 30);
            this.txtEmptyParkSlot.Name = "txtEmptyParkSlot";
            this.txtEmptyParkSlot.Size = new System.Drawing.Size(32, 23);
            this.txtEmptyParkSlot.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Number Of Empty Parking Slot : ";
            // 
            // btnSaveCustomer
            // 
            this.btnSaveCustomer.Location = new System.Drawing.Point(6, 146);
            this.btnSaveCustomer.Name = "btnSaveCustomer";
            this.btnSaveCustomer.Size = new System.Drawing.Size(217, 23);
            this.btnSaveCustomer.TabIndex = 6;
            this.btnSaveCustomer.Text = "Save Customer";
            this.btnSaveCustomer.UseVisualStyleBackColor = true;
            this.btnSaveCustomer.Click += new System.EventHandler(this.btnSaveCustomer_Click);
            // 
            // cmbCarType
            // 
            this.cmbCarType.Location = new System.Drawing.Point(101, 117);
            this.cmbCarType.Name = "cmbCarType";
            this.cmbCarType.Size = new System.Drawing.Size(122, 23);
            this.cmbCarType.TabIndex = 5;
            // 
            // mtxtCarPlate
            // 
            this.mtxtCarPlate.Location = new System.Drawing.Point(101, 88);
            this.mtxtCarPlate.Mask = "00 >LLL 0000";
            this.mtxtCarPlate.Name = "mtxtCarPlate";
            this.mtxtCarPlate.Size = new System.Drawing.Size(122, 23);
            this.mtxtCarPlate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Car Type : ";
            // 
            // dtpCheckInTime
            // 
            this.dtpCheckInTime.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpCheckInTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckInTime.Location = new System.Drawing.Point(101, 59);
            this.dtpCheckInTime.Name = "dtpCheckInTime";
            this.dtpCheckInTime.Size = new System.Drawing.Size(122, 23);
            this.dtpCheckInTime.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Car Plate : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check-in Time : ";
            // 
            // gbPaymentSection
            // 
            this.gbPaymentSection.Controls.Add(this.btnCalculateParkingPrice);
            this.gbPaymentSection.Controls.Add(this.dtpCheckOutTime);
            this.gbPaymentSection.Controls.Add(this.label4);
            this.gbPaymentSection.Controls.Add(this.dgvListOfInsideCars);
            this.gbPaymentSection.Location = new System.Drawing.Point(250, 12);
            this.gbPaymentSection.Name = "gbPaymentSection";
            this.gbPaymentSection.Size = new System.Drawing.Size(379, 242);
            this.gbPaymentSection.TabIndex = 1;
            this.gbPaymentSection.TabStop = false;
            this.gbPaymentSection.Text = "Payment Section";
            // 
            // btnCalculateParkingPrice
            // 
            this.btnCalculateParkingPrice.Location = new System.Drawing.Point(6, 207);
            this.btnCalculateParkingPrice.Name = "btnCalculateParkingPrice";
            this.btnCalculateParkingPrice.Size = new System.Drawing.Size(217, 23);
            this.btnCalculateParkingPrice.TabIndex = 7;
            this.btnCalculateParkingPrice.Text = "Calculate Parking Price";
            this.btnCalculateParkingPrice.UseVisualStyleBackColor = true;
            this.btnCalculateParkingPrice.Click += new System.EventHandler(this.btnCalculateParkingPrice_Click);
            // 
            // dtpCheckOutTime
            // 
            this.dtpCheckOutTime.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpCheckOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckOutTime.Location = new System.Drawing.Point(101, 180);
            this.dtpCheckOutTime.Name = "dtpCheckOutTime";
            this.dtpCheckOutTime.Size = new System.Drawing.Size(122, 23);
            this.dtpCheckOutTime.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Check-out Time :";
            // 
            // dgvListOfInsideCars
            // 
            this.dgvListOfInsideCars.AllowUserToAddRows = false;
            this.dgvListOfInsideCars.AllowUserToDeleteRows = false;
            this.dgvListOfInsideCars.AllowUserToResizeRows = false;
            this.dgvListOfInsideCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvListOfInsideCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListOfInsideCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CarPlate,
            this.CheckInTime,
            this.CarType});
            this.dgvListOfInsideCars.Location = new System.Drawing.Point(6, 20);
            this.dgvListOfInsideCars.MultiSelect = false;
            this.dgvListOfInsideCars.Name = "dgvListOfInsideCars";
            this.dgvListOfInsideCars.ReadOnly = true;
            this.dgvListOfInsideCars.RowHeadersWidth = 80;
            this.dgvListOfInsideCars.RowTemplate.Height = 25;
            this.dgvListOfInsideCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListOfInsideCars.Size = new System.Drawing.Size(367, 149);
            this.dgvListOfInsideCars.TabIndex = 2;
            this.dgvListOfInsideCars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListOfInsideCars_CellClick);
            // 
            // CarPlate
            // 
            this.CarPlate.HeaderText = "Car Plate";
            this.CarPlate.Name = "CarPlate";
            this.CarPlate.ReadOnly = true;
            this.CarPlate.Width = 79;
            // 
            // CheckInTime
            // 
            this.CheckInTime.HeaderText = "Check-in Time";
            this.CheckInTime.Name = "CheckInTime";
            this.CheckInTime.ReadOnly = true;
            this.CheckInTime.Width = 109;
            // 
            // CarType
            // 
            this.CarType.HeaderText = "Car Type";
            this.CarType.Name = "CarType";
            this.CarType.ReadOnly = true;
            this.CarType.Width = 77;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 30);
            this.label7.TabIndex = 3;
            this.label7.Text = "Name";
            // 
            // ParkingLotManagementConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 262);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gbPaymentSection);
            this.Controls.Add(this.gbEntrySection);
            this.Name = "ParkingLotManagementConsole";
            this.Text = "Parking Lot Management Console";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbEntrySection.ResumeLayout(false);
            this.gbEntrySection.PerformLayout();
            this.gbPaymentSection.ResumeLayout(false);
            this.gbPaymentSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOfInsideCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEntrySection;
        private System.Windows.Forms.GroupBox gbPaymentSection;
        private System.Windows.Forms.DateTimePicker dtpCheckInTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCarType;
        private System.Windows.Forms.MaskedTextBox mtxtCarPlate;
        private System.Windows.Forms.Button btnSaveCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalculateParkingPrice;
        private System.Windows.Forms.DateTimePicker dtpCheckOutTime;
        private System.Windows.Forms.TextBox txtEmptyParkSlot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvListOfInsideCars;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarPlate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckInTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarType;
        private System.Windows.Forms.Label label7;
    }
}

