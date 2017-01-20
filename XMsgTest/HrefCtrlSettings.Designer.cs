namespace XMsgTest
{
    partial class HrefCtrlSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.textHref = new System.Windows.Forms.TextBox();
            this.textAlias = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonColor = new System.Windows.Forms.Button();
            this.labelHref = new System.Windows.Forms.Label();
            this.checkDisplayControl = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Href:";
            // 
            // textHref
            // 
            this.textHref.Location = new System.Drawing.Point(68, 48);
            this.textHref.Name = "textHref";
            this.textHref.Size = new System.Drawing.Size(186, 20);
            this.textHref.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textHref, "Enter valid HTTP or HTTPS resource");
            // 
            // textAlias
            // 
            this.textAlias.Location = new System.Drawing.Point(68, 74);
            this.textAlias.Name = "textAlias";
            this.textAlias.Size = new System.Drawing.Size(186, 20);
            this.textAlias.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textAlias, "Optional alias to be displayed for the resource");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alias:";
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(182, 101);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(72, 23);
            this.buttonColor.TabIndex = 4;
            this.buttonColor.Text = "ForeColor";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // labelHref
            // 
            this.labelHref.AutoSize = true;
            this.labelHref.ForeColor = System.Drawing.Color.Blue;
            this.labelHref.Location = new System.Drawing.Point(65, 106);
            this.labelHref.Name = "labelHref";
            this.labelHref.Size = new System.Drawing.Size(38, 13);
            this.labelHref.TabIndex = 5;
            this.labelHref.Text = "http://";
            // 
            // checkDisplayControl
            // 
            this.checkDisplayControl.AutoSize = true;
            this.checkDisplayControl.Location = new System.Drawing.Point(153, 7);
            this.checkDisplayControl.Name = "checkDisplayControl";
            this.checkDisplayControl.Size = new System.Drawing.Size(101, 17);
            this.checkDisplayControl.TabIndex = 6;
            this.checkDisplayControl.Text = "Control is visible";
            this.checkDisplayControl.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Web Link";
            // 
            // HrefCtrlSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkDisplayControl);
            this.Controls.Add(this.labelHref);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.textAlias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textHref);
            this.Controls.Add(this.label1);
            this.Name = "HrefCtrlSettings";
            this.Size = new System.Drawing.Size(269, 136);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textHref;
        private System.Windows.Forms.TextBox textAlias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Label labelHref;
        private System.Windows.Forms.CheckBox checkDisplayControl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
