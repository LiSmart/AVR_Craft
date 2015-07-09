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
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.AddStartButton = new System.Windows.Forms.Button();
            this.ControlGroup = new System.Windows.Forms.GroupBox();
            this.CodeGroup = new System.Windows.Forms.GroupBox();
            this.CodeScrollBar = new System.Windows.Forms.VScrollBar();
            this.PropertyGroup = new System.Windows.Forms.GroupBox();
            this.PropertyChangeConfirm = new System.Windows.Forms.Button();
            this.ControlGroup.SuspendLayout();
            this.CodeGroup.SuspendLayout();
            this.PropertyGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddStartButton
            // 
            this.AddStartButton.Location = new System.Drawing.Point(6, 20);
            this.AddStartButton.Name = "AddStartButton";
            this.AddStartButton.Size = new System.Drawing.Size(100, 50);
            this.AddStartButton.TabIndex = 0;
            this.AddStartButton.Text = "开始";
            this.AddStartButton.UseVisualStyleBackColor = true;
            this.AddStartButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ControlGroup
            // 
            this.ControlGroup.Controls.Add(this.AddStartButton);
            this.ControlGroup.Location = new System.Drawing.Point(12, 15);
            this.ControlGroup.Name = "ControlGroup";
            this.ControlGroup.Size = new System.Drawing.Size(114, 655);
            this.ControlGroup.TabIndex = 1;
            this.ControlGroup.TabStop = false;
            this.ControlGroup.Text = "创建控件";
            // 
            // CodeGroup
            // 
            this.CodeGroup.Controls.Add(this.CodeScrollBar);
            this.CodeGroup.Location = new System.Drawing.Point(132, 15);
            this.CodeGroup.Name = "CodeGroup";
            this.CodeGroup.Size = new System.Drawing.Size(808, 655);
            this.CodeGroup.TabIndex = 2;
            this.CodeGroup.TabStop = false;
            this.CodeGroup.Text = "可视化编程";
            // 
            // CodeScrollBar
            // 
            this.CodeScrollBar.LargeChange = 125;
            this.CodeScrollBar.Location = new System.Drawing.Point(777, 20);
            this.CodeScrollBar.Maximum = 1000;
            this.CodeScrollBar.Name = "CodeScrollBar";
            this.CodeScrollBar.Size = new System.Drawing.Size(28, 632);
            this.CodeScrollBar.TabIndex = 0;
            this.CodeScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.CodeScrollBar_Scroll);
            // 
            // PropertyGroup
            // 
            this.PropertyGroup.Controls.Add(this.PropertyChangeConfirm);
            this.PropertyGroup.Location = new System.Drawing.Point(946, 15);
            this.PropertyGroup.Name = "PropertyGroup";
            this.PropertyGroup.Size = new System.Drawing.Size(226, 655);
            this.PropertyGroup.TabIndex = 3;
            this.PropertyGroup.TabStop = false;
            this.PropertyGroup.Text = "控件属性";
            // 
            // PropertyChangeConfirm
            // 
            this.PropertyChangeConfirm.Location = new System.Drawing.Point(17, 626);
            this.PropertyChangeConfirm.Name = "PropertyChangeConfirm";
            this.PropertyChangeConfirm.Size = new System.Drawing.Size(75, 23);
            this.PropertyChangeConfirm.TabIndex = 0;
            this.PropertyChangeConfirm.Text = "确认更改";
            this.PropertyChangeConfirm.UseVisualStyleBackColor = true;
            this.PropertyChangeConfirm.Click += new System.EventHandler(this.PropertyChangeConfirm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 682);
            this.Controls.Add(this.ControlGroup);
            this.Controls.Add(this.CodeGroup);
            this.Controls.Add(this.PropertyGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "可视化编程------SA索奥科技中心出品";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.ControlGroup.ResumeLayout(false);
            this.CodeGroup.ResumeLayout(false);
            this.PropertyGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddStartButton;
        private System.Windows.Forms.GroupBox ControlGroup;
        private System.Windows.Forms.GroupBox CodeGroup;
        private System.Windows.Forms.GroupBox PropertyGroup;
        private System.Windows.Forms.Label[] PropertyLabelArray;
        private System.Windows.Forms.TextBox[] PropertyTextBoxArray;
        private System.Windows.Forms.Button PropertyChangeConfirm;
        private System.Windows.Forms.Control ControlIndex;
        private int ControlsNumber = 0;
        private VScrollBar CodeScrollBar;
    }
}

