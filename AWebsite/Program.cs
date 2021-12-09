using System;

namespace AWebsite
{
    class Program
    {
        static void Main(string[] args)
        {
            DataReaderManager webreader = new DataReaderManager(new WebReader());

            Console.Write("Write path: ");
            string path = Console.ReadLine();
            Console.WriteLine(webreader.ReadFromPath(path));
        }
    }
}
