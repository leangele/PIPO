namespace XMsgTest
{
    partial class DimensionSettings
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
            this.checkSetDlgDimensions = new System.Windows.Forms.CheckBox();
            this.textDlgMaxHeight = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.textDlgMaxWidth = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.textDlgMaxHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDlgMaxWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // checkSetDlgDimensions
            // 
            this.checkSetDlgDimensions.AutoSize = true;
            this.checkSetDlgDimensions.Location = new System.Drawing.Point(14, 12);
            this.checkSetDlgDimensions.Name = "checkSetDlgDimensions";
            this.checkSetDlgDimensions.Size = new System.Drawing.Size(132, 17);
            this.checkSetDlgDimensions.TabIndex = 14;
            this.checkSetDlgDimensions.Text = "Set Dialog Dimensions";
            this.checkSetDlgDimensions.UseVisualStyleBackColor = true;
            // 
            // textDlgMaxHeight
            // 
            this.textDlgMaxHeight.Location = new System.Drawing.Point(116, 77);
            this.textDlgMaxHeight.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.textDlgMaxHeight.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            -2147483648});
            this.textDlgMaxHeight.Name = "textDlgMaxHeight";
            this.textDlgMaxHeight.Size = new System.Drawing.Size(76, 20);
            this.textDlgMaxHeight.TabIndex = 13;
            this.toolTip1.SetToolTip(this.textDlgMaxHeight, "0 to disable; (-) to force; (+) to limit");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Max.Height:";
            // 
            // textDlgMaxWidth
            // 
            this.textDlgMaxWidth.Location = new System.Drawing.Point(116, 50);
            this.textDlgMaxWidth.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.textDlgMaxWidth.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            -2147483648});
            this.textDlgMaxWidth.Name = "textDlgMaxWidth";
            this.textDlgMaxWidth.Size = new System.Drawing.Size(76, 20);
            this.textDlgMaxWidth.TabIndex = 11;
            this.toolTip1.SetToolTip(this.textDlgMaxWidth, "0 to disable; (-) to force; (+) to limit");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Max.Width:";
            // 
            // DimensionSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkSetDlgDimensions);
            this.Controls.Add(this.textDlgMaxHeight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textDlgMaxWidth);
            this.Controls.Add(this.label4);
            this.Name = "DimensionSettings";
            this.Size = new System.Drawing.Size(208, 111);
            ((System.ComponentModel.ISupportInitialize)(this.textDlgMaxHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDlgMaxWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkSetDlgDimensions;
        private System.Windows.Forms.NumericUpDown textDlgMaxHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown textDlgMaxWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
