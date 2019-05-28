using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhymarcyApp_K30
{
    public static class Extencies
    {
        public static bool IsNotEmpty(string[]value,string checkInput)
        {
            foreach (var val in value)
            {
                if (val == checkInput)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
