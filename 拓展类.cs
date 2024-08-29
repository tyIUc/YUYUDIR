using PluginAPI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YUYUDIR
{
    public static class Logger
    {
        public static void Info(string message) => ServerConsole.AddLog("[YUYUDIR]:" + message, ConsoleColor.Blue);
        public static void Err(string message) => ServerConsole.AddLog("[YUYUDIR报错]:" + message, ConsoleColor.Red);
    }
}
