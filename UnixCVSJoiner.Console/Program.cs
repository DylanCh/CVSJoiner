using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace UnixCVSJoiner
{
    class Program
    {
        private static void selection() {
            //short selection;
            Console.WriteLine("Please make a selection");
            Console.Write("1, Hash Join;\n");
            Console.Write("2, Merge Join;\n");
            Console.Write("3, Print both unjoined tables;\n");
            //Joiner joiner = new Joiner (,,Convert.ToInt16(Console.ReadLine()));
        }

        static void Main(string[] args)
        {
            CSVParser csvParser1, csvParser2;
            string path;
            if (args.Length < 2) // if no path is entered in CLI
            {
                //Console.WriteLine("Please enter full path of the CSV file");
                //path = Console.ReadLine();
                //csvParser1 = new CSVParser(path);
                //Console.WriteLine("Please enter the CSV file you want to join");
                //path = Console.ReadLine();
                //csvParser2 = new CSVParser(path);
                path = @"C:\Users\STUDENT\Desktop\CVSJoiner-master\CVSJoiner-master\UnixCVSJoiner.Console\Insurance_Key_State.csv";
                csvParser1 = new CSVParser(path);
                path = @"C:\Users\STUDENT\Desktop\CVSJoiner-master\CVSJoiner-master\UnixCVSJoiner.Console\Insurance_Key_County.csv";
                csvParser2 = new CSVParser(path);
                selection();
            }

            //else if (args.Length == 2) // if only one file path is entered in CLI
            //{
            //    csvParser1 = new CSVParser(args[1]);
            //    Console.WriteLine("Please enter the CSV file you want to join");
            //    path = Console.ReadLine();
            //    csvParser2 = new CSVParser(path);
            //}

            //else if (args.Length == 3) {
            //    csvParser1 = new CSVParser(args[1]);
            //    csvParser2 = new CSVParser(args[2]);
            //}

            
        }
    }
}
