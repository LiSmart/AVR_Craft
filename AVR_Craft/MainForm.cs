using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVR_Craft
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MyComponentInitialize();
        }

        void MyComponentInitialize()
        {
            this.PropertyLabelArray = new Label[10];
            for (int i = 0; i < 10; i++)
            {
                this.PropertyLabelArray[i] = new Label();
                this.PropertyLabelArray[i].Name = "Label" + i;
                this.PropertyLabelArray[i].Location = new Point(15, 32 + 30 * i);
                this.PropertyLabelArray[i].Text = "属性" + i;
                this.PropertyLabelArray[i].Size = new Size(60, 15);
                this.PropertyLabelArray[i].BackColor = Color.LightPink;
                this.PropertyLabelArray[i].Hide();
                this.PropertyGroup.Controls.Add(PropertyLabelArray[i]);
            }
            this.PropertyTextBoxArray = new TextBox[10];
            for (int i = 0; i < 10; i++)
            {
                this.PropertyTextBoxArray[i] = new TextBox();
                this.PropertyTextBoxArray[i].Name = "Label" + i;
                this.PropertyTextBoxArray[i].Location = new Point(80, 30 + 30 * i);
                this.PropertyTextBoxArray[i].Size = new Size(100, 30);
                this.PropertyTextBoxArray[i].BackColor = Color.LightGreen;
                this.PropertyTextBoxArray[i].Hide();
                this.PropertyGroup.Controls.Add(PropertyTextBoxArray[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AVR_Controls mbtn = new AVR_Controls
                (AVR_Craft.AVR_Controls.ControlsTypes.Start, "mStart" + ControlsNumber, 1000, new Point(500, 500));
            this.Controls.Add(mbtn.mObject);
            this.CodeGroup.Controls.Add(mbtn.mObject);
            mbtn.mObject.Click += ButtonClick;
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            ControlIndex = (Control)sender;
            switch (sender.ToString().Split(',')[0].Split('.')[1])
            {
                case "mButtonStart":
                    //MessageBox.Show("mButton_Start");
                    mButtonStart ButtonStart = (mButtonStart)ControlIndex;
                    this.PropertyLabelArray[0].Text = "启动延时";
                    this.PropertyLabelArray[0].Show();
                    this.PropertyTextBoxArray[0].Text = ButtonStart.DelayTime.ToString();
                    this.PropertyTextBoxArray[0].Show();
                    break;
                default     :
                    MessageBox.Show(sender.ToString().Split(',')[0].Split('.')[1]);
                    break;
            }
        }

        private void PropertyChangeConfirm_Click(object sender, EventArgs e)
        {
            switch (ControlIndex.ToString().Split(',')[0].Split('.')[1])
            {
                case "mButtonStart":
                    //MessageBox.Show("mButton_Start");
                    mButtonStart ButtonStart = (mButtonStart)ControlIndex;
                    ButtonStart.DelayTime = int.Parse(this.PropertyTextBoxArray[0].Text);
                    break;
                default:
                    MessageBox.Show(ControlIndex.ToString().Split(',')[0].Split('.')[1]);
                    break;
            }
            for (int i = 0; i < 10; i++)
            {
                this.PropertyLabelArray[i].Hide();
                this.PropertyTextBoxArray[i].Hide();
            }
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            this.PropertyGroup.Location = new Point(this.Size.Width - 250, 15);
            this.CodeGroup.Size = new Size(this.Size.Width -390,this.CodeGroup.Size.Height);
            this.CodeScrollBar.Location = new Point(this.CodeGroup.Size.Width - 35, 15);
        }

        private void CodeScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            foreach (Control Ctl in this.CodeGroup.Controls)
            {
                //MessageBox.Show(Ctl.GetType().ToString());
                if (Ctl.GetType().ToString().Contains("mButton"))
                    Ctl.Location = new Point(Ctl.Location.X, Ctl.Location.Y + (e.OldValue - e.NewValue));
            }
        }
    }
}
