using Microsoft.Win32;
using SsCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinRegistry
{
    public partial class SettingsForm : Form
    {
        string KeyValue = "SOFTWARE\\Czemi";
        string subKeyValue = "\\WinRegLesson";

        [Serializable()]
        struct SettingsData
        {
            public string coName, Manager, Advertising;
            public string Telephone, MobileTel, HandleName;
            public string ActivityDone, AddressCo, EmailCo, WebsiteCo;
            public string Language;
        }

        SettingsData herein = new SettingsData();


        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SetData()
        {
            herein.coName = txtCoName.Text;
            herein.Manager = txtManager.Text;
            herein.Advertising = txtAdvertising.Text;
            herein.Telephone = txtTel.Text;
            herein.MobileTel = txtMobile.Text;
            herein.HandleName = txtHandle.Text;
            herein.ActivityDone = txtActivity.Text;
            herein.AddressCo = txtAddress.Text;
            herein.EmailCo = txtEmail.Text;
            herein.WebsiteCo = txtWebsite.Text;
            herein.Language = comboLanguage.Text;
        }

        private void GetData()
        {
            txtCoName.Text = herein.coName;
            txtManager.Text = herein.Manager;
            txtAdvertising.Text = herein.Advertising;
            txtTel.Text = herein.Telephone;
            txtMobile.Text = herein.MobileTel;
            txtHandle.Text = herein.HandleName;
            txtActivity.Text = herein.ActivityDone;
            txtAddress.Text = herein.AddressCo;
            txtEmail.Text = herein.EmailCo;
            txtWebsite.Text = herein.WebsiteCo;
            comboLanguage.Text = herein.Language;
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            RegistryKey myRegKeys, myRegKeySub;

            myRegKeys = Registry.CurrentUser.OpenSubKey(KeyValue);

            if (myRegKeys == null) //Key doesn't exist
            {
                Registry.CurrentUser.CreateSubKey(KeyValue, RegistryKeyPermissionCheck.ReadWriteSubTree);
            }
            myRegKeys = Registry.CurrentUser.OpenSubKey(KeyValue + subKeyValue);
            if (myRegKeys == null) // Subkey does exist 
            {
                Registry.CurrentUser.CreateSubKey(KeyValue + subKeyValue, RegistryKeyPermissionCheck.ReadWriteSubTree);
            }

            // Read entries and save to struct
            SetData();
            // Save struct to registry ???
            if ((myRegKeys = Registry.CurrentUser.OpenSubKey(KeyValue + subKeyValue, true)) != null)
            // if(myRegKeys != null)
            {
                myRegKeys.SetValue("AppSettings", herein, RegistryValueKind.Unknown);
                myRegKeys.Close();
            }
            else
                CommonProcs.Beep();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            btnSaveChanges_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            RegistryKey myRegKeys, myRegKeySub;

            myRegKeys = Registry.CurrentUser.OpenSubKey(KeyValue);

            if (myRegKeys == null) //Key doesn't exist
            {
                CommonProcs.Beep();
                return;
            }
            myRegKeys = Registry.CurrentUser.OpenSubKey(KeyValue + subKeyValue);
            if (myRegKeys == null) // Subkey does exist 
            {
                CommonProcs.Beep();
                return;
            }

            // Delete
            if ((myRegKeys = Registry.CurrentUser.OpenSubKey(KeyValue + subKeyValue, true)) != null)
            // if(myRegKeys != null) i.e check whether it exists first
            {
                myRegKeys.Close(); //Not so sure if this is necessary. Pur in for completeness to avoid deleting open key
                Registry.CurrentUser.DeleteSubKey(KeyValue + subKeyValue, false); // Delete and ignore any exceptions
                // delete value behaves the same myRegKeys.DeleteValue(<value>, false);
            }
            else
                CommonProcs.Beep();
        }
    }
}
