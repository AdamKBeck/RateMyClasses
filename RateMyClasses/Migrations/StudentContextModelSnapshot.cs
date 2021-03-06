﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using RateMyClasses.Models;
using System;

namespace RateMyClasses.Migrations.Student
{
    [DbContext(typeof(StudentContext))]
    partial class StudentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("RateMyClasses.Models.Student", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("firstName");

                    b.Property<bool>("isModerator");

                    b.Property<string>("lastName");

                    b.Property<string>("studentStatus");

                    b.Property<string>("userName");

                    b.HasKey("id");

                    b.ToTable("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
