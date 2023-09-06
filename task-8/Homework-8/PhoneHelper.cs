using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
{
    public static class PhoneHelper
    {
       public static bool IsPhoneValid(string str)
        {
            bool buffer = true;

            if (str.Length != 13 || !str.StartsWith("+375"))
            { buffer = false; }
            if (buffer)
            {
                for (int i = 4; i < str.Length; i++)
                {

                    if (str[i] < 0 && str[i] > 9)
                    {
                        buffer = false;
                    }

                }
            }
            return buffer;
            
        }
    }
}
