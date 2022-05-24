using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayandlist
{
    public class arrayclass
    {
        public void arraycl()
        {
            int[] val = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int i in val)
            {
                Console.WriteLine(i);
            }
            String[] val1 = { "tim", "martin", "nikki", "sara" };
            foreach (string s in val1)
            {
                Console.WriteLine(s);
            }
            Boolean[] val2 = { true, false, true, false, true, false, true, false, true, false };
            foreach (Boolean s1 in val2)
            {
                Console.WriteLine(s1);
            }

        }
    }
    public class createlist
    {
        public string icecream_flavours { get; set; }

        public void listcl()
        {
            List<createlist> list = new List<createlist>();
            createlist cr = new createlist();
            cr.icecream_flavours = "chocolate";
            list.Add(cr);
            Console.WriteLine(cr.icecream_flavours);
            cr.icecream_flavours = "vennela";
            list.Add(cr);
            Console.WriteLine(cr.icecream_flavours);
            cr.icecream_flavours = "beterscoch";
            list.Add(cr);
            Console.WriteLine(cr.icecream_flavours);
            cr.icecream_flavours = "pista";
            list.Add(cr);
            Console.WriteLine(cr.icecream_flavours);
            cr.icecream_flavours = "blur berrey";
            list.Add(cr);
            Console.WriteLine(cr.icecream_flavours);
          
        }
    }
}
   
