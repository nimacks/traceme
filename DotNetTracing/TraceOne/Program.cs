using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraceOne
{
    class Program
    {
        /// <summary>
        /// //Writing Debug and Trace Statements to file via code configuration
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            

            // Create a file for output named TestFile.txt.
            Stream myFile = File.Create("TestFile.txt");

            /* Create a new text writer using the output stream, and add it to
             * the trace listeners. */
            TextWriterTraceListener myTextListener = new TextWriterTraceListener(myFile);

            //Add listener to collection
            Trace.Listeners.Add(myTextListener);
            Debug.Listeners.Add(myTextListener);

            // Write output to the file.
            Trace.Write("Test output ");
            Debug.Write("Trace 1 with Debug");

            // Flush the output.
            Trace.Flush();
            Trace.Close();



        }
    }
}
