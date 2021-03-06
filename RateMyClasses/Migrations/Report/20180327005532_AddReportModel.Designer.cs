﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using RateMyClasses.Models;
using System;

namespace RateMyClasses.Migrations.Report
{
    [DbContext(typeof(ReportContext))]
    [Migration("20180327005532_AddReportModel")]
    partial class AddReportModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("RateMyClasses.Models.Report", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("isHandled");

                    b.Property<string>("reportContent");

                    b.Property<long>("reviewID");

                    b.HasKey("id");

                    b.ToTable("Report");
                });
#pragma warning restore 612, 618
        }
    }
}
