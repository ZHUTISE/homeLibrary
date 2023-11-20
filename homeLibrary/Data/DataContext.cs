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
        public DbSet<BookForm> BookForm { get; set; }
        public DbSet<Collection> Collection { get; set; }
        public DbSet<CollectionMap> CollectionMap { get; set; }
        public DbSet<Diary> Diary { get; set; }

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
                .HasOne(e => e.Form)
                .WithOne(e => e.Book)
                .HasForeignKey<BookForm>(e => e.BookId)
                .IsRequired();
            modelBuilder.Entity<Book>()
                .HasOne(e => e.Collection)
                .WithOne(e => e.Book)
                .HasForeignKey<CollectionMap>(e => e.BookId)
                .IsRequired(false);
            modelBuilder.Entity<Book>()
                .ToTable("book");


            modelBuilder.Entity<BookAuthor>()
                .HasKey(ba => new { ba.BookId, ba.AuthorId });
            modelBuilder.Entity<BookAuthor>()
                .HasOne(b => b._Book)
                .WithMany(ba => ba.BookAuthor)
                .HasForeignKey(b => b.BookId);
            modelBuilder.Entity<BookAuthor>()
                .HasOne(b => b._Author)
                .WithMany(ba => ba.BookAuthor)
                .HasForeignKey(a => a.AuthorId);
            modelBuilder.Entity<BookAuthor>()
                .Property(e => e.Created)
                .HasDefaultValueSql("now()");
            modelBuilder.Entity<BookAuthor>()
                .ToTable("book_author");


            modelBuilder.Entity<BookForm>()
                .Property(e => e.Created)
                .HasDefaultValueSql("now()");
            modelBuilder.Entity<BookForm>()
                .ToTable("book_form");


            modelBuilder.Entity<Collection>()
                .Property(e => e.Created)
                .HasDefaultValueSql("now()");
            modelBuilder.Entity<Collection>()
                 .ToTable("collection");


            modelBuilder.Entity<CollectionMap>()
                .Property(e => e.Created)
                .HasDefaultValueSql("now()");
            modelBuilder.Entity<CollectionMap>()
                 .ToTable("collection_map");


            modelBuilder.Entity<Diary>()
                .Property(e => e.Created)
                .HasDefaultValueSql("now()");
            modelBuilder.Entity<Diary>()
                .ToTable("diary");

        }
    }
}

