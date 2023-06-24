using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static SsCommon.CommonProcs;
using static WinRegistry.RegChecks;
using static System.Resources.ResXFileRef;
using static WinRegistry.Globals;


namespace WinRegistry
{

    public partial class SaveInRegistry : Form
    {



        public SaveInRegistry()
        {
            InitializeComponent();
        }



        private void btnBackCol_Click(object sender, EventArgs e)
        {
            ColorConverter converter = new ColorConverter();
            string colorString;

            this.colourDialogue.ShowDialog();
            this.txt_TestText.BackColor = this.colourDialogue.Color;
            colorString = converter.ConvertToString(this.txt_TestText.BackColor);
            lbl_Backcolor.Text = colorString;
        }

        private void btnFrontCol_Click(object sender, EventArgs e)
        {
            ColorConverter converter = new ColorConverter();
            string colorString;

            this.colourDialogue.ShowDialog();
            this.txt_TestText.ForeColor = this.colourDialogue.Color;
            colorString = converter.ConvertToString(this.txt_TestText.ForeColor);
            lbl_Forecolor.Text = colorString;
        }

        private void SaveInRegistry_Load(object sender, EventArgs e)
        {
            ColorConverter playColor = new ColorConverter();

            CheckRegKeys();
            this.lbl_Forecolor.Text = playColor.ConvertToString(this.txt_TestText.ForeColor);
            this.lbl_Backcolor.Text = playColor.ConvertToString(this.txt_TestText.BackColor);
            btn_LoadColors_Click(sender, e);
            btn_LoadFont_Click(sender, e);

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            RegistryKey myRegKeys;
            ColorConverter playColor = new ColorConverter();
            string backColor;
            string foreColor;

            CheckRegKeys();

            myRegKeys = Registry.CurrentUser.OpenSubKey(subReg, RegistryKeyPermissionCheck.ReadWriteSubTree);
            foreColor = playColor.ConvertToString(this.txt_TestText.ForeColor);
            backColor = playColor.ConvertToString(this.txt_TestText.BackColor);
            myRegKeys.SetValue(myForeColor, foreColor);
            myRegKeys.SetValue(myBackColor, backColor);
            myRegKeys.Close(); // Empty buffer (I guess C is still bugging me)

        }

        private void btn_LoadColors_Click(object sender, EventArgs e)
        {
            RegistryKey regKey;
            string foreColor;
            string backColor;
            object objfc = null, objbc = null;

            ColorConverter playColor = new ColorConverter();

            CheckRegKeys();
            regKey = Registry.CurrentUser.OpenSubKey(subReg, true);

            objfc = regKey.GetValue(myForeColor, null);
            objbc = regKey.GetValue(myBackColor, null);
            if (objfc != null)
            {
                this.txt_TestText.ForeColor = (Color)playColor.ConvertFromString(objfc.ToString());
            }
            else
                this.txt_TestText.ForeColor = (Color)playColor.ConvertFromString("WindowText");

            if (objbc != null)
            {
                this.txt_TestText.BackColor = (Color)playColor.ConvertFromString(objbc.ToString());
            }
            else
                this.txt_TestText.BackColor = (Color)playColor.ConvertFromString("Window");
        }

        private void btn_Fonts_Click(object sender, EventArgs e)
        {
            FontConverter fontConverter = new FontConverter();
            string fontName;

            this.fontDialog1.ShowDialog();
            fontName = fontConverter.ConvertToString(this.fontDialog1.Font); //Font name for display
            this.txt_Fonts.Text = fontName; //Display name
            this.txt_Fonts.Font = this.fontDialog1.Font; //Set font
        }

        private void btn_SaveFont_Click(object sender, EventArgs e)
        {
            object objfc = null;
            RegistryKey regKey;
            string fontName;
            FontConverter fontConverter = new FontConverter();

            CheckRegKeys();
            regKey = Registry.CurrentUser.OpenSubKey(subReg, true);
            fontName = fontConverter.ConvertToString(this.fontDialog1.Font);
            if (fontName != null)
            {
                regKey.SetValue(myFont, fontName);
            }
            else
                MyBeep();
        }

        private void btn_LoadFont_Click(object sender, EventArgs e)
        {
            object obj;
            RegistryKey regKey;
            string fontName;
            FontConverter fontConverter = new FontConverter();

            CheckRegKeys();
            regKey = Registry.CurrentUser.OpenSubKey(subReg, true);

            obj = regKey.GetValue(myFont, null);

            if (obj != null)
            {
                fontName = obj.ToString(); // Get font name for display
                fontDialog1.Font = this.txt_Fonts.Font = (Font)fontConverter.ConvertFromString(obj.ToString()); //Set font
                this.txt_Fonts.Text = fontName;
            }
            else
            {
                this.txt_Fonts.Font = fontDialog1.Font;

            }

        }
    }
}
