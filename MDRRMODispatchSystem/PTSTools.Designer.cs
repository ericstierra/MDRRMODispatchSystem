namespace DRRMOperationsIMS
{
    partial class PTSTools
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbRef = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbDispatcher = new System.Windows.Forms.ComboBox();
            this.cbTransport = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDestination = new System.Windows.Forms.TextBox();
            this.tbOrigin = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbPname = new System.Windows.Forms.TextBox();
            this.tbCase = new System.Windows.Forms.TextBox();
            this.lbTransport = new System.Windows.Forms.Label();
            this.lblOrigin = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblAgeOfPt = new System.Windows.Forms.Label();
            this.lblPtname = new System.Windows.Forms.Label();
            this.lbCase = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbID = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printDispatch = new System.Drawing.Printing.PrintDocument();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.tbRef);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.cbDispatcher);
            this.panel2.Controls.Add(this.cbTransport);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbDestination);
            this.panel2.Controls.Add(this.tbOrigin);
            this.panel2.Controls.Add(this.tbAge);
            this.panel2.Controls.Add(this.tbPname);
            this.panel2.Controls.Add(this.tbCase);
            this.panel2.Controls.Add(this.lbTransport);
            this.panel2.Controls.Add(this.lblOrigin);
            this.panel2.Controls.Add(this.lblDestination);
            this.panel2.Controls.Add(this.lblAgeOfPt);
            this.panel2.Controls.Add(this.lblPtname);
            this.panel2.Controls.Add(this.lbCase);
            this.panel2.Controls.Add(this.lbDate);
            this.panel2.Location = new System.Drawing.Point(14, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1031, 445);
            this.panel2.TabIndex = 2;
            // 
            // tbRef
            // 
            this.tbRef.Font = new System.Drawing.Font("Source Sans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbRef.Location = new System.Drawing.Point(194, 318);
            this.tbRef.Name = "tbRef";
            this.tbRef.Size = new System.Drawing.Size(808, 31);
            this.tbRef.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Source Sans Pro Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 26);
            this.label5.TabIndex = 36;
            this.label5.Text = "Referred By:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Font = new System.Drawing.Font("Source Sans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(194, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(134, 31);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // cbDispatcher
            // 
            this.cbDispatcher.Font = new System.Drawing.Font("Source Sans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbDispatcher.FormattingEnabled = true;
            this.cbDispatcher.Items.AddRange(new object[] {
            "Equalizer",
            "Echo",
            "Volunteer On-Duty"});
            this.cbDispatcher.Location = new System.Drawing.Point(709, 371);
            this.cbDispatcher.Name = "cbDispatcher";
            this.cbDispatcher.Size = new System.Drawing.Size(293, 32);
            this.cbDispatcher.TabIndex = 35;
            // 
            // cbTransport
            // 
            this.cbTransport.Font = new System.Drawing.Font("Source Sans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTransport.FormattingEnabled = true;
            this.cbTransport.Items.AddRange(new object[] {
            "PTV-Larry",
            "AMB-Sendong",
            "AMB-Mario",
            "AMB-Danny",
            "PTV-STAN",
            "MDRRMO-Medic"});
            this.cbTransport.Location = new System.Drawing.Point(194, 370);
            this.cbTransport.Name = "cbTransport";
            this.cbTransport.Size = new System.Drawing.Size(282, 32);
            this.cbTransport.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Sans Pro Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(528, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 26);
            this.label2.TabIndex = 21;
            this.label2.Text = "Dispatched by:";
            // 
            // tbDestination
            // 
            this.tbDestination.Font = new System.Drawing.Font("Source Sans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDestination.Location = new System.Drawing.Point(194, 263);
            this.tbDestination.Name = "tbDestination";
            this.tbDestination.Size = new System.Drawing.Size(808, 31);
            this.tbDestination.TabIndex = 33;
            // 
            // tbOrigin
            // 
            this.tbOrigin.Font = new System.Drawing.Font("Source Sans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbOrigin.Location = new System.Drawing.Point(194, 216);
            this.tbOrigin.Name = "tbOrigin";
            this.tbOrigin.Size = new System.Drawing.Size(808, 31);
            this.tbOrigin.TabIndex = 32;
            // 
            // tbAge
            // 
            this.tbAge.Font = new System.Drawing.Font("Source Sans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAge.Location = new System.Drawing.Point(194, 170);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(808, 31);
            this.tbAge.TabIndex = 31;
            // 
            // tbPname
            // 
            this.tbPname.Font = new System.Drawing.Font("Source Sans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPname.Location = new System.Drawing.Point(194, 124);
            this.tbPname.Name = "tbPname";
            this.tbPname.Size = new System.Drawing.Size(808, 31);
            this.tbPname.TabIndex = 29;
            // 
            // tbCase
            // 
            this.tbCase.Font = new System.Drawing.Font("Source Sans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCase.Location = new System.Drawing.Point(194, 75);
            this.tbCase.Name = "tbCase";
            this.tbCase.Size = new System.Drawing.Size(808, 31);
            this.tbCase.TabIndex = 28;
            // 
            // lbTransport
            // 
            this.lbTransport.AutoSize = true;
            this.lbTransport.Font = new System.Drawing.Font("Source Sans Pro Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTransport.Location = new System.Drawing.Point(14, 371);
            this.lbTransport.Name = "lbTransport";
            this.lbTransport.Size = new System.Drawing.Size(107, 26);
            this.lbTransport.TabIndex = 13;
            this.lbTransport.Text = "Transport:";
            // 
            // lblOrigin
            // 
            this.lblOrigin.AutoSize = true;
            this.lblOrigin.Font = new System.Drawing.Font("Source Sans Pro Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrigin.Location = new System.Drawing.Point(16, 216);
            this.lblOrigin.Name = "lblOrigin";
            this.lblOrigin.Size = new System.Drawing.Size(75, 26);
            this.lblOrigin.TabIndex = 12;
            this.lblOrigin.Text = "Origin:";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Source Sans Pro Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDestination.Location = new System.Drawing.Point(16, 262);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(126, 26);
            this.lblDestination.TabIndex = 11;
            this.lblDestination.Text = "Destination:";
            // 
            // lblAgeOfPt
            // 
            this.lblAgeOfPt.AutoSize = true;
            this.lblAgeOfPt.Font = new System.Drawing.Font("Source Sans Pro Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAgeOfPt.Location = new System.Drawing.Point(16, 172);
            this.lblAgeOfPt.Name = "lblAgeOfPt";
            this.lblAgeOfPt.Size = new System.Drawing.Size(52, 26);
            this.lblAgeOfPt.TabIndex = 10;
            this.lblAgeOfPt.Text = "Age:";
            // 
            // lblPtname
            // 
            this.lblPtname.AutoSize = true;
            this.lblPtname.Font = new System.Drawing.Font("Source Sans Pro Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPtname.Location = new System.Drawing.Point(14, 126);
            this.lblPtname.Name = "lblPtname";
            this.lblPtname.Size = new System.Drawing.Size(143, 26);
            this.lblPtname.TabIndex = 9;
            this.lblPtname.Text = "Patient Name:";
            // 
            // lbCase
            // 
            this.lbCase.AutoSize = true;
            this.lbCase.Font = new System.Drawing.Font("Source Sans Pro Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCase.Location = new System.Drawing.Point(14, 75);
            this.lbCase.Name = "lbCase";
            this.lbCase.Size = new System.Drawing.Size(132, 26);
            this.lbCase.TabIndex = 8;
            this.lbCase.Text = "Patient Case:";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Source Sans Pro Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDate.Location = new System.Drawing.Point(16, 29);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(61, 26);
            this.lbDate.TabIndex = 7;
            this.lbDate.Text = "Date:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(631, 538);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 39);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(902, 538);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(125, 39);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(766, 538);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 39);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(492, 538);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 39);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Source Sans Pro Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbID.ForeColor = System.Drawing.Color.Black;
            this.lbID.Location = new System.Drawing.Point(680, 14);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(169, 19);
            this.lbID.TabIndex = 24;
            this.lbID.Text = "Search using Dispatch ID:";
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbID.Location = new System.Drawing.Point(877, 11);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(137, 26);
            this.tbID.TabIndex = 25;
            this.tbID.TextChanged += new System.EventHandler(this.tbID_TextChanged);
            this.tbID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbID_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Transport Form";
            // 
            // PTSTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 672);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PTSTools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddItem";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel2;
        private Button btnUpdate;
        private Button btnDel;
        private Button btnClear;
        private Button btnAdd;
        private Label lblAgeOfPt;
        private Label lblPtname;
        private Label lbCase;
        private Label lbDate;
        private TextBox tbDestination;
        private TextBox tbOrigin;
        private TextBox tbAge;
        private TextBox tbPname;
        private TextBox tbCase;
        private Label lbTransport;
        private Label lblOrigin;
        private Label lblDestination;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbDispatcher;
        private ComboBox cbTransport;
        private TextBox tbRef;
        private Label label5;
        private Label lbID;
        private TextBox tbID;
        private Label label1;
        private System.Drawing.Printing.PrintDocument printDispatch;
    }
}