using Newtonsoft.Json;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;

namespace JasonParser
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student()
            {
                Id = 1,
                Name = "Eray",
                Degree = "MCA",
                Hobbies = new System.Collections.Generic.List<string>()
                {
                    "Chess",
                    "Formula 1"
                }


            };


            string strResultJson = JsonConvert.SerializeObject(student);
            System.IO.File.WriteAllText(@"student.json",strResultJson);
            Console.WriteLine("stored!");


            strResultJson = String.Empty;
            strResultJson = System.IO.File.ReadAllText(@"student.json");
            //   Student resultStudent = JsonConvert.DeserializeObject<Student>(strResultJson);
            //   Console.WriteLine(resultStudent.ToString());
            //   Console.ReadKey();

            var dictionary = JsonConvert.DeserializeObject<IDictionary>(strResultJson);
            foreach (DictionaryEntry entry in dictionary)
            {
                Console.WriteLine(entry.Key+" : "+entry.Value);
                Console.ReadKey();
            }
        }
    }
}
