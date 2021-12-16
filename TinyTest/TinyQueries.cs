using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyTest
{
    public class TinyQueries
    {
        List<ExampleClass> exampleClasses;

        public TinyQueries()
        {
            exampleClasses = new List<ExampleClass>();
            exampleClasses.Add(new ExampleClass(id: 3456, name: "Fabien Seacaster"));
            exampleClasses.Add(new ExampleClass(id: 5456, name: "Fig Faeth"));
            exampleClasses.Add(new ExampleClass(id: 2353, name: "Gorgug Thistlespring"));
            exampleClasses.Add(new ExampleClass(id: 7348, name: "Adine Abernant"));
            exampleClasses.Add(new ExampleClass(id: 9346, name: "Riz Gukgak"));
            exampleClasses.Add(new ExampleDerivedClass(id: 4577, name: "Gorthalax the Insatiable", description: "Formerly Gorthiel the Seraph of Eating the Right Amount of Food"));
        }

        public void LINQQuery()
        {
            var query = from e in exampleClasses
                        where e.Id > 5000
                        select e;

            Console.WriteLine("All Query results:");
            foreach (ExampleClass e in query)
                Console.WriteLine(e.Everything());
        }
    }
}
