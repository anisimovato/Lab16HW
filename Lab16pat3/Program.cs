using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lab16pat3
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonString;
            jsonString = File.ReadAllText("person1.json");
            Console.WriteLine(jsonString);
            string jsonString1 = "[{\"Код товара\": 1, \"Вид\": \"Цветы\",\"Цена\": 500,\"Наименование\": \"Фиалка\"},{\"Код товара\": 2,\"Вид\": \"Цветы\",\"Цена\": 600,\"Наименование\": \"Сирень\"},{\"Код товара\": 3,\"Вид\":\"Цветы\",\"Цена\": 700,\"Наименование\": \"Ромашка\"},{\"Код товара\": 4,\"Вид\": \"Цветы\",\"Цена\": 800,\"Наименование\": \"Роза\"},{\"Код товара\": 5,\"Вид\": \"Цветы\",\"Цена\": 900,\"Наименование\": \"Орхидея\"}]";
            
            Product[] product = JsonSerializer.Deserialize<Product[]>(jsonString1);
            Console.ReadKey();
        }
    }
    class Product
    {
        [JsonPropertyName("Код товара")]
        public int Code { get; set; }
        [JsonPropertyName("Вид")]
        public string TipeProduct { get; set; }
        [JsonPropertyName("Цена")]
        public decimal Price { get; set; }
        [JsonPropertyName("Наименование")]
        public string Name { get; set; }
    }
}


//string jsonString = "{\"firstName\":\"Tom\",\"lastName\": \"Jekson\", \"gender\" : \"male\",\"age\":29,\"onlain\":true,\"hobby\":[ \"footbol\",\"reading\",\"swimming\"]}";

//[
//  {
//    "Код товара": 1,
//    "Вид": "Цветы",
//    "Цена": 500,
//    "Наименование": "Фиалка"
//  },
//  {
//    "Код товара": 2,
//    "Вид": "Цветы",
//    "Цена": 600,
//    "Наименование": "Сирень"
//  },
//  {
//    "Код товара": 3,
//    "Вид": "Цветы",
//    "Цена": 700,
//    "Наименование": "Ромашка"
//  },
//  {
//    "Код товара": 4,
//    "Вид": "Цветы",
//    "Цена": 800,
//    "Наименование": "Роза"
//  },
//  {
//    "Код товара": 5,
//    "Вид": "Цветы",
//    "Цена": 900,
//    "Наименование": "Орхидея"
//  }
//]


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
// char[] products = jsonString.ToArray();

