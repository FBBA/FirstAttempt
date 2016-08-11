using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //var sample = "I enjoy writing uber-software in C#";

            //var result = from c in sample.ToLower()
            //             where c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'
            //             orderby c
            //             group c by c;

            //foreach(var item in result)
            //{
            //    Console.WriteLine("{0}, {1}", item.Key, item.Count());
            //}

            IEnumerable<Employee> developers = new Employee[]{
                new Employee{Id=1, Name="Scott"},
                new Employee{Id=2, Name="Chris"}
            };

            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee{Id=3, Name="Alex"}
            };

            Console.WriteLine(sales.Count());

            IEnumerator<Employee> enumerator = sales.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.Name);
            }

            Console.ReadLine();
        }
    }
}
