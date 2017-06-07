using System;

public class HelloWorld
{
    public string output { get; set; }
	public HelloWorld()
	{
        output = "Hello World";
	}
    public HelloWorld(string newOutput)
    {
        output = newOutput;
    }
}
