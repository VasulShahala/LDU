using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebAppLvivDebateUnion.Models;

namespace WebAppLvivDebateUnion.Migrations
{
    [DbContext(typeof(WebAppLvivDebateUnionContext))]
    partial class WebAppLvivDebateUnionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAppLvivDebateUnion.Models.ActionDebater", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DebaterId");

                    b.Property<int>("GameCount");

                    b.Property<double>("RiatStars");

                    b.Property<int>("TotalStars");

                    b.HasKey("Id");

                    b.HasIndex("DebaterId")
                        .IsUnique();

                    b.ToTable("ActionDebaters");
                });

            modelBuilder.Entity("WebAppLvivDebateUnion.Models.Club", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ClubBornDate");

                    b.Property<int?>("ClubGroupId");

                    b.Property<string>("Information");

                    b.Property<string>("Location");

                    b.Property<string>("Name");

                    b.Property<string>("Path");

                    b.HasKey("Id");

                    b.HasIndex("ClubGroupId");

                    b.ToTable("Clubs");
                });

            modelBuilder.Entity("WebAppLvivDebateUnion.Models.ClubGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("ClubGroups");
                });

            modelBuilder.Entity("WebAppLvivDebateUnion.Models.Debater", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Blocked");

                    b.Property<DateTime>("BornDate");

                    b.Property<string>("CardNumber");

                    b.Property<int>("ClubId");

                    b.Property<string>("Email");

                    b.Property<string>("FbLink");

                    b.Property<string>("Inform");

                    b.Property<string>("NameIP");

                    b.Property<string>("Password");

                    b.Property<string>("Phone");

                    b.Property<double>("Rating");

                    b.Property<int>("RolleId");

                    b.Property<string>("VkLink");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.HasIndex("RolleId");

                    b.ToTable("Debaters");
                });

            modelBuilder.Entity("WebAppLvivDebateUnion.Models.DebaterGameRaund", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DebaterId");

                    b.Property<int>("RaundId");

                    b.HasKey("Id");

                    b.HasIndex("DebaterId");

                    b.HasIndex("RaundId");

                    b.ToTable("DebaterGameRaunds");
                });

            modelBuilder.Entity("WebAppLvivDebateUnion.Models.Juge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DebaterId");

                    b.Property<double>("Rating");

                    b.HasKey("Id");

                    b.HasIndex("DebaterId")
                        .IsUnique();

                    b.ToTable("Judes");
                });

            modelBuilder.Entity("WebAppLvivDebateUnion.Models.Raund", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ClubId");

                    b.Property<string>("Format");

                    b.Property<DateTime>("GameDate");

                    b.Property<int>("JugeId");

                    b.Property<string>("RaundNumb");

                    b.Property<string>("Resolution");

                    b.Property<string>("StatLevel");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.HasIndex("JugeId")
                        .IsUnique();

                    b.ToTable("Raunds");
                });

            modelBuilder.Entity("WebAppLvivDebateUnion.Models.Rolle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Rolles");
                });

            modelBuilder.Entity("WebAppLvivDebateUnion.Models.RolleGame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DebaterId");

                    b.Property<string>("GameRolle");

                    b.HasKey("Id");

                    b.HasIndex("DebaterId")
                        .IsUnique();

                    b.ToTable("RolleGames");
                });

            modelBuilder.Entity("WebAppLvivDebateUnion.Models.ActionDebater", b =>
                {
                    b.HasOne("WebAppLvivDebateUnion.Models.Debater", "Debater")
                        .WithOne("DActionDebater")
                        .HasForeignKey("WebAppLvivDebateUnion.Models.ActionDebater", "DebaterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebAppLvivDebateUnion.Models.Club", b =>
                {
                    b.HasOne("WebAppLvivDebateUnion.Models.ClubGroup")
                        .WithMany("Clubs")
                        .HasForeignKey("ClubGroupId");
                });

            modelBuilder.Entity("WebAppLvivDebateUnion.Models.Debater", b =>
                {
                    b.HasOne("WebAppLvivDebateUnion.Models.Club", "Club")
                        .WithMany("Debaters")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebAppLvivDebateUnion.Models.Rolle", "Rolle")
                        .WithMany("Debaters")
                        .HasForeignKey("RolleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebAppLvivDebateUnion.Models.DebaterGameRaund", b =>
                {
                    b.HasOne("WebAppLvivDebateUnion.Models.Debater", "Debater")
                        .WithMany("DebaterGameRaund")
                        .HasForeignKey("DebaterId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebAppLvivDebateUnion.Models.Raund", "Raund")
                        .WithMany("DebaterGameRaund")
                        .HasForeignKey("RaundId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebAppLvivDebateUnion.Models.Juge", b =>
                {
                    b.HasOne("WebAppLvivDebateUnion.Models.Debater", "Debater")
                        .WithOne("GameJuge")
                        .HasForeignKey("WebAppLvivDebateUnion.Models.Juge", "DebaterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebAppLvivDebateUnion.Models.Raund", b =>
                {
                    b.HasOne("WebAppLvivDebateUnion.Models.Club", "Club")
                        .WithMany()
                        .HasForeignKey("ClubId");

                    b.HasOne("WebAppLvivDebateUnion.Models.Juge", "Juge")
                        .WithOne("Raund")
                        .HasForeignKey("WebAppLvivDebateUnion.Models.Raund", "JugeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebAppLvivDebateUnion.Models.RolleGame", b =>
                {
                    b.HasOne("WebAppLvivDebateUnion.Models.Debater", "Debater")
                        .WithOne("RolleInGame")
                        .HasForeignKey("WebAppLvivDebateUnion.Models.RolleGame", "DebaterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
