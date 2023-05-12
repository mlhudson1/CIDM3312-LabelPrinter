﻿// <auto-generated />
using System;
using LabelPrinter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CIDM3312_LabelPrinter.Migrations
{
    [DbContext(typeof(LabelContext))]
    partial class LabelContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("LabelPrinter.Models.Lbl_Bin", b =>
                {
                    b.Property<int>("Lbl_BinID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("addDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("binID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("binName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("qty")
                        .HasColumnType("INTEGER");

                    b.HasKey("Lbl_BinID");

                    b.ToTable("Lbls_Bin");
                });

            modelBuilder.Entity("LabelPrinter.Models.Lbl_Item", b =>
                {
                    b.Property<int>("Lbl_ItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("addDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("item")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("qty")
                        .HasColumnType("INTEGER");

                    b.Property<string>("upc")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Lbl_ItemID");

                    b.ToTable("Lbls_Item");
                });

            modelBuilder.Entity("LabelPrinter.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("LabelPrinter.Models.UserLbl_Bin", b =>
                {
                    b.Property<int>("Lbl_BinID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserID")
                        .HasColumnType("INTEGER");

                    b.HasKey("Lbl_BinID", "UserID");

                    b.HasIndex("UserID");

                    b.ToTable("UserLbl_Bin");
                });

            modelBuilder.Entity("LabelPrinter.Models.UserLbl_Item", b =>
                {
                    b.Property<int>("Lbl_ItemID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserID")
                        .HasColumnType("INTEGER");

                    b.HasKey("Lbl_ItemID", "UserID");

                    b.HasIndex("UserID");

                    b.ToTable("UserLbl_Item");
                });

            modelBuilder.Entity("LabelPrinter.Models.UserLbl_Bin", b =>
                {
                    b.HasOne("LabelPrinter.Models.Lbl_Bin", "Lbl_Bin")
                        .WithMany("UserLbl_Bins")
                        .HasForeignKey("Lbl_BinID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LabelPrinter.Models.User", "User")
                        .WithMany("UserLbl_Bins")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lbl_Bin");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LabelPrinter.Models.UserLbl_Item", b =>
                {
                    b.HasOne("LabelPrinter.Models.Lbl_Item", "Lbl_Item")
                        .WithMany("UserLbl_Items")
                        .HasForeignKey("Lbl_ItemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LabelPrinter.Models.User", "User")
                        .WithMany("UserLbl_Items")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lbl_Item");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LabelPrinter.Models.Lbl_Bin", b =>
                {
                    b.Navigation("UserLbl_Bins");
                });

            modelBuilder.Entity("LabelPrinter.Models.Lbl_Item", b =>
                {
                    b.Navigation("UserLbl_Items");
                });

            modelBuilder.Entity("LabelPrinter.Models.User", b =>
                {
                    b.Navigation("UserLbl_Bins");

                    b.Navigation("UserLbl_Items");
                });
#pragma warning restore 612, 618
        }
    }
}
