using System;
using System.Reflection;

namespace ReflectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //var personMethods = typeof(Person).GetMethods();

            //foreach (var item in personMethods)
            //{
            //    Console.WriteLine(item.Name);
            //}



            var personMethodsSecond = typeof(Person).GetMethod("GetA");
            var personInstance = Activator.CreateInstance(typeof(Person), 20);
            var result = personMethodsSecond.Invoke(personInstance, new object[] {});
            Console.WriteLine(personMethodsSecond.ReturnType);


            //var personConstructor = typeof(Person).GetConstructor(new Type[] { typeof(int) });
            //var person = personConstructor.Invoke(new object[] { 10 }) as Person;

            //Console.WriteLine(person.A);




            //var ageField = typeof(Person).GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);

            //Console.WriteLine(ageField.IsPublic);



            //var type = typeof(Person);
            //Console.WriteLine(type.GetProperty("Age").PropertyType.Name); //Int 32
            //Console.WriteLine(type.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance).Name); //age




            //var person = Activator.CreateInstance(typeof(Person), 10) as Person;

            //Console.WriteLine(person.Age);



            //Type personType = typeof(Person);
            ////var person = new Person();
            //var person = Activator.CreateInstance(personType) as Person;
            //person.Age = 20;

            //Console.WriteLine(personType.GetProperty("Age").Name);

            //var result = personType.GetProperty("Age").GetValue(person);
            //Console.WriteLine(result); //20

            //Type personType = typeof(Person);
            //var propName = personType.GetProperty("Age");
            //Console.WriteLine(propName);

            //var getType = GetType("ReflectionDemo.Person");
            //Console.WriteLine(getType.Name);
        }

        static Type GetType(string name)
        {
            var type = Type.GetType(name);

            return type;
        }
    }
}
