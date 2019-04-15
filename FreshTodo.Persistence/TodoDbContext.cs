using FreshToDo.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace FreshToDo.Persistence
{
    public class ToDoDbContext : DbContext
    {
        public ToDoDbContext(DbContextOptions<ToDoDbContext> options) 
            : base (options)
        {
            
        }


        public DbSet<ToDoItem> TodoItems { get; set; }
    }
}
