using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filereding
{
    public class Retrive
    {
        public void Success()
        {
            var mydata = File.ReadAllLines(@"E:\laxman\networklog.txt");
            foreach (String s in mydata)
            {
                if(s.Contains("Success"))
                {
                    Console.WriteLine(s);
                }
            }
        }
        public void missed()
        {
            var mydata = File.ReadAllLines(@"E:\laxman\networklog.txt");
            foreach (String s in mydata)
            {
                if (s.Contains("missed"))
                {
                    Console.WriteLine(s);
                }
            }

        }
        public void failed()
        {
            var mydata = File.ReadAllLines(@"E:\laxman\networklog.txt");
            foreach (String s in mydata)
            {
                if (s.Contains("failed"))
                {
                    Console.WriteLine(s);
                }
            }
        }
        public void dialled()
        {
            var mydata = File.ReadAllLines(@"E:\laxman\networklog.txt");
            foreach (String s in mydata)
            {
                if (s.Contains("dailled"))
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
