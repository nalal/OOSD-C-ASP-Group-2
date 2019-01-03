using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ADMIN_OOSD
{
    public class ErrHandle
    {
        public static bool isThere(string id)
        {
            bool result = false;
            if (FileIO.fileIsThere(id) == true)
            {
                result = true;
            }
            return result;
        }
    }
}
