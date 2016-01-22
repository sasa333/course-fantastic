using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using CourseFantastic.DataAccess.Models;

namespace CourseFantastic.DataAccess.Migrations
{
    [DbContext(typeof(CourseFantasticDbContext))]
    [Migration("20160117235633_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CourseFantastic.DataAccess.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DoB");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("Identity");

                    b.Property<string>("Surname");

                    b.HasKey("Id");
                });
        }
    }
}
