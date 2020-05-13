using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using MobTasks.Data;
using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace MobTasks.ConsoleApp
{
    class Program
    {
        private static DataContext context;
        static void Main(string[] args)
        {
            
            string connectionStringBuilder = new SqliteConnectionStringBuilder()
            {
                DataSource = "tasks.db"
            }.ToString();

            Console.WriteLine(connectionStringBuilder);

            var context = new DataContext(connectionStringBuilder);

            context.Database.EnsureCreated();

            Console.WriteLine($"Found {context.Tasks.Count()} tasks.");

            context.Tasks.Add(new Domain.Task() { Id = Guid.NewGuid().ToString(), Name = "Dave" });
            context.SaveChanges();


            var tasks = context.Tasks.ToList();
            foreach (var task in tasks)
            {
                Console.Write(task.Id);
                Console.WriteLine(task.Name);
            }

            Console.WriteLine($"Found {context.Tasks.Count()} tasks.");
        }
    }
}
