using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YUYUDIR_Loader
{

    public class Loader
    { 
        [PluginEntryPoint("YUYUDIR","1.0","YUYUDIR框架","YF-OFFICE")]
        void Load()
        {
            if (Directory.Exists("C:\\YUYUDIR"))
            {
                YUYUDIR.Main.Start();
            }
            else
            {
                Log.Warning("YUYUDIR框架加载失败 未找到框架目录");
                Log.Warning("已创建框架目录 请重启服务器进行加载");
                Directory.CreateDirectory("C:\\YUYUDIR");
            }
        
        }
    }
}
