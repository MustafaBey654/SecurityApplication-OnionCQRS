﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Security.Persistence.Context;

#nullable disable

namespace Security.Persistence.Migrations
{
    [DbContext(typeof(PersonelDbContext))]
    partial class PersonelDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PersonelUnit", b =>
                {
                    b.Property<int>("PersonelsId")
                        .HasColumnType("int");

                    b.Property<int>("unitsId")
                        .HasColumnType("int");

                    b.HasKey("PersonelsId", "unitsId");

                    b.HasIndex("unitsId");

                    b.ToTable("PersonelUnit");
                });

            modelBuilder.Entity("Security.Domain.Entities.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BranchName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Branch");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BranchName = "İdari Mali İşler Şube Müdürlüğü",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            BranchName = "Destek Hizmetleri Şube Müdürlüğü",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            BranchName = "Personel Şube Müdürlüğü",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 4,
                            BranchName = "Eğitim Şube Müdürlüğü",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 5,
                            BranchName = "Öğrenci İşleri Şube Müdürlüğü",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 6,
                            BranchName = "Pomem Şube Müdürlüğü",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("Security.Domain.Entities.CarPlate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("EntryDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPersonel")
                        .HasColumnType("bit");

                    b.Property<string>("PlateName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CarPlate");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EntryDate = new DateTime(2024, 5, 7, 0, 9, 0, 635, DateTimeKind.Local).AddTicks(2996),
                            IsDeleted = false,
                            IsPersonel = true,
                            PlateName = "69 AAA 13"
                        },
                        new
                        {
                            Id = 2,
                            EntryDate = new DateTime(2024, 5, 7, 0, 9, 0, 635, DateTimeKind.Local).AddTicks(3022),
                            IsDeleted = false,
                            IsPersonel = false,
                            PlateName = "69 AB 25"
                        },
                        new
                        {
                            Id = 3,
                            EntryDate = new DateTime(2024, 5, 7, 0, 9, 0, 635, DateTimeKind.Local).AddTicks(3023),
                            IsDeleted = false,
                            IsPersonel = true,
                            PlateName = "25 ACH 361"
                        },
                        new
                        {
                            Id = 4,
                            EntryDate = new DateTime(2024, 5, 7, 0, 9, 0, 635, DateTimeKind.Local).AddTicks(3024),
                            IsDeleted = false,
                            IsPersonel = false,
                            PlateName = "34 PLK 45"
                        },
                        new
                        {
                            Id = 5,
                            EntryDate = new DateTime(2024, 5, 7, 0, 9, 0, 635, DateTimeKind.Local).AddTicks(3024),
                            IsDeleted = false,
                            IsPersonel = false,
                            PlateName = "69 AS 89"
                        });
                });

            modelBuilder.Entity("Security.Domain.Entities.Personel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DatabaseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personel");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0e7341dd-04e0-4c65-9095-2128387ea789",
                            EmailConfirmed = false,
                            FirstName = "İlayda",
                            IsDeleted = false,
                            LastName = "Erçetin",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = 2,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e146bd80-8afd-4cf7-84bc-acd480f42674",
                            EmailConfirmed = false,
                            FirstName = "İlayda",
                            IsDeleted = false,
                            LastName = "Erçetin",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = 3,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c1bf7932-0422-47f7-b7f7-93f141250da9",
                            EmailConfirmed = false,
                            FirstName = "İlayda",
                            IsDeleted = false,
                            LastName = "Erçetin",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = 4,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "19ef57db-a01c-4767-808a-4a066ea2068f",
                            EmailConfirmed = false,
                            FirstName = "İlayda",
                            IsDeleted = false,
                            LastName = "Erçetin",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = 5,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "184e8bf5-7831-476c-87e2-ea1be05b87c8",
                            EmailConfirmed = false,
                            FirstName = "İlayda",
                            IsDeleted = true,
                            LastName = "Erçetin",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = 6,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7eb462fe-aff6-4b82-a6c4-cdfb0edf76af",
                            EmailConfirmed = false,
                            FirstName = "İlayda",
                            IsDeleted = false,
                            LastName = "Erçetin",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = 7,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1c170303-c425-49ef-8887-c49af5b6fbc6",
                            EmailConfirmed = false,
                            FirstName = "İlayda",
                            IsDeleted = false,
                            LastName = "Erçetin",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = 8,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3e3c73a4-9b65-4a2f-9ef5-7c1f7ed9a51e",
                            EmailConfirmed = false,
                            FirstName = "İlayda",
                            IsDeleted = false,
                            LastName = "Erçetin",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = 9,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a880e9f1-fb5a-4329-b8ac-6430e3d13f2a",
                            EmailConfirmed = false,
                            FirstName = "İlayda",
                            IsDeleted = false,
                            LastName = "Erçetin",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = 10,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a0b6c049-f58d-43ca-9aeb-9ea045e64ee6",
                            EmailConfirmed = false,
                            FirstName = "İlayda",
                            IsDeleted = true,
                            LastName = "Erçetin",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false
                        });
                });

            modelBuilder.Entity("Security.Domain.Entities.PersonelEntities.PersonelChartOfAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonelId")
                        .HasColumnType("int");

                    b.Property<string>("PersonelType")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("SerialNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PersonelChartOfAccounts", (string)null);
                });

            modelBuilder.Entity("Security.Domain.Entities.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("UnitName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.ToTable("Unit");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BranchId = 1,
                            IsDeleted = false,
                            UnitName = "Satın Alma Büro Amirliği"
                        },
                        new
                        {
                            Id = 2,
                            BranchId = 1,
                            IsDeleted = false,
                            UnitName = "Tahakkuk Büro Amirliği"
                        },
                        new
                        {
                            Id = 3,
                            BranchId = 2,
                            IsDeleted = false,
                            UnitName = "Atış Büro Amirliği"
                        },
                        new
                        {
                            Id = 4,
                            BranchId = 3,
                            IsDeleted = false,
                            UnitName = "Personel Kayıt Amirliği"
                        },
                        new
                        {
                            Id = 5,
                            BranchId = 4,
                            IsDeleted = false,
                            UnitName = "Öğrenci Özlük Amirliği"
                        },
                        new
                        {
                            Id = 6,
                            BranchId = 6,
                            IsDeleted = false,
                            UnitName = "Belge Yönetimi Amirliği"
                        });
                });

            modelBuilder.Entity("Security.Domain.Entities.Visitor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BranchId")
                        .HasColumnType("int");

                    b.Property<string>("CarPlateName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EntryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("JobInterview")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonelId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UnitId")
                        .HasColumnType("int");

                    b.Property<bool>("Visit")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("PersonelId");

                    b.ToTable("Visitor");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BranchId = 1,
                            EntryDate = new DateTime(2024, 5, 7, 0, 9, 0, 643, DateTimeKind.Local).AddTicks(9097),
                            FirstName = "Işıl",
                            IdentityNumber = "199308296442",
                            IsDeleted = false,
                            JobInterview = true,
                            LastName = "Karabulut",
                            PersonelId = 1,
                            Visit = false
                        },
                        new
                        {
                            Id = 2,
                            EntryDate = new DateTime(2024, 5, 7, 0, 9, 0, 644, DateTimeKind.Local).AddTicks(1413),
                            FirstName = "Işıl",
                            IdentityNumber = "199308296442",
                            IsDeleted = false,
                            JobInterview = true,
                            LastName = "Karabulut",
                            PersonelId = 1,
                            ReleaseDate = new DateTime(2024, 5, 7, 0, 9, 0, 644, DateTimeKind.Local).AddTicks(1419),
                            UnitId = 2,
                            Visit = false
                        },
                        new
                        {
                            Id = 3,
                            BranchId = 3,
                            EntryDate = new DateTime(2024, 5, 7, 0, 9, 0, 644, DateTimeKind.Local).AddTicks(1421),
                            FirstName = "Işıl",
                            IdentityNumber = "199308296442",
                            IsDeleted = true,
                            JobInterview = true,
                            LastName = "Karabulut",
                            PersonelId = 1,
                            Visit = false
                        },
                        new
                        {
                            Id = 4,
                            EntryDate = new DateTime(2024, 5, 7, 0, 9, 0, 644, DateTimeKind.Local).AddTicks(1423),
                            FirstName = "Işıl",
                            IdentityNumber = "199308296442",
                            IsDeleted = false,
                            JobInterview = true,
                            LastName = "Karabulut",
                            PersonelId = 1,
                            ReleaseDate = new DateTime(2024, 5, 7, 0, 9, 0, 644, DateTimeKind.Local).AddTicks(1425),
                            UnitId = 4,
                            Visit = false
                        },
                        new
                        {
                            Id = 5,
                            BranchId = 2,
                            EntryDate = new DateTime(2024, 5, 7, 0, 9, 0, 644, DateTimeKind.Local).AddTicks(1426),
                            FirstName = "Işıl",
                            IdentityNumber = "199308296442",
                            IsDeleted = false,
                            JobInterview = true,
                            LastName = "Karabulut",
                            PersonelId = 1,
                            ReleaseDate = new DateTime(2024, 5, 7, 0, 9, 0, 644, DateTimeKind.Local).AddTicks(1428),
                            Visit = false
                        },
                        new
                        {
                            Id = 6,
                            BranchId = 5,
                            EntryDate = new DateTime(2024, 5, 7, 0, 9, 0, 644, DateTimeKind.Local).AddTicks(1429),
                            FirstName = "Işıl",
                            IdentityNumber = "199308296442",
                            IsDeleted = true,
                            JobInterview = true,
                            LastName = "Karabulut",
                            PersonelId = 1,
                            Visit = false
                        });
                });

            modelBuilder.Entity("PersonelUnit", b =>
                {
                    b.HasOne("Security.Domain.Entities.Personel", null)
                        .WithMany()
                        .HasForeignKey("PersonelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Security.Domain.Entities.Unit", null)
                        .WithMany()
                        .HasForeignKey("unitsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Security.Domain.Entities.Unit", b =>
                {
                    b.HasOne("Security.Domain.Entities.Branch", "Branch")
                        .WithMany("Units")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("Security.Domain.Entities.Visitor", b =>
                {
                    b.HasOne("Security.Domain.Entities.Personel", "Personel")
                        .WithMany()
                        .HasForeignKey("PersonelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("Security.Domain.Entities.Branch", b =>
                {
                    b.Navigation("Units");
                });
#pragma warning restore 612, 618
        }
    }
}