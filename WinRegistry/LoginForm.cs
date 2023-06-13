using SsCommon;
using Microsoft.Win32;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinRegistry
{
    public partial class LoginForm : Form
    {

        string KeyValue = "SOFTWARE\\Czemi\\WinRegLesson";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void changeformdate() // not quite useful, but need to see
        {
            dtp_DateOf.Value = DateTime.Now;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            RegistryKey key;
            object item;

            key = Registry.CurrentUser.OpenSubKey(KeyValue, true);
            if (key != null)
            {
                key.SetValue("user_name", this.txt_UserName.Text);
                key.SetValue("full_name", this.txt_FullName.Text);
                key.SetValue("Date", this.dtp_DateOf.Value);
                key.Close();
                this.Close();
            }
            else
                CommonProcs.Beep();

            // key.SetValue("")


        }

        private void btn_SaveLM_Click(object sender, EventArgs e)
        {
            if (!AdminUse.IsUserAdministrator())
            {
                CommonProcs.Beep();
                MessageBox.Show("Has to be run as Administrator for this option");
                return;
            }

            RegistryKey myRegKeys;
            RegistryKey key;

            myRegKeys = Registry.LocalMachine.OpenSubKey(KeyValue);

            if (myRegKeys == null)
            {
                Registry.LocalMachine.CreateSubKey(KeyValue, RegistryKeyPermissionCheck.ReadWriteSubTree);
                this.Text = "Login New";
            }

            key = Registry.LocalMachine.OpenSubKey(KeyValue, RegistryKeyPermissionCheck.ReadWriteSubTree); //This allows you to read and write
            if (key != null)
            {
                key.SetValue("user_name", this.txt_UserName.Text);
                key.SetValue("full_name", this.txt_FullName.Text);
                key.SetValue("Date", this.dtp_DateOf.Value);
                key.Close();
                this.Close();
            }
            else
                CommonProcs.Beep();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            RegistryKey myRegKeys;

            DateTimePickerFormat datePickerFormat = new DateTimePickerFormat();

            dtp_DateOf.Format = DateTimePickerFormat.Custom;
            dtp_DateOf.CustomFormat = "dd/MM/yyyy hh:mm:ss";

            myRegKeys = Registry.CurrentUser.OpenSubKey(KeyValue);

            if (myRegKeys == null) //Key doesn't exist
            {
                Registry.CurrentUser.CreateSubKey(KeyValue, RegistryKeyPermissionCheck.ReadWriteSubTree);
                this.Text = "Login New";
                changeformdate();
            }
            else
            {
                object objt;

                if ((objt = myRegKeys.GetValue("user_name")) != null)
                {
                    this.txt_UserName.Text = objt.ToString();
                }
                if ((objt = myRegKeys.GetValue("full_name")) != null)
                {
                    this.txt_FullName.Text = objt.ToString();
                }
                if ((objt = myRegKeys.GetValue("Date")) != null)
                {

                    this.dtp_DateOf.Value = DateTime.Parse(objt.ToString());
                }
                objt = myRegKeys.GetValue("ConfuseIt", "AAA"); // Give default value. Prevents giving error if doesn't exist

            }


        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.txt_FullName.Clear();
            this.txt_UserName.Clear();
            this.txt_Date.Clear();
        }
    }
}
