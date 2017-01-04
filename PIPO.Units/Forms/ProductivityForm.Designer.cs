namespace PIPO.Units.Forms
{
    partial class ProductivityForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.lblArea = new System.Windows.Forms.Label();
            this.cbxArea = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCasesCosedToday = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCasesOpenToday = new System.Windows.Forms.Label();
            this.lblAreaName = new System.Windows.Forms.Label();
            this.lblAreaNamePrinted = new System.Windows.Forms.Label();
            this.lblNamePerson = new System.Windows.Forms.Label();
            this.cbxAreasInform = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(313, 3);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 30);
            this.txtCode.TabIndex = 0;
            this.txtCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCode_KeyPress);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(247, 6);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(60, 25);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "Code";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToOrderColumns = true;
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvData.Location = new System.Drawing.Point(13, 42);
            this.dgvData.Name = "dgvData";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.Size = new System.Drawing.Size(723, 296);
            this.dgvData.TabIndex = 3;
            this.dgvData.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvData_RowPrePaint);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(13, 6);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(54, 25);
            this.lblArea.TabIndex = 4;
            this.lblArea.Text = "Area";
            // 
            // cbxArea
            // 
            this.cbxArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxArea.FormattingEnabled = true;
            this.cbxArea.Location = new System.Drawing.Point(73, 3);
            this.cbxArea.Name = "cbxArea";
            this.cbxArea.Size = new System.Drawing.Size(168, 33);
            this.cbxArea.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(628, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Area";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCasesCosedToday);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblCasesOpenToday);
            this.panel1.Controls.Add(this.lblAreaName);
            this.panel1.Controls.Add(this.lblAreaNamePrinted);
            this.panel1.Controls.Add(this.lblNamePerson);
            this.panel1.Location = new System.Drawing.Point(12, 384);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 169);
            this.panel1.TabIndex = 9;
            // 
            // lblCasesCosedToday
            // 
            this.lblCasesCosedToday.AutoSize = true;
            this.lblCasesCosedToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCasesCosedToday.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCasesCosedToday.Location = new System.Drawing.Point(184, 121);
            this.lblCasesCosedToday.Name = "lblCasesCosedToday";
            this.lblCasesCosedToday.Size = new System.Drawing.Size(42, 25);
            this.lblCasesCosedToday.TabIndex = 17;
            this.lblCasesCosedToday.Text = "xxx";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(12, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cases Closed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cases open";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Name Person";
            // 
            // lblCasesOpenToday
            // 
            this.lblCasesOpenToday.AutoSize = true;
            this.lblCasesOpenToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCasesOpenToday.Location = new System.Drawing.Point(184, 85);
            this.lblCasesOpenToday.Name = "lblCasesOpenToday";
            this.lblCasesOpenToday.Size = new System.Drawing.Size(42, 25);
            this.lblCasesOpenToday.TabIndex = 15;
            this.lblCasesOpenToday.Text = "xxx";
            // 
            // lblAreaName
            // 
            this.lblAreaName.AutoSize = true;
            this.lblAreaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaName.Location = new System.Drawing.Point(12, 18);
            this.lblAreaName.Name = "lblAreaName";
            this.lblAreaName.Size = new System.Drawing.Size(111, 25);
            this.lblAreaName.TabIndex = 10;
            this.lblAreaName.Text = "Name Area";
            // 
            // lblAreaNamePrinted
            // 
            this.lblAreaNamePrinted.AutoSize = true;
            this.lblAreaNamePrinted.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaNamePrinted.Location = new System.Drawing.Point(184, 18);
            this.lblAreaNamePrinted.Name = "lblAreaNamePrinted";
            this.lblAreaNamePrinted.Size = new System.Drawing.Size(42, 25);
            this.lblAreaNamePrinted.TabIndex = 11;
            this.lblAreaNamePrinted.Text = "xxx";
            // 
            // lblNamePerson
            // 
            this.lblNamePerson.AutoSize = true;
            this.lblNamePerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamePerson.Location = new System.Drawing.Point(184, 50);
            this.lblNamePerson.Name = "lblNamePerson";
            this.lblNamePerson.Size = new System.Drawing.Size(42, 25);
            this.lblNamePerson.TabIndex = 13;
            this.lblNamePerson.Text = "xxx";
            // 
            // cbxAreasInform
            // 
            this.cbxAreasInform.FormattingEnabled = true;
            this.cbxAreasInform.Location = new System.Drawing.Point(54, 357);
            this.cbxAreasInform.Name = "cbxAreasInform";
            this.cbxAreasInform.Size = new System.Drawing.Size(121, 21);
            this.cbxAreasInform.TabIndex = 10;
            this.cbxAreasInform.SelectedIndexChanged += new System.EventHandler(this.cbxAreasInform_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(506, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Actual Time";
            // 
            // ProductivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 631);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxAreasInform);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxArea);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txtCode);
            this.Name = "ProductivityForm";
            this.Text = "ProductivityForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cbxArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAreaNamePrinted;
        private System.Windows.Forms.Label lblAreaName;
        private System.Windows.Forms.Label lblNamePerson;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCasesCosedToday;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCasesOpenToday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxAreasInform;
        private System.Windows.Forms.Label label3;
    }
}

