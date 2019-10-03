using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Reflection
{
    public class ejercicio1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("*******************************Executing Assemblies***************************");
            var assembly = Assembly.GetExecutingAssembly();
            Console.WriteLine($"Executing assembly is : {assembly.FullName}");

            Console.WriteLine("*******************************Types in Executing Assemblies***************************");
            var types = assembly.GetTypes();
            var list = new List<Type>();
            foreach (var item in types)
            {
                list.Add(item);
                Console.WriteLine($"Type name: {item.Name}");
            }

            Console.WriteLine("*******************************Types in University Namespace***************************");
            var typesInUniversityNamespace = list.Where(x => x.Namespace.StartsWith("University")).ToList();

            typesInUniversityNamespace.ForEach(x =>
            {
                Console.WriteLine($"type name: { x.Name}");
            });
        }
    }
}

namespace University
{

    public class Student
    {
        public string FullName { get; set; }

        public int Class { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string GetCharacteristics()
        {
            return "";
        }
    }

    namespace Department
    {

        public class Professor
        {

            public string FullName { get; set; }

        }
    }
}