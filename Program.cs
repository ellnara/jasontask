using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pro> orders = new List<Pro>();
            Pro p1 = new Pro()
            {
                Name = "nokia",
                Id = 1,
                Price = 48

            }; Pro p2 = new Pro()
            {
                Name = "apple",
                Id = 2,
                Price = 5215
            };
            orders.Add(p1);
            orders.Add(p2);

            using (StreamWriter salam = new StreamWriter(@"C:/Users/Emil Hajizade/Desktop\hello\asd.txt"))
            {
                salam.WriteLine("salam");

            };
            var json = JsonConvert.SerializeObject(orders);
            string result;
            using (StreamReader streamReader = new StreamReader(@"C:\Users\Emil Hajizade\source\repos\ConsoleApp13\ConsoleApp13\Files\json1.json"))
            {
                result = streamReader.ReadToEnd();
            }

            var parrseResult = JsonConvert.DeserializeObject(result);
            Console.WriteLine(parrseResult);
        }
    }
}
