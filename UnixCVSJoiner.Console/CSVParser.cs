using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace UnixCVSJoiner
{
    
    class CSVParser
    {
        private string line = string.Empty;
        private List<KeyValuePair<int, string>> dic = new List<KeyValuePair<int, string>>();

        private StreamReader sr;
        private StreamWriter sw;

        public CSVParser(string path){
            //sw = new StreamWriter(path);
            try
            {
                sr = new StreamReader(File.OpenRead(path));
                parseCVS();
            }
            catch (FileNotFoundException e) {
                Console.WriteLine(e.Message);
            }
        }

        // parse the CVS into a list of key-value pairs and 
        private bool parseCVS() {
            try
            {
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    var values = line.Split(',');

                    // add keys and values to the list of key value pair
                    dic.Add(new KeyValuePair<int,string>(int.Parse(values[0]),values[1].ToString()));
                }
                return true;
            }
            catch (Exception e) {
                Console.Write(e.Message);
                return false;
            }
        }
    }
}
