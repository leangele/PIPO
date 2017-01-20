namespace XMsgTest
{
    partial class MessageSettings
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
            this.checkMessageWebLink = new System.Windows.Forms.CheckBox();
            this.textMessageWebLink = new System.Windows.Forms.TextBox();
            this.textDlgMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.textDlgCaption = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMessageFontName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericTimeout = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericTimeout)).BeginInit();
            this.SuspendLayout();
            // 
            // checkMessageWebLink
            // 
            this.checkMessageWebLink.AutoSize = true;
            this.checkMessageWebLink.Location = new System.Drawing.Point(84, 195);
            this.checkMessageWebLink.Name = "checkMessageWebLink";
            this.checkMessageWebLink.Size = new System.Drawing.Size(246, 17);
            this.checkMessageWebLink.TabIndex = 14;
            this.checkMessageWebLink.Text = "Mouse click on the message opens web page:";
            this.checkMessageWebLink.UseVisualStyleBackColor = true;
            // 
            // textMessageWebLink
            // 
            this.textMessageWebLink.Location = new System.Drawing.Point(84, 218);
            this.textMessageWebLink.MaxLength = 260;
            this.textMessageWebLink.Name = "textMessageWebLink";
            this.textMessageWebLink.Size = new System.Drawing.Size(333, 20);
            this.textMessageWebLink.TabIndex = 13;
            this.toolTip1.SetToolTip(this.textMessageWebLink, "Enter valid HTTP or HTTPS resource");
            // 
            // textDlgMessage
            // 
            this.textDlgMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDlgMessage.Location = new System.Drawing.Point(84, 46);
            this.textDlgMessage.Multiline = true;
            this.textDlgMessage.Name = "textDlgMessage";
            this.textDlgMessage.Size = new System.Drawing.Size(333, 83);
            this.textDlgMessage.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Message:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Message Font";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textDlgCaption
            // 
            this.textDlgCaption.Location = new System.Drawing.Point(84, 9);
            this.textDlgCaption.Name = "textDlgCaption";
            this.textDlgCaption.Size = new System.Drawing.Size(333, 20);
            this.textDlgCaption.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Caption:";
            // 
            // labelMessageFontName
            // 
            this.labelMessageFontName.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessageFontName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelMessageFontName.Location = new System.Drawing.Point(423, 72);
            this.labelMessageFontName.Name = "labelMessageFontName";
            this.labelMessageFontName.Size = new System.Drawing.Size(164, 57);
            this.labelMessageFontName.TabIndex = 18;
            this.labelMessageFontName.Text = "Arial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Timeout, ms:";
            // 
            // numericTimeout
            // 
            this.numericTimeout.Location = new System.Drawing.Point(84, 149);
            this.numericTimeout.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.numericTimeout.Name = "numericTimeout";
            this.numericTimeout.Size = new System.Drawing.Size(74, 20);
            this.numericTimeout.TabIndex = 20;
            this.toolTip1.SetToolTip(this.numericTimeout, "Setting to 0 disables timeout");
            // 
            // MessageSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericTimeout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelMessageFontName);
            this.Controls.Add(this.textDlgCaption);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkMessageWebLink);
            this.Controls.Add(this.textMessageWebLink);
            this.Controls.Add(this.textDlgMessage);
            this.Controls.Add(this.label1);
            this.Name = "MessageSettings";
            this.Size = new System.Drawing.Size(602, 252);
            ((System.ComponentModel.ISupportInitialize)(this.numericTimeout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkMessageWebLink;
        private System.Windows.Forms.TextBox textMessageWebLink;
        private System.Windows.Forms.TextBox textDlgMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox textDlgCaption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMessageFontName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericTimeout;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
