﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Test_Dataaccess.Data;

namespace Test_Dataaccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211113090103_AddRenamecategoryTable")]
    partial class AddRenamecategoryTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Test_Model.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Test_Model.Models.Book", b =>
                {
                    b.Property<int>("Book_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookDetail_id")
                        .HasColumnType("int");

                    b.Property<int>("Category_Id")
                        .HasColumnType("int");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Publisher_Id")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Book_Id");

                    b.HasIndex("BookDetail_id")
                        .IsUnique();

                    b.HasIndex("Category_Id");

                    b.HasIndex("Publisher_Id");

                    b.ToTable("books");
                });

            modelBuilder.Entity("Test_Model.Models.BookDetails", b =>
                {
                    b.Property<int>("BookDetail_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NumberOfChapters")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumberofPages")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("BookDetail_id");

                    b.ToTable("BookDetails");
                });

            modelBuilder.Entity("Test_Model.Models.BookinAuthor", b =>
                {
                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("Book_Id")
                        .HasColumnType("int");

                    b.HasKey("AuthorId", "Book_Id");

                    b.HasIndex("Book_Id");

                    b.ToTable("BookInAuthors");
                });

            modelBuilder.Entity("Test_Model.Models.Category", b =>
                {
                    b.Property<int>("Categoru_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("categories_Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Categoru_Id");

                    b.ToTable("tbl-category");
                });

            modelBuilder.Entity("Test_Model.Models.FluentAPI.Fluenr_Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("fluenr_Authors");
                });

            modelBuilder.Entity("Test_Model.Models.FluentAPI.Fluent_Book", b =>
                {
                    b.Property<int>("Book_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Fluent_PublisherPublisher_Id")
                        .HasColumnType("int");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("PriceRange")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Book_Id");

                    b.HasIndex("Fluent_PublisherPublisher_Id");

                    b.ToTable("Fluent_Book");
                });

            modelBuilder.Entity("Test_Model.Models.FluentAPI.Fluent_BookDetails", b =>
                {
                    b.Property<int>("BookDetail_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NumberOfChapters")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumberofPages")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("BookDetail_id");

                    b.ToTable("Fluent_Books");
                });

            modelBuilder.Entity("Test_Model.Models.FluentAPI.Fluent_BookinAuthor", b =>
                {
                    b.Property<int>("Book_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int?>("Fluenr_AuthorAuthorId")
                        .HasColumnType("int");

                    b.HasKey("Book_Id");

                    b.HasIndex("Fluenr_AuthorAuthorId");

                    b.ToTable("fluent_BookinAuthors");
                });

            modelBuilder.Entity("Test_Model.Models.FluentAPI.Fluent_Publisher", b =>
                {
                    b.Property<int>("Publisher_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Publisher_Id");

                    b.ToTable("fluent_Publishers");
                });

            modelBuilder.Entity("Test_Model.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("GenreName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.HasKey("GenreId");

                    b.ToTable("tbl_Genre");
                });

            modelBuilder.Entity("Test_Model.Models.Publisher", b =>
                {
                    b.Property<int>("Publisher_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Publisher_Id");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("Test_Model.Models.Book", b =>
                {
                    b.HasOne("Test_Model.Models.BookDetails", "BookDetails")
                        .WithOne("Book")
                        .HasForeignKey("Test_Model.Models.Book", "BookDetail_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Test_Model.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("Category_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Test_Model.Models.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("Publisher_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookDetails");

                    b.Navigation("Category");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("Test_Model.Models.BookinAuthor", b =>
                {
                    b.HasOne("Test_Model.Models.Author", "Author")
                        .WithMany("BookinAuthors")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Test_Model.Models.Book", "Book")
                        .WithMany("BookinAuthors")
                        .HasForeignKey("Book_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("Test_Model.Models.FluentAPI.Fluent_Book", b =>
                {
                    b.HasOne("Test_Model.Models.FluentAPI.Fluent_Publisher", null)
                        .WithMany("Books")
                        .HasForeignKey("Fluent_PublisherPublisher_Id");
                });

            modelBuilder.Entity("Test_Model.Models.FluentAPI.Fluent_BookinAuthor", b =>
                {
                    b.HasOne("Test_Model.Models.FluentAPI.Fluenr_Author", null)
                        .WithMany("BookinAuthors")
                        .HasForeignKey("Fluenr_AuthorAuthorId");
                });

            modelBuilder.Entity("Test_Model.Models.Author", b =>
                {
                    b.Navigation("BookinAuthors");
                });

            modelBuilder.Entity("Test_Model.Models.Book", b =>
                {
                    b.Navigation("BookinAuthors");
                });

            modelBuilder.Entity("Test_Model.Models.BookDetails", b =>
                {
                    b.Navigation("Book");
                });

            modelBuilder.Entity("Test_Model.Models.FluentAPI.Fluenr_Author", b =>
                {
                    b.Navigation("BookinAuthors");
                });

            modelBuilder.Entity("Test_Model.Models.FluentAPI.Fluent_Publisher", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Test_Model.Models.Publisher", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
