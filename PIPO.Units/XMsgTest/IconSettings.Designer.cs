namespace XMsgTest
{
    partial class IconSettings
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
            this.components = new System.ComponentModel.Container();
            this.checkIconWebLink = new System.Windows.Forms.CheckBox();
            this.textIconWebLink = new System.Windows.Forms.TextBox();
            this.checkUdfIconsEnabled = new System.Windows.Forms.CheckBox();
            this.iconSelect1 = new XMsgTest.IconSelect();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // checkIconWebLink
            // 
            this.checkIconWebLink.AutoSize = true;
            this.checkIconWebLink.Location = new System.Drawing.Point(14, 183);
            this.checkIconWebLink.Name = "checkIconWebLink";
            this.checkIconWebLink.Size = new System.Drawing.Size(224, 17);
            this.checkIconWebLink.TabIndex = 8;
            this.checkIconWebLink.Text = "Mouse click on the icon opens web page:";
            this.checkIconWebLink.UseVisualStyleBackColor = true;
            // 
            // textIconWebLink
            // 
            this.textIconWebLink.Location = new System.Drawing.Point(32, 206);
            this.textIconWebLink.MaxLength = 260;
            this.textIconWebLink.Name = "textIconWebLink";
            this.textIconWebLink.Size = new System.Drawing.Size(288, 20);
            this.textIconWebLink.TabIndex = 7;
            this.toolTip1.SetToolTip(this.textIconWebLink, "Enter valid HTTP or HTTPS resource");
            // 
            // checkUdfIconsEnabled
            // 
            this.checkUdfIconsEnabled.AutoSize = true;
            this.checkUdfIconsEnabled.Location = new System.Drawing.Point(14, 12);
            this.checkUdfIconsEnabled.Name = "checkUdfIconsEnabled";
            this.checkUdfIconsEnabled.Size = new System.Drawing.Size(179, 17);
            this.checkUdfIconsEnabled.TabIndex = 5;
            this.checkUdfIconsEnabled.Text = "Enable user-defined dialog icons";
            this.checkUdfIconsEnabled.UseVisualStyleBackColor = true;
            // 
            // iconSelect1
            // 
            this.iconSelect1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iconSelect1.IconFileSelected = "";
            this.iconSelect1.Location = new System.Drawing.Point(14, 50);
            this.iconSelect1.Name = "iconSelect1";
            this.iconSelect1.ResourceIndexSelected = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.iconSelect1.Size = new System.Drawing.Size(306, 116);
            this.iconSelect1.TabIndex = 6;
            // 
            // IconSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkIconWebLink);
            this.Controls.Add(this.textIconWebLink);
            this.Controls.Add(this.checkUdfIconsEnabled);
            this.Controls.Add(this.iconSelect1);
            this.Name = "IconSettings";
            this.Size = new System.Drawing.Size(334, 244);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkIconWebLink;
        private System.Windows.Forms.TextBox textIconWebLink;
        private System.Windows.Forms.CheckBox checkUdfIconsEnabled;
        private IconSelect iconSelect1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
