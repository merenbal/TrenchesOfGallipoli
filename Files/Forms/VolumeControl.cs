using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trenches_of_Gallipoli.Files.Forms
{
    public partial class VolumeControl : UserControl
    {
        public VolumeControl()
        {
            InitializeComponent();
            this.Size = new Size(350,30);
            this.BackColor = Color.Black;
            DoubleBuffered = true;

        }

        int pb_Value = 40, pb_Min = 0, pb_Max = 100;

        public int Max { get { return pb_Max; } set { pb_Max = value; Invalidate(); } }
        public int Min { get { return pb_Min; } set { pb_Min = value; Invalidate(); } }
        public int Value { get { return pb_Value; } set { pb_Value = value; Invalidate(); } }
        public int gap = 10;

        Color b_color = Color.Aqua;
        public Color Bar_color { get {  return b_color; } set { b_color = value; Invalidate(); } }

        private void VolumeControl_Paint(object sender, PaintEventArgs e)
        {
            int start_point = 40;
            SolidBrush sb = new SolidBrush(Color.DimGray);
            for (int j = 0; j < (Max*ClientSize.Width/Max -75)/gap; j++)
            {
                e.Graphics.FillRectangle(sb, new Rectangle(start_point,0,gap-5,ClientSize.Height));
                start_point += gap;

            }

            int buffer_point = 40;
            SolidBrush br = new SolidBrush(b_color);

            for (int i = 0; i < (pb_Value* ClientSize.Width/Max - pb_Value) / gap; i++)
            {
                e.Graphics.FillRectangle(br, new Rectangle(buffer_point,0,gap-2,ClientSize.Height)) ;
                buffer_point += gap;

            }

            int thumsize = 25;
            SolidBrush thumb = new SolidBrush(Color.White);
            e.Graphics.FillRectangle(thumb,new Rectangle(buffer_point,0,thumsize,ClientSize.Height));

            if (pb_Value >= Min)
            {
                Image left_img = Properties.Resources.down_img;
                e.Graphics.DrawImage(left_img, 5, 0, ClientSize.Height, ClientSize.Height);
            }
            if (pb_Value <= 50)
            {
                Image right_img = Properties.Resources.mid_img;
                e.Graphics.DrawImage(right_img,ClientSize.Width -35,0,ClientSize.Height,ClientSize.Height);
            }
            if (pb_Value <= Min)
            {
                Image left_img = Properties.Resources.mute_img;
                e.Graphics.DrawImage(left_img, 5, 0, ClientSize.Height, ClientSize.Height);
            }
            if (pb_Value >= 50)
            {
                Image right_img = Properties.Resources.high_img;
                e.Graphics.DrawImage(right_img, ClientSize.Width - 35, 0, ClientSize.Height, ClientSize.Height);
            }
        }
        bool mouse = false;
        private void VolumeControl_MouseDown(object sender, MouseEventArgs e)
        {
            mouse=true;
            Bar_Value(thumb_value(e.X));
        }

        private void VolumeControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouse) return;
            Bar_Value(thumb_value(e.X) );
        }

        private void VolumeControl_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

        private void Bar_Value(float value)
        {
            if (value < Min) value = Min;
            if (value > Max) value = Max;
            if (pb_Value == value) return;
            pb_Value = (int)value;
            this.Refresh();
        }
        private float thumb_value(int x)
        {
            return Min+(Max-Min)*x / (float)(ClientSize.Width);
        }


    }
}
