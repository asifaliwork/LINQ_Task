using Linq;
using LinqTest.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTest
{
    internal class Search_Internship
    {
        public static void search_Internship()
        {
            Console.WriteLine("Enter Location : ");
            string location = Console.ReadLine();

            Console.WriteLine("Enter Industry Name : ");
            string industry = Console.ReadLine();

            Console.WriteLine("Enter salary : ");
            int salary = Convert.ToInt32(Console.ReadLine());

            Company1 company21 = new Company1()
            {
                Location = location,
                Industry = industry,
            };

            list.company1.Add(company21);

            Details detail = new Details()
            {
                Salary = salary,
            };

            list.datails1.Add(detail);

            var lin1 = from search in list.company
                       from searc in list.company1
                       from second in list.datails
                       from third in list.datails1
                       where search.Location == searc.Location && search.Industry == searc.Industry && second.Salary== third.Salary                       
                       select (search,second);

            foreach (var line in lin1) 
            { 
                Console.WriteLine(line.search.Location);
                Console.WriteLine(line.search.Industry);
                Console.WriteLine(line.second.Salary);
                Console.WriteLine(line.second.Skills);
                Console.WriteLine(line.second.Duration);

            }

            Intern.intern();
                          
            Search_Internship.search_Internship();
           
            Console.ReadKey(true);

        }


        
    }
}
