using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPatter
{
    /// <summary>
    /// Singleton
    /// </summary>
    public class Logger
    {
        private static Logger? _instance;

        /// <summary>
        /// Instence
        /// </summary>
        public static Logger Instance
        {
            get
            {
                if( _instance == null)
                {
                    _instance = new Logger();
                }
                return _instance;
            }
        }

        protected Logger() { }

        public void Log(string message)
        {
            Console.WriteLine($"Message to log: {message}");
        }
    }
}
