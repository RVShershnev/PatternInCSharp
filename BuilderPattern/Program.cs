using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyWebPage page = new MyWebPage();
            String pageContent = page.TransformText();
            System.IO.File.WriteAllText("outputPage.html", pageContent);
        }
    }
}
