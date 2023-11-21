using System;
using homeLibrary.Models;
using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace homeLibrary.Data
{
	public class DataContext : DbContext
	{
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Author> Author { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<BookAuthor> BookAuthor { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("library");

            modelBuilder.Entity<Author>()
                .Property(e => e.Created)
                .HasDefaultValueSql("now()");
            modelBuilder.Entity<Author>()
                .ToTable("author");


            modelBuilder.Entity<Book>()
                .Property(e => e.Created)
                .HasDefaultValueSql("now()");
            modelBuilder.Entity<Book>()
                .ToTable("book");


            modelBuilder.Entity<BookAuthor>()
                .HasKey(ba => new { ba.BookId, ba.AuthorId });
            modelBuilder.Entity<BookAuthor>()
                .HasOne(b => b.Book)
                .WithMany(ba => ba.BookAuthor)
                .HasForeignKey(b => b.BookId);
            modelBuilder.Entity<BookAuthor>()
                .HasOne(b => b.Author)
                .WithMany(ba => ba.BookAuthor)
                .HasForeignKey(a => a.AuthorId);
            modelBuilder.Entity<BookAuthor>()
                .Property(e => e.Created)
                .HasDefaultValueSql("now()");
            modelBuilder.Entity<BookAuthor>()
                .ToTable("book_author");
        }
    }
}

