using System;

namespace HtmlStrings
{
    class Html
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string article = Console.ReadLine();

            Console.WriteLine($"<h1>\n\t{title}\n</h1>");
            Console.WriteLine($"<article>\n\t{article}\n</article>");

            string comments = Console.ReadLine();

            while (comments != "end of comments")
            {
                Console.WriteLine($"<div>\n\t{comments}\n</div>");
                comments = Console.ReadLine();
            }
        }
    }
}
