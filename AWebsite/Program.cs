using System;

namespace AWebsite
{
    class Program
    {
        static void Main(string[] args)
        {
            DataReaderManager webreader = new DataReaderManager(new WebReader());
            //DataReaderManager filereader = new DataReaderManager(new );

            Console.WriteLine("Type 1 for web");
            Console.WriteLine("Type 2 for file");
            char clickedChar = Console.ReadKey().KeyChar;
            switch (clickedChar)
            {
                case '1':
                    write(webreader);
                    break;
                case '2':
                    write(webreader);
                    break;
                default:
                    break;
            }
        }

        static void write(DataReaderManager reader)
        {
            Console.WriteLine();
            Console.Write("Write path: ");
            string path = Console.ReadLine();
            Console.WriteLine(reader.ReadFromPath(path));
        }
    }
}
