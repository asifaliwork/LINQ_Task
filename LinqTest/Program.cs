
using LinqTest;
using LinqTest.Classes;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
namespace Linq
{

    class Program
    {       
        public static void Main(string[] args)
        {
            Intern.intern();

        }
    }

    class Intern
    {
        public static void intern()
        {

            Console.WriteLine("Inter 1 for Add Internship: ");
            Console.WriteLine("Inter 2 for Search Internship: ");
            Console.WriteLine("Inter 3 for Update Internship: ");
            Console.WriteLine("Inter 4 for Delete Internship: ");
            int user_inter = Convert.ToInt32(Console.ReadLine());

            if (user_inter == 1)
            {
                Add_Internship.addInternship();

            }
            else if (user_inter == 2)
            {
                Search_Internship.search_Internship();

            }
            else if (user_inter == 3)
            {
                Detailss.detailss();

            }
            else if (user_inter == 4)
            {
                Console.WriteLine(user_inter);
            }
            else
            {
                Console.WriteLine(user_inter);

            }

        }
    }




}





