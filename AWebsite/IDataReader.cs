﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWebsite
{
    interface IDataReader
    {
        public void CreateRequest(string path);
        public void GetResponse();
        public string GetResponseString();
    }
}