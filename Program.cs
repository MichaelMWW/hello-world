using System;
using System.Xml;

namespace ConsoleHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Int32 i=5,j = 15;
            Int32 k = i + j;

            
            Console.ReadLine();
            XmlTextWriter xtw = new XmlTextWriter(@"d:\test.txt", System.Text.Encoding.ASCII);
        }
    }
}
