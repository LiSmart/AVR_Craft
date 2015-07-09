using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AVR_Craft
{
    public class AVR_Controls : Control
    {
        public Control mObject;

        public enum ControlsTypes
        {
            //
            Start,                  //开始
            End,                    //结束
            //
            TwoBranch,              //二叉树(判断)
            //
            ForCycle,               //For循环
            WhileCycle,             //While循环
            DoWhileCycle,           //DoWhile循环
            //
            mTimer,                 //延时
            mCalculator,            //计算器
            //
            input,                  //输入
            output,                 //输出
            //
            init                    //初始化
        }

        public AVR_Controls(ControlsTypes mType, string mName, Object mValue,Point mLocation )
        {
            try
            {
                switch (mType)
                {
                    //
                    case ControlsTypes.Start:
                        mObject = new mButtonStart(mName, int.Parse(mValue.ToString()), mLocation);
                        break;
                    case ControlsTypes.End:
                        break;
                    //
                    case ControlsTypes.TwoBranch:
                        break;
                    //
                    case ControlsTypes.ForCycle:
                        break;
                    case ControlsTypes.WhileCycle:
                        break;
                    case ControlsTypes.DoWhileCycle:
                    //
                    case ControlsTypes.mTimer:
                        break;
                    case ControlsTypes.mCalculator:
                        break;
                    //
                    case ControlsTypes.input:
                        break;
                    case ControlsTypes.output:
                        break;
                    //
                    case ControlsTypes.init:
                        break;
                }
            }
            catch
            {
            }
        }

    }
}
