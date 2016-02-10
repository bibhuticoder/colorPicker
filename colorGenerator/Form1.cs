using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colorGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            setBitmapSize();

        }

        Graphics gPic, gColor;
        int x, y = 0;
        private bool colorPicker = false;
        Bitmap picBitmap, colorBitmap;
        Color clr;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

      
        private void barRed_Scroll(object sender, EventArgs e)
        {
            setTracker();
        }

        private void setTracker()
        {
            //show color in pictureBox
            pbColorRGB.BackColor = Color.FromArgb(barRed.Value, barGreen.Value, barBlue.Value);

            //show different color values(RGB)
            lblRedValue.Text = pbColorRGB.BackColor.R.ToString();
            lblGreenValue.Text = pbColorRGB.BackColor.G.ToString();
            lblBlueValue.Text = pbColorRGB.BackColor.B.ToString();

            //show hex color code
            tbColor.Text = "#" + pbColorRGB.BackColor.R.ToString("X2") + pbColorRGB.BackColor.G.ToString("X2") + pbColorRGB.BackColor.B.ToString("X2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //copy the value of textbox to clipbopard
            Clipboard.SetText(tbColor.Text);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //show color picker
            colorPicker = true;

            lblPressP.Visible = true;


            // colorPicker = true;
            timerPicker.Start();

        }


        private void timerPicker_Tick(object sender, EventArgs e)
        {
            if (colorPicker)
            {
                //current mouse position
                x = Cursor.Position.X;
                y = Cursor.Position.Y;

                //zoom view
                gPic.CopyFromScreen(x - picSize / 2, y - picSize / 2, 0, 0, new Size(picSize, picSize));
                pbPicker.SizeMode = PictureBoxSizeMode.StretchImage;                
               pbPicker.Image = picBitmap;

                //single pixel colour
                gColor.CopyFromScreen(x, y, 0, 0, new Size(2, 2));
                clr = colorBitmap.GetPixel(1, 1);
                pbColorPicker.BackColor = clr;
                tbColorPickerHex.Text = "#" + clr.R.ToString("X2") + clr.G.ToString("X2") + clr.B.ToString("X2");

            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (colorPicker)
            {
                if (e.KeyCode == Keys.P)
                {
                    timerPicker.Stop();
                    Clipboard.SetText(tbColorPickerHex.Text);
                    MessageBox.Show("Color copied to clipboard");
                    barRed.Value = clr.R;
                    barGreen.Value = clr.G;
                    barBlue.Value = clr.B;
                    setTracker();
                    lblPressP.Visible = false;


                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnColorPickerCopy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(tbColorPickerHex.Text);
            }
            catch { }
        }

        private void pbPicker_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(pbPicker.Width / 2 - 2, pbPicker.Height / 2 - 2, 5, 5));
        }

        int picSize = 60;
        void setBitmapSize()
        {
            picBitmap = new Bitmap(picSize, picSize);
            colorBitmap = new Bitmap(2, 2);
            gPic = Graphics.FromImage(picBitmap as Image);
            gColor = Graphics.FromImage(colorBitmap as Image);
        }

        private void zoomFactor_Scroll(object sender, EventArgs e)
        {
            setBitmapSize();            
            picSize = 60 - zoomFactor.Value;
            lblZoomFactor.Text = (zoomFactor.Value - 5).ToString();
           
        }
    }
}


