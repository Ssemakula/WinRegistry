using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WinRegistry.Globals; // So we can use the constants


// This is simply to check if I can use code and variables across all modules irregardless
namespace WinRegistry
{
    public static class RegChecks
    {
        public static void CheckRegKeys() //Ensure reg keys exist
        {
            RegistryKey myRegKeys;

            myRegKeys = Registry.CurrentUser.OpenSubKey(mainReg);
            if (myRegKeys == null) //Key doesn't exist
            {
                Registry.CurrentUser.CreateSubKey(mainReg, RegistryKeyPermissionCheck.ReadWriteSubTree);
            }
            myRegKeys = Registry.CurrentUser.OpenSubKey(subReg); //Ensure Subkey exists (in case other things deleted it)
            if (myRegKeys == null) // Subkey does exist 
            {
                Registry.CurrentUser.CreateSubKey(subReg, RegistryKeyPermissionCheck.ReadWriteSubTree);
            }
        }

        public static bool ColorsExist()
        {
            object objFC, objBC;
            RegistryKey myRegKeys;

            myRegKeys = Registry.CurrentUser.OpenSubKey(mainReg, true);

            objFC = myRegKeys.GetValue(myForeColor, null);
            objBC = myRegKeys.GetValue(myBackColor, null);

            if (objFC != null && objBC != null) { return true; }
            return false;

        }

        public static bool WindSizeExist()
        {
            object obj;
            RegistryKey myRegKeys;

            myRegKeys = Registry.CurrentUser.OpenSubKey(subReg, true);

            obj = myRegKeys.GetValue(myWindSize, null);

            if (obj != null) { return true; }
            return false;

        }

        public static bool PanelPosExist()
        {
            object obj;
            RegistryKey myRegKeys;

            myRegKeys = Registry.CurrentUser.OpenSubKey(subReg, true);

            obj = myRegKeys.GetValue(myPanelPosition, null);

            if (obj != null) { return true; }
            return false;

        }
    }

 
    public static class Globals
    {
        public const string mainReg = "SOFTWARE\\Czemi";
        public const string subReg = "SOFTWARE\\Czemi\\WinRegLesson";
        public const string myBackColor = "myBackColor";
        public const string myForeColor = "myForeColor";
        public const string myFont = "myFont";
        public const string myWindSize = "WindowSize";
        public const string myPanelPosition = "myPanelPosition";
    }
}
