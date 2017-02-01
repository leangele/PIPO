namespace LabTrack.Forms
{
    partial class FinishCase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDataEnd = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Unit1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdArea1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label24 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.dtpDateClose = new System.Windows.Forms.DateTimePicker();
            this.lblDateClose = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDataEnd
            // 
            this.dgvDataEnd.AllowUserToAddRows = false;
            this.dgvDataEnd.AllowUserToDeleteRows = false;
            this.dgvDataEnd.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvDataEnd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataEnd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
            this.Unit1,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn21,
            this.IdArea1,
            this.Company1});
            this.dgvDataEnd.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvDataEnd.Location = new System.Drawing.Point(5, 95);
            this.dgvDataEnd.Name = "dgvDataEnd";
            this.dgvDataEnd.ReadOnly = true;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgvDataEnd.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDataEnd.RowTemplate.ReadOnly = true;
            this.dgvDataEnd.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataEnd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDataEnd.Size = new System.Drawing.Size(1031, 243);
            this.dgvDataEnd.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Id";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dataGridViewTextBoxColumn15.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn15.HeaderText = "ID";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn15.Width = 75;
            // 
            // Unit1
            // 
            this.Unit1.DataPropertyName = "Unit";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unit1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Unit1.HeaderText = "IU";
            this.Unit1.Name = "Unit1";
            this.Unit1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Area";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dataGridViewTextBoxColumn20.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn20.HeaderText = "AREA";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Code";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dataGridViewTextBoxColumn16.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn16.HeaderText = "CODE";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 65;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "DtRecive";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle5.Format = "G";
            dataGridViewCellStyle5.NullValue = null;
            this.dataGridViewTextBoxColumn17.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn17.HeaderText = "RECEIVED";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 240;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "dtStart";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle6.Format = "G";
            this.dataGridViewTextBoxColumn18.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn18.HeaderText = "STARTED";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 240;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "DtFinish";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle7.Format = "G";
            this.dataGridViewTextBoxColumn19.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn19.HeaderText = "FINISHED";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 240;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Incharge";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dataGridViewTextBoxColumn21.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn21.HeaderText = "TECHNICIAN";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // IdArea1
            // 
            this.IdArea1.DataPropertyName = "IdArea";
            this.IdArea1.HeaderText = "IdArea";
            this.IdArea1.Name = "IdArea1";
            this.IdArea1.ReadOnly = true;
            this.IdArea1.Visible = false;
            // 
            // Company1
            // 
            this.Company1.DataPropertyName = "Company";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Company1.DefaultCellStyle = dataGridViewCellStyle9;
            this.Company1.HeaderText = "Company";
            this.Company1.Name = "Company1";
            this.Company1.ReadOnly = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(230, 35);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(60, 25);
            this.label24.TabIndex = 32;
            this.label24.Text = "Code";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(331, 30);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 30);
            this.txtCode.TabIndex = 31;
            this.txtCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCode_KeyPress);
            // 
            // dtpDateClose
            // 
            this.dtpDateClose.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtpDateClose.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateClose.Location = new System.Drawing.Point(122, 38);
            this.dtpDateClose.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dtpDateClose.Name = "dtpDateClose";
            this.dtpDateClose.ShowCheckBox = true;
            this.dtpDateClose.Size = new System.Drawing.Size(102, 20);
            this.dtpDateClose.TabIndex = 33;
            this.dtpDateClose.ValueChanged += new System.EventHandler(this.dtpDateClose_ValueChanged);
            // 
            // lblDateClose
            // 
            this.lblDateClose.AutoSize = true;
            this.lblDateClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateClose.Location = new System.Drawing.Point(12, 35);
            this.lblDateClose.Name = "lblDateClose";
            this.lblDateClose.Size = new System.Drawing.Size(104, 25);
            this.lblDateClose.TabIndex = 34;
            this.lblDateClose.Text = "Date close";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(230, 35);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(75, 25);
            this.lblSearch.TabIndex = 36;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(331, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 30);
            this.txtSearch.TabIndex = 35;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // FinishCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 344);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblDateClose);
            this.Controls.Add(this.dtpDateClose);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.dgvDataEnd);
            this.Name = "FinishCase";
            this.Text = "FinishCase";
            this.Load += new System.EventHandler(this.FinishCase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDataEnd;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdArea1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.DateTimePicker dtpDateClose;
        private System.Windows.Forms.Label lblDateClose;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}