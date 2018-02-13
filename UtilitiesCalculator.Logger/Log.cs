using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesCalculator.Logger
{
    public class Log
    {
        private static Log _instance;
        public static Log Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Log();
                }
                return _instance;
            }

        }
        private Log() { }

        public void LogInfo(string msg)
        {
            Console.WriteLine("Info: " + msg);
        }

        public void LogWarning(string msg)
        {
            Console.WriteLine("Warning: " + msg);
        }

        public void LogError(string msg)
        {
            Console.WriteLine("Error: " + msg);
        }
    }
}
