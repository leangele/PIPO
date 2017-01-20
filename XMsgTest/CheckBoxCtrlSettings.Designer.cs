namespace XMsgTest
{
    partial class CheckBoxCtrlSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkDisplayControl = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textControlCaption = new System.Windows.Forms.TextBox();
            this.checkCheckedStatus = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkDisplayControl
            // 
            this.checkDisplayControl.AutoSize = true;
            this.checkDisplayControl.Location = new System.Drawing.Point(155, 6);
            this.checkDisplayControl.Name = "checkDisplayControl";
            this.checkDisplayControl.Size = new System.Drawing.Size(101, 17);
            this.checkDisplayControl.TabIndex = 7;
            this.checkDisplayControl.Text = "Control is visible";
            this.checkDisplayControl.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Caption:";
            // 
            // textControlCaption
            // 
            this.textControlCaption.Location = new System.Drawing.Point(77, 38);
            this.textControlCaption.Name = "textControlCaption";
            this.textControlCaption.Size = new System.Drawing.Size(179, 20);
            this.textControlCaption.TabIndex = 9;
            // 
            // checkCheckedStatus
            // 
            this.checkCheckedStatus.AutoSize = true;
            this.checkCheckedStatus.Location = new System.Drawing.Point(20, 73);
            this.checkCheckedStatus.Name = "checkCheckedStatus";
            this.checkCheckedStatus.Size = new System.Drawing.Size(95, 17);
            this.checkCheckedStatus.TabIndex = 10;
            this.checkCheckedStatus.Text = "Check on start";
            this.checkCheckedStatus.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "CheckBox";
            // 
            // CheckBoxCtrlSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkCheckedStatus);
            this.Controls.Add(this.textControlCaption);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkDisplayControl);
            this.Name = "CheckBoxCtrlSettings";
            this.Size = new System.Drawing.Size(271, 111);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkDisplayControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textControlCaption;
        private System.Windows.Forms.CheckBox checkCheckedStatus;
        private System.Windows.Forms.Label label4;
    }
}
