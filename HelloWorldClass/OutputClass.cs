using OutputClass;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputClass
{
    public class Output
    {

        public string output { get; set; }

        public Output()
        {
            //default output
            output = "Hello World";
        }
        public Output(string newOutput)
        {
            output = newOutput;
        }

        //JSON are used throughout the industry for easy accessibility
        public string getJSONString()
        {
            return @"{output : '" + output + "'}";
        }

        public string getHTMLPage()
        {
            return @"<!DOCTYPE html>
                    <html lang='en'>
                        <head>
                            <meta charset='utf-8'>
                            <title>Hello World Example</title>
                        </head>
                        <body>
                            <h1>" + output + @"</h1>
                        </body>
                    </html>";
        }
    }
}
    

