using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArelleValidation.CmdLine.Utilities
{
    public class CmdLineUtility
    {
        public static void ExceuteCommand(string command)
        {
            var process = new Process();
            process.StartInfo = new ProcessStartInfo(command)
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardOutput = true
            };
            process.Start();
            process.WaitForExit();
        }
        public static void ExceuteCommand(string executableName, string argument)
        {
            var StartInfo = new ProcessStartInfo()
            {
                FileName = executableName,
                Arguments = argument,
                CreateNoWindow = false,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden
            };

            var proc = Process.Start(StartInfo);
            proc.WaitForExit();
            proc.Close();
        }
    }
}
