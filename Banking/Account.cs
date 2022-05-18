using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public abstract class Account
    {
        public abstract string create();
        public abstract string Read();
        public abstract string update();
        public abstract string delete();
        public virtual void transaction(int a)
        {
            if (a <= 50000)
            {
                Console.WriteLine("this is silver account");
            }
            else if (a > 50000)
            {
                Console.WriteLine("this is  account");

            }
            else
            {
                Console.WriteLine("this an account");
            }

        }


    }
    public class savings_account:Account
    {
        public override string create()
        {
            return "name";

        }
        public override string Read()
        {
            return "detials";

        }
        public override string update()
        {
            return "detials";
        }
        public override string delete()
        {
            return "account";
        }
        public  override void transaction(int a)
        {
            if (a <= 50000)
            {
                Console.WriteLine("this is silver account");
            }
            else if (a > 50000)
            {
                Console.WriteLine("this is  account");

            }
            else
            {
                Console.WriteLine("this an account");
            }

        }

    }
    public class current_account : Account
    {
        public override string create()
        {
            return "name";

        }
        public override string Read()
        {
            return "detials";

        }
        public override string update()
        {
            return "detials";
        }
        public override string delete()
        {
            return "account";
        }
        public override void  transaction(int a)
        {
            if (a <= 50000)
            {
                Console.WriteLine("this is silver account");
            }
            else if (a > 50000)
            {
                Console.WriteLine("this is  account");

            }
            else
            {
                Console.WriteLine("this an account");
            }

        }


    }
}
