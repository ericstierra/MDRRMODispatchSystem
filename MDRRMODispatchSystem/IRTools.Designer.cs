namespace DRRMOperationsIMS
{
    partial class IRTools
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbID = new System.Windows.Forms.Label();
            this.txtIRNum = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtCasualty = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.lbTransport = new System.Windows.Forms.Label();
            this.printDispatch = new System.Drawing.Printing.PrintDocument();
            this.lblOrigin = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblAgeOfPt = new System.Windows.Forms.Label();
            this.lblPtname = new System.Windows.Forms.Label();
            this.lbCase = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtVehicles = new System.Windows.Forms.TextBox();
            this.cmbHospital = new System.Windows.Forms.ComboBox();
            this.txtResponded = new System.Windows.Forms.TextBox();
            this.cmbCollision = new System.Windows.Forms.ComboBox();
            this.cmbPOI = new System.Windows.Forms.ComboBox();
            this.cmbNOI = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(1046, 228);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 21);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(776, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Vehicles Involved:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.CustomFormat = "MM/DD/YYYY";
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(104, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 23);
            this.dateTimePicker1.TabIndex = 26;
            this.dateTimePicker1.Value = new System.DateTime(2022, 8, 11, 10, 3, 48, 0);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbID.ForeColor = System.Drawing.Color.Black;
            this.lbID.Location = new System.Drawing.Point(1043, 10);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(99, 13);
            this.lbID.TabIndex = 32;
            this.lbID.Text = "Search using IR #:";
            // 
            // txtIRNum
            // 
            this.txtIRNum.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIRNum.Location = new System.Drawing.Point(1165, 5);
            this.txtIRNum.Name = "txtIRNum";
            this.txtIRNum.Size = new System.Drawing.Size(195, 22);
            this.txtIRNum.TabIndex = 33;
            this.txtIRNum.TextChanged += new System.EventHandler(this.txtIRNum_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(934, 228);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 21);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(1153, 228);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 21);
            this.btnClear.TabIndex = 30;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtCasualty
            // 
            this.txtCasualty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCasualty.Location = new System.Drawing.Point(663, 48);
            this.txtCasualty.Name = "txtCasualty";
            this.txtCasualty.Size = new System.Drawing.Size(93, 23);
            this.txtCasualty.TabIndex = 31;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDel.ForeColor = System.Drawing.Color.Black;
            this.btnDel.Location = new System.Drawing.Point(1258, 228);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(92, 21);
            this.btnDel.TabIndex = 31;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            // 
            // lbTransport
            // 
            this.lbTransport.AutoSize = true;
            this.lbTransport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTransport.Location = new System.Drawing.Point(3, 86);
            this.lbTransport.Name = "lbTransport";
            this.lbTransport.Size = new System.Drawing.Size(99, 17);
            this.lbTransport.TabIndex = 13;
            this.lbTransport.Text = "Responded By:";
            // 
            // lblOrigin
            // 
            this.lblOrigin.AutoSize = true;
            this.lblOrigin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrigin.Location = new System.Drawing.Point(5, 50);
            this.lblOrigin.Name = "lblOrigin";
            this.lblOrigin.Size = new System.Drawing.Size(168, 17);
            this.lblOrigin.TabIndex = 12;
            this.lblOrigin.Text = "Endorsed to w/c Hospital:";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDestination.Location = new System.Drawing.Point(367, 53);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(99, 17);
            this.lblDestination.TabIndex = 11;
            this.lblDestination.Text = "Is it Collision?:";
            // 
            // lblAgeOfPt
            // 
            this.lblAgeOfPt.AutoSize = true;
            this.lblAgeOfPt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAgeOfPt.Location = new System.Drawing.Point(552, 51);
            this.lblAgeOfPt.Name = "lblAgeOfPt";
            this.lblAgeOfPt.Size = new System.Drawing.Size(107, 17);
            this.lblAgeOfPt.TabIndex = 10;
            this.lblAgeOfPt.Text = "No. of Casualty:";
            // 
            // lblPtname
            // 
            this.lblPtname.AutoSize = true;
            this.lblPtname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPtname.Location = new System.Drawing.Point(868, 16);
            this.lblPtname.Name = "lblPtname";
            this.lblPtname.Size = new System.Drawing.Size(115, 17);
            this.lblPtname.TabIndex = 9;
            this.lblPtname.Text = "Place of Incident:";
            // 
            // lbCase
            // 
            this.lbCase.AutoSize = true;
            this.lbCase.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCase.Location = new System.Drawing.Point(445, 16);
            this.lbCase.Name = "lbCase";
            this.lbCase.Size = new System.Drawing.Size(125, 17);
            this.lbCase.TabIndex = 8;
            this.lbCase.Text = "Nature of Incident:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "Incidents Report Form";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDate.Location = new System.Drawing.Point(3, 16);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(95, 17);
            this.lbDate.TabIndex = 7;
            this.lbDate.Text = "Date Occured:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtRemarks);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtTime);
            this.panel2.Controls.Add(this.txtVehicles);
            this.panel2.Controls.Add(this.cmbHospital);
            this.panel2.Controls.Add(this.txtResponded);
            this.panel2.Controls.Add(this.cmbCollision);
            this.panel2.Controls.Add(this.cmbPOI);
            this.panel2.Controls.Add(this.cmbNOI);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.txtCasualty);
            this.panel2.Controls.Add(this.lbTransport);
            this.panel2.Controls.Add(this.lblOrigin);
            this.panel2.Controls.Add(this.lblDestination);
            this.panel2.Controls.Add(this.lblAgeOfPt);
            this.panel2.Controls.Add(this.lblPtname);
            this.panel2.Controls.Add(this.lbCase);
            this.panel2.Controls.Add(this.lbDate);
            this.panel2.Location = new System.Drawing.Point(10, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1350, 228);
            this.panel2.TabIndex = 27;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRemarks.Location = new System.Drawing.Point(437, 86);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(903, 97);
            this.txtRemarks.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(367, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "Remarks:";
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTime.Location = new System.Drawing.Point(311, 12);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(114, 23);
            this.txtTime.TabIndex = 47;
            // 
            // txtVehicles
            // 
            this.txtVehicles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVehicles.Location = new System.Drawing.Point(901, 51);
            this.txtVehicles.Name = "txtVehicles";
            this.txtVehicles.Size = new System.Drawing.Size(439, 23);
            this.txtVehicles.TabIndex = 46;
            // 
            // cmbHospital
            // 
            this.cmbHospital.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbHospital.FormattingEnabled = true;
            this.cmbHospital.Items.AddRange(new object[] {
            "N/A",
            "DMMDH",
            "NSDAH"});
            this.cmbHospital.Location = new System.Drawing.Point(177, 47);
            this.cmbHospital.Name = "cmbHospital";
            this.cmbHospital.Size = new System.Drawing.Size(170, 23);
            this.cmbHospital.TabIndex = 45;
            // 
            // txtResponded
            // 
            this.txtResponded.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResponded.Location = new System.Drawing.Point(107, 85);
            this.txtResponded.Multiline = true;
            this.txtResponded.Name = "txtResponded";
            this.txtResponded.Size = new System.Drawing.Size(240, 98);
            this.txtResponded.TabIndex = 44;
            // 
            // cmbCollision
            // 
            this.cmbCollision.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbCollision.FormattingEnabled = true;
            this.cmbCollision.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbCollision.Location = new System.Drawing.Point(470, 50);
            this.cmbCollision.Name = "cmbCollision";
            this.cmbCollision.Size = new System.Drawing.Size(63, 23);
            this.cmbCollision.TabIndex = 42;
            // 
            // cmbPOI
            // 
            this.cmbPOI.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbPOI.FormattingEnabled = true;
            this.cmbPOI.Items.AddRange(new object[] {
            "Angeles",
            "Balubad",
            "Balugohin",
            "Barangay Zone 1-Pob",
            "Barangay Zone 2-Pob",
            "Barangay Zone 3-Pob",
            "Barangay Zone 4-Pob",
            "Buhangin",
            "Caridad Ibaba",
            "Caridad Ilaya",
            "Habingan",
            "Inaclagan",
            "Inalig",
            "Kilait",
            "Kulawit",
            "Lakip",
            "Lubi",
            "Lumutan",
            "Magsaysay",
            "Malinao Ibaba",
            "Malinao Ilaya",
            "Malusak",
            "Manggalayan Bundok",
            "Manggalayan Labak",
            "Matanag",
            "Montes Balaon",
            "Montes Kallagan",
            "Ponon",
            "Rizal",
            "San Andres Bundok",
            "San Andres Labak",
            "San Isidro",
            "San Jose Balatok",
            "San Rafael",
            "Santa Catalina",
            "Sapaan",
            "Sokol",
            "Tagbakin",
            "Talaba",
            "Tinandog",
            "Villa Ibaba",
            "Villa Ilaya"});
            this.cmbPOI.Location = new System.Drawing.Point(987, 13);
            this.cmbPOI.Name = "cmbPOI";
            this.cmbPOI.Size = new System.Drawing.Size(353, 23);
            this.cmbPOI.TabIndex = 41;
            // 
            // cmbNOI
            // 
            this.cmbNOI.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbNOI.FormattingEnabled = true;
            this.cmbNOI.Items.AddRange(new object[] {
            "Road Crash",
            "Fire",
            "Earthquake",
            "Drowning",
            "Hacking",
            "Stabbing",
            "Water Transportation",
            "Weather Related Injuries"});
            this.cmbNOI.Location = new System.Drawing.Point(574, 13);
            this.cmbNOI.Name = "cmbNOI";
            this.cmbNOI.Size = new System.Drawing.Size(272, 23);
            this.cmbNOI.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(266, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Time:";
            // 
            // IRTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1372, 273);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.txtIRNum);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IRTools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IRTools";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnUpdate;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label lbID;
        private TextBox txtIRNum;
        private Button btnAdd;
        private Button btnClear;
        private TextBox txtCasualty;
        private Button btnDel;
        private Label lbTransport;
        private System.Drawing.Printing.PrintDocument printDispatch;
        private Label lblOrigin;
        private Label lblDestination;
        private Label lblAgeOfPt;
        private Label lblPtname;
        private Label lbCase;
        private Label label1;
        private Label lbDate;
        private Panel panel2;
        private ComboBox cmbCollision;
        private ComboBox cmbPOI;
        private ComboBox cmbNOI;
        private Label label3;
        private TextBox txtResponded;
        private TextBox txtVehicles;
        private ComboBox cmbHospital;
        private TextBox txtTime;
        private TextBox txtRemarks;
        private Label label2;
    }
}