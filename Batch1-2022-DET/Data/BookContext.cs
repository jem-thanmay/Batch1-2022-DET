using Batch1_2022_DET.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_2022_DET.Data
{
  
    public class BookContext : DbContext
    {
        
        public BookContext()
        {

        }


        public BookContext(DbContextOptions<BookContext> options)
            : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
       // public virtual DbSet<Book> Book { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)

                optionsBuilder.UseSqlServer("Server=6B5ZQG2-SHEL\\SQLEXPRESS;Database=Thanmay;Trusted_Connection=True;MultipleActiveResultSets=True");
        }



        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{



        //    //Property Configurations
        //    //Fluent API
        //    modelBuilder.Entity<Book>()
           
        //   .Property(b => b.price)
        //   .IsRequired() //[Required]
        //   .HasColumnName("BKprice") //[Column("bkprice")]
        //   .HasDefaultValue(200);

        //}

    }
}
    