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
            this.txtVehicles = new System.Windows.Forms.TextBox();
            this.cmbHospital = new System.Windows.Forms.ComboBox();
            this.txtResponded = new System.Windows.Forms.TextBox();
            this.cmbCollision = new System.Windows.Forms.ComboBox();
            this.cmbPOI = new System.Windows.Forms.ComboBox();
            this.cmbNOI = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(631, 539);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 39);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Source Sans Pro Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 26);
            this.label5.TabIndex = 36;
            this.label5.Text = "Vehicles Involved:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Font = new System.Drawing.Font("Source Sans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(243, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 31);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Source Sans Pro Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbID.ForeColor = System.Drawing.Color.Black;
            this.lbID.Location = new System.Drawing.Point(719, 15);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(122, 19);
            this.lbID.TabIndex = 32;
            this.lbID.Text = "Search using IR #:";
            // 
            // txtIRNum
            // 
            this.txtIRNum.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIRNum.Location = new System.Drawing.Point(872, 12);
            this.txtIRNum.Name = "txtIRNum";
            this.txtIRNum.Size = new System.Drawing.Size(137, 26);
            this.txtIRNum.TabIndex = 33;
            this.txtIRNum.TextChanged += new System.EventHandler(this.txtIRNum_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(492, 539);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 39);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(766, 539);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 39);
            this.btnClear.TabIndex = 30;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtCasualty
            // 
            this.txtCasualty.Font = new System.Drawing.Font("Source Sans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCasualty.Location = new System.Drawing.Point(243, 170);
            this.txtCasualty.Name = "txtCasualty";
            this.txtCasualty.Size = new System.Drawing.Size(759, 31);
            this.txtCasualty.TabIndex = 31;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(902, 539);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(125, 39);
            this.btnDel.TabIndex = 31;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            // 
            // lbTransport
            // 
            this.lbTransport.AutoSize = true;
            this.lbTransport.Font = new System.Drawing.Font("Source Sans Pro Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTransport.Location = new System.Drawing.Point(14, 371);
            this.lbTransport.Name = "lbTransport";
            this.lbTransport.Size = new System.Drawing.Size(148, 26);
            this.lbTransport.TabIndex = 13;
            this.lbTransport.Text = "Responded By:";
            // 
            // lblOrigin
            // 
            this.lblOrigin.AutoSize = true;
            this.lblOrigin.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrigin.Location = new System.Drawing.Point(16, 221);
            this.lblOrigin.Name = "lblOrigin";
            this.lblOrigin.Size = new System.Drawing.Size(187, 20);
            this.lblOrigin.TabIndex = 12;
            this.lblOrigin.Text = "Endorsed to w/c Hospital:";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Source Sans Pro Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDestination.Location = new System.Drawing.Point(16, 269);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(145, 26);
            this.lblDestination.TabIndex = 11;
            this.lblDestination.Text = "Is it Collision?:";
            // 
            // lblAgeOfPt
            // 
            this.lblAgeOfPt.AutoSize = true;
            this.lblAgeOfPt.Font = new System.Drawing.Font("Source Sans Pro Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAgeOfPt.Location = new System.Drawing.Point(16, 172);
            this.lblAgeOfPt.Name = "lblAgeOfPt";
            this.lblAgeOfPt.Size = new System.Drawing.Size(156, 26);
            this.lblAgeOfPt.TabIndex = 10;
            this.lblAgeOfPt.Text = "No. of Casualty:";
            // 
            // lblPtname
            // 
            this.lblPtname.AutoSize = true;
            this.lblPtname.Font = new System.Drawing.Font("Source Sans Pro Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPtname.Location = new System.Drawing.Point(14, 126);
            this.lblPtname.Name = "lblPtname";
            this.lblPtname.Size = new System.Drawing.Size(171, 26);
            this.lblPtname.TabIndex = 9;
            this.lblPtname.Text = "Place of Incident:";
            // 
            // lbCase
            // 
            this.lbCase.AutoSize = true;
            this.lbCase.Font = new System.Drawing.Font("Source Sans Pro Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCase.Location = new System.Drawing.Point(14, 75);
            this.lbCase.Name = "lbCase";
            this.lbCase.Size = new System.Drawing.Size(186, 26);
            this.lbCase.TabIndex = 8;
            this.lbCase.Text = "Nature of Incident:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Incidents Report Form";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Source Sans Pro Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDate.Location = new System.Drawing.Point(16, 29);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(141, 26);
            this.lbDate.TabIndex = 7;
            this.lbDate.Text = "Date Occured:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
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
            this.panel2.Location = new System.Drawing.Point(10, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1031, 445);
            this.panel2.TabIndex = 27;
            // 
            // txtVehicles
            // 
            this.txtVehicles.Font = new System.Drawing.Font("Source Sans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVehicles.Location = new System.Drawing.Point(243, 318);
            this.txtVehicles.Name = "txtVehicles";
            this.txtVehicles.Size = new System.Drawing.Size(759, 31);
            this.txtVehicles.TabIndex = 46;
            // 
            // cmbHospital
            // 
            this.cmbHospital.Font = new System.Drawing.Font("Source Sans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbHospital.FormattingEnabled = true;
            this.cmbHospital.Items.AddRange(new object[] {
            "DMMDH",
            "NSDAH"});
            this.cmbHospital.Location = new System.Drawing.Point(243, 218);
            this.cmbHospital.Name = "cmbHospital";
            this.cmbHospital.Size = new System.Drawing.Size(759, 32);
            this.cmbHospital.TabIndex = 45;
            // 
            // txtResponded
            // 
            this.txtResponded.Font = new System.Drawing.Font("Source Sans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResponded.Location = new System.Drawing.Point(243, 371);
            this.txtResponded.Name = "txtResponded";
            this.txtResponded.Size = new System.Drawing.Size(759, 31);
            this.txtResponded.TabIndex = 44;
            // 
            // cmbCollision
            // 
            this.cmbCollision.Font = new System.Drawing.Font("Source Sans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbCollision.FormattingEnabled = true;
            this.cmbCollision.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbCollision.Location = new System.Drawing.Point(243, 266);
            this.cmbCollision.Name = "cmbCollision";
            this.cmbCollision.Size = new System.Drawing.Size(759, 32);
            this.cmbCollision.TabIndex = 42;
            // 
            // cmbPOI
            // 
            this.cmbPOI.Font = new System.Drawing.Font("Source Sans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.cmbPOI.Location = new System.Drawing.Point(243, 124);
            this.cmbPOI.Name = "cmbPOI";
            this.cmbPOI.Size = new System.Drawing.Size(759, 32);
            this.cmbPOI.TabIndex = 41;
            // 
            // cmbNOI
            // 
            this.cmbNOI.Font = new System.Drawing.Font("Source Sans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.cmbNOI.Location = new System.Drawing.Point(243, 74);
            this.cmbNOI.Name = "cmbNOI";
            this.cmbNOI.Size = new System.Drawing.Size(759, 32);
            this.cmbNOI.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Source Sans Pro Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(441, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 26);
            this.label3.TabIndex = 38;
            this.label3.Text = "Time:";
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("Source Sans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTime.Location = new System.Drawing.Point(558, 82);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(454, 31);
            this.txtTime.TabIndex = 47;
            // 
            // IRTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 672);
            this.Controls.Add(this.txtTime);
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
    }
}