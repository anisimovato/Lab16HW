using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.IO;

namespace Lab16HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[5];
            products[0] = new Product(1, "Цветы", 500, "Фиалка");
            products[1] = new Product(2, "Цветы", 600, "Сирень");
            products[2] = new Product(3, "Цветы", 700, "Ромашка");
            products[3] = new Product(4, "Цветы", 800, "Роза");
            products[4] = new Product(5, "Цветы", 900, "Орхидея");

            {
            };
            JsonSerializerOptions options = new JsonSerializerOptions()           // чтоб русские буквы были
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),                                                        //диапазон используемых символов
                WriteIndented = true  // добавляет пробелы
            };
            string jsonString1 = JsonSerializer.Serialize(products, options);  //typeof(Person)
            //Console.WriteLine(jsonString1);
            //Console.ReadKey();
            StreamWriter file = File.CreateText("person1.json");                                                                      // создаем строку
            file.WriteLine(jsonString1);
            file.Close();
        }
    }
    public class Product
    {
        [JsonPropertyName("Код товара")]
        public int Code { get; set; }
        [JsonPropertyName("Вид")]
        public string TipeProduct { get; set; }
        [JsonPropertyName("Цена")]
        public decimal Price { get; set; }
        [JsonPropertyName("Наименование")]
        public string Name { get; set; }

        public Product(int code, string tipeProduct, decimal price, string name)
        {
            Code = code;
            TipeProduct = tipeProduct;
            Price = price;
            Name = name;
        }
    }
}



//.    Необходимо разработать программу для записи информации о товаре в текстовый файл в формате json.

//Разработать класс для моделирования объекта «Товар». Предусмотреть члены класса «Код товара» (целое число), «Название товара» (строка), «Цена товара» (вещественное число).
//Создать массив из 5-ти товаров, значения должны вводиться пользователем с клавиатуры.
//Сериализовать массив в json-строку, сохранить ее программно в файл «Products.json».

//2.    Необходимо разработать программу для получения информации о товаре из json-файла.
//Десериализовать файл «Products.json» из задачи 1. Определить название самого дорогого товара.