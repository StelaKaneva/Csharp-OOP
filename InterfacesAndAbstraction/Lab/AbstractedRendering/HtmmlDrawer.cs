using AbstractedRendering.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AbstractedRendering
{
    public class HtmmlDrawer : IDrawer
    {
        private string path;
        private StringBuilder result;

        public HtmmlDrawer(string path)
        {
            this.path = path;
            result = new StringBuilder();
        }

        public void Write(string input)
        {
            result.Append(input);
            using (StreamWriter writer = new StreamWriter(path + ".htmml", false))
            {
                writer.Write($"<htmml><head></head><body><h1>Best game!!!<h1><p>${result.ToString()}</p></body></htmml>");
            }
        }

        public void WriteLine(string input)
        {
            result.Append(input);
            using (StreamWriter writer = new StreamWriter(path + ".htmml", false))
            {
                writer.Write($"<htmml><head></head><body><h1>Best game!!!<h1><p>${result.ToString()}</p></body></htmml>");
            }
        }
    }
}
