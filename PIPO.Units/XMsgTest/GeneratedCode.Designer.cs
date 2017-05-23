namespace XMsgTest
{
    partial class GeneratedCode
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textCodeCS = new System.Windows.Forms.TextBox();
            this.textCodeVB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(39, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "C#";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(48, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(39, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "VB";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textCodeCS
            // 
            this.textCodeCS.BackColor = System.Drawing.Color.Azure;
            this.textCodeCS.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCodeCS.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.textCodeCS.Location = new System.Drawing.Point(3, 26);
            this.textCodeCS.Multiline = true;
            this.textCodeCS.Name = "textCodeCS";
            this.textCodeCS.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textCodeCS.Size = new System.Drawing.Size(673, 269);
            this.textCodeCS.TabIndex = 2;
            // 
            // textCodeVB
            // 
            this.textCodeVB.BackColor = System.Drawing.Color.OldLace;
            this.textCodeVB.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCodeVB.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textCodeVB.Location = new System.Drawing.Point(3, 26);
            this.textCodeVB.Multiline = true;
            this.textCodeVB.Name = "textCodeVB";
            this.textCodeVB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textCodeVB.Size = new System.Drawing.Size(673, 272);
            this.textCodeVB.TabIndex = 3;
            this.textCodeVB.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "To Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GeneratedCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textCodeVB);
            this.Controls.Add(this.textCodeCS);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Name = "GeneratedCode";
            this.Size = new System.Drawing.Size(679, 298);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textCodeCS;
        private System.Windows.Forms.TextBox textCodeVB;
        private System.Windows.Forms.Button button1;
    }
}
