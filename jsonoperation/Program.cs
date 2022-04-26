using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace jsonoperation
{
    ///*https://www.c-sharpcorner.com/article/working-with-json-in-C-Sharp/*/
    public class Student
    {
        public string name
        {
            get;
            set;
        }
        public string address
        {
            get;
            set;
        }
    }
    public class Universities
    {
        public string university
        {
            get;
            set;
        }
        public IList<Student> students
        {
            get;
            set;
        }
    }
    public class ClassUniversities
    {
        public Universities universities
        {
            get;
            set;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ClassUniversities university1 = new ClassUniversities();

            university1.universities = new Universities();
            university1.universities.university = "South Carolina StateUniversity";

            List<Student> listStudent = new List<Student>();
            Student student1 = new Student {
                name = "StephenCousins"
            };
            Student student2 = new Student {
                name = "Austin A. Newton"
            };
            Student student3 = new Student {
                name = "Adam Wilhite"
            };
            Student student4 = new Student {
                name = "Enis Kurtay YILMAZ"
            };

            listStudent.Add(student1);
            listStudent.Add(student2);
            listStudent.Add(student3);
            listStudent.Add(student4);

            university1.universities.students = listStudent;
            string json = JsonConvert.SerializeObject(university1);

            Console.WriteLine(json);
            Console.ReadLine();
        }
    }
}
