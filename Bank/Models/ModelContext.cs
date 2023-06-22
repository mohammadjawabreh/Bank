using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Bank.Models;

public partial class ModelContext : DbContext
{
    public ModelContext()
    {
    }

    public ModelContext(DbContextOptions<ModelContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Aboutu> Aboutus { get; set; }

    public virtual DbSet<Bank> Banks { get; set; }

    public virtual DbSet<Contactu> Contactus { get; set; }

    public virtual DbSet<Homepage> Homepages { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Testimonial> Testimonials { get; set; }

    public virtual DbSet<Transformation> Transformations { get; set; }

    public virtual DbSet<Useraccount> Useraccounts { get; set; }

    public virtual DbSet<Visacard> Visacards { get; set; }

    public virtual DbSet<Wallet> Wallets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseOracle("USER ID=JOR18_USER16;PASSWORD=Test321;DATA SOURCE=94.56.229.181:3488/traindb");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasDefaultSchema("JOR18_USER16")
            .UseCollation("USING_NLS_COMP");

        modelBuilder.Entity<Aboutu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SYS_C00378027");

            entity.ToTable("ABOUTUS");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER(38)")
                .HasColumnName("ID");
            entity.Property(e => e.Description1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION1");
            entity.Property(e => e.Description2)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION2");
            entity.Property(e => e.Description3)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION3");
            entity.Property(e => e.Image)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("IMAGE");
            entity.Property(e => e.Text1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TEXT1");
            entity.Property(e => e.Text2)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TEXT2");
            entity.Property(e => e.Title1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TITLE1");
            entity.Property(e => e.Title2)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TITLE2");
            entity.Property(e => e.Title3)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TITLE3");
        });

        modelBuilder.Entity<Bank>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SYS_C00378016");

            entity.ToTable("BANKS");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER(38)")
                .HasColumnName("ID");
            entity.Property(e => e.Bankname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BANKNAME");
            entity.Property(e => e.ContactNumber)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CONTACT_NUMBER");
            entity.Property(e => e.ImagPath)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("IMAG_PATH");
        });

        modelBuilder.Entity<Contactu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SYS_C00378038");

            entity.ToTable("CONTACTUS");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER(38)")
                .HasColumnName("ID");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Fullname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FULLNAME");
            entity.Property(e => e.Message)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("MESSAGE");
            entity.Property(e => e.Phonenumber)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PHONENUMBER");
        });

        modelBuilder.Entity<Homepage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SYS_C00378031");

            entity.ToTable("HOMEPAGE");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER(38)")
                .HasColumnName("ID");
            entity.Property(e => e.Background)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("BACKGROUND");
            entity.Property(e => e.Companyemail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("COMPANYEMAIL");
            entity.Property(e => e.Companyphone)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("COMPANYPHONE");
            entity.Property(e => e.Logo)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("LOGO");
            entity.Property(e => e.Text1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TEXT1");
            entity.Property(e => e.Text2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TEXT2");
            entity.Property(e => e.Text3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TEXT3");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SYS_C00378011");

            entity.ToTable("ROLE");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER(38)")
                .HasColumnName("ID");
            entity.Property(e => e.Rolename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ROLENAME");
        });

        modelBuilder.Entity<Testimonial>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SYS_C00378044");

            entity.ToTable("TESTIMONIALS");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER(38)")
                .HasColumnName("ID");
            entity.Property(e => e.Image)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("IMAGE");
            entity.Property(e => e.Message)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("MESSAGE");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Stuts)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("STUTS");
            entity.Property(e => e.UserId)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("USER_ID");

            entity.HasOne(d => d.User).WithMany(p => p.Testimonials)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("USRES_FK");
        });

        modelBuilder.Entity<Transformation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SYS_C00378047");

            entity.ToTable("TRANSFORMATION");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER(38)")
                .HasColumnName("ID");
            entity.Property(e => e.Commission)
                .HasColumnType("NUMBER")
                .HasColumnName("COMMISSION");
            entity.Property(e => e.DateFrom)
                .HasColumnType("DATE")
                .HasColumnName("DATE_FROM");
            entity.Property(e => e.FromwalletId)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("FROMWALLET_ID");
            entity.Property(e => e.TowalletId)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("TOWALLET_ID");
            entity.Property(e => e.Transferamount)
                .HasColumnType("NUMBER")
                .HasColumnName("TRANSFERAMOUNT");

            entity.HasOne(d => d.Fromwallet).WithMany(p => p.TransformationFromwallets)
                .HasForeignKey(d => d.FromwalletId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("WALLETS_FK");

            entity.HasOne(d => d.Towallet).WithMany(p => p.TransformationTowallets)
                .HasForeignKey(d => d.TowalletId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("WALLET_FK");
        });

        modelBuilder.Entity<Useraccount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SYS_C00378013");

            entity.ToTable("USERACCOUNT");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER(38)")
                .HasColumnName("ID");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Fullname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FULLNAME");
            entity.Property(e => e.ImagPath)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("IMAG_PATH");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.Phonenumber)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PHONENUMBER");
            entity.Property(e => e.RoleId)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("ROLE_ID");

            entity.HasOne(d => d.Role).WithMany(p => p.Useraccounts)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ROLE_FK");
        });

        modelBuilder.Entity<Visacard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SYS_C00378025");

            entity.ToTable("VISACARD");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER(38)")
                .HasColumnName("ID");
            entity.Property(e => e.CardNumber)
                .HasColumnType("NUMBER")
                .HasColumnName("CARD_NUMBER");
            entity.Property(e => e.Cvv)
                .HasColumnType("NUMBER")
                .HasColumnName("CVV");
            entity.Property(e => e.ExpirationDate)
                .HasColumnType("DATE")
                .HasColumnName("EXPIRATION_DATE");
            entity.Property(e => e.Owneremail)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("OWNEREMAIL");
            entity.Property(e => e.Ownername)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("OWNERNAME");
        });

        modelBuilder.Entity<Wallet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SYS_C00378018");

            entity.ToTable("WALLETS");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER(38)")
                .HasColumnName("ID");
            entity.Property(e => e.Balance)
                .HasColumnType("NUMBER")
                .HasColumnName("BALANCE");
            entity.Property(e => e.BankId)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("BANK_ID");
            entity.Property(e => e.Iban)
                .HasColumnType("NUMBER")
                .HasColumnName("IBAN");
            entity.Property(e => e.Stuts)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("STUTS");
            entity.Property(e => e.UserId)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("USER_ID");

            entity.HasOne(d => d.Bank).WithMany(p => p.Wallets)
                .HasForeignKey(d => d.BankId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("BANK_FK");

            entity.HasOne(d => d.User).WithMany(p => p.Wallets)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("USRE_FK");
        });
        modelBuilder.HasSequence("SEQ_TEST2").IncrementsBy(2);

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
