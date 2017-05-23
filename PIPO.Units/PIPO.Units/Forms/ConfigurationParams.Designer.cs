namespace LabTrack.Forms
{
    partial class ConfigurationParams
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
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lblNameConfig = new System.Windows.Forms.Label();
            this.dgvConfig = new System.Windows.Forms.DataGridView();
            this.q = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfig)).BeginInit();
            this.SuspendLayout();
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(171, 217);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 20);
            this.txtValue.TabIndex = 7;
            // 
            // lblNameConfig
            // 
            this.lblNameConfig.AutoSize = true;
            this.lblNameConfig.Location = new System.Drawing.Point(32, 220);
            this.lblNameConfig.Name = "lblNameConfig";
            this.lblNameConfig.Size = new System.Drawing.Size(37, 13);
            this.lblNameConfig.TabIndex = 6;
            this.lblNameConfig.Text = "Config";
            // 
            // dgvConfig
            // 
            this.dgvConfig.AllowUserToAddRows = false;
            this.dgvConfig.AllowUserToDeleteRows = false;
            this.dgvConfig.AllowUserToOrderColumns = true;
            this.dgvConfig.AllowUserToResizeRows = false;
            this.dgvConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConfig.Location = new System.Drawing.Point(31, 51);
            this.dgvConfig.MultiSelect = false;
            this.dgvConfig.Name = "dgvConfig";
            this.dgvConfig.ReadOnly = true;
            this.dgvConfig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConfig.ShowCellErrors = false;
            this.dgvConfig.Size = new System.Drawing.Size(240, 150);
            this.dgvConfig.TabIndex = 8;
            this.dgvConfig.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConfig_CellContentClick);
            this.dgvConfig.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConfig_CellDoubleClick);
            this.dgvConfig.SelectionChanged += new System.EventHandler(this.dgvConfig_SelectionChanged);
            // 
            // q
            // 
            this.q.Location = new System.Drawing.Point(166, 16);
            this.q.Name = "q";
            this.q.Size = new System.Drawing.Size(100, 20);
            this.q.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search";
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(171, 243);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 11;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // ConfigurationParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 273);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.q);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvConfig);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lblNameConfig);
            this.Name = "ConfigurationParams";
            this.Text = "ConfigurationParams";
            this.Load += new System.EventHandler(this.ConfigurationParams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label lblNameConfig;
        private System.Windows.Forms.DataGridView dgvConfig;
        private System.Windows.Forms.TextBox q;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModify;
    }
}