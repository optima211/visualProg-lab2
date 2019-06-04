using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab2
{
    public partial class ColorForm : Form
    {
        private Color colorResult;
        public ColorForm()
        {
            InitializeComponent();        
        }

        private void buttonOther_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Scroll_Red.Value = colorDialog.Color.R;
                Scroll_Green.Value = colorDialog.Color.G;
                Scroll_Blue.Value = colorDialog.Color.B;

                colorResult = colorDialog.Color;

                UpdateColor();
            }
        }

        void UpdateColor()
        {
            colorResult = Color.FromArgb(Scroll_Red.Value, Scroll_Green.Value, Scroll_Blue.Value);

            numericUpDownRed.Value = Scroll_Red.Value;
            numericUpDownGreen.Value = Scroll_Green.Value;
            numericUpDownBlue.Value = Scroll_Blue.Value;


            pictureBox1.BackColor = colorResult;
        }
        private void ColorForm_Load(object sender, EventArgs e)
        {
            Form1 Main = this.Owner as Form1;
            if (Main != null)
            {
                colorResult = Main.currentPen.Color;
                pictureBox1.BackColor = colorResult;

                Scroll_Red.Value = colorResult.R;
                numericUpDownRed.Value = colorResult.R;

                Scroll_Green.Value = colorResult.G;
                numericUpDownGreen.Value = colorResult.G;

                Scroll_Blue.Value = colorResult.B;
                numericUpDownBlue.Value = colorResult.B;
            }

        }

        private void Scroll_Red_Scroll(object sender, ScrollEventArgs e)
        {
            numericUpDownRed.Value = Scroll_Red.Value;
            UpdateColor();
        }

        private void Scroll_Green_Scroll(object sender, ScrollEventArgs e)
        {
            numericUpDownGreen.Value = Scroll_Green.Value;
            UpdateColor();
        }

        private void Scroll_Blue_Scroll(object sender, ScrollEventArgs e)
        {
            numericUpDownBlue.Value = Scroll_Blue.Value;
            UpdateColor();
        }

        private void buttonChangeColor_Click(object sender, EventArgs e)
        {
            Form1 Main = this.Owner as Form1;

            Main.currentPen.Color = colorResult;
            this.Close();
        }

        private void numericUpDownRed_ValueChanged(object sender, EventArgs e)
        {
            Scroll_Red.Value = (int)numericUpDownRed.Value;
            UpdateColor();
        }

        private void numericUpDownGreen_ValueChanged(object sender, EventArgs e)
        {
            Scroll_Green.Value = (int)numericUpDownGreen.Value;
            UpdateColor();
        }

        private void numericUpDownBlue_ValueChanged(object sender, EventArgs e)
        {
            Scroll_Blue.Value = (int)numericUpDownBlue.Value;
            UpdateColor();
        }
    }
}
