using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
namespace reportapi
{
    public class Program
    {
        public static void Main(string[] args)
        {
        var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddRazorPages();

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            string[] booklistset = { "Достоевский \"Идиот\"", "Куприн \"Сборник рассказов\"", "Лермонтов \"Мцыри\"", "Толстой \"Война и мир\"" };
            X.This.booklist.AddRange(booklistset);
            app.MapGet("/booklist", () => X.This.booklist);
            app.MapGet("/personnames", () => X.This.personnames);
            app.MapGet("/report", X.This.report);
            app.MapGet("/reports", () => X.This.reports);
            app.MapGet("/deletereport", X.This.deletereport);
            app.MapGet("/deletereports", X.This.deletereports);
            app.MapGet("/addbook", X.This.addbook);
            app.MapGet("/deletebook", X.This.deletebook);
            app.Run();
    }

        class X
        {
            private static X x = new X();
            private X()
            {
                reports = new List<string>();
                booklist = new List<string>();
            }
            public static X? This
            {
                get => x;
            }

            public List<string> booklist { get; set; }
            public List<string> personnames = new List<string>() { "Арбузов Н.В.", "Вылегжанина О.Ю.", "Иванов П.Р.", "Петров С.Е.", "Сидоров А.И." };
            public string report([FromQuery] string name, [FromQuery] string status, [FromQuery] string book, [FromQuery] string days)
            {
                string result = string.Empty;
                result = name + " " + status + " " + book + " Количество дней " + days;
                reports.Add(result);
                return result;
            }
            public void deletereport([FromQuery] string report)
            {
                string result = string.Empty;
                result = report;
                reports.Remove(result);
            }
            public void deletereports()
            {
                reports.Clear();
            }
            public void addbook([FromQuery] string book)
            {
                booklist.Add(book);
            }
            public void deletebook([FromQuery] string book)
            {
                booklist.Remove(book);
            }
            public List<string> reports { get; set; }
        }
    }
}
