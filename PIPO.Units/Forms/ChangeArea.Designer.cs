namespace LabTrack.Forms
{
    partial class ChangeArea
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxNewArea = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOldArea = new System.Windows.Forms.Label();
            this.lblOldTechnitian = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "New area";
            // 
            // cbxNewArea
            // 
            this.cbxNewArea.FormattingEnabled = true;
            this.cbxNewArea.Location = new System.Drawing.Point(76, 36);
            this.cbxNewArea.Name = "cbxNewArea";
            this.cbxNewArea.Size = new System.Drawing.Size(121, 21);
            this.cbxNewArea.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(238, 34);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Old area";
            // 
            // lblOldArea
            // 
            this.lblOldArea.AutoSize = true;
            this.lblOldArea.Location = new System.Drawing.Point(73, 9);
            this.lblOldArea.Name = "lblOldArea";
            this.lblOldArea.Size = new System.Drawing.Size(47, 13);
            this.lblOldArea.TabIndex = 4;
            this.lblOldArea.Text = "Old area";
            // 
            // lblOldTechnitian
            // 
            this.lblOldTechnitian.AutoSize = true;
            this.lblOldTechnitian.Location = new System.Drawing.Point(247, 9);
            this.lblOldTechnitian.Name = "lblOldTechnitian";
            this.lblOldTechnitian.Size = new System.Drawing.Size(72, 13);
            this.lblOldTechnitian.TabIndex = 6;
            this.lblOldTechnitian.Text = "Old technitian";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Technitian";
            // 
            // Change_Area
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 93);
            this.Controls.Add(this.lblOldTechnitian);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblOldArea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbxNewArea);
            this.Controls.Add(this.label1);
            this.Name = "ChangeArea";
            this.Text = "Change_Area";
            this.Load += new System.EventHandler(this.Change_Area_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxNewArea;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOldArea;
        private System.Windows.Forms.Label lblOldTechnitian;
        private System.Windows.Forms.Label label4;
    }
}