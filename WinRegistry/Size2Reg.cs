using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SsCommon.CommonProcs;
using static WinRegistry.Globals;
using static WinRegistry.RegChecks;

namespace WinRegistry
{
    public partial class Size2Reg : Form
    {
        public Size2Reg()
        {
            InitializeComponent();
        }

        private void trackBar_height_ValueChanged(object sender, EventArgs e)
        {
            /*
             * Leeson is
             * int h, w;
             * w = this.txt_Sizable.Size.Width;
             * h = 381 - this.trackBar_height.Value;
             * this.this.txt_Sizable.Size = new Size(w, h);
             * 
             * I think my idea is leaner
             */

            this.txt_Sizable.Height = 381 - this.trackBar_height.Value; //Starting from high to low for visibility --lesson leaves it horizontal
        }

        private void trackBar_width_ValueChanged(object sender, EventArgs e)
        {
            /*
             * Leeson is
             * int h, w;
             * h = this.txt_Sizable.Size.Height;
             * w = this.trackBar_width.Value;
             * this.this.txt_Sizable.Size = new Size(w, h);
             * 
             * I think my idea is leaner
             */

            this.txt_Sizable.Width = this.trackBar_width.Value;
        }

        private void WinSizeSave()
        {
            RegistryKey myRegKeys;
            SizeConverter winSize = new SizeConverter();
            string winSizeString;

            CheckRegKeys();
            winSizeString = winSize.ConvertToString(this.txt_Sizable.Size);

            myRegKeys = Registry.CurrentUser.OpenSubKey(subReg, RegistryKeyPermissionCheck.ReadWriteSubTree);
            // Save in reg
            myRegKeys.SetValue(myWindSize, winSizeString);
            myRegKeys.Close();

        }

        private void WinSizeLoad()
        {
            RegistryKey myRegKeys;
            SizeConverter winSize = new SizeConverter();
            object obj;
            string winSizeString;

            CheckRegKeys();
            myRegKeys = Registry.CurrentUser.OpenSubKey(subReg, RegistryKeyPermissionCheck.ReadWriteSubTree);

            if (WindSizeExist())
            {
                obj = myRegKeys.GetValue(myWindSize, "20,20");
                winSizeString = obj.ToString();
                this.txt_Sizable.Size = (Size)winSize.ConvertFromString(winSizeString);
                this.trackBar_width.Value = this.txt_Sizable.Width;
                this.trackBar_height.Value = 381 - this.txt_Sizable.Height;
            }
            else
            {
                MessageBox.Show("Setting Defaults");
                this.txt_Sizable.Width = 20;
                this.txt_Sizable.Height = 20;
                this.trackBar_width.Value = 20;
                this.trackBar_height.Value = 381 - 20;
            }
            myRegKeys.Close();
        }

        private void PanelSizeSave()
        {
            RegistryKey myRegKeys;
            PointConverter panelPosition = new PointConverter();
            string panelPosString;

            CheckRegKeys();
            panelPosString = panelPosition.ConvertToString(this.panel_Size.Location);

            myRegKeys = Registry.CurrentUser.OpenSubKey(subReg, RegistryKeyPermissionCheck.ReadWriteSubTree);
            // Save in reg
            myRegKeys.SetValue(myPanelPosition, panelPosString);
            myRegKeys.Close();
        }

        private void PanelSizeLoad()
        {
            RegistryKey myRegKeys;
            PointConverter panelPosition = new PointConverter();
            string panelPosString;
            object obj;

            CheckRegKeys();
            myRegKeys = Registry.CurrentUser.OpenSubKey(subReg, RegistryKeyPermissionCheck.ReadWriteSubTree);

            if (PanelPosExist())
            {
                obj = myRegKeys.GetValue(myPanelPosition, "12,41");
                panelPosString = obj.ToString();
                this.panel_Size.Location = (Point)panelPosition.ConvertFromString(panelPosString);
                this.trackBar_XPanel.Value = this.panel_Size.Location.X;
                this.trackBar_YPanel.Value = 221 - this.panel_Size.Location.Y;
            }
            else
            {
                MessageBox.Show("Setting Defaults");
                this.panel_Size.Location = new Point(12, 41);
                this.trackBar_XPanel.Value = 12;
                this.trackBar_YPanel.Value = 221 - 41;
            }
            myRegKeys.Close();
        }

        private void Size2Reg_FormClosing(object sender, FormClosingEventArgs e)
        {
            WinSizeSave();
            PanelSizeSave();
        }

        private void Size2Reg_Load(object sender, EventArgs e)
        {
            WinSizeLoad();
            PanelSizeLoad();
        }

        private void trackBar_XPanel_ValueChanged(object sender, EventArgs e)
        {
            this.panel_Size.Location = new Point(this.trackBar_XPanel.Value, this.panel_Size.Location.Y);

        }

        private void trackBar_YPanel_ValueChanged(object sender, EventArgs e)
        {
            this.panel_Size.Location = new Point(this.panel_Size.Location.X, 221 - this.trackBar_YPanel.Value);
        }
    }
}
