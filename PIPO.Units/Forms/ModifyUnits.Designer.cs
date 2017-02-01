namespace LabTrack.Forms
{
    partial class ModifyUnits
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
            this.btnSave = new System.Windows.Forms.Button();
            this.nudUnits = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblCase = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnits)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(175, 33);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // nudUnits
            // 
            this.nudUnits.Location = new System.Drawing.Point(71, 33);
            this.nudUnits.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudUnits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudUnits.Name = "nudUnits";
            this.nudUnits.Size = new System.Drawing.Size(98, 20);
            this.nudUnits.TabIndex = 1;
            this.nudUnits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Units";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Case:";
            // 
            // LblCase
            // 
            this.LblCase.AutoSize = true;
            this.LblCase.Location = new System.Drawing.Point(68, 9);
            this.LblCase.Name = "LblCase";
            this.LblCase.Size = new System.Drawing.Size(30, 13);
            this.LblCase.TabIndex = 4;
            this.LblCase.Text = "case";
            // 
            // ModifyUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 68);
            this.Controls.Add(this.LblCase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudUnits);
            this.Controls.Add(this.btnSave);
            this.Name = "ModifyUnits";
            this.Text = "ModifyUnits";
            this.Load += new System.EventHandler(this.ModifyUnits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudUnits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown nudUnits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblCase;
    }
}