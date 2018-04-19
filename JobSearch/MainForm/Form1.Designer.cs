namespace MainForm
{
    partial class frmJobSearch
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
            this.dgMain = new System.Windows.Forms.DataGridView();
            this.btnLeadsPerDay = new System.Windows.Forms.Button();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.btnQuietLeads = new System.Windows.Forms.Button();
            this.btnActiveContacts = new System.Windows.Forms.Button();
            this.btnLeadsBySource = new System.Windows.Forms.Button();
            this.btnLeadReport = new System.Windows.Forms.Button();
            this.btnSearchLog = new System.Windows.Forms.Button();
            this.btnLeadCallList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbControls = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbDateReturns = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgActivities = new System.Windows.Forms.DataGridView();
            this.txtActID = new System.Windows.Forms.TextBox();
            this.txtLeadID = new System.Windows.Forms.TextBox();
            this.txtActDate = new System.Windows.Forms.TextBox();
            this.txtActDetails = new System.Windows.Forms.TextBox();
            this.txtRefLink = new System.Windows.Forms.TextBox();
            this.gbActivityInputs = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbActType = new System.Windows.Forms.ComboBox();
            this.cbComplete = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgMain)).BeginInit();
            this.tbControls.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbDateReturns.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgActivities)).BeginInit();
            this.gbActivityInputs.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgMain
            // 
            this.dgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMain.Location = new System.Drawing.Point(14, 17);
            this.dgMain.Name = "dgMain";
            this.dgMain.Size = new System.Drawing.Size(708, 292);
            this.dgMain.TabIndex = 0;
            // 
            // btnLeadsPerDay
            // 
            this.btnLeadsPerDay.Location = new System.Drawing.Point(155, 34);
            this.btnLeadsPerDay.Name = "btnLeadsPerDay";
            this.btnLeadsPerDay.Size = new System.Drawing.Size(86, 32);
            this.btnLeadsPerDay.TabIndex = 1;
            this.btnLeadsPerDay.Text = "Leads per Day";
            this.btnLeadsPerDay.UseVisualStyleBackColor = true;
            this.btnLeadsPerDay.Click += new System.EventHandler(this.btnLeadsPerDay_Click);
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(8, 41);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(124, 20);
            this.txtStartDate.TabIndex = 2;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(8, 85);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(124, 20);
            this.txtEndDate.TabIndex = 3;
            // 
            // btnQuietLeads
            // 
            this.btnQuietLeads.Location = new System.Drawing.Point(30, 19);
            this.btnQuietLeads.Name = "btnQuietLeads";
            this.btnQuietLeads.Size = new System.Drawing.Size(86, 36);
            this.btnQuietLeads.TabIndex = 4;
            this.btnQuietLeads.Text = "Quiet Active Leads";
            this.btnQuietLeads.UseVisualStyleBackColor = true;
            this.btnQuietLeads.Click += new System.EventHandler(this.btnQuietLeads_Click);
            // 
            // btnActiveContacts
            // 
            this.btnActiveContacts.Location = new System.Drawing.Point(74, 74);
            this.btnActiveContacts.Name = "btnActiveContacts";
            this.btnActiveContacts.Size = new System.Drawing.Size(86, 36);
            this.btnActiveContacts.TabIndex = 6;
            this.btnActiveContacts.Text = "Active Contacts";
            this.btnActiveContacts.UseVisualStyleBackColor = true;
            this.btnActiveContacts.Click += new System.EventHandler(this.btnActiveContacts_Click);
            // 
            // btnLeadsBySource
            // 
            this.btnLeadsBySource.Location = new System.Drawing.Point(143, 19);
            this.btnLeadsBySource.Name = "btnLeadsBySource";
            this.btnLeadsBySource.Size = new System.Drawing.Size(86, 36);
            this.btnLeadsBySource.TabIndex = 5;
            this.btnLeadsBySource.Text = "Leads By Source";
            this.btnLeadsBySource.UseVisualStyleBackColor = true;
            this.btnLeadsBySource.Click += new System.EventHandler(this.btnLeadsBySource_Click);
            // 
            // btnLeadReport
            // 
            this.btnLeadReport.Location = new System.Drawing.Point(209, 75);
            this.btnLeadReport.Name = "btnLeadReport";
            this.btnLeadReport.Size = new System.Drawing.Size(86, 36);
            this.btnLeadReport.TabIndex = 10;
            this.btnLeadReport.Text = "Lead Report";
            this.btnLeadReport.UseVisualStyleBackColor = true;
            this.btnLeadReport.Click += new System.EventHandler(this.btnLeadReport_Click);
            // 
            // btnSearchLog
            // 
            this.btnSearchLog.Location = new System.Drawing.Point(155, 72);
            this.btnSearchLog.Name = "btnSearchLog";
            this.btnSearchLog.Size = new System.Drawing.Size(86, 32);
            this.btnSearchLog.TabIndex = 9;
            this.btnSearchLog.Text = "Search Log";
            this.btnSearchLog.UseVisualStyleBackColor = true;
            this.btnSearchLog.Click += new System.EventHandler(this.btnSearchLog_Click);
            // 
            // btnLeadCallList
            // 
            this.btnLeadCallList.Location = new System.Drawing.Point(259, 19);
            this.btnLeadCallList.Name = "btnLeadCallList";
            this.btnLeadCallList.Size = new System.Drawing.Size(86, 36);
            this.btnLeadCallList.TabIndex = 8;
            this.btnLeadCallList.Text = "Active Lead Call List";
            this.btnLeadCallList.UseVisualStyleBackColor = true;
            this.btnLeadCallList.Click += new System.EventHandler(this.btnLeadCallList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "End Date";
            // 
            // tbControls
            // 
            this.tbControls.Controls.Add(this.tabPage1);
            this.tbControls.Controls.Add(this.tabPage2);
            this.tbControls.Location = new System.Drawing.Point(22, 12);
            this.tbControls.Name = "tbControls";
            this.tbControls.SelectedIndex = 0;
            this.tbControls.Size = new System.Drawing.Size(747, 535);
            this.tbControls.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.gbDateReturns);
            this.tabPage1.Controls.Add(this.dgMain);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(739, 509);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Outputs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbDateReturns
            // 
            this.gbDateReturns.Controls.Add(this.label2);
            this.gbDateReturns.Controls.Add(this.btnLeadsPerDay);
            this.gbDateReturns.Controls.Add(this.label1);
            this.gbDateReturns.Controls.Add(this.txtStartDate);
            this.gbDateReturns.Controls.Add(this.txtEndDate);
            this.gbDateReturns.Controls.Add(this.btnSearchLog);
            this.gbDateReturns.Location = new System.Drawing.Point(24, 351);
            this.gbDateReturns.Name = "gbDateReturns";
            this.gbDateReturns.Size = new System.Drawing.Size(273, 128);
            this.gbDateReturns.TabIndex = 13;
            this.gbDateReturns.TabStop = false;
            this.gbDateReturns.Text = "Dates Required";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gbActivityInputs);
            this.tabPage2.Controls.Add(this.dgActivities);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(739, 509);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Activities";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLeadReport);
            this.groupBox1.Controls.Add(this.btnQuietLeads);
            this.groupBox1.Controls.Add(this.btnLeadCallList);
            this.groupBox1.Controls.Add(this.btnLeadsBySource);
            this.groupBox1.Controls.Add(this.btnActiveContacts);
            this.groupBox1.Location = new System.Drawing.Point(342, 351);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 127);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "No Dates Required";
            // 
            // dgActivities
            // 
            this.dgActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgActivities.Location = new System.Drawing.Point(6, 408);
            this.dgActivities.Name = "dgActivities";
            this.dgActivities.Size = new System.Drawing.Size(727, 95);
            this.dgActivities.TabIndex = 0;
            // 
            // txtActID
            // 
            this.txtActID.Location = new System.Drawing.Point(7, 16);
            this.txtActID.Name = "txtActID";
            this.txtActID.Size = new System.Drawing.Size(134, 20);
            this.txtActID.TabIndex = 1;
            // 
            // txtLeadID
            // 
            this.txtLeadID.Location = new System.Drawing.Point(18, 110);
            this.txtLeadID.Name = "txtLeadID";
            this.txtLeadID.Size = new System.Drawing.Size(134, 20);
            this.txtLeadID.TabIndex = 2;
            // 
            // txtActDate
            // 
            this.txtActDate.Location = new System.Drawing.Point(18, 287);
            this.txtActDate.Name = "txtActDate";
            this.txtActDate.Size = new System.Drawing.Size(134, 20);
            this.txtActDate.TabIndex = 3;
            // 
            // txtActDetails
            // 
            this.txtActDetails.Location = new System.Drawing.Point(193, 235);
            this.txtActDetails.Multiline = true;
            this.txtActDetails.Name = "txtActDetails";
            this.txtActDetails.Size = new System.Drawing.Size(134, 72);
            this.txtActDetails.TabIndex = 5;
            // 
            // txtRefLink
            // 
            this.txtRefLink.Location = new System.Drawing.Point(193, 110);
            this.txtRefLink.Name = "txtRefLink";
            this.txtRefLink.Size = new System.Drawing.Size(134, 20);
            this.txtRefLink.TabIndex = 7;
            // 
            // gbActivityInputs
            // 
            this.gbActivityInputs.Controls.Add(this.btnClear);
            this.gbActivityInputs.Controls.Add(this.cbComplete);
            this.gbActivityInputs.Controls.Add(this.cbActType);
            this.gbActivityInputs.Controls.Add(this.label9);
            this.gbActivityInputs.Controls.Add(this.label8);
            this.gbActivityInputs.Controls.Add(this.label6);
            this.gbActivityInputs.Controls.Add(this.label5);
            this.gbActivityInputs.Controls.Add(this.label4);
            this.gbActivityInputs.Controls.Add(this.btnInsert);
            this.gbActivityInputs.Controls.Add(this.groupBox2);
            this.gbActivityInputs.Controls.Add(this.txtRefLink);
            this.gbActivityInputs.Controls.Add(this.txtActDetails);
            this.gbActivityInputs.Controls.Add(this.txtActDate);
            this.gbActivityInputs.Controls.Add(this.txtLeadID);
            this.gbActivityInputs.Location = new System.Drawing.Point(17, 34);
            this.gbActivityInputs.Name = "gbActivityInputs";
            this.gbActivityInputs.Size = new System.Drawing.Size(481, 338);
            this.gbActivityInputs.TabIndex = 8;
            this.gbActivityInputs.TabStop = false;
            this.gbActivityInputs.Text = "Input Parameters";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "ActivityID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtActID);
            this.groupBox2.Location = new System.Drawing.Point(9, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 49);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(215, 13);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 30);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(367, 140);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(98, 32);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "LeadID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Activity Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Activity Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(253, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Activity Details";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(247, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Reference Link";
            // 
            // cbActType
            // 
            this.cbActType.FormattingEnabled = true;
            this.cbActType.Items.AddRange(new object[] {
            "Inquiry",
            "Application",
            "Contact",
            "Interview",
            "Follow-up",
            "Correspondence",
            "Documentation",
            "Closure",
            "Other"});
            this.cbActType.Location = new System.Drawing.Point(18, 184);
            this.cbActType.Name = "cbActType";
            this.cbActType.Size = new System.Drawing.Size(132, 21);
            this.cbActType.TabIndex = 18;
            // 
            // cbComplete
            // 
            this.cbComplete.AutoSize = true;
            this.cbComplete.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbComplete.Checked = true;
            this.cbComplete.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cbComplete.Location = new System.Drawing.Point(250, 184);
            this.cbComplete.Name = "cbComplete";
            this.cbComplete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbComplete.Size = new System.Drawing.Size(76, 17);
            this.cbComplete.TabIndex = 19;
            this.cbComplete.Text = "Complete?";
            this.cbComplete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(367, 192);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 32);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmJobSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 573);
            this.Controls.Add(this.tbControls);
            this.Name = "frmJobSearch";
            this.Text = "Job Search";
            ((System.ComponentModel.ISupportInitialize)(this.dgMain)).EndInit();
            this.tbControls.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbDateReturns.ResumeLayout(false);
            this.gbDateReturns.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgActivities)).EndInit();
            this.gbActivityInputs.ResumeLayout(false);
            this.gbActivityInputs.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMain;
        private System.Windows.Forms.Button btnLeadsPerDay;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Button btnQuietLeads;
        private System.Windows.Forms.Button btnActiveContacts;
        private System.Windows.Forms.Button btnLeadsBySource;
        private System.Windows.Forms.Button btnLeadReport;
        private System.Windows.Forms.Button btnSearchLog;
        private System.Windows.Forms.Button btnLeadCallList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tbControls;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbDateReturns;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbActivityInputs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRefLink;
        private System.Windows.Forms.TextBox txtActDetails;
        private System.Windows.Forms.TextBox txtActDate;
        private System.Windows.Forms.TextBox txtLeadID;
        private System.Windows.Forms.TextBox txtActID;
        private System.Windows.Forms.DataGridView dgActivities;
        private System.Windows.Forms.ComboBox cbActType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox cbComplete;
        private System.Windows.Forms.Button btnClear;
    }
}

