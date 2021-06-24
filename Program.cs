using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Counters
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new ApplicationDbContext();            
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            Console.WriteLine($"PID: {System.Diagnostics.Process.GetCurrentProcess().Id}");

            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                db.Pessoas.Add(new Pessoa {
                    Nome =  "Tony Stark"
                });

                db.SaveChanges();

                _ = db.Pessoas.Find(1);
                _ = db.Pessoas.AsNoTracking().FirstOrDefault();
            }
        }
    }
}
