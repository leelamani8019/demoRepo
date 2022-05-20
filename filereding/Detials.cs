using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filereding
{
    public class Detials
    {
        public void readfile()
        {
            FileStream fileStreamObj = new FileStream(@"E:\laxman\networklog.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStreamObj);
            Console.WriteLine("Id\tsource \t destination \t date \t  time \t\t network \tstatus");
            streamReaderObj.ReadLine();
            while (streamReaderObj.Peek() > 0)
            {
                string line = streamReaderObj.ReadLine();
                if (line != "")
                {
                    Console.WriteLine(line);


                }

                

            }
            Console.WriteLine("\n" + "Read operation completed");
        }
    }
}
             
