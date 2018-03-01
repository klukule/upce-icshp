using System;

namespace Fei.BaseLib
{
    /// <summary>
    /// Provides set of utility methods, which are used to read and convert input from instance of <see cref="System.Console"/> window.
    /// </summary>
    public class Reading
    {
        #region Public methods

        /// <summary>
        /// Reads the int from console.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns>Returns Converted text as <see cref="System.Int32"/> or throws <see cref="System.Exception"/> when conversion fails</returns>
        /// <exception cref="System.Exception">Invalid text</exception>
        public static int ReadInt(string message = "")
        {
            if (int.TryParse(PrintMessageAndReadFromConsole(message), out int number))
            {
                return number;
            }
            throw new Exception("Invalid text");
        }

        /// <summary>
        /// Reads the float from console.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns>Returns Converted text as <see cref="System.Single"/> or throws <see cref="System.Exception"/> when conversion fails</returns>
        /// <exception cref="System.Exception">Invalid text</exception>
        public static float ReadFloat(string message = "")
        {
            if (float.TryParse(PrintMessageAndReadFromConsole(message), out float number))
            {
                return number;
            }
            throw new Exception("Invalid text");
        }

        /// <summary>
        /// Reads the double from console.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns>Returns Converted text as <see cref="System.Double"/> or throws <see cref="System.Exception"/> when conversion fails</returns>
        /// <exception cref="System.Exception">Invalid text</exception>
        public static double ReadDouble(string message = "")
        {
            if (double.TryParse(PrintMessageAndReadFromConsole(message), out double number))
            {
                return number;
            }
            throw new Exception("Invalid text");
        }

        /// <summary>
        /// Reads the character from console.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns>Returns character from console.</returns>
        public static char ReadChar(string message = "")
        {
            Console.Write(message == "" ? "" : message + ": ");
            return (char)Console.Read();
        }

        /// <summary>
        /// Reads the string from console.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns>String from console.</returns>
        public static string ReadString(string message = "")
        {
            return PrintMessageAndReadFromConsole(message);
        }

        #endregion Public methods

        #region Private/Utility methods

        /// <summary>
        /// Prints the message and reads from console.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns>Text from console.</returns>
        private static string PrintMessageAndReadFromConsole(string message)
        {
            Console.Write(message == "" ? "" : message + ": ");
            return Console.ReadLine();
        }

        #endregion Private/Utility methods
    }
}