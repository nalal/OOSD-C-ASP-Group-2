using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_ADMIN_OOSD
{
    public class ErrHandle
    {
        //Check if file exists
        public static bool isThere(string id)
        {
            bool result = false;
            //Call FileIO to test if file exists
            if (FileIO.fileIsThere(id) == true)
            {
                result = true;
            }
            return result;
        }
        //Check if string is null
        public static bool isNonNull(string content)
        {
            bool result = true;
            //check if string has a value
            if (content != "" || content != null)
            {
                result = false;
            }
            return result;
        }
        //Error message return
        public static void message()
        {
            MessageBox.Show("There was an issue validating your input","INPUT ERROR");
        }
    }
}
