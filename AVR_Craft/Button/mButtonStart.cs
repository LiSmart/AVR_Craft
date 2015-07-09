using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AVR_Craft
{
    public class mButtonStart : mButton
    {
        private int mDelayTime;
        public int DelayTime
        {
            get { return mDelayTime; }
            set { mDelayTime = value; }
        }

        public mButtonStart(string mName, int mDelayTime, Point mLocation)
            : base(mName, "开始", mLocation)
        {
            this.DelayTime = mDelayTime;
            //MessageBox.Show("新按键！");
        }

    }
}
