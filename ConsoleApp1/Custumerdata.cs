using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace ConsoleApp1
{
    public class Custumerdata
    {
        public static string sqlconnectionstr = @"Data Source=LAKSHMAN\MSSQLSERVER01;Initial Catalog=Bankdb;Integrated Security=True";
        public string Insertcustomer()
        {
            Console.Write("enter custid:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter custname:");
            string name = Console.ReadLine();
            Console.Write("enter email:");
            string email = Console.ReadLine();
            Console.Write("Enter Customer Mobile: ");
            int mobile = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Customer address: ");
            string address = Console.ReadLine();
            SqlConnection sqlConnection = new SqlConnection(sqlconnectionstr);
            SqlCommand cmd = new SqlCommand("insert into Customer values(" + id + "," + name + "','" + email + "'," + mobile + ",'" + address + "')", sqlConnection);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return "Inserted";
        }
        public string UpdateCustomer()
        {
            return "";
        }
        public string DeleteCustomer()
        {
            return "";
        }
        public string SelectCustomers()
        {
            return "";
        }
        public string SelectCustomerById()
        {
            return "";
        }

           
        }


    }


