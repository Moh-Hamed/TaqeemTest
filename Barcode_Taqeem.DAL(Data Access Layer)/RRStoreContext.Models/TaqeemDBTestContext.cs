using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Barcode_Taqeem.DAL_Data_Access_Layer_.RRStoreContext.Models
{
    public partial class TaqeemDBTestContext : DbContext
    {
        public TaqeemDBTestContext()
        {
        }

        public TaqeemDBTestContext(DbContextOptions<TaqeemDBTestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<LoginUser> LoginUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-2R623PB;Database=barcodedb;Integrated Security=True;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmpCode)
                    .HasName("PK_Emp");

                entity.ToTable("Employee");

                entity.Property(e => e.EmpCode)
                    .HasMaxLength(50)
                    .HasColumnName("Emp_code");

                entity.Property(e => e.EmpActive)
                    .HasMaxLength(50)
                    .HasColumnName("Emp_active");

                entity.Property(e => e.EmpBirthDate)
                    .HasColumnType("date")
                    .HasColumnName("Emp_BirthDate");

                entity.Property(e => e.EmpBirthPlaceId).HasColumnName("Emp_BirthPlaceId");

                entity.Property(e => e.EmpBrCode).HasColumnName("Emp_Br_code");

                entity.Property(e => e.EmpCmpCode).HasColumnName("Emp_Cmp_code");

                entity.Property(e => e.EmpCreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Emp_created_at");

                entity.Property(e => e.EmpCreatedBy).HasColumnName("Emp_created_by");

                entity.Property(e => e.EmpCreatedChanel)
                    .HasMaxLength(50)
                    .HasColumnName("Emp_created_chanel");

                entity.Property(e => e.EmpDptCode).HasColumnName("Emp_Dpt_code");

                entity.Property(e => e.EmpJobCode).HasColumnName("Emp_Job_code");

                entity.Property(e => e.EmpMary)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Emp_Mary")
                    .IsFixedLength(true);

                entity.Property(e => e.EmpNameAr)
                    .HasMaxLength(150)
                    .HasColumnName("Emp_name_ar");

                entity.Property(e => e.EmpNameEn)
                    .HasMaxLength(150)
                    .HasColumnName("Emp_name_en");

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(50)
                    .HasColumnName("Emp_No");

                entity.Property(e => e.EmpRankCode).HasColumnName("Emp_Rank_code");

                entity.Property(e => e.EmpReligon).HasColumnName("Emp_Religon");

                entity.Property(e => e.EmpRoleCode)
                    .HasMaxLength(50)
                    .HasColumnName("Emp_role_code");

                entity.Property(e => e.EmpSex)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Emp_Sex")
                    .HasDefaultValueSql("('M')")
                    .IsFixedLength(true);

                entity.Property(e => e.EmpUpdateAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Emp_update_at");

                entity.Property(e => e.EmpUpdateBy).HasColumnName("Emp_update_by");

                entity.Property(e => e.EmpUpdateChanel)
                    .HasMaxLength(50)
                    .HasColumnName("Emp_update_chanel");
            });

            modelBuilder.Entity<LoginUser>(entity =>
            {
                entity.HasKey(e => e.LogEmpCode)
                    .HasName("PK_login");

                entity.ToTable("login_user");

                entity.Property(e => e.LogEmpCode)
                    .HasMaxLength(50)
                    .HasColumnName("Log_Emp_code");

                entity.Property(e => e.LogCreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("log_created_at");

                entity.Property(e => e.LogCreatedBy).HasColumnName("log_created_by");

                entity.Property(e => e.LogCreatedChanel)
                    .HasMaxLength(50)
                    .HasColumnName("log_created_chanel");

                entity.Property(e => e.LogEmpEmail).HasColumnName("Log_Emp_email");

                entity.Property(e => e.LogPassword).HasColumnName("Log_password");

                entity.Property(e => e.LogUpdateAt)
                    .HasColumnType("datetime")
                    .HasColumnName("log_update_at");

                entity.Property(e => e.LogUpdateBy).HasColumnName("log_update_by");

                entity.Property(e => e.LogUpdateChanel)
                    .HasMaxLength(50)
                    .HasColumnName("log_update_chanel");

                entity.HasOne(d => d.LogEmpCodeNavigation)
                    .WithOne(p => p.LoginUser)
                    .HasForeignKey<LoginUser>(d => d.LogEmpCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_login_Employee");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
