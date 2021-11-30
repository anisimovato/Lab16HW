using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Lab16pat3
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonString;
            jsonString = File.ReadAllText("person1.json");
            Console.WriteLine(jsonString);
            Console.ReadKey();
        }
    }
}
// products = JsonSerializer.Deserialize<Product>(jsonString);
//StreamReader sr = new StreamReader("person1.json");
//string products = sr.ReadLine();
//foreach (var number in products.Split())
//{
//    Console.WriteLine(number);
//}
//char[] newarrey = products.ToArray();

//Person person = JsonSerializer.Deserialize<Person>(jsonString)
//int Sum = 0;
////for (int j = 0; j < newarrey.Length; j++)
//{

//    Sum += newarrey[j];
//}


//Console.WriteLine("Сумма=" + Sum);