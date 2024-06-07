using Linq;
using LinqTest.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTest
{
    internal class Detailss
    {
        public static void detailss()
        {


            var listtt = list.company.Zip(list.datails, (c, d) => new { company = c, datails = d });

            foreach (var item in listtt)
            {
                Console.WriteLine("Company Location: " + item.company.Location);
                Console.WriteLine("Company Name: " + item.company.Industry);
                Console.WriteLine("Salary: " + item.datails.Salary);
                Console.WriteLine("Skills: " + item.datails.Skills);
                Console.WriteLine("Start Date: " + item.datails.StartDate);
                Console.WriteLine("Duration: " + item.datails.Duration);
                Console.WriteLine("Remote: " + item.datails.IsRemote);

            }


            Intern.intern();
            Console.ReadKey(true);


        }
    }
}
