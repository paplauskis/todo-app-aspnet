﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using todo_app.Data.Context;

#nullable disable

namespace todo_app.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241020110233_Update")]
    partial class Update
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("todo_app.Models.SimpleTodo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at")
                        .HasAnnotation("Relational:JsonPropertyName", "created_at");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description")
                        .HasAnnotation("Relational:JsonPropertyName", "description");

                    b.Property<string>("Image")
                        .HasColumnType("text")
                        .HasColumnName("image")
                        .HasAnnotation("Relational:JsonPropertyName", "image");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_completed")
                        .HasAnnotation("Relational:JsonPropertyName", "is_completed");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name")
                        .HasAnnotation("Relational:JsonPropertyName", "name");

                    b.Property<int>("Priority")
                        .HasColumnType("integer")
                        .HasColumnName("priority")
                        .HasAnnotation("Relational:JsonPropertyName", "priority");

                    b.HasKey("Id");

                    b.ToTable("simple_todo", (string)null);
                });

            modelBuilder.Entity("todo_app.Models.TimedTodo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at")
                        .HasAnnotation("Relational:JsonPropertyName", "created_at");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description")
                        .HasAnnotation("Relational:JsonPropertyName", "description");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("due_date")
                        .HasAnnotation("Relational:JsonPropertyName", "due_date");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_completed")
                        .HasAnnotation("Relational:JsonPropertyName", "is_completed");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name")
                        .HasAnnotation("Relational:JsonPropertyName", "name");

                    b.HasKey("Id");

                    b.ToTable("timed_todo", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
