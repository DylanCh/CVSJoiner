using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace UnixCVSJoiner
{
    
    class CSVParser
    {
        private List<int> key;
        private List<string> value1;

        public CSVParser(string path){
            key = new List<int>();
            value1 = new List<string>();
            readCSV(path);
        }

        private void readCSV(string path)  {
            StreamReader reader;
            try
            {
                 reader = new StreamReader(File.OpenRead(path));
                 parseCSV(reader);
            }
            catch (FileNotFoundException fNFE) {
                Console.WriteLine(fNFE.Message);
            }   
        }

        private void parseCSV(StreamReader reader){
            while (!reader.EndOfStream)
            {
                try
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    key.Add(int.Parse(values[0]));
                    value1.Add((values[1].ToString()));
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                }
            }
        }
    }
}
