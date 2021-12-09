using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWebsite
{
    internal class FileReader : IDataReader
    {
        public string GetResponseString(string path)
        {
            return System.IO.File.ReadAllText(path);

        }
    }
}
