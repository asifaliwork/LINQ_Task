using Linq;
using LinqTest.Classes;


namespace LinqTest
{
    internal class Add_Internship
    {

        public  static void  addInternship()
        {

            Console.WriteLine("Enter the location: ");
            string location= Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter the industry: ");
            string industry = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter the minimum salary:");
            int salar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the start date (yyyy-mm-dd): ");
            DateTime date = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Enter required skills (comma-separated): ");
            string skills = Console.ReadLine();

            Console.WriteLine("Enter maximum duration in weeks: ");
            int weeks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Is remote? (yes/no): ");            
            string isremote = Console.ReadLine();

            if(isremote == "yes" || isremote == "Yes" || isremote == "No" || isremote == "no")
            {
                Details detail = new Details()
                {
                    IsRemote = isremote,

                };
                list.datails.Add(detail);
            }
            else
            {
                Console.WriteLine(" Please Enter Yes Or No ");
            }

            Console.WriteLine("Enter minimum average rating: ");
            int rating = Convert.ToInt32(Console.ReadLine());

             while (rating < 0 || rating > 5){
                Console.WriteLine("Please Enter Between 0 to 5 Thanks");
                rating = Convert.ToInt32(Console.ReadLine());
            }

            
            Review revie = new Review();
            list.review.Add(revie);



            Company1 name = new Company1()
            {
                Location = location,
                Industry = industry,
               
            };

            Details details = new Details()
            {
                Salary = salar,
                StartDate = date,
                Skills = skills,
                Duration = weeks,
               
                
            };
            Review review = new Review()
            {
                Rating = rating,
            };

           
            list.company.Add(name);
            list.datails.Add(details);
            list.review.Add(review);
            foreach (var item in list.company)
            {
                Console.WriteLine(item.Location);
                Console.WriteLine(item.Industry);
               
            }

            foreach (var item in list.datails)
            {
                Console.WriteLine(item.Salary);
                Console.WriteLine(item.StartDate);
                Console.WriteLine(item.Skills);
                Console.WriteLine(item.Salary);
            }
            foreach (var item in list.review)
            {
                Console.WriteLine(item.Rating);
                
            }

            Console.WriteLine("\n");
            Console.Clear();
            Intern.intern();
            Console.ReadKey(true);

        }
    }

   
           
    
    
        
}
    

