namespace XMsgTest
{
    partial class DialogButtonSettings
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
            this.labelButtonName = new System.Windows.Forms.Label();
            this.checkButtonDisabled = new System.Windows.Forms.CheckBox();
            this.textButtonCaption = new System.Windows.Forms.TextBox();
            this.textButtonTooltip = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // labelButtonName
            // 
            this.labelButtonName.AutoSize = true;
            this.labelButtonName.Location = new System.Drawing.Point(-3, 4);
            this.labelButtonName.Name = "labelButtonName";
            this.labelButtonName.Size = new System.Drawing.Size(66, 13);
            this.labelButtonName.TabIndex = 0;
            this.labelButtonName.Text = "ButtonName";
            // 
            // checkButtonDisabled
            // 
            this.checkButtonDisabled.AutoSize = true;
            this.checkButtonDisabled.Location = new System.Drawing.Point(72, 4);
            this.checkButtonDisabled.Name = "checkButtonDisabled";
            this.checkButtonDisabled.Size = new System.Drawing.Size(38, 17);
            this.checkButtonDisabled.TabIndex = 1;
            this.checkButtonDisabled.Text = "off";
            this.checkButtonDisabled.UseVisualStyleBackColor = true;
            // 
            // textButtonCaption
            // 
            this.textButtonCaption.Location = new System.Drawing.Point(116, 1);
            this.textButtonCaption.Name = "textButtonCaption";
            this.textButtonCaption.Size = new System.Drawing.Size(62, 20);
            this.textButtonCaption.TabIndex = 2;
            // 
            // textButtonTooltip
            // 
            this.textButtonTooltip.Location = new System.Drawing.Point(232, 1);
            this.textButtonTooltip.Name = "textButtonTooltip";
            this.textButtonTooltip.Size = new System.Drawing.Size(80, 20);
            this.textButtonTooltip.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Font";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DialogButtonSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textButtonTooltip);
            this.Controls.Add(this.textButtonCaption);
            this.Controls.Add(this.checkButtonDisabled);
            this.Controls.Add(this.labelButtonName);
            this.Name = "DialogButtonSettings";
            this.Size = new System.Drawing.Size(319, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelButtonName;
        private System.Windows.Forms.CheckBox checkButtonDisabled;
        private System.Windows.Forms.TextBox textButtonCaption;
        private System.Windows.Forms.TextBox textButtonTooltip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}
