using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Model.Models.FluentAPI;
using Test_Model.Models;

namespace Test_Dataaccess.Data
{
   public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Book> books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

        public DbSet<BookDetails> BookDetails { get; set; }
        public DbSet<BookinAuthor> BookInAuthors { get; set; }
        public DbSet<Fluent_BookDetails> Fluent_Books { get; set; }

        public DbSet<Fluent_Book> Fluent_Book { get; set; }
        public DbSet<Fluent_BookinAuthor> fluent_BookinAuthors { get; set; }
        public DbSet<Fluenr_Author> fluenr_Authors { get; set; }
        public DbSet<Fluent_Publisher> fluent_Publishers{ get; set; }

        public DbSet<Fluent_Category> Fluent_Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookinAuthor>().HasKey(ba => new { ba.AuthorId, ba.Book_Id });
            //fluent Book Model
            modelBuilder.Entity<Fluent_BookDetails>().HasKey(b => b.BookDetail_id);
            modelBuilder.Entity<Fluent_BookDetails>().Property(c => c.NumberOfChapters).IsRequired();
            modelBuilder.Entity<Fluent_Book>().HasKey(b => b.Book_Id);
            modelBuilder.Entity<Fluent_Book>().Property(c => c.ISBN).IsRequired();
            modelBuilder.Entity<Fluent_Book>().Property(c => c.Price).IsRequired();


            //Fluent Book Autrhor
            modelBuilder.Entity<Fluenr_Author>().HasKey(b => b.AuthorId);
            modelBuilder.Entity<Fluenr_Author>().Property(c => c.FirstName).IsRequired();
            modelBuilder.Entity<Fluenr_Author>().Property(b => b.LastName);
            modelBuilder.Entity<Fluenr_Author>().Ignore(c => c.FullName);

            modelBuilder.Entity<Fluent_Publisher>().HasKey(b => b.Publisher_Id);
            modelBuilder.Entity<Fluent_Publisher>().Property(c => c.Name).IsRequired();
            modelBuilder.Entity<Fluent_Publisher>().Property(c => c.Location).IsRequired();


            modelBuilder.Entity<Fluent_BookinAuthor>().HasKey(b => b.Book_Id);

            modelBuilder.Entity<Fluent_Category>().HasKey(b => b.Categoru_Id);
            modelBuilder.Entity<Fluent_Category>().ToTable("Fluent_Category");
            modelBuilder.Entity<Fluent_Category>().Property(a => a.Name).HasColumnName("Category_Name");

            //One to one Relationship between Book And Book Details with Fluent API
            modelBuilder.Entity<Fluent_Book>().HasOne(a => a.Fluent_BookDetail)
                .WithOne(a => a.Fluent_Book)
                .HasForeignKey<Fluent_Book>(c => c.BookDetail_id);

            //One to Many Relationship between Book And Publisher with Fluent API
            modelBuilder.Entity<Fluent_Book>().HasOne(a => a.Fluent_Publisher)
                .WithMany(a => a.Fluent_Books)
                .HasForeignKey(c => c.Publisher_Id);

            modelBuilder.Entity<Fluent_BookinAuthor>().HasOne(a => a.Fluent_Book)
                .WithMany(b => b.Fluent_BookinAuthors)
                .HasForeignKey(c => c.Book_Id);

            modelBuilder.Entity<Fluent_BookinAuthor>().HasOne(a => a.Fluenr_Author)
               .WithMany(a => a.Fluent_BookinAuthors)
               .HasForeignKey(c => c.AuthorId);

        }
    }
}
