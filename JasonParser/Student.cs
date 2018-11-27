using System.Collections.Generic;

namespace JasonParser
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Degree { get; set; }
        public List<string> Hobbies { get; set; }

        public override string ToString()
        {
            return string.Format("Student information:\n Id :{0}\n Name :{1} \n Degree : {2}\n Hobbies : {3} ",Id,Name,Degree,string.Join(",",Hobbies.ToArray()));
        }
    }
}
