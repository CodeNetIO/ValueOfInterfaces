using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codenet.logging
{
    public class MemoryLogger:ILogger
    {
        private IList<string> _log; 
        public MemoryLogger(ref IList<string> log)
        {
            _log = log;
        }

        #region Implementation of ILogger

        /// <summary>
        /// Writes text to the log
        /// </summary>
        /// <param name="text">The text to write to the log</param>
        public void WriteLine(string text)
        {
            _log.Add(text);
        }

        #endregion
    }
}
