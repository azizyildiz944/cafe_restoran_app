﻿using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace CafeRestoranApp.Entities.Utilities
{
    public enum LogLevel
    {
        Info,
        Warning,
        Error,
        Critical
    }

    public static class Logger
    {
        private static readonly string logDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "CafeRestoranLogs");

        static Logger()
        {
            // Create log directory if it doesn't exist
            if (!Directory.Exists(logDirectory))
            {
                Directory.CreateDirectory(logDirectory);
            }
        }

        /// <summary>
        /// Writes log to file and console synchronously.
        /// </summary>
        /// <param name="message">Log message.</param>
        /// <param name="level">Log level (Info, Warning, Error, Critical).</param>
        /// <param name="ex">Optional exception object for error and critical log levels.</param>
        /// <param name="callerName">Name of the method where the log is called from.</param>
        public static void Log(string message, LogLevel level = LogLevel.Info, Exception ex = null, [System.Runtime.CompilerServices.CallerMemberName] string callerName = "")
        {
            string logFilePath = Path.Combine(logDirectory, $"Log_{DateTime.Now:yyyy-MM-dd}.txt");

            try
            {
                // Prepare log details
                string logDetails = PrepareLogDetails(message, level, ex, callerName);

                // Write log synchronously to the file
                WriteLogToFile(logFilePath, logDetails);

                // Also write to console for immediate feedback
                Console.WriteLine(logDetails);
            }
            catch (Exception logEx)
            {
                // If there's an error writing to the log file, show a message to the user
                MessageBox.Show($"An error occurred while writing the log: {logEx.Message}", "Log Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Prepares the log entry.
        /// </summary>
        /// <param name="message">Log message.</param>
        /// <param name="level">Log level (Info, Warning, Error, Critical).</param>
        /// <param name="ex">Optional exception object for error and critical log levels.</param>
        /// <param name="callerName">The name of the method where the log is called from.</param>
        /// <returns>Formatted log entry as a string.</returns>
        private static string PrepareLogDetails(string message, LogLevel level, Exception ex, string callerName)
        {
            string separator = new string('-', 80);
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string className = new StackTrace().GetFrame(1)?.GetMethod()?.DeclaringType?.FullName ?? "Unknown";
            string osVersion = Environment.OSVersion.ToString();
            string appVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();

            // Append exception details if available
            string exceptionDetails = ex != null
                ? $"\nERROR MESSAGE: {ex.Message}\nSTACK TRACE:\n{ex.StackTrace}"
                : "";

            return $@"
{separator}
DATE: {timestamp}
LOG LEVEL: {level}
CLASS: {className}
METHOD: {callerName}
MESSAGE: {message}
OS: {osVersion}
APP VERSION: {appVersion}
{exceptionDetails}
{separator}
";
        }

        /// <summary>
        /// Writes the log synchronously to the file using StreamWriter.
        /// </summary>
        /// <param name="logFilePath">The file path to write the log to.</param>
        /// <param name="logDetails">The formatted log details.</param>
        private static void WriteLogToFile(string logFilePath, string logDetails)
        {
            try
            {
                // Use StreamWriter to synchronously write the log to the file
                using (StreamWriter writer = new StreamWriter(logFilePath, append: true, encoding: Encoding.UTF8))
                {
                    writer.WriteLine(logDetails);
                }
            }
            catch (Exception ex)
            {
                // Handle any exception that occurs while writing to the file
                MessageBox.Show($"An error occurred while writing the log to the file: {ex.Message}", "Log File Write Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Convenience methods for different log levels
        public static void LogInfo(string message, Exception ex = null, [System.Runtime.CompilerServices.CallerMemberName] string callerName = "")
        {
            Log(message, LogLevel.Info, ex, callerName);
        }

        public static void LogWarning(string message, Exception ex = null, [System.Runtime.CompilerServices.CallerMemberName] string callerName = "")
        {
            Log(message, LogLevel.Warning, ex, callerName);
        }

        public static void LogError(string message, Exception ex = null, [System.Runtime.CompilerServices.CallerMemberName] string callerName = "")
        {
            Log(message, LogLevel.Error, ex, callerName);
        }

        public static void LogCritical(string message, Exception ex = null, [System.Runtime.CompilerServices.CallerMemberName] string callerName = "")
        {
            Log(message, LogLevel.Critical, ex, callerName);
        }

        public static void LogXeta(Exception ex)
        {
            throw new NotImplementedException();
        }
    }
}
