using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace XMsgTest
{
    public partial class IconSelect : UserControl
    {
        public String IconFileSelected
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public Decimal ResourceIndexSelected
        {
            get { return numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }

        public IconSelect()
        {
            InitializeComponent();
        }

        private void DisplaySelectedIcon()
        {
        }

        private void SelectIconFile()
        {
            openFileDialog1.FileName = textBox1.Text;
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                textBox1.Text = openFileDialog1.FileName;
                DisplaySelectedIcon();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectIconFile();
        }
    }
}
