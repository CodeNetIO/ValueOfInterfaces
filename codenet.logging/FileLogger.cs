using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codenet.logging
{
    public class FileLogger : ILogger
    {
        private string _logfileName;
        private string _logfilePath;

        /// <summary>
        /// Creates an instance of the FileLogger
        /// </summary>
        /// <param name="logfileName">The name of the logfile</param>
        /// <param name="logfilePath">The location to save the logfile</param>
        /// <exception cref="ArgumentNullException">
        /// logfileName is null
        /// OR
        /// logfilePath is null
        /// </exception>
        public FileLogger(string logfileName, string logfilePath)
        {
            // Validate arguments
            if (string.IsNullOrEmpty(logfileName))
            {
                throw new ArgumentNullException("logfilePath");
            }

            if (string.IsNullOrEmpty(logfilePath))
            {
                throw new ArgumentNullException("logfilePath");
            }

            // Store arguments
            _logfileName = logfileName;
            _logfilePath = logfilePath;
        }

        #region Implementation of ILogger

        /// <summary>
        /// Writes text to the log
        /// </summary>
        /// <param name="text">The text to write to the log</param>
        public void WriteLine(string text)
        {
            var path = Path.Combine(_logfilePath, _logfileName);
            var sw = !File.Exists(path) ? File.CreateText(path) : File.AppendText(path);
            sw.WriteLine(text);
        }

        #endregion
    }
}
