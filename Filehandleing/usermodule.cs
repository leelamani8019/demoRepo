using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Filehandleing
{ 
    public  class usermodule
    { 
        public void User_Module()
            {
                FileStream fst = new FileStream(@"E:\laxman\Filehandleing\userdetials.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fst);
                Console.Write("Enter the UserId: ");
                sw.Write(Console.ReadLine());
                sw.Write(',');

                Console.Write("Enter the Fname: ");
                sw.Write(Console.ReadLine());
                sw.Write(',');

                Console.Write("Enter the Lname: ");
                sw.Write(Console.ReadLine());
                sw.Write(',');

                Console.Write("Enter the Email: ");
                sw.Write(Console.ReadLine());
                sw.Write(',');

                Console.Write("Enter the Phone: ");
                sw.Write(Console.ReadLine());
                sw.WriteLine("");
                sw.Close();
                fst.Close();
            }
            public void Category_Module()
            {
                FileStream fst = new FileStream(@"E:\laxman\Filehandleing\Category.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fst);
                Console.Write("Enter the CategoryId: ");
                sw.Write(Console.ReadLine());
                sw.Write(',');

                Console.Write("Enter the CategoryType: ");
                sw.Write(Console.ReadLine());

                sw.WriteLine("");
                sw.Close();
                fst.Close();
            }
            public void Product_Module()
            {

                FileStream fst = new FileStream(@"E:\laxman\Filehandleing\Product.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fst);
                Console.Write("Enter the Productid: ");
                sw.Write(Console.ReadLine());
                sw.Write(',');

                Console.Write("Enter the categorytype: ");
                sw.Write(Console.ReadLine());
                sw.Write(',');

                Console.Write("Enter the productname: ");
                sw.Write(Console.ReadLine());
                sw.Write(',');

                Console.Write("Enter the quantity: ");
                sw.Write(Console.ReadLine());
                sw.Write(',');

                Console.Write("Enter the price: ");
                sw.Write(Console.ReadLine());
                sw.WriteLine("");
                sw.Close();
                fst.Close();

            }
            public void Purchase_and_Sales_Module()
            {


                FileStream fst = new FileStream(@"D:\DotnetTraining\DemoRepo\PurchaseandSales.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fst);
                Console.Write("Enter the SalesId: ");
                sw.Write(Console.ReadLine());
                sw.Write(',');

                Console.Write("Enter the Productid: ");
                sw.Write(Console.ReadLine());
                sw.Write(',');

                Console.Write("Enter the price: ");
                sw.Write(Console.ReadLine());
                sw.Write(',');

                Console.Write("Enter the salesdate: ");
                sw.Write(Console.ReadLine());



                sw.WriteLine("");
                sw.Close();
                fst.Close();


            }
           



        }
}

