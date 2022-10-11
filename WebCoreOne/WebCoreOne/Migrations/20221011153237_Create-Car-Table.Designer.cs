using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebCoreOne.Data;

namespace WebCoreOne.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221011153237_Create-Car-Table")]
    partial class CreateCarTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebCoreOne.Entities.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Color");

                    b.Property<int>("Year");

                    b.HasKey("CarId");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("WebCoreOne.Entities.People", b =>
                {
                    b.Property<int>("PeopleId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("PeopleId");

                    b.ToTable("peoples");
                });

            modelBuilder.Entity("WebCoreOne.Entities.PersonAdresss", b =>
                {
                    b.Property<int>("PersonAdresssId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<int>("PeopleId");

                    b.Property<string>("State");

                    b.Property<string>("StreetName");

                    b.Property<string>("ZipCode");

                    b.HasKey("PersonAdresssId");

                    b.HasIndex("PeopleId");

                    b.ToTable("PeopleAdressss");
                });

            modelBuilder.Entity("WebCoreOne.Entities.PersonAdresss", b =>
                {
                    b.HasOne("WebCoreOne.Entities.People", "People")
                        .WithMany("PersonAdressses")
                        .HasForeignKey("PeopleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
