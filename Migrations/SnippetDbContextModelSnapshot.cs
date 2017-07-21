﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using iSnippets.Models;

namespace iSnippets.Migrations
{
    [DbContext(typeof(SnippetDbContext))]
    partial class SnippetDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1");

            modelBuilder.Entity("iSnippets.Models.Snippet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Language");

                    b.Property<string>("SnippetText");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.ToTable("Snippets");
                });
        }
    }
}
