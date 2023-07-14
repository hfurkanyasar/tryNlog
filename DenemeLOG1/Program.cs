using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeLOG1
{
    public class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            //Per request
            System.Diagnostics.Trace.CorrelationManager.ActivityId = Guid.NewGuid();

            DoWork();

        }

        private static void DoWork()
        {
            //...

            logger.Debug("DoWork method'u çalıştırıldı.");

            DoOtherWork();
            LimitUstuAvans();
        }

        private static void DoOtherWork()
        {
            //...

            logger.Debug("DoOtherWork method'u çalıştırıldı.");
        }


        private static void LimitUstuAvans()
        {

            logger.Debug("Limit üstü avans çekimi yapıldı.");
        
        
        }
    }
}
