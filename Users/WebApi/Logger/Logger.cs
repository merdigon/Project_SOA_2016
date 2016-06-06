using log4net;
using log4net.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Logger
{
    public class Logger : ILogger
    {
        private static readonly ILog log =
           log4net.LogManager.GetLogger(typeof(Logger));

        public void LogInfo(string message)
        {
            if (log != null)
                log.Info(message);
        }
    }
}