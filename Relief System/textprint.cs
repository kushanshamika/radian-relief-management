﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Relief_System
{
    class textprint:Program
    {
        public static void relwrite()
        {
            sw = new StreamWriter("../../Relief Text//TeacherID-1003_Date-"+date+"_Relief.html");
            reltext = "<!doctype html><html><head><style>th{text-align: center;background-color: aqua;}td{text-align: center;}</style><meta charset='utf-8'><title>Relief</title></head><body><b><font face='Century Gothic'><h2 align=center>Relief For 1001</h2><table align=center border='1' width ='400px' cellspacing='0' cellpadding='10'><tr><th>Period</th><th>Class</th></tr><tr><td>One</td><td>-</td></tr><tr><td>Two</td><td>-</td></tr><tr><td>Three</td><td>-</td></tr><tr><td>Four</td><td>-</td></tr><tr><td>Five</td><td>-</td></tr><tr><td>Six</td><td>-</td></tr><tr><td>Seven</td><td>-</td></tr><tr><td>Eight</td><td>-</td></tr></table></font></b></body></html>";
            sw.WriteLine(reltext);
            sw.Flush();
            sw.Close();
        }

    }
}