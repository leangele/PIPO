namespace LabTrack.UserControls
{
    partial class TimerMessageBox
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
            this.timClose = new System.Windows.Forms.Timer(this.components);
            this.lblMesage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timClose
            // 
            this.timClose.Tick += new System.EventHandler(this.timClose_Tick);
            // 
            // lblMesage
            // 
            this.lblMesage.AutoSize = true;
            this.lblMesage.Location = new System.Drawing.Point(39, 71);
            this.lblMesage.Name = "lblMesage";
            this.lblMesage.Size = new System.Drawing.Size(35, 13);
            this.lblMesage.TabIndex = 0;
            this.lblMesage.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "This message will be closed in:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(396, 180);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(21, 13);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "##";
            // 
            // TimerMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMesage);
            this.Name = "TimerMessageBox";
            this.Size = new System.Drawing.Size(434, 204);
            this.Load += new System.EventHandler(this.TimerMessageBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timClose;
        private System.Windows.Forms.Label lblMesage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCount;
    }
}
