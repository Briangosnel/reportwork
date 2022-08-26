using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Reflection;
using System.Diagnostics;

namespace bookmanage
{
    internal class Program
    {
        public static void Main()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Список книг:");
                Console.ResetColor();
                booklist().GetAwaiter().GetResult();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Хотите удалить иди добавить книгу?(add/remove)");
                Console.ResetColor();
                string addorremove = Console.ReadLine();
                if (addorremove == "add")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Введите название");
                    Console.ResetColor();
                    bookadd(Console.ReadLine());
                }
                else if (addorremove == "remove")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Введите название");
                    Console.ResetColor();
                    bookdelete(Console.ReadLine());
                }
            }
        }
        public static async Task<List<string>> booklist()
        {
            await Task.Delay(1000); // Задержку добавил, т.к. список иногда не успевал обновляться.
            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri(@"https://localhost:7105"),
            };
            var response = await client.GetAsync("/booklist");
            string str = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<string>>(str);
            foreach(string s in result)
            {
                Console.WriteLine(s);
            }
            return result;
        }
        public static async void bookadd(string book)
        {
            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri(@"https://localhost:7105"),
            };
            var response = await client.GetAsync($"/addbook?book={book}");
        }
        public static async void bookdelete(string book)
        {
            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri(@"https://localhost:7105"),
            };
            var response = await client.GetAsync($"/deletebook?book={book}");
        }
    }
}