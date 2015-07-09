using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace AVR_Craft
{
    public class mButton : Button
    {
        private Point Location_temp;
        private Point Location_now;
        private bool IsMouseDown;
        private bool IsMouseMoved;

        public mButton(string mName,string mText, Point mLocation)
        {
            this.Name = mName;
            this.Location = mLocation;
            this.Text = mText;
            this.Size = new Size(60, 37);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            //SolidBrush mBrush = new SolidBrush(Color.Red);
            //pevent.Graphics.FillRectangle(mBrush,pevent.ClipRectangle);
        }

        protected override void OnClick(EventArgs e)
        {
            if (!this.IsMouseMoved)
            {
                base.OnClick(e);
                MessageBox.Show("Override CLICK！");
            }
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            this.IsMouseMoved = false;
            this.IsMouseDown = true;
            this.Location_temp = mevent.Location;
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            this.IsMouseMoved = false;
            this.IsMouseDown = false;
            this.Location_now = mevent.Location;
            this.Location = new Point(this.Location.X - (this.Location_temp.X - this.Location_now.X),
                                      this.Location.Y - (this.Location_temp.Y - this.Location_now.Y));
            this.Location = new Point(this.Location.X > 0 ? this.Location.X : 0,
                                      this.Location.Y > 0 ? this.Location.Y : 0);
            this.Location = new Point(this.Location.X < 800 ? this.Location.X : 800,
                                      this.Location.Y < 800 ? this.Location.Y : 800);
        }

        protected override void OnMouseMove(MouseEventArgs mevent)
        {
            IsMouseMoved = true;
            if (IsMouseDown)
            {
                this.Location_now = mevent.Location;
                if((Math.Abs(this.Location_temp.X - this.Location_now.X)>3)||(Math.Abs(this.Location_temp.Y - this.Location_now.Y)>3)) 
                    this.Location = new Point(  this.Location.X - (this.Location_temp.X - this.Location_now.X),
                                                this.Location.Y - (this.Location_temp.Y - this.Location_now.Y));
            }
        }

        protected override void OnKeyDown(KeyEventArgs kevent)
        {
            //base.OnKeyDown(kevent);
            if (kevent.KeyCode.ToString().Equals("Delete"))
                if (MessageBox.Show("Delete"+this.Text+"?","按钮删除",MessageBoxButtons.OKCancel)== DialogResult.OK)
                {
                    this.Dispose();
                }
        }

        protected override void OnMove(EventArgs e)
        {
            base.OnMove(e);
        }
    }
}
