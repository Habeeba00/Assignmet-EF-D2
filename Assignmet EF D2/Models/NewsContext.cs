using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Assignmet_EF_D2.Models
{
    public class NewsContext:DbContext
    {
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Catalog> Catalog { get; set; }
        public virtual DbSet<Author>Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=HABEEEEBA\\SQLEXPRESS;Database=NewsDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //composite key
            //modelBuilder.Entity<>().HasKey("", "");

            
            modelBuilder.Entity<Author>().HasData
                (
                new Author() {Author_Id=1,Name="Habiba Mohamed",JoinDate = new DateOnly(2009, 7, 2),Username="Habiba",Password="12345",ConfirmPassword="12345",Bref=""},
                new Author() {Author_Id=2,Name = "Tasnim Mohamed", JoinDate = new DateOnly(2005,8, 31), Username = "tasnim", Password = "12345", ConfirmPassword = "12345", Bref = "" }
                );
            modelBuilder.Entity<Catalog>().HasData
               (
                new Catalog() { Catalog_Id=1,Name ="Sports", Description = "Sports" },
                new Catalog() { Catalog_Id=2,Name = "Beuaty", Description = "Beuaty" }

               );
            modelBuilder.Entity<News>().HasData
                (
                new News() { News_Id=1,Bref = "Football", Description = "collective game", DateTime = new DateTime(2000, 2, 2), Catalog_Id = 1, Auther_Id = 1 },

                new News() {News_Id=2, Bref = "Padel", Description = "individual game", DateTime = new DateTime(2002, 5, 15), Catalog_Id = 1, Auther_Id = 1 }

                );
        }


    }
}
