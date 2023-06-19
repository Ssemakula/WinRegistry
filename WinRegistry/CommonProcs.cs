using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SsCommon
{
    public class AdminUse //Use this for system level stuff
    {
        public static bool IsUserAdministrator()
        {
            bool isAdmin;
            try
            {
                WindowsIdentity user = WindowsIdentity.GetCurrent(); // Get user
                WindowsPrincipal principal = new WindowsPrincipal(user); //Get the role of the user reutns enum WindowsBuiltInRole (int)
                isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator); //Check if it's administrator
            }
            catch (UnauthorizedAccessException) // I wonder if a parameter is neccessary here
            {
                isAdmin = false;
            }
            catch (Exception) // or here
            {
                isAdmin = false;
            }
            return isAdmin;
        }
    }

 
    public class CommonProcs //Use this for application level stuff
    {
        public static void Beep() //Make a system beep
        {
            SystemSounds.Beep.Play();
        }
    }
}
