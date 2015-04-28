namespace codenet.logging
{
    /// <summary>
    /// Represents a logger
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Writes text to the log
        /// </summary>
        /// <param name="text">The text to write to the log</param>
        void WriteLine(string text);
    }
}