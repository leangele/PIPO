namespace XMsgTest
{
    partial class BackgroundSettings
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
            this.checkUdfBackcolorsEnabled = new System.Windows.Forms.CheckBox();
            this.colorSelect2 = new XMsgTest.ColorSelect();
            this.colorSelect1 = new XMsgTest.ColorSelect();
            this.SuspendLayout();
            // 
            // checkUdfBackcolorsEnabled
            // 
            this.checkUdfBackcolorsEnabled.AutoSize = true;
            this.checkUdfBackcolorsEnabled.Checked = true;
            this.checkUdfBackcolorsEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkUdfBackcolorsEnabled.Location = new System.Drawing.Point(12, 10);
            this.checkUdfBackcolorsEnabled.Name = "checkUdfBackcolorsEnabled";
            this.checkUdfBackcolorsEnabled.Size = new System.Drawing.Size(211, 17);
            this.checkUdfBackcolorsEnabled.TabIndex = 5;
            this.checkUdfBackcolorsEnabled.Text = "Enable user-defined background colors";
            this.checkUdfBackcolorsEnabled.UseVisualStyleBackColor = true;
            // 
            // colorSelect2
            // 
            this.colorSelect2.BackgroundMode = 0;
            this.colorSelect2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorSelect2.ControlCaption = "Toolbar Background";
            this.colorSelect2.Location = new System.Drawing.Point(275, 45);
            this.colorSelect2.Name = "colorSelect2";
            this.colorSelect2.SelectedBitmapFile = "";
            this.colorSelect2.SelectedBrush = 0;
            this.colorSelect2.SelectedColor = System.Drawing.Color.Silver;
            this.colorSelect2.Size = new System.Drawing.Size(257, 211);
            this.colorSelect2.TabIndex = 7;
            this.colorSelect2.UseSystemDefault = false;
            this.colorSelect2.OnColorSelected += new XMsgTest.ColorSelect.ColorSelectedHandler(this.colorSelect2_OnColorSelected);
            // 
            // colorSelect1
            // 
            this.colorSelect1.BackgroundMode = 0;
            this.colorSelect1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorSelect1.ControlCaption = "Main Background";
            this.colorSelect1.Location = new System.Drawing.Point(12, 45);
            this.colorSelect1.Name = "colorSelect1";
            this.colorSelect1.SelectedBitmapFile = "";
            this.colorSelect1.SelectedBrush = 0;
            this.colorSelect1.SelectedColor = System.Drawing.Color.Silver;
            this.colorSelect1.Size = new System.Drawing.Size(257, 211);
            this.colorSelect1.TabIndex = 6;
            this.colorSelect1.UseSystemDefault = false;
            this.colorSelect1.OnColorSelected += new XMsgTest.ColorSelect.ColorSelectedHandler(this.colorSelect1_OnColorSelected);
            // 
            // BackgroundSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.colorSelect2);
            this.Controls.Add(this.colorSelect1);
            this.Controls.Add(this.checkUdfBackcolorsEnabled);
            this.Name = "BackgroundSettings";
            this.Size = new System.Drawing.Size(544, 277);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkUdfBackcolorsEnabled;
        private ColorSelect colorSelect1;
        private ColorSelect colorSelect2;
    }
}
