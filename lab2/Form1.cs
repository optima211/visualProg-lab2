using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        bool drawing;
        int historyCounter;      

        GraphicsPath currentPath;
        Point oldLocation;
        public Pen currentPen;
        Color historyColor;     
        List<Image> History;    


        public Form1()
        {
            InitializeComponent();
            drawing = false;                     
            currentPen = new Pen(Color.Black);   
            currentPen.Width = trackBarPen.Value;  

            History = new List<Image>();          
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History.Clear();
            historyCounter = 0;

            if (picDrawingSurface.Image != null)
            {
                var result = MessageBox.Show("Сохранить текущее изображение перед созданием нового рисунка?", "Предупреждение", MessageBoxButtons.YesNoCancel);

                switch (result)
                {
                    case DialogResult.No: break;
                    case DialogResult.Yes: SaveMenu_Click(sender, e); break;
                    case DialogResult.Cancel: return;
                }
            }


            Bitmap pic = new Bitmap(750, 500);
            picDrawingSurface.Image = pic;
            Graphics g = Graphics.FromImage(picDrawingSurface.Image);

            g.Clear(Color.White);
            g.DrawImage(picDrawingSurface.Image, 0, 0, 750, 500);

           
            History.Add(new Bitmap(picDrawingSurface.Image));
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            NewToolStripMenuItem_Click(null, null);
        }

     

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            SaveMenu_Click(null, null);
        }

        private void SaveMenu_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDlg = new SaveFileDialog();
            SaveDlg.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            SaveDlg.Title = "Save an Image File";
            SaveDlg.FilterIndex = 4;    

            SaveDlg.ShowDialog();

            if (SaveDlg.FileName != "")     
            {
                System.IO.FileStream fs =
                    (System.IO.FileStream)SaveDlg.OpenFile();

                switch (SaveDlg.FilterIndex)
                {
                    case 1:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Jpeg);
                        break;

                    case 2:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Bmp);
                        break;

                    case 3:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Gif);
                        break;

                    case 4:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Png);
                        break;
                }

                fs.Close();
            }

        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OP = new OpenFileDialog();
            OP.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            OP.Title = "Open an Image File";
            OP.FilterIndex = 1; 

            if (OP.ShowDialog() != DialogResult.Cancel)
            {
                History.Clear();
                historyCounter = 0;
                picDrawingSurface.Load(OP.FileName);
                History.Add(new Bitmap(picDrawingSurface.Image));
            }
            picDrawingSurface.AutoSize = true;

        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            OpenToolStripMenuItem_Click(null, null);
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToolStripButton5_Click(object sender, EventArgs e)
        {
            ExitMenu_Click(null, null);
        }
        private void PicDrawingSurface_MouseDown(object sender, MouseEventArgs e)
        {
            if (picDrawingSurface.Image == null)
            {
                MessageBox.Show("Сначала создайте новый файл!");
                return;
            }

            if (e.Button == MouseButtons.Right)
            {
                historyColor = currentPen.Color;
                currentPen.Color = Color.White;
            }
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                drawing = true;
                oldLocation = e.Location;
                currentPath = new GraphicsPath();
            }

        }

        private void PicDrawingSurface_MouseUp(object sender, MouseEventArgs e)
        {
            History.RemoveRange(historyCounter + 1, History.Count - historyCounter - 1);
            History.Add(new Bitmap(picDrawingSurface.Image));
            if (historyCounter + 1 < 10) historyCounter++;
            if (History.Count - 1 == 10) History.RemoveAt(0);


            if ((e.Button & MouseButtons.Right) != 0)
            {
                currentPen.Color = historyColor;
            }
            drawing = false;
            try
            {
                currentPath.Dispose();
            }
            catch { };
        }

        private void PicDrawingSurface_MouseMove(object sender, MouseEventArgs e)
        {
            label_XY.Text = e.X.ToString() + ", " + e.Y.ToString();
            if (drawing)
            {
                Graphics g = Graphics.FromImage(picDrawingSurface.Image);
                currentPath.AddLine(oldLocation, e.Location);
                g.DrawPath(currentPen, currentPath);
                oldLocation = e.Location;
                g.Dispose();
                picDrawingSurface.Invalidate();
            }

        }

        private void TrackBarPen_Scroll(object sender, EventArgs e)
        {
            currentPen.Width = trackBarPen.Value;
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (History.Count != 0 && historyCounter != 0)
            {
                picDrawingSurface.Image = new Bitmap(History[--historyCounter]);
            }
            else MessageBox.Show("История пуста");
        }

        private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (historyCounter < History.Count - 1)
            {
                picDrawingSurface.Image = new Bitmap(History[++historyCounter]);
            }
            else MessageBox.Show("История пуста");

        }

        private void SolidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.Solid;

            solidStyleMenu.Checked = true;
            dotStyleMenu.Checked = false;
            dashDotDotStyleMenu.Checked = false;

        }

        private void DotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.DashDot;

            solidStyleMenu.Checked = false;
            dotStyleMenu.Checked = true;
            dashDotDotStyleMenu.Checked = false;
        }

        private void DashDotDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.DashDotDot;

            solidStyleMenu.Checked = false;
            dotStyleMenu.Checked = false;
            dashDotDotStyleMenu.Checked = true;
        }


        private void ColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorForm colorForm = new ColorForm();
            colorForm.Owner = this;
            colorForm.ShowDialog();
        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            ColorToolStripMenuItem_Click(null, null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
