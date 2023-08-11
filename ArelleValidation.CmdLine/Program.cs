using ArelleValidation.CmdLine.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArelleValidation.CmdLine
{
    class Program
    {
        static void Main(string[] args)
        {
            var arellePath = "\"D:\\SYSTEM\\Windows\\Program Files\\Arelle\\arelleCmdLine.exe\"";
            var instancePath = @"E:\WORK\PROJECT\MALEO\PRODUCTION\SIPP\1_VERSION_5_1\WEB\App_Data\INSTANCE\";
            var instanceName = "260460-2022-04-30-220020300";

            var arelleArgument = "--file " + "\"{INSTANCENAME}.xml\"" +
                " --validate --calcDecimals --logLevel=error --logLevel=assertion-not-satisfied --logLevel=inconsistency --logCodeFilter=^((?!.*arelleUtrLoader).)*$ --logFile " +
                "\"{INSTANCENAME}-arelle.log.xml\"";

            string fileName = instancePath + instanceName;

            var argumentParse = arelleArgument.Replace("{INSTANCENAME}", fileName);

            CmdLineUtility.ExceuteCommand(arellePath, argumentParse);
            //if (args.Length > 0)
            //{
            //    var arg = args[0];
            //    if (arg == null) return;

            //    if (arg.ToLower().Contains("--cmdpath="))
            //    {
            //        var command = arg.ToLower().Replace("--cmdpath=", "");
            //        CmdLineUtility.ExceuteCommand(command);
            //    }
            //}
        }
    }
}
