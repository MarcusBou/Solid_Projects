﻿using System;

namespace AWebsite
{
    class Program
    {
        static void Main(string[] args)
        {
            WebReader webReader = new WebReader();
            webReader.CreateRequest("https://docs.microsoft.com");
            webReader.GetResponse();
            Console.WriteLine(webReader.GetResponseString());
        }
    }
}
