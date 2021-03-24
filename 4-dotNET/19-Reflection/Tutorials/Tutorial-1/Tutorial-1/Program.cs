using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Tutorial_1
{
    class Program
    {
        private const string Tab = "\t";
        static void Main(string[] args)
        {
            //ShowClassesInfo();


            /*var student = new Student();
            student.ShowSecret();

            Type studentType = typeof(Student);

            FieldInfo field = studentType.GetField("StudentsSecret", BindingFlags.NonPublic | BindingFlags.Instance);
            field.SetValue(student,"Secret exposed!!!");
            student.ShowSecret();*/

            TypeAttributes ta = typeof(Console).Attributes;
            MethodAttributes ma = MethodInfo.GetCurrentMethod().Attributes;
            Console.WriteLine(ta + "\r\n" + ma);
        }
        public static void ShowClassesInfo()
        {
            var assembly = Assembly.GetExecutingAssembly();

            var types = assembly.GetTypes();

            types = types.Reverse().ToArray();

            foreach (var type in types)
            {

                Console.WriteLine("Class: {0}", type.Name);
                var methods = type.GetMethods();

                foreach (var method in methods)
                {
                    Console.WriteLine(Tab + method.Name);
                    var parameters = method.GetParameters();

                    foreach (var parameter in parameters)
                    {
                        var name = parameter.Name;
                        var parameterType = parameter.ParameterType;
                        Console.WriteLine(Tab + Tab + "Parameter: " + name + "  |  Type: " + parameterType);
                    }
                }
                Console.WriteLine();
            }
        }

    }
}
