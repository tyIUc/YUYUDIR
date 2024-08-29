using PluginAPI.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YUYUDIR
{
    public class Main
    {
        public static List<string> ConfigList { get; set; } = new List<string>()
        {
            "C:\\YUYUDIR\\框架主体配置.ini",
            "C:\\YUYUDIR\\插件配置.ini",
            "C:\\YUYUDIR\\翻译配置.ini",
        };
        public static void Start()
        {
            Exits();
        }
        public static void Exits()
        {
            foreach (var item in ConfigList)
            {
                if (item.IsExits())
                {
                    continue;
                }
                else
                {
                    item.写入("测试","测试(此项无效)");
                }
            }
            Logger.Info("框架基础文件检查完毕");
        }
    }
}
