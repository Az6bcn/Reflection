using System;
using System.Linq;
using System.Reflection;

namespace Reflection
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var assembly = Assembly.GetExecutingAssembly();

            Console.WriteLine($"current assembly name: {assembly.GetName()}");
            Console.WriteLine($"current assembly fullname: {assembly.FullName}");
            Console.WriteLine($"current assembly version: {assembly.GetName().Version}");
            Console.WriteLine($"current assembly culture info: {assembly.GetName().CultureInfo}");
            Console.WriteLine($"current assembly culture name: {assembly.GetName().CultureName}");
            Console.WriteLine($"current assembly location: {assembly.Location}");

            var typeInfo = typeof(Student);

            Console.WriteLine($"namespace: {typeInfo.Namespace}");
            Console.WriteLine($"name: {typeInfo.Name}");

            var properties = typeInfo.GetProperties().ToList();
            properties.ForEach(x =>
            {
                Console.WriteLine(x.Name, x.PropertyType);
            });

            Console.WriteLine("********************************** M E T H O D *******************************************");
            typeInfo.GetMethods().ToList().ForEach(x => { Console.WriteLine($"{x.Name}, {x.IsPrivate}, {x.IsPublic}, {x.ReturnType}"); });

            Console.WriteLine("********************************** T Y P E S *******************************************");
            Assembly.GetExecutingAssembly().GetTypes().ToList().ForEach(x => { Console.WriteLine($"Type: {x.Name} is public?: {x.IsPublic} properties count: {x.GetProperties().ToList().Count}"); });


            Assembly.GetExecutingAssembly().GetTypes().ToList().ForEach(x => { Console.WriteLine($"declared properties count: {x.GetTypeInfo().DeclaredProperties.ToList().Count}"); });
        }
    }

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
}
