using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Code
{ 
        public partial class Program
        {
            public static List<StudentContainer> lStudents = new List<StudentContainer>();
            public  class StudentIdGenerator
            {
                public Guid id = Guid.NewGuid();
            }
            public abstract class Person : StudentIdGenerator
            {


                public string name;

                public string surname;
            }
        public class Student : Person
        {
            public string gpa;
        }
            public partial class StudentContainer : Student
            {
                
                public StudentContainer(Guid id, string name, string surname, string gpa)
                {
                    this.id = id;
                    this.name = name;
                    this.surname = surname;
                    this.gpa = gpa;
                }
                public Guid Id
                {
                    get
                    {
                        return id;
                    }
                    private set
                    {
                        id = value;
                    }
                }

                public string Name
                {
                    get
                    {
                        return name;
                    }
                    set
                    {
                        name = value;
                    }
                }

                public string Surname
                {
                    get
                    {
                        return surname;
                    }
                    set
                    {
                        surname = value;
                    }
                }

                public string GPA
                {
                    get
                    {
                        return GPA;
                    }
                    set
                    {
                        GPA = value;
                    }
                }
            }

            public static void AddStudent()
            {
                string studentname, studentsurname, studentgpa;
                
                Guid studentid = Guid.NewGuid();
                Console.WriteLine("Name: ");
                studentname = Console.ReadLine();
                while (String.IsNullOrEmpty(studentname))
                {
                    Console.WriteLine("You need insert value");
                    Console.WriteLine("Name: ");
                    studentname = Console.ReadLine();
                }

                Console.WriteLine("Surname: ");
                studentsurname = Console.ReadLine();
                while (String.IsNullOrEmpty(studentsurname))
                {
                    Console.WriteLine("You need insert value");
                    Console.WriteLine("Surname: ");
                    studentsurname = Console.ReadLine();
                }

                decimal gpa;
                Console.WriteLine("GPA: ");
                studentgpa = Console.ReadLine();
                while (!decimal.TryParse(studentgpa, out gpa))
                {
                    Console.WriteLine("You need to insert numerical value.");
                    Console.WriteLine("GPA: ");
                    studentgpa = Console.ReadLine();
                }

                lStudents.Add(new StudentContainer(studentid,
                        studentname,
                        studentsurname,
                        studentgpa));

                Console.WriteLine("You have successfully added a Student!");

                
            }

            public static void ShowAllStudents()
            {
                lStudents.Sort((x, y) => string.Compare(x.Surname, y.Surname));
                Console.WriteLine("Students in a system: ");
                foreach (StudentContainer s in lStudents)
                {
                    Console
                        .WriteLine("ID: {0}, Name: {1}, Surname: {2}, GPA: {3}",
                        s.id,
                        s.name,
                        s.surname,
                        s.gpa);
                }
            }
        }
    }

