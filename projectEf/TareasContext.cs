using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using projectEf.Models;

namespace projectEf
{
    public class TareasContext: DbContext
    {
        public DbSet<Categories> categories {get; set;}
        public DbSet<Taskes> tasks {get; set;}

        public TareasContext(DbContextOptions<TareasContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>(cat=>
            {
                cat.ToTable("Categoria");
                cat.HasKey(x => x.categoryID);
                cat.Property(x => x.name).IsRequired().HasMaxLength(150);
                cat.Property(x => x.description);
            
        });
        modelBuilder.Entity<Taskes>(task=>
        {
            task.ToTable("Tarea");
            task.HasKey(x=> x.taskID);
            task.HasOne(x=> x.category).WithMany(x=>x.tasks).HasForeignKey(x=> x.categoryID);
            task.Property(x=> x.title).IsRequired().HasMaxLength(200);
            task.Property(x=>x.description);
            task.Property(x=>x.prioridadTask);
            task.Property(x=> x.creationDate);
            task.Ignore(x=> x.summary);       
            

        });
        }

    }
}