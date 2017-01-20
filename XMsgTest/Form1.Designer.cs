namespace XMsgTest
{
    partial class formXMsgTest
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
            this.button2 = new System.Windows.Forms.Button();
            this.chkDlgMonitor = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.messageSettings1 = new XMsgTest.MessageSettings();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dimensionSettings1 = new XMsgTest.DimensionSettings();
            this.positionSettings1 = new XMsgTest.PositionSettings();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.backgroundSettings1 = new XMsgTest.BackgroundSettings();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.iconSettings1 = new XMsgTest.IconSettings();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dialogButtonsSettings1 = new XMsgTest.DialogButtonsSettings();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.textInputCtrlSettings1 = new XMsgTest.TextInputCtrlSettings();
            this.checkBoxCtrlSettings1 = new XMsgTest.CheckBoxCtrlSettings();
            this.hrefCtrlSettings1 = new XMsgTest.HrefCtrlSettings();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.generatedCode1 = new XMsgTest.GeneratedCode();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripReturnedValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripTimeout = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripAuxButton = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripCheckBox = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripTextInput = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkGreen;
            this.button2.Location = new System.Drawing.Point(216, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "MessageBox.Show";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chkDlgMonitor
            // 
            this.chkDlgMonitor.AutoSize = true;
            this.chkDlgMonitor.Checked = true;
            this.chkDlgMonitor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDlgMonitor.Location = new System.Drawing.Point(398, 382);
            this.chkDlgMonitor.Name = "chkDlgMonitor";
            this.chkDlgMonitor.Size = new System.Drawing.Size(132, 17);
            this.chkDlgMonitor.TabIndex = 8;
            this.chkDlgMonitor.Text = "Extended Features On";
            this.chkDlgMonitor.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(10, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(699, 336);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.messageSettings1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(691, 310);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dialog";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // messageSettings1
            // 
            this.messageSettings1.DlgCaption = "Extended MessageBox .NET Assembly";
            this.messageSettings1.DlgMessage = "MessageBox Class displays a message box that can contain text, buttons, and symbo" +
                "ls that inform and instruct the user. To display a message box, call the static " +
                "method MessageBox.Show.";
            this.messageSettings1.DlgMessageBackColor = System.Drawing.SystemColors.Window;
            this.messageSettings1.DlgMessageFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageSettings1.DlgMessageForeColor = System.Drawing.Color.DarkSlateGray;
            this.messageSettings1.DlgMessageWebLink = "http://www.news2news.com/vfp/?solution=5";
            this.messageSettings1.DlgTimeout = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.messageSettings1.Location = new System.Drawing.Point(6, 6);
            this.messageSettings1.Name = "messageSettings1";
            this.messageSettings1.Size = new System.Drawing.Size(602, 252);
            this.messageSettings1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dimensionSettings1);
            this.tabPage3.Controls.Add(this.positionSettings1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(691, 310);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Position & Dimensions";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dimensionSettings1
            // 
            this.dimensionSettings1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dimensionSettings1.DialogMaxHeight = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dimensionSettings1.DialogMaxWidth = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.dimensionSettings1.ExtendedFeaturesEnabled = true;
            this.dimensionSettings1.Location = new System.Drawing.Point(15, 15);
            this.dimensionSettings1.Name = "dimensionSettings1";
            this.dimensionSettings1.Size = new System.Drawing.Size(228, 118);
            this.dimensionSettings1.TabIndex = 1;
            // 
            // positionSettings1
            // 
            this.positionSettings1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.positionSettings1.ExtendedFeaturesEnabled = true;
            this.positionSettings1.HorizontalAlign = 2;
            this.positionSettings1.Location = new System.Drawing.Point(249, 15);
            this.positionSettings1.Name = "positionSettings1";
            this.positionSettings1.PositionLeft = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.positionSettings1.PositionMode = 1;
            this.positionSettings1.PositionTop = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.positionSettings1.Size = new System.Drawing.Size(362, 118);
            this.positionSettings1.TabIndex = 0;
            this.positionSettings1.VerticalAlign = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.backgroundSettings1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(691, 310);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Background";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // backgroundSettings1
            // 
            this.backgroundSettings1.BackgroundColorMain = System.Drawing.Color.Lavender;
            this.backgroundSettings1.BackgroundColorToolbar = System.Drawing.Color.SlateGray;
            this.backgroundSettings1.Location = new System.Drawing.Point(6, 6);
            this.backgroundSettings1.Name = "backgroundSettings1";
            this.backgroundSettings1.SelectedBitmapFileMain = "";
            this.backgroundSettings1.SelectedBitmapFileToolbar = "";
            this.backgroundSettings1.SelectedBrushMain = XMsgLib.Dlg.XMessageBoxHatchStyle.HatchStyleNone;
            this.backgroundSettings1.SelectedBrushToolbar = XMsgLib.Dlg.XMessageBoxHatchStyle.HatchStyleNone;
            this.backgroundSettings1.Size = new System.Drawing.Size(544, 278);
            this.backgroundSettings1.TabIndex = 0;
            this.backgroundSettings1.OnBackgroundColorSelected += new XMsgTest.BackgroundSettings.BackgroundColorSelectedHandler(this.backgroundSettings1_OnBackgroundColorSelected);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.iconSettings1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(691, 310);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Icon";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // iconSettings1
            // 
            this.iconSettings1.ExtendedFeaturesEnabled = true;
            this.iconSettings1.IconFileSelected = "*.cs";
            this.iconSettings1.IconWebLink = "http://www.news2news.com/vfp/?solution=5";
            this.iconSettings1.IconWebLinkEnabled = false;
            this.iconSettings1.Location = new System.Drawing.Point(6, 6);
            this.iconSettings1.Name = "iconSettings1";
            this.iconSettings1.ResourceIndexSelected = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.iconSettings1.Size = new System.Drawing.Size(334, 250);
            this.iconSettings1.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.dialogButtonsSettings1);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(691, 310);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Buttons";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dialogButtonsSettings1
            // 
            this.dialogButtonsSettings1.DialogButtonsSelected = System.Windows.Forms.MessageBoxButtons.OKCancel;
            this.dialogButtonsSettings1.Location = new System.Drawing.Point(0, 6);
            this.dialogButtonsSettings1.Name = "dialogButtonsSettings1";
            this.dialogButtonsSettings1.Size = new System.Drawing.Size(664, 268);
            this.dialogButtonsSettings1.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.textInputCtrlSettings1);
            this.tabPage7.Controls.Add(this.checkBoxCtrlSettings1);
            this.tabPage7.Controls.Add(this.hrefCtrlSettings1);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(691, 310);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Additional Controls";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // textInputCtrlSettings1
            // 
            this.textInputCtrlSettings1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textInputCtrlSettings1.ControlCaption = "Enter Password:";
            this.textInputCtrlSettings1.ControlEnabled = false;
            this.textInputCtrlSettings1.ControlHeight = 20;
            this.textInputCtrlSettings1.ControlStyle = XMsgLib.Dlg.XMessageBoxEditControlStyles.Password;
            this.textInputCtrlSettings1.ControlWidth = 140;
            this.textInputCtrlSettings1.Location = new System.Drawing.Point(16, 16);
            this.textInputCtrlSettings1.Name = "textInputCtrlSettings1";
            this.textInputCtrlSettings1.Size = new System.Drawing.Size(381, 246);
            this.textInputCtrlSettings1.TabIndex = 2;
            // 
            // checkBoxCtrlSettings1
            // 
            this.checkBoxCtrlSettings1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkBoxCtrlSettings1.ControlCaption = "Record to application log";
            this.checkBoxCtrlSettings1.ControlCheckedStatus = false;
            this.checkBoxCtrlSettings1.ControlEnabled = false;
            this.checkBoxCtrlSettings1.Location = new System.Drawing.Point(403, 161);
            this.checkBoxCtrlSettings1.Name = "checkBoxCtrlSettings1";
            this.checkBoxCtrlSettings1.Size = new System.Drawing.Size(271, 101);
            this.checkBoxCtrlSettings1.TabIndex = 1;
            // 
            // hrefCtrlSettings1
            // 
            this.hrefCtrlSettings1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hrefCtrlSettings1.ControlEnabled = true;
            this.hrefCtrlSettings1.Location = new System.Drawing.Point(403, 16);
            this.hrefCtrlSettings1.Name = "hrefCtrlSettings1";
            this.hrefCtrlSettings1.SelectedAlias = "Extended MessageBox .NET web page";
            this.hrefCtrlSettings1.SelectedColor = System.Drawing.Color.Blue;
            this.hrefCtrlSettings1.SelectedHref = "http://www.news2news.com/vfp/?solution=5";
            this.hrefCtrlSettings1.Size = new System.Drawing.Size(271, 139);
            this.hrefCtrlSettings1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.generatedCode1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(691, 310);
            this.tabPage1.TabIndex = 7;
            this.tabPage1.Text = "Sample Code";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // generatedCode1
            // 
            this.generatedCode1.Location = new System.Drawing.Point(6, 6);
            this.generatedCode1.Name = "generatedCode1";
            this.generatedCode1.Size = new System.Drawing.Size(679, 298);
            this.generatedCode1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(721, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "&Program";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.runToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.runToolStripMenuItem.Text = "&Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(111, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel5,
            this.toolStripReturnedValue,
            this.toolStripStatusLabel4,
            this.toolStripTimeout,
            this.toolStripStatusLabel1,
            this.toolStripAuxButton,
            this.toolStripStatusLabel2,
            this.toolStripCheckBox,
            this.toolStripStatusLabel3,
            this.toolStripTextInput});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(721, 24);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(58, 19);
            this.toolStripStatusLabel5.Text = "Returned:";
            // 
            // toolStripReturnedValue
            // 
            this.toolStripReturnedValue.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripReturnedValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripReturnedValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.toolStripReturnedValue.Name = "toolStripReturnedValue";
            this.toolStripReturnedValue.Size = new System.Drawing.Size(14, 19);
            this.toolStripReturnedValue.Text = " ";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(108, 19);
            this.toolStripStatusLabel4.Text = "Closed on timeout:";
            // 
            // toolStripTimeout
            // 
            this.toolStripTimeout.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripTimeout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripTimeout.Name = "toolStripTimeout";
            this.toolStripTimeout.Size = new System.Drawing.Size(14, 19);
            this.toolStripTimeout.Text = " ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(83, 19);
            this.toolStripStatusLabel1.Text = "Aux.Button ID:";
            // 
            // toolStripAuxButton
            // 
            this.toolStripAuxButton.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripAuxButton.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripAuxButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripAuxButton.Name = "toolStripAuxButton";
            this.toolStripAuxButton.Size = new System.Drawing.Size(14, 19);
            this.toolStripAuxButton.Tag = "auxbutton";
            this.toolStripAuxButton.Text = " ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(90, 19);
            this.toolStripStatusLabel2.Text = "CheckBox state:";
            // 
            // toolStripCheckBox
            // 
            this.toolStripCheckBox.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripCheckBox.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripCheckBox.Name = "toolStripCheckBox";
            this.toolStripCheckBox.Size = new System.Drawing.Size(14, 19);
            this.toolStripCheckBox.Text = " ";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(63, 19);
            this.toolStripStatusLabel3.Text = "Text Input:";
            // 
            // toolStripTextInput
            // 
            this.toolStripTextInput.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripTextInput.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripTextInput.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripTextInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripTextInput.Name = "toolStripTextInput";
            this.toolStripTextInput.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripTextInput.Size = new System.Drawing.Size(14, 19);
            this.toolStripTextInput.Text = " ";
            // 
            // formXMsgTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 448);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.chkDlgMonitor);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formXMsgTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Testing Extended MessageBox .NET Assembly";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox chkDlgMonitor;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private MessageSettings messageSettings1;
        private PositionSettings positionSettings1;
        private BackgroundSettings backgroundSettings1;
        private IconSettings iconSettings1;
        private DialogButtonsSettings dialogButtonsSettings1;
        private DimensionSettings dimensionSettings1;
        private TextInputCtrlSettings textInputCtrlSettings1;
        private CheckBoxCtrlSettings checkBoxCtrlSettings1;
        private HrefCtrlSettings hrefCtrlSettings1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripAuxButton;
        private System.Windows.Forms.ToolStripStatusLabel toolStripCheckBox;
        private System.Windows.Forms.ToolStripStatusLabel toolStripTextInput;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.TabPage tabPage1;
        private GeneratedCode generatedCode1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripTimeout;
        private System.Windows.Forms.ToolStripStatusLabel toolStripReturnedValue;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;

    }
}

