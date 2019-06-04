namespace lab2
{
    partial class ColorForm
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
            this.Scroll_Red = new System.Windows.Forms.HScrollBar();
            this.buttonOther = new System.Windows.Forms.Button();
            this.Scroll_Green = new System.Windows.Forms.HScrollBar();
            this.Scroll_Blue = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonChangeColor = new System.Windows.Forms.Button();
            this.numericUpDownRed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGreen = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBlue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // Scroll_Red
            // 
            this.Scroll_Red.Location = new System.Drawing.Point(174, 16);
            this.Scroll_Red.Maximum = 255;
            this.Scroll_Red.Name = "Scroll_Red";
            this.Scroll_Red.Size = new System.Drawing.Size(350, 31);
            this.Scroll_Red.TabIndex = 0;
            this.Scroll_Red.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Scroll_Red_Scroll);
            // 
            // buttonOther
            // 
            this.buttonOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOther.Location = new System.Drawing.Point(422, 153);
            this.buttonOther.Name = "buttonOther";
            this.buttonOther.Size = new System.Drawing.Size(102, 38);
            this.buttonOther.TabIndex = 1;
            this.buttonOther.Text = "Other Colors";
            this.buttonOther.UseVisualStyleBackColor = true;
            this.buttonOther.Click += new System.EventHandler(this.buttonOther_Click);
            // 
            // Scroll_Green
            // 
            this.Scroll_Green.Location = new System.Drawing.Point(174, 62);
            this.Scroll_Green.Maximum = 255;
            this.Scroll_Green.Name = "Scroll_Green";
            this.Scroll_Green.Size = new System.Drawing.Size(350, 31);
            this.Scroll_Green.TabIndex = 2;
            this.Scroll_Green.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Scroll_Green_Scroll);
            // 
            // Scroll_Blue
            // 
            this.Scroll_Blue.Location = new System.Drawing.Point(174, 106);
            this.Scroll_Blue.Maximum = 255;
            this.Scroll_Blue.Name = "Scroll_Blue";
            this.Scroll_Blue.Size = new System.Drawing.Size(350, 31);
            this.Scroll_Blue.TabIndex = 3;
            this.Scroll_Blue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Scroll_Blue_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(147, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(147, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(147, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "B";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 128);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // buttonChangeColor
            // 
            this.buttonChangeColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeColor.Location = new System.Drawing.Point(174, 153);
            this.buttonChangeColor.Name = "buttonChangeColor";
            this.buttonChangeColor.Size = new System.Drawing.Size(102, 38);
            this.buttonChangeColor.TabIndex = 8;
            this.buttonChangeColor.Text = "Ok";
            this.buttonChangeColor.UseVisualStyleBackColor = true;
            this.buttonChangeColor.Click += new System.EventHandler(this.buttonChangeColor_Click);
            // 
            // numericUpDownRed
            // 
            this.numericUpDownRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownRed.Location = new System.Drawing.Point(548, 16);
            this.numericUpDownRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownRed.Name = "numericUpDownRed";
            this.numericUpDownRed.Size = new System.Drawing.Size(79, 31);
            this.numericUpDownRed.TabIndex = 9;
            this.numericUpDownRed.ValueChanged += new System.EventHandler(this.numericUpDownRed_ValueChanged);
            // 
            // numericUpDownGreen
            // 
            this.numericUpDownGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownGreen.Location = new System.Drawing.Point(548, 62);
            this.numericUpDownGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownGreen.Name = "numericUpDownGreen";
            this.numericUpDownGreen.Size = new System.Drawing.Size(79, 31);
            this.numericUpDownGreen.TabIndex = 10;
            this.numericUpDownGreen.ValueChanged += new System.EventHandler(this.numericUpDownGreen_ValueChanged);
            // 
            // numericUpDownBlue
            // 
            this.numericUpDownBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownBlue.Location = new System.Drawing.Point(548, 106);
            this.numericUpDownBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownBlue.Name = "numericUpDownBlue";
            this.numericUpDownBlue.Size = new System.Drawing.Size(79, 31);
            this.numericUpDownBlue.TabIndex = 11;
            this.numericUpDownBlue.ValueChanged += new System.EventHandler(this.numericUpDownBlue_ValueChanged);
            // 
            // ColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 203);
            this.Controls.Add(this.numericUpDownBlue);
            this.Controls.Add(this.numericUpDownGreen);
            this.Controls.Add(this.numericUpDownRed);
            this.Controls.Add(this.buttonChangeColor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Scroll_Blue);
            this.Controls.Add(this.Scroll_Green);
            this.Controls.Add(this.buttonOther);
            this.Controls.Add(this.Scroll_Red);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выберите цвет";
            this.Load += new System.EventHandler(this.ColorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar Scroll_Red;
        private System.Windows.Forms.Button buttonOther;
        private System.Windows.Forms.HScrollBar Scroll_Green;
        private System.Windows.Forms.HScrollBar Scroll_Blue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonChangeColor;
        private System.Windows.Forms.NumericUpDown numericUpDownRed;
        private System.Windows.Forms.NumericUpDown numericUpDownGreen;
        private System.Windows.Forms.NumericUpDown numericUpDownBlue;
    }
}