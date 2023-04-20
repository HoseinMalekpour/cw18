using Microsoft.EntityFrameworkCore;

namespace cw18.Models;

public partial class AppDbContext : DbContext
{

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public  DbSet<Address> Addresses { get; set; }

    public  DbSet<Book> Books { get; set; }

    public  DbSet<BookMember> BookMembers { get; set; }

    public  DbSet<City> Cities { get; set; }

    public  DbSet<Genre> Genres { get; set; }

    public  DbSet<Member> Members { get; set; }

    public  DbSet<Province> Provinces { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BookMember>(entity =>
        {
            entity.HasNoKey();
        });


    }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<Address>(entity =>
    //    {
    //        entity.ToTable("Address");

    //        entity.Property(e => e.Id).ValueGeneratedNever();
    //        entity.Property(e => e.Address1).HasColumnName("Address_");

    //        entity.HasOne(d => d.City).WithMany(p => p.Addresses)
    //            .HasForeignKey(d => d.CityId)
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_Address_City");

    //        entity.HasOne(d => d.IdNavigation).WithOne(p => p.Address)
    //            .HasForeignKey<Address>(d => d.Id)
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_Address_Member");
    //    });

    //    modelBuilder.Entity<Book>(entity =>
    //    {
    //        entity.ToTable("Book");

    //        entity.HasOne(d => d.Genre).WithMany(p => p.Books)
    //            .HasForeignKey(d => d.GenreId)
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_Book_Genre");
    //    });

    //    modelBuilder.Entity<BookMember>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToTable("BookMember");

    //        entity.HasOne(d => d.Books).WithMany()
    //            .HasForeignKey(d => d.BooksId)
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_BookMember_Book");

    //        entity.HasOne(d => d.Members).WithMany()
    //            .HasForeignKey(d => d.MembersId)
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_BookMember_Member");
    //    });

    //    modelBuilder.Entity<City>(entity =>
    //    {
    //        entity.ToTable("City");

    //        entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

    //        entity.HasOne(d => d.Province).WithMany(p => p.Cities)
    //            .HasForeignKey(d => d.ProvinceId)
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_City_Province");
    //    });

    //    modelBuilder.Entity<Genre>(entity =>
    //    {
    //        entity.ToTable("Genre");
    //    });

    //    modelBuilder.Entity<Member>(entity =>
    //    {
    //        entity.ToTable("Member");
    //    });

    //    modelBuilder.Entity<Province>(entity =>
    //    {
    //        entity.ToTable("Province");
    //    });

    //    OnModelCreatingPartial(modelBuilder);
    //}

    //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
