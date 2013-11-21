using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipHTML
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            List<string> lines = new List<string>();
            for (;;)
            {
                string line = Console.ReadLine();
                if (line == null)
                    break;
                lines.Add(line);
            }
            string input = string.Join(Environment.NewLine, lines);
            HtmlFragment.CopyToClipboard(input, null, null);
        }
    }
}
