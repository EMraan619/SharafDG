﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SharafDG.Persistence;

namespace SharafDG.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SharafDG.Domain.Entities.Bank", b =>
                {
                    b.Property<int>("BankId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountHolderName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("AccountNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("BankName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IfscCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BankId");

                    b.ToTable("Banks");
                });

            modelBuilder.Entity("SharafDG.Domain.Entities.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dde"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Concerts"
                        },
                        new
                        {
                            CategoryId = new Guid("6313179f-7837-473a-a4d5-a5571b43e6a6"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Musicals"
                        },
                        new
                        {
                            CategoryId = new Guid("bf3f3002-7e53-441e-8b76-f6280be284aa"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Plays"
                        },
                        new
                        {
                            CategoryId = new Guid("fe98f549-e790-4e9f-aa16-18c2292a2ee9"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Conferences"
                        });
                });

            modelBuilder.Entity("SharafDG.Domain.Entities.Event", b =>
                {
                    b.Property<Guid>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("EventId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            EventId = new Guid("ee272f8b-6096-4cb6-8625-bb4bb2d89e8b"),
                            Artist = "John Egbert",
                            CategoryId = new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dde"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2022, 4, 20, 13, 36, 34, 721, DateTimeKind.Local).AddTicks(5407),
                            Description = "Join John for his farwell tour across 15 continents. John really needs no introduction since he has already mesmerized the world with his banjo.",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/GloboTicket/banjo.jpg",
                            Name = "John Egbert Live",
                            Price = 65
                        },
                        new
                        {
                            EventId = new Guid("3448d5a4-0f72-4dd7-bf15-c14a46b26c00"),
                            Artist = "Michael Johnson",
                            CategoryId = new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dde"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2022, 7, 20, 13, 36, 34, 722, DateTimeKind.Local).AddTicks(8646),
                            Description = "Michael Johnson doesn't need an introduction. His 25 concert across the globe last year were seen by thousands. Can we add you to the list?",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/GloboTicket/michael.jpg",
                            Name = "The State of Affairs: Michael Live!",
                            Price = 85
                        },
                        new
                        {
                            EventId = new Guid("b419a7ca-3321-4f38-be8e-4d7b6a529319"),
                            Artist = "DJ 'The Mike'",
                            CategoryId = new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dde"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2022, 2, 20, 13, 36, 34, 722, DateTimeKind.Local).AddTicks(8766),
                            Description = "DJs from all over the world will compete in this epic battle for eternal fame.",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/GloboTicket/dj.jpg",
                            Name = "Clash of the DJs",
                            Price = 85
                        },
                        new
                        {
                            EventId = new Guid("62787623-4c52-43fe-b0c9-b7044fb5929b"),
                            Artist = "Manuel Santinonisi",
                            CategoryId = new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dde"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2022, 2, 20, 13, 36, 34, 722, DateTimeKind.Local).AddTicks(8802),
                            Description = "Get on the hype of Spanish Guitar concerts with Manuel.",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/GloboTicket/guitar.jpg",
                            Name = "Spanish guitar hits with Manuel",
                            Price = 25
                        },
                        new
                        {
                            EventId = new Guid("1babd057-e980-4cb3-9cd2-7fdd9e525668"),
                            Artist = "Many",
                            CategoryId = new Guid("fe98f549-e790-4e9f-aa16-18c2292a2ee9"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2022, 8, 20, 13, 36, 34, 722, DateTimeKind.Local).AddTicks(8832),
                            Description = "The best tech conference in the world",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/GloboTicket/conf.jpg",
                            Name = "Techorama 2021",
                            Price = 400
                        },
                        new
                        {
                            EventId = new Guid("adc42c09-08c1-4d2c-9f96-2d15bb1af299"),
                            Artist = "Nick Sailor",
                            CategoryId = new Guid("6313179f-7837-473a-a4d5-a5571b43e6a6"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2022, 6, 20, 13, 36, 34, 722, DateTimeKind.Local).AddTicks(8867),
                            Description = "The critics are over the moon and so will you after you've watched this sing and dance extravaganza written by Nick Sailor, the man from 'My dad and sister'.",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/GloboTicket/musical.jpg",
                            Name = "To the Moon and Back",
                            Price = 135
                        });
                });

            modelBuilder.Entity("SharafDG.Domain.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("OrderPaid")
                        .HasColumnType("bit");

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderTotal")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7e94bc5b-71a5-4c8c-bc3b-71bb7976237e"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderPaid = true,
                            OrderPlaced = new DateTime(2021, 10, 20, 13, 36, 34, 723, DateTimeKind.Local).AddTicks(169),
                            OrderTotal = 400,
                            UserId = new Guid("a441eb40-9636-4ee6-be49-a66c5ec1330b")
                        },
                        new
                        {
                            Id = new Guid("86d3a045-b42d-4854-8150-d6a374948b6e"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderPaid = true,
                            OrderPlaced = new DateTime(2021, 10, 20, 13, 36, 34, 723, DateTimeKind.Local).AddTicks(1014),
                            OrderTotal = 135,
                            UserId = new Guid("ac3cfaf5-34fd-4e4d-bc04-ad1083ddc340")
                        },
                        new
                        {
                            Id = new Guid("771cca4b-066c-4ac7-b3df-4d12837fe7e0"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderPaid = true,
                            OrderPlaced = new DateTime(2021, 10, 20, 13, 36, 34, 723, DateTimeKind.Local).AddTicks(1069),
                            OrderTotal = 85,
                            UserId = new Guid("d97a15fc-0d32-41c6-9ddf-62f0735c4c1c")
                        },
                        new
                        {
                            Id = new Guid("3dcb3ea0-80b1-4781-b5c0-4d85c41e55a6"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderPaid = true,
                            OrderPlaced = new DateTime(2021, 10, 20, 13, 36, 34, 723, DateTimeKind.Local).AddTicks(1096),
                            OrderTotal = 245,
                            UserId = new Guid("4ad901be-f447-46dd-bcf7-dbe401afa203")
                        },
                        new
                        {
                            Id = new Guid("e6a2679c-79a3-4ef1-a478-6f4c91b405b6"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderPaid = true,
                            OrderPlaced = new DateTime(2021, 10, 20, 13, 36, 34, 723, DateTimeKind.Local).AddTicks(1121),
                            OrderTotal = 142,
                            UserId = new Guid("7aeb2c01-fe8e-4b84-a5ba-330bdf950f5c")
                        },
                        new
                        {
                            Id = new Guid("f5a6a3a0-4227-4973-abb5-a63fbe725923"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderPaid = true,
                            OrderPlaced = new DateTime(2021, 10, 20, 13, 36, 34, 723, DateTimeKind.Local).AddTicks(1149),
                            OrderTotal = 40,
                            UserId = new Guid("f5a6a3a0-4227-4973-abb5-a63fbe725923")
                        },
                        new
                        {
                            Id = new Guid("ba0eb0ef-b69b-46fd-b8e2-41b4178ae7cb"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderPaid = true,
                            OrderPlaced = new DateTime(2021, 10, 20, 13, 36, 34, 723, DateTimeKind.Local).AddTicks(1173),
                            OrderTotal = 116,
                            UserId = new Guid("7aeb2c01-fe8e-4b84-a5ba-330bdf950f5c")
                        });
                });

            modelBuilder.Entity("SharafDG.Domain.Entities.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("SharafDG.Domain.Entities.SMEUser", b =>
                {
                    b.Property<int>("SMEId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("AlternateNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("CompanyAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CompanyPhone")
                        .HasColumnType("bigint");

                    b.Property<string>("CompanyWebsite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PhoneNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("TypeOfBusiness")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SMEId");

                    b.ToTable("SMEUsers");
                });

            modelBuilder.Entity("SharafDG.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PhoneNumber")
                        .HasColumnType("bigint")
                        .HasMaxLength(10);

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SharafDG.Domain.Entities.UserDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BankId")
                        .HasColumnType("int");

                    b.Property<string>("CompanyAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyLogo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyWebsite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeOfBussiness")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BankId");

                    b.HasIndex("UserId");

                    b.ToTable("UserDetails");
                });

            modelBuilder.Entity("SharafDG.Domain.Entities.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte>("isActive")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("SharafDG.Domain.Entities.Event", b =>
                {
                    b.HasOne("SharafDG.Domain.Entities.Category", "Category")
                        .WithMany("Events")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SharafDG.Domain.Entities.Role", b =>
                {
                    b.HasOne("SharafDG.Domain.Entities.User", null)
                        .WithMany("Roles")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("SharafDG.Domain.Entities.UserDetail", b =>
                {
                    b.HasOne("SharafDG.Domain.Entities.Bank", "Bank")
                        .WithMany()
                        .HasForeignKey("BankId");

                    b.HasOne("SharafDG.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SharafDG.Domain.Entities.UserRole", b =>
                {
                    b.HasOne("SharafDG.Domain.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SharafDG.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
