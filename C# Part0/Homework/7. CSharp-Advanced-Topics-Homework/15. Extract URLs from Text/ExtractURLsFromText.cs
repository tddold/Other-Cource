// Write a program that extracts and prints all URLs from given text. URL can be in only two formats:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
class ExtractURLsFromText
{
    static void Main()
    {
        Regex urlRegex = new Regex("http://([\\w+?\\.\\w+])+([a-zA-Z0-9\\~\\!\\@\\#\\$\\%\\^\\&amp;\\*\\(\\)_\\-\\=\\+\\\\\\/\\?\\.\\:\\;\\'\\,]*)?", RegexOptions.IgnoreCase);

        var matches = urlRegex.Matches(Console.ReadLine());

        foreach (var match in matches)
        {
            Console.WriteLine(match);
        }
    }
}