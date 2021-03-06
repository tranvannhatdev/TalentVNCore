﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TalentVN.Infrastructure.Data;

namespace Infrastructure.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190502080904_InitialModel")]
    partial class InitialModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TalentVN.ApplicationCore.Entities.Account", b =>
                {
                    b.Property<string>("AccountID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccountType");

                    b.Property<string>("Address");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsLogin");

                    b.Property<string>("LastName");

                    b.Property<string>("PassWord");

                    b.Property<string>("RoleID");

                    b.Property<string>("UserName");

                    b.HasKey("AccountID");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("TalentVN.ApplicationCore.Entities.Group", b =>
                {
                    b.Property<string>("GroupID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("GroupID");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("TalentVN.ApplicationCore.Entities.GroupAccount", b =>
                {
                    b.Property<string>("AccountID");

                    b.Property<string>("GroupID");

                    b.HasKey("AccountID", "GroupID");

                    b.HasIndex("GroupID");

                    b.ToTable("GroupAccounts");
                });

            modelBuilder.Entity("TalentVN.ApplicationCore.Entities.News", b =>
                {
                    b.Property<string>("NewsID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body");

                    b.Property<string>("Header");

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name");

                    b.Property<int>("NewsType");

                    b.HasKey("NewsID");

                    b.ToTable("News");
                });

            modelBuilder.Entity("TalentVN.ApplicationCore.Entities.Notify", b =>
                {
                    b.Property<string>("NotifyID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Message");

                    b.Property<string>("TeacherID");

                    b.Property<int>("Type");

                    b.HasKey("NotifyID");

                    b.HasIndex("TeacherID");

                    b.ToTable("Notifys");
                });

            modelBuilder.Entity("TalentVN.ApplicationCore.Entities.NotifyGroup", b =>
                {
                    b.Property<string>("NotifyID");

                    b.Property<string>("GroupID");

                    b.HasKey("NotifyID", "GroupID");

                    b.HasIndex("GroupID");

                    b.ToTable("NotifyGroups");
                });

            modelBuilder.Entity("TalentVN.ApplicationCore.Entities.Student", b =>
                {
                    b.Property<string>("StudentID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccountID");

                    b.Property<string>("MSSV");

                    b.HasKey("StudentID");

                    b.HasIndex("AccountID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("TalentVN.ApplicationCore.Entities.Teacher", b =>
                {
                    b.Property<string>("TeacherID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccountID");

                    b.Property<string>("MSGV");

                    b.HasKey("TeacherID");

                    b.HasIndex("AccountID");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("TalentVN.ApplicationCore.Entities.GroupAccount", b =>
                {
                    b.HasOne("TalentVN.ApplicationCore.Entities.Account", "Account")
                        .WithMany("GroupAccounts")
                        .HasForeignKey("AccountID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TalentVN.ApplicationCore.Entities.Group", "Group")
                        .WithMany("GroupAccounts")
                        .HasForeignKey("GroupID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TalentVN.ApplicationCore.Entities.Notify", b =>
                {
                    b.HasOne("TalentVN.ApplicationCore.Entities.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherID");
                });

            modelBuilder.Entity("TalentVN.ApplicationCore.Entities.NotifyGroup", b =>
                {
                    b.HasOne("TalentVN.ApplicationCore.Entities.Group", "Group")
                        .WithMany("NotifyGroups")
                        .HasForeignKey("GroupID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TalentVN.ApplicationCore.Entities.Notify", "Notify")
                        .WithMany("NotifyGroups")
                        .HasForeignKey("NotifyID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TalentVN.ApplicationCore.Entities.Student", b =>
                {
                    b.HasOne("TalentVN.ApplicationCore.Entities.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountID");
                });

            modelBuilder.Entity("TalentVN.ApplicationCore.Entities.Teacher", b =>
                {
                    b.HasOne("TalentVN.ApplicationCore.Entities.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountID");
                });
#pragma warning restore 612, 618
        }
    }
}
