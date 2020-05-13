using Microsoft.EntityFrameworkCore;
using MobTasks.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobTasks.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Task> Tasks { get; set; }

        string _connectionString = "tasks.db";

        public DataContext()
        { }

        public DataContext(string ConnectionString)
        {
            _connectionString = ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_connectionString);        
        }
    }
}
