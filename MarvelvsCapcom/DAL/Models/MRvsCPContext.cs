using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MarvelvsCapcom.DAL.Models
{
    public partial class MRvsCPContext : DbContext
    {
        public MRvsCPContext()
        {
        }

        public MRvsCPContext(DbContextOptions<MRvsCPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ability> Abilities { get; set; } = null!;
        public virtual DbSet<Admin> Admins { get; set; } = null!;
        public virtual DbSet<Arena> Arenas { get; set; } = null!;
        public virtual DbSet<Character> Characters { get; set; } = null!;
        public virtual DbSet<Round> Rounds { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserLevel> UserLevels { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:marvel-vs-capcom.database.windows.net,1433; Database=MRvsCP;User ID=mrvscpuserad;Password=Gonfle!123;Trusted_Connection=False; Encrypt=True; Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ability>(entity =>
            {
                entity.ToTable("abilities");

                entity.HasIndex(e => e.AbName, "UQ__abilitie__721AEC8D8AA6C04D")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AbName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("abName");

                entity.Property(e => e.CoolDown).HasColumnName("coolDown");

                entity.Property(e => e.Damage).HasColumnName("damage");
            });

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.ToTable("admins");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Passwd)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasColumnName("passwd");
            });

            modelBuilder.Entity<Arena>(entity =>
            {
                entity.ToTable("arena");

                entity.HasIndex(e => e.Name, "UQ__arena__72E12F1B30EBC79C")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ArenaImg)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("arenaImg");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Character>(entity =>
            {
                entity.ToTable("characters");

                entity.HasIndex(e => e.CharName, "UQ__characte__ABC56DFBB2BB15F0")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ab1Id).HasColumnName("ab1ID");

                entity.Property(e => e.Ab2Id).HasColumnName("ab2ID");

                entity.Property(e => e.Ab3Id).HasColumnName("ab3ID");

                entity.Property(e => e.Ab4Id).HasColumnName("ab4ID");

                entity.Property(e => e.CharName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("charName");

                entity.Property(e => e.HeathPoints).HasColumnName("heathPoints");

                entity.Property(e => e.Side)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("side");

                entity.HasOne(d => d.Ab1)
                    .WithMany(p => p.CharacterAb1s)
                    .HasForeignKey(d => d.Ab1Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__character__ab1ID__76969D2E");

                entity.HasOne(d => d.Ab2)
                    .WithMany(p => p.CharacterAb2s)
                    .HasForeignKey(d => d.Ab2Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__character__ab2ID__7B5B524B");

                entity.HasOne(d => d.Ab3)
                    .WithMany(p => p.CharacterAb3s)
                    .HasForeignKey(d => d.Ab3Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__character__ab3ID__7C4F7684");

                entity.HasOne(d => d.Ab4)
                    .WithMany(p => p.CharacterAb4s)
                    .HasForeignKey(d => d.Ab4Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__character__ab4ID__7D439ABD");
            });

            modelBuilder.Entity<Round>(entity =>
            {
                entity.ToTable("rounds");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Arena).HasColumnName("arena");

                entity.Property(e => e.FirstPid).HasColumnName("firstPID");

                entity.Property(e => e.P1char1).HasColumnName("p1char1");

                entity.Property(e => e.P1char2).HasColumnName("p1char2");

                entity.Property(e => e.P1char3).HasColumnName("p1char3");

                entity.Property(e => e.P2char1).HasColumnName("p2char1");

                entity.Property(e => e.P2char2).HasColumnName("p2char2");

                entity.Property(e => e.P2char3).HasColumnName("p2char3");

                entity.Property(e => e.SecondPid).HasColumnName("secondPID");

                entity.Property(e => e.Winner).HasColumnName("winner");

                entity.HasOne(d => d.ArenaNavigation)
                    .WithMany(p => p.Rounds)
                    .HasForeignKey(d => d.Arena)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__rounds__arena__05D8E0BE");

                entity.HasOne(d => d.FirstP)
                    .WithMany(p => p.RoundFirstPs)
                    .HasForeignKey(d => d.FirstPid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__rounds__firstPID__2CF2ADDF");

                entity.HasOne(d => d.P1char1Navigation)
                    .WithMany(p => p.RoundP1char1Navigations)
                    .HasForeignKey(d => d.P1char1)
                    .HasConstraintName("FK__rounds__p1char1__00200768");

                entity.HasOne(d => d.P1char2Navigation)
                    .WithMany(p => p.RoundP1char2Navigations)
                    .HasForeignKey(d => d.P1char2)
                    .HasConstraintName("FK__rounds__p1char2__01142BA1");

                entity.HasOne(d => d.P1char3Navigation)
                    .WithMany(p => p.RoundP1char3Navigations)
                    .HasForeignKey(d => d.P1char3)
                    .HasConstraintName("FK__rounds__p1char3__02084FDA");

                entity.HasOne(d => d.P2char1Navigation)
                    .WithMany(p => p.RoundP2char1Navigations)
                    .HasForeignKey(d => d.P2char1)
                    .HasConstraintName("FK__rounds__p2char1__02FC7413");

                entity.HasOne(d => d.P2char2Navigation)
                    .WithMany(p => p.RoundP2char2Navigations)
                    .HasForeignKey(d => d.P2char2)
                    .HasConstraintName("FK__rounds__p2char2__03F0984C");

                entity.HasOne(d => d.P2char3Navigation)
                    .WithMany(p => p.RoundP2char3Navigations)
                    .HasForeignKey(d => d.P2char3)
                    .HasConstraintName("FK__rounds__p2char3__04E4BC85");

                entity.HasOne(d => d.SecondP)
                    .WithMany(p => p.RoundSecondPs)
                    .HasForeignKey(d => d.SecondPid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__rounds__secondPI__2DE6D218");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.Username, "UQ__users__F3DBC57273F833AA")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Username)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<UserLevel>(entity =>
            {
                entity.ToTable("userLevel");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CharacterId).HasColumnName("characterID");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserLevels)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__userLevel__userI__282DF8C2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
