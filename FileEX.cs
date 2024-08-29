using PluginAPI.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YUYUDIR
{
    public static class FileEX
    {
        public static bool IsExits(this string value)
        {
            return File.Exists(value);
        }
        public static string 读取(this string va,string 项)
        {
            
            var Re = "null";
            if (va.IsExits())
            {
                foreach (var item in File.ReadAllLines(va))
                {
                    if (item.Contains(项))
                    {
                        Re = item.Split('=')[1];
                        break;
                    }
                }
            }
            return Re;

        }
        public static void 写入(this string va, string 项,string 值)
        {
            try
            {
                var Line = 项 + "=" + 值;
                if (va.IsExits())
                {

                    var A = File.ReadAllText(va);
                    
                    if (A.Contains(项))
                    {
                        A.Replace(A.读取(项), 值);
                    }
                    else
                    {
                        if (A.EndsWith("\r\n"))
                        {
                            A += Line;
                        }
                        else
                        {
                            A += "\r\n" + Line;
                        }

                    }
                    File.WriteAllText(va, A);
                }
                else
                {
                    File.WriteAllText(va,Line);
                }
             
            }
            catch (Exception ex) { Logger.Err(ex.Message); }
            
        }

    }
}
