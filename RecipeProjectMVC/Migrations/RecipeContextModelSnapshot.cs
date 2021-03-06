// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecipeProjectMVC.Data;

namespace RecipeProjectMVC.Migrations
{
    [DbContext(typeof(RecipeContext))]
    partial class RecipeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RecipeProjectMVC.Models.Admin", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Email");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("RecipeProjectMVC.Models.Recipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CookTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CookingSteps")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FoodCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredients")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrepTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ranking")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tools")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserCommentsCommentId")
                        .HasColumnType("int");

                    b.HasKey("RecipeId");

                    b.HasIndex("UserCommentsCommentId");

                    b.ToTable("Recipe");
                });

            modelBuilder.Entity("RecipeProjectMVC.Models.User", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserCommentsCommentId")
                        .HasColumnType("int");

                    b.HasKey("Username");

                    b.HasIndex("UserCommentsCommentId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("RecipeProjectMVC.Models.UserComments", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommentDetail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("commentTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CommentId");

                    b.ToTable("UserComments");
                });

            modelBuilder.Entity("RecipeProjectMVC.Models.Recipe", b =>
                {
                    b.HasOne("RecipeProjectMVC.Models.UserComments", null)
                        .WithMany("RecipeId")
                        .HasForeignKey("UserCommentsCommentId");
                });

            modelBuilder.Entity("RecipeProjectMVC.Models.User", b =>
                {
                    b.HasOne("RecipeProjectMVC.Models.UserComments", null)
                        .WithMany("UserName")
                        .HasForeignKey("UserCommentsCommentId");
                });

            modelBuilder.Entity("RecipeProjectMVC.Models.UserComments", b =>
                {
                    b.Navigation("RecipeId");

                    b.Navigation("UserName");
                });
#pragma warning restore 612, 618
        }
    }
}
