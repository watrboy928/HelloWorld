using OutputClass;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApplication
{
    class HelloWorldProgram
    {
        static void Main()
        {
            //using default value "Hello World"
            Output outputClass = new Output();

            string outputLocation = System.Configuration.ConfigurationManager.AppSettings["OutputLocation"];
            string filePath = System.Configuration.ConfigurationManager.AppSettings["SaveFilePath"];
            if (outputLocation.Equals("Console"))
            {
                outputToConsole(outputClass.output);
            }
            else if (outputLocation.Equals("HTML file"))
            {
                outputToHTMLFile(outputClass, filePath, "Hello World");
            }
            else if (outputLocation == null)
            {
                Console.WriteLine("WARNING: Output location not specified in App.config.\nNo output will be displayed.\nOptional outputs are: Console, HTML file");
                waitForResponse();
            }
        }
        private static void outputToHTMLFile(Output outputClass, string folderPath, string fileName)
        {
            string path = folderPath + fileName + @".html";
            try
            {
                // Create the file
                File.WriteAllText(path, outputClass.getHTMLPage());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Application has encountered the following error:");
                outputToConsole(ex.Message);
            }

            outputToConsole("File created successfully");
        }

        private static void outputToConsole(string output)
        {
            Console.WriteLine(output);
            waitForResponse();
        }

        private static void waitForResponse()
        {
            Console.WriteLine("Press anything to exit...");
            Console.ReadKey();
        }


    }
}
