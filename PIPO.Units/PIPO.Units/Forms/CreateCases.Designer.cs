﻿namespace LabTrack.Forms
{
    partial class CreateCases
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
            this.lboxCases = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDateFinish = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDateCreation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodeFind = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabScan = new System.Windows.Forms.TabControl();
            this.tpScan = new System.Windows.Forms.TabPage();
            this.nudUnitsScaner = new System.Windows.Forms.NumericUpDown();
            this.txtBarCodeScanned = new System.Windows.Forms.TextBox();
            this.lblMessageETA = new System.Windows.Forms.Label();
            this.tpManual = new System.Windows.Forms.TabPage();
            this.nudTimeETA = new System.Windows.Forms.NumericUpDown();
            this.nudUnitsManual = new System.Windows.Forms.NumericUpDown();
            this.lbxCompany = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.tabScan.SuspendLayout();
            this.tpScan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitsScaner)).BeginInit();
            this.tpManual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeETA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitsManual)).BeginInit();
            this.SuspendLayout();
            // 
            // lboxCases
            // 
            this.lboxCases.FormattingEnabled = true;
            this.lboxCases.Location = new System.Drawing.Point(252, 32);
            this.lboxCases.Name = "lboxCases";
            this.lboxCases.Size = new System.Drawing.Size(257, 407);
            this.lboxCases.TabIndex = 0;
            this.lboxCases.SelectedIndexChanged += new System.EventHandler(this.lboxCases_SelectedIndexChanged);
            this.lboxCases.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lboxCases_MouseDoubleClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(97, 231);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(97, 232);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 13;
            this.txtId.Visible = false;
            // 
            // txtDateFinish
            // 
            this.txtDateFinish.Location = new System.Drawing.Point(97, 198);
            this.txtDateFinish.Name = "txtDateFinish";
            this.txtDateFinish.ReadOnly = true;
            this.txtDateFinish.Size = new System.Drawing.Size(100, 20);
            this.txtDateFinish.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Date Done";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Time IN Prod";
            // 
            // txtDateCreation
            // 
            this.txtDateCreation.Location = new System.Drawing.Point(97, 124);
            this.txtDateCreation.Name = "txtDateCreation";
            this.txtDateCreation.ReadOnly = true;
            this.txtDateCreation.Size = new System.Drawing.Size(100, 20);
            this.txtDateCreation.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Date Creation";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Time Prod";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Units";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(97, 12);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 1;
            this.txtCode.Enter += new System.EventHandler(this.txtCode_Enter);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // txtCodeFind
            // 
            this.txtCodeFind.Location = new System.Drawing.Point(104, 32);
            this.txtCodeFind.Name = "txtCodeFind";
            this.txtCodeFind.Size = new System.Drawing.Size(67, 20);
            this.txtCodeFind.TabIndex = 5;
            this.txtCodeFind.Enter += new System.EventHandler(this.txtCodeFind_Enter);
            this.txtCodeFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeFind_KeyPress);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Search code:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Code";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Units ";
            // 
            // tabScan
            // 
            this.tabScan.Controls.Add(this.tpScan);
            this.tabScan.Controls.Add(this.tpManual);
            this.tabScan.Location = new System.Drawing.Point(10, 141);
            this.tabScan.Name = "tabScan";
            this.tabScan.SelectedIndex = 0;
            this.tabScan.Size = new System.Drawing.Size(224, 304);
            this.tabScan.TabIndex = 11;
            // 
            // tpScan
            // 
            this.tpScan.Controls.Add(this.nudUnitsScaner);
            this.tpScan.Controls.Add(this.txtBarCodeScanned);
            this.tpScan.Controls.Add(this.lblMessageETA);
            this.tpScan.Controls.Add(this.label10);
            this.tpScan.Controls.Add(this.label8);
            this.tpScan.Location = new System.Drawing.Point(4, 22);
            this.tpScan.Name = "tpScan";
            this.tpScan.Padding = new System.Windows.Forms.Padding(3);
            this.tpScan.Size = new System.Drawing.Size(216, 278);
            this.tpScan.TabIndex = 1;
            this.tpScan.Text = "Scan";
            this.tpScan.UseVisualStyleBackColor = true;
            // 
            // nudUnitsScaner
            // 
            this.nudUnitsScaner.Location = new System.Drawing.Point(97, 52);
            this.nudUnitsScaner.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudUnitsScaner.Name = "nudUnitsScaner";
            this.nudUnitsScaner.Size = new System.Drawing.Size(100, 20);
            this.nudUnitsScaner.TabIndex = 22;
            this.nudUnitsScaner.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudUnitsScaner.Click += new System.EventHandler(this.nudUnits_Click);
            // 
            // txtBarCodeScanned
            // 
            this.txtBarCodeScanned.Location = new System.Drawing.Point(97, 12);
            this.txtBarCodeScanned.Name = "txtBarCodeScanned";
            this.txtBarCodeScanned.Size = new System.Drawing.Size(100, 20);
            this.txtBarCodeScanned.TabIndex = 12;
            this.txtBarCodeScanned.Enter += new System.EventHandler(this.txtBarCodeScanned_Enter);
            this.txtBarCodeScanned.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeBCS_KeyPress);
            // 
            // lblMessageETA
            // 
            this.lblMessageETA.AutoSize = true;
            this.lblMessageETA.ForeColor = System.Drawing.Color.Red;
            this.lblMessageETA.Location = new System.Drawing.Point(11, 97);
            this.lblMessageETA.Name = "lblMessageETA";
            this.lblMessageETA.Size = new System.Drawing.Size(22, 13);
            this.lblMessageETA.TabIndex = 9;
            this.lblMessageETA.Text = "xxx";
            // 
            // tpManual
            // 
            this.tpManual.Controls.Add(this.nudTimeETA);
            this.tpManual.Controls.Add(this.nudUnitsManual);
            this.tpManual.Controls.Add(this.btnSave);
            this.tpManual.Controls.Add(this.label1);
            this.tpManual.Controls.Add(this.txtId);
            this.tpManual.Controls.Add(this.txtCode);
            this.tpManual.Controls.Add(this.txtDateFinish);
            this.tpManual.Controls.Add(this.label2);
            this.tpManual.Controls.Add(this.label7);
            this.tpManual.Controls.Add(this.label6);
            this.tpManual.Controls.Add(this.label4);
            this.tpManual.Controls.Add(this.txtDateCreation);
            this.tpManual.Controls.Add(this.label5);
            this.tpManual.Location = new System.Drawing.Point(4, 22);
            this.tpManual.Name = "tpManual";
            this.tpManual.Padding = new System.Windows.Forms.Padding(3);
            this.tpManual.Size = new System.Drawing.Size(216, 278);
            this.tpManual.TabIndex = 0;
            this.tpManual.Text = "Manual";
            this.tpManual.UseVisualStyleBackColor = true;
            // 
            // nudTimeETA
            // 
            this.nudTimeETA.Location = new System.Drawing.Point(97, 85);
            this.nudTimeETA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTimeETA.Name = "nudTimeETA";
            this.nudTimeETA.Size = new System.Drawing.Size(100, 20);
            this.nudTimeETA.TabIndex = 24;
            this.nudTimeETA.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTimeETA.Click += new System.EventHandler(this.nudTimeETA_Click);
            // 
            // nudUnitsManual
            // 
            this.nudUnitsManual.Location = new System.Drawing.Point(97, 48);
            this.nudUnitsManual.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudUnitsManual.Name = "nudUnitsManual";
            this.nudUnitsManual.Size = new System.Drawing.Size(100, 20);
            this.nudUnitsManual.TabIndex = 23;
            this.nudUnitsManual.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudUnitsManual.Click += new System.EventHandler(this.nudUnitsManual_Click);
            // 
            // lbxCompany
            // 
            this.lbxCompany.FormattingEnabled = true;
            this.lbxCompany.Location = new System.Drawing.Point(12, 84);
            this.lbxCompany.Name = "lbxCompany";
            this.lbxCompany.Size = new System.Drawing.Size(218, 56);
            this.lbxCompany.TabIndex = 12;
            this.lbxCompany.SelectedIndexChanged += new System.EventHandler(this.lbxCompany_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "Company:";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(177, 31);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(57, 23);
            this.Search.TabIndex = 14;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // CreateCases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 458);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbxCompany);
            this.Controls.Add(this.tabScan);
            this.Controls.Add(this.txtCodeFind);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lboxCases);
            this.Name = "CreateCases";
            this.Text = "CreateCases";
            this.Load += new System.EventHandler(this.CreateCases_Load);
            this.tabScan.ResumeLayout(false);
            this.tpScan.ResumeLayout(false);
            this.tpScan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitsScaner)).EndInit();
            this.tpManual.ResumeLayout(false);
            this.tpManual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeETA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitsManual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxCases;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDateFinish;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDateCreation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodeFind;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabScan;
        private System.Windows.Forms.TabPage tpManual;
        private System.Windows.Forms.TabPage tpScan;
        private System.Windows.Forms.Label lblMessageETA;
        private System.Windows.Forms.TextBox txtBarCodeScanned;
        private System.Windows.Forms.NumericUpDown nudUnitsScaner;
        private System.Windows.Forms.NumericUpDown nudUnitsManual;
        private System.Windows.Forms.NumericUpDown nudTimeETA;
        private System.Windows.Forms.ListBox lbxCompany;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Search;
    }
}