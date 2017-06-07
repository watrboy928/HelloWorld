using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorldClass
{
    public class HelloWorld
    {

        public string output { get; set; }

        public HelloWorld()
        {
            //default output
            output = "Hello World";
        }
        public HelloWorld(string newOutput)
        {
            output = newOutput;
        }

    }
}