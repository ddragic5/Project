using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using static Project.Code.Program;

namespace Project.App
{
    
    public partial class Program
    {

        public static class Operations
        {
            public static void GetMenu()
            {
                Console.WriteLine("Choose between two operations (DISPLAY/ENLIST)");
                string mystring = null;
                mystring = Console.ReadLine();
                string str = mystring.ToUpper();

                switch (str)
                {
                    case "DISPLAY":
                        ShowAllStudents();
                        break;
                    case "ENLIST":
                        AddStudent();
                        GetMenu();
                        break;
                    default:
                        Console.WriteLine("Invalid operation, try again!");
                        GetMenu();
                        break;
                }
            }

            static void Main(string[] args)
            {
                {
                    Console.WriteLine("App is now ready!");
                }
                GetMenu();
            }
        }
    }
}