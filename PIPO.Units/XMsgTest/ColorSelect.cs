using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace XMsgTest
{
    public partial class ColorSelect : UserControl
    {
        public delegate void ColorSelectedHandler(Color c); //object sender, EventArgs e

        public event ColorSelectedHandler OnColorSelected;

        public bool UseSystemDefault
        {
            get { return checkUseDefault.Checked; }
            set { checkUseDefault.Checked = value; }
        }

        public int BackgroundMode
        {
            get
            {
                if (radioButton1.Checked) return 0;
                else return 1;
            }
            set
            {
                radioButton1.Checked = (value == 0);
            }
        }

        public String SelectedBitmapFile
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public int SelectedBrush
        {
            get { return comboBox1.SelectedIndex; }
            set { comboBox1.SelectedIndex = value; }
        }

        public String ControlCaption
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public Color SelectedColor
        {
            get { return panel1.BackColor; }
            set { panel1.BackColor = value; }
        }

        public ColorSelect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectColor();
        }

        private void SelectColor()
        {
            colorDialog1.Color = panel1.BackColor;
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                DisplaySelectedColor();
                OnColorSelected(colorDialog1.Color);
            }
        }

        private void DisplaySelectedColor()
        {
            if (radioButton1.Checked)
            {
                panel1.BackgroundImage = null;
                panel1.BackColor = colorDialog1.Color;
            }
            else
            {
                try
                {
                    panel1.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
                }
                catch
                {
                    panel1.BackgroundImage = null;
                }
            }
        }

        private void SelectBitmap()
        {
            openFileDialog1.FileName = textBox1.Text;
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                textBox1.Text = openFileDialog1.FileName;
                DisplaySelectedColor();
            }
        }

        private void ColorSelect_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            colorDialog1.Color = panel1.BackColor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelectBitmap();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                DisplaySelectedColor();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                DisplaySelectedColor();
            }
        }
    }
}
