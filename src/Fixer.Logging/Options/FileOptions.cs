using System;
using System.Collections.Generic;
using System.Text;

namespace Fixer.Logging.Options
{
    public class FileOptions
    {
        public bool Enabled { get; set; }
        public string Path { get; set; }
        public string Interval { get; set; }
    }
}
