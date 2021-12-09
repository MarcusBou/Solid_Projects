using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWebsite
{
    class DataReaderManager
    {
        private IDataReader reader;
        public DataReaderManager(IDataReader read)
        {
            reader = read;
        }

        public string ReadFromPath(string path)
        {
            reader.CreateRequest(path);
            reader.GetResponse();
            return reader.GetResponseString();
        }
    }
}
