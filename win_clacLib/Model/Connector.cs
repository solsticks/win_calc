using System;
using System.Collections.Generic;
using System.Text;

namespace win_calc
{
   public static class Connector
    {
        public static Iwin_Calc Ifuse { get; set; }

        public static void PlugFuse()
        {
            Operations fusing = new Operations();
            Ifuse = fusing;
        }
    }
}
