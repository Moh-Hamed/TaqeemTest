using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Barcode_Taqeem.DAL_Data_Access_Layer_.DB_7_3_2021_1_30.Models
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

        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<DptDev> DptDevs { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<GeneralDictionaryDetail> GeneralDictionaryDetails { get; set; }
        public virtual DbSet<GeneralDictionaryMaster> GeneralDictionaryMasters { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<JobGroup> JobGroups { get; set; }
        public virtual DbSet<Rank> Ranks { get; set; }
        public virtual DbSet<Role> Roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-2R623PB;Database=groupdb;Integrated Security=True;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.HasKey(e => e.BrCode);

                entity.ToTable("Branch");

                entity.Property(e => e.BrCode)
                    .ValueGeneratedNever()
                    .HasColumnName("Br_code");

                entity.Property(e => e.BrActive)
                    .HasMaxLength(50)
                    .HasColumnName("Br_active")
                    .HasDefaultValueSql("(N'y')");

                entity.Property(e => e.BrCmpCode)
                    .HasColumnName("Br_Cmp_code")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.BrCreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Br_created_at");

                entity.Property(e => e.BrCreatedBy).HasColumnName("Br_created_by");

                entity.Property(e => e.BrCreatedChanel)
                    .HasMaxLength(50)
                    .HasColumnName("Br_created_chanel");

                entity.Property(e => e.BrNameAr)
                    .HasMaxLength(150)
                    .HasColumnName("Br_name_ar");

                entity.Property(e => e.BrNameEn)
                    .HasMaxLength(150)
                    .HasColumnName("Br_name_en");

                entity.Property(e => e.BrUpdateAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Br_update_at");

                entity.Property(e => e.BrUpdateBy).HasColumnName("Br_update_by");

                entity.Property(e => e.BrUpdateChanel)
                    .HasMaxLength(50)
                    .HasColumnName("Br_update_chanel");

                entity.HasOne(d => d.BrCmpCodeNavigation)
                    .WithMany(p => p.Branches)
                    .HasForeignKey(d => d.BrCmpCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Branch_Company");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasKey(e => e.CmpCode);

                entity.ToTable("Company");

                entity.Property(e => e.CmpCode)
                    .ValueGeneratedNever()
                    .HasColumnName("Cmp_code");

                entity.Property(e => e.CmpActive)
                    .HasMaxLength(50)
                    .HasColumnName("Cmp_active");

                entity.Property(e => e.CmpArAdress)
                    .HasColumnName("Cmp_ArAdress")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CmpCotCode).HasColumnName("Cmp_Cot_code");

                entity.Property(e => e.CmpCreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Cmp_created_at");

                entity.Property(e => e.CmpCreatedBy).HasColumnName("Cmp_created_by");

                entity.Property(e => e.CmpCreatedChanel)
                    .HasMaxLength(50)
                    .HasColumnName("Cmp_created_chanel");

                entity.Property(e => e.CmpEnAdress)
                    .HasColumnName("Cmp_EnAdress")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CmpFooterDesc).HasColumnName("Cmp_FooterDesc");

                entity.Property(e => e.CmpLicensNo)
                    .HasMaxLength(50)
                    .HasColumnName("Cmp_LicensNo");

                entity.Property(e => e.CmpLicensStartDate)
                    .HasColumnType("date")
                    .HasColumnName("Cmp_LicensStartDate");

                entity.Property(e => e.CmpNameAr)
                    .HasColumnName("Cmp_name_ar")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CmpNameEn)
                    .HasColumnName("Cmp_name_en")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CmpTradingRecordNo)
                    .HasMaxLength(50)
                    .HasColumnName("Cmp_TradingRecordNo")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CmpTradingRoomNo)
                    .HasMaxLength(50)
                    .HasColumnName("Cmp_TradingRoomNo")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CmpUpdateAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Cmp_update_at");

                entity.Property(e => e.CmpUpdateBy).HasColumnName("Cmp_update_by");

                entity.Property(e => e.CmpUpdateChanel)
                    .HasMaxLength(50)
                    .HasColumnName("Cmp_update_chanel");

                entity.Property(e => e.CmpVatNo)
                    .HasMaxLength(50)
                    .HasColumnName("Cmp_VatNo")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.CotCode)
                    .HasName("PK_countries");

                entity.ToTable("Country");

                entity.Property(e => e.CotCode)
                    .ValueGeneratedNever()
                    .HasColumnName("Cot_code");

                entity.Property(e => e.CotActive)
                    .HasMaxLength(50)
                    .HasColumnName("Cot_active")
                    .HasDefaultValueSql("(N'y')");

                entity.Property(e => e.CotCreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Cot_created_at");

                entity.Property(e => e.CotCreatedBy).HasColumnName("Cot_created_by");

                entity.Property(e => e.CotCreatedChanel)
                    .HasMaxLength(50)
                    .HasColumnName("Cot_created_chanel");

                entity.Property(e => e.CotKey)
                    .HasMaxLength(20)
                    .HasColumnName("Cot_key");

                entity.Property(e => e.CotNameAr)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Cot_name_ar");

                entity.Property(e => e.CotNameEn)
                    .HasMaxLength(50)
                    .HasColumnName("Cot_name_en");

                entity.Property(e => e.CotNameKey)
                    .HasMaxLength(20)
                    .HasColumnName("Cot_name_key");

                entity.Property(e => e.CotUpdateAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Cot_update_at");

                entity.Property(e => e.CotUpdateBy).HasColumnName("Cot_update_by");

                entity.Property(e => e.CotUpdateChanel)
                    .HasMaxLength(50)
                    .HasColumnName("Cot_update_chanel");
            });

            modelBuilder.Entity<DptDev>(entity =>
            {
                entity.HasKey(e => e.DptCode)
                    .HasName("PK_Department");

                entity.ToTable("Dpt_Dev");

                entity.Property(e => e.DptCode)
                    .ValueGeneratedNever()
                    .HasColumnName("Dpt_code");

                entity.Property(e => e.DptActive)
                    .HasMaxLength(50)
                    .HasColumnName("Dpt_active")
                    .HasDefaultValueSql("(N'y')");

                entity.Property(e => e.DptBrCode)
                    .HasColumnName("Dpt_Br_code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DptCreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Dpt_created_at");

                entity.Property(e => e.DptCreatedBy).HasColumnName("Dpt_created_by");

                entity.Property(e => e.DptCreatedChanel)
                    .HasMaxLength(50)
                    .HasColumnName("Dpt_created_chanel");

                entity.Property(e => e.DptNameAr)
                    .HasMaxLength(150)
                    .HasColumnName("Dpt_name_ar");

                entity.Property(e => e.DptNameEn)
                    .HasMaxLength(150)
                    .HasColumnName("Dpt_name_en");

                entity.Property(e => e.DptParent).HasColumnName("Dpt_parent");

                entity.Property(e => e.DptType)
                    .HasMaxLength(1)
                    .HasColumnName("Dpt_type")
                    .HasDefaultValueSql("('D')");

                entity.Property(e => e.DptUpdateAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Dpt_update_at");

                entity.Property(e => e.DptUpdateBy).HasColumnName("Dpt_update_by");

                entity.Property(e => e.DptUpdateChanel)
                    .HasMaxLength(50)
                    .HasColumnName("Dpt_update_chanel");

                entity.HasOne(d => d.DptBrCodeNavigation)
                    .WithMany(p => p.DptDevs)
                    .HasForeignKey(d => d.DptBrCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Department_Branch");

                entity.HasOne(d => d.DptParentNavigation)
                    .WithMany(p => p.InverseDptParentNavigation)
                    .HasForeignKey(d => d.DptParent)
                    .HasConstraintName("FK_Department_Department");
            });

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

                entity.Property(e => e.EmpManager)
                    .HasMaxLength(50)
                    .HasColumnName("Emp_manager");

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

                entity.Property(e => e.EmpRoleCode).HasColumnName("Emp_role_code");

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

                entity.HasOne(d => d.EmpBirthPlace)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.EmpBirthPlaceId)
                    .HasConstraintName("FK_Employee_Country");

                entity.HasOne(d => d.EmpCmpCodeNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.EmpCmpCode)
                    .HasConstraintName("FK_Employee_Company");

                entity.HasOne(d => d.EmpDptCodeNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.EmpDptCode)
                    .HasConstraintName("FK_Employee_Dpt_Dev");

                entity.HasOne(d => d.EmpJobCodeNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.EmpJobCode)
                    .HasConstraintName("FK_Employee_Job");

                entity.HasOne(d => d.EmpManagerNavigation)
                    .WithMany(p => p.InverseEmpManagerNavigation)
                    .HasForeignKey(d => d.EmpManager)
                    .HasConstraintName("FK_Employee_Employee");

                entity.HasOne(d => d.EmpRankCodeNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.EmpRankCode)
                    .HasConstraintName("FK_Employee_Rank");
            });

            modelBuilder.Entity<GeneralDictionaryDetail>(entity =>
            {
                entity.HasKey(e => e.GddCdoe)
                    .HasName("PK_DictTypeD");

                entity.ToTable("General_Dictionary_details");

                entity.Property(e => e.GddCdoe)
                    .ValueGeneratedNever()
                    .HasColumnName("GDD_cdoe");

                entity.Property(e => e.GddActive)
                    .HasMaxLength(50)
                    .HasColumnName("GDD_Active");

                entity.Property(e => e.GddCreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("GDD_created_at");

                entity.Property(e => e.GddCreatedBy).HasColumnName("GDD_created_by");

                entity.Property(e => e.GddCreatedChanel)
                    .HasMaxLength(50)
                    .HasColumnName("GDD_created_chanel");

                entity.Property(e => e.GddGdmDescAr)
                    .HasMaxLength(100)
                    .HasColumnName("GDD_GDM_Desc_ar");

                entity.Property(e => e.GddGdmDescEn)
                    .HasMaxLength(100)
                    .HasColumnName("GDD_GDM_Desc_en");

                entity.Property(e => e.GddGdmTypeCode).HasColumnName("GDD_GDM_Type_code");

                entity.Property(e => e.GddUpdateAt)
                    .HasColumnType("datetime")
                    .HasColumnName("GDD_update_at");

                entity.Property(e => e.GddUpdateBy).HasColumnName("GDD_update_by");

                entity.Property(e => e.GddUpdateChanel)
                    .HasMaxLength(50)
                    .HasColumnName("GDD_update_chanel");

                entity.HasOne(d => d.GddGdmTypeCodeNavigation)
                    .WithMany(p => p.GeneralDictionaryDetails)
                    .HasForeignKey(d => d.GddGdmTypeCode)
                    .HasConstraintName("FK_General_Dictionary_details_General_Dictionary_Master");
            });

            modelBuilder.Entity<GeneralDictionaryMaster>(entity =>
            {
                entity.HasKey(e => e.GdmTypeCode)
                    .HasName("PK_DictType");

                entity.ToTable("General_Dictionary_Master");

                entity.Property(e => e.GdmTypeCode)
                    .ValueGeneratedNever()
                    .HasColumnName("GDM_Type_code");

                entity.Property(e => e.GdmActive)
                    .HasMaxLength(50)
                    .HasColumnName("GDM_Active");

                entity.Property(e => e.GdmCreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("GDM_created_at");

                entity.Property(e => e.GdmCreatedBy).HasColumnName("GDM_created_by");

                entity.Property(e => e.GdmCreatedChanel)
                    .HasMaxLength(50)
                    .HasColumnName("GDM_created_chanel");

                entity.Property(e => e.GdmTypeDescAr)
                    .HasMaxLength(100)
                    .HasColumnName("GDM_Type_Desc_ar");

                entity.Property(e => e.GdmTypeDescEn)
                    .HasMaxLength(100)
                    .HasColumnName("GDM_Type_Desc_en");

                entity.Property(e => e.GdmUpdateAt)
                    .HasColumnType("datetime")
                    .HasColumnName("GDM_update_at");

                entity.Property(e => e.GdmUpdateBy).HasColumnName("GDM_update_by");

                entity.Property(e => e.GdmUpdateChanel)
                    .HasMaxLength(50)
                    .HasColumnName("GDM_update_chanel");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.HasKey(e => e.JobCode)
                    .HasName("PK_Job_1");

                entity.ToTable("Job");

                entity.Property(e => e.JobCode)
                    .ValueGeneratedNever()
                    .HasColumnName("Job_code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedChanel)
                    .HasMaxLength(50)
                    .HasColumnName("created_chanel");

                entity.Property(e => e.JobActive)
                    .HasMaxLength(1)
                    .HasColumnName("job_active")
                    .HasDefaultValueSql("(N'y')")
                    .IsFixedLength(true);

                entity.Property(e => e.JobJbgCode).HasColumnName("Job_jbg_code");

                entity.Property(e => e.JobNameAr)
                    .HasMaxLength(50)
                    .HasColumnName("Job_name_ar");

                entity.Property(e => e.JobNameEn)
                    .HasMaxLength(150)
                    .HasColumnName("Job_name_en");

                entity.Property(e => e.UpdateAt)
                    .HasColumnType("datetime")
                    .HasColumnName("update_at");

                entity.Property(e => e.UpdateBy).HasColumnName("update_by");

                entity.Property(e => e.UpdateChanel)
                    .HasMaxLength(50)
                    .HasColumnName("update_chanel");

                entity.HasOne(d => d.JobJbgCodeNavigation)
                    .WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.JobJbgCode)
                    .HasConstraintName("FK_Job_Job_group");
            });

            modelBuilder.Entity<JobGroup>(entity =>
            {
                entity.HasKey(e => e.JbgCode)
                    .HasName("PK_Jobgroup_1");

                entity.ToTable("Job_group");

                entity.Property(e => e.JbgCode)
                    .ValueGeneratedNever()
                    .HasColumnName("jbg_code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedChanel)
                    .HasMaxLength(50)
                    .HasColumnName("created_chanel");

                entity.Property(e => e.JbgActive)
                    .HasMaxLength(1)
                    .HasColumnName("jbg_active")
                    .HasDefaultValueSql("(N'y')")
                    .IsFixedLength(true);

                entity.Property(e => e.JbgCmpCode).HasColumnName("jbg_Cmp_code");

                entity.Property(e => e.JbgJbfgNameEn)
                    .HasMaxLength(150)
                    .HasColumnName("jbg_jbfg_name_en");

                entity.Property(e => e.JbgNameAr)
                    .HasMaxLength(50)
                    .HasColumnName("jbg_name_ar");

                entity.Property(e => e.UpdateAt)
                    .HasColumnType("datetime")
                    .HasColumnName("update_at");

                entity.Property(e => e.UpdateBy).HasColumnName("update_by");

                entity.Property(e => e.UpdateChanel)
                    .HasMaxLength(50)
                    .HasColumnName("update_chanel");

                entity.HasOne(d => d.JbgCmpCodeNavigation)
                    .WithMany(p => p.JobGroups)
                    .HasForeignKey(d => d.JbgCmpCode)
                    .HasConstraintName("FK_Job_group_Company");
            });

            modelBuilder.Entity<Rank>(entity =>
            {
                entity.HasKey(e => e.RankCode)
                    .HasName("PK_Rank_1");

                entity.ToTable("Rank");

                entity.Property(e => e.RankCode)
                    .ValueGeneratedNever()
                    .HasColumnName("rank_code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedChanel)
                    .HasMaxLength(50)
                    .HasColumnName("created_chanel");

                entity.Property(e => e.RankActive)
                    .HasMaxLength(1)
                    .HasColumnName("rank_active")
                    .HasDefaultValueSql("(N'y')")
                    .IsFixedLength(true);

                entity.Property(e => e.RankCmpCode).HasColumnName("rank_Cmp_code");

                entity.Property(e => e.RankNameAr)
                    .HasMaxLength(50)
                    .HasColumnName("rank_name_ar");

                entity.Property(e => e.RankNameEn)
                    .HasMaxLength(150)
                    .HasColumnName("rank_name_en");

                entity.Property(e => e.UpdateAt)
                    .HasColumnType("datetime")
                    .HasColumnName("update_at");

                entity.Property(e => e.UpdateBy).HasColumnName("update_by");

                entity.Property(e => e.UpdateChanel)
                    .HasMaxLength(50)
                    .HasColumnName("update_chanel");

                entity.HasOne(d => d.RankCmpCodeNavigation)
                    .WithMany(p => p.Ranks)
                    .HasForeignKey(d => d.RankCmpCode)
                    .HasConstraintName("FK_Rank_Company");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.RoleCode)
                    .HasName("PK_Role_1");

                entity.Property(e => e.RoleCode)
                    .ValueGeneratedNever()
                    .HasColumnName("role_code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedChanel)
                    .HasMaxLength(50)
                    .HasColumnName("created_chanel");

                entity.Property(e => e.RoleActive)
                    .HasMaxLength(1)
                    .HasColumnName("role_active")
                    .IsFixedLength(true);

                entity.Property(e => e.RoleCmpCode).HasColumnName("role_Cmp_code");

                entity.Property(e => e.RoleNameAr)
                    .HasMaxLength(50)
                    .HasColumnName("role_name_ar");

                entity.Property(e => e.RoleNameEn)
                    .HasMaxLength(150)
                    .HasColumnName("role_name_en");

                entity.Property(e => e.UpdateAt)
                    .HasColumnType("datetime")
                    .HasColumnName("update_at");

                entity.Property(e => e.UpdateBy).HasColumnName("update_by");

                entity.Property(e => e.UpdateChanel)
                    .HasMaxLength(50)
                    .HasColumnName("update_chanel");

                entity.HasOne(d => d.RoleCmpCodeNavigation)
                    .WithMany(p => p.Roles)
                    .HasForeignKey(d => d.RoleCmpCode)
                    .HasConstraintName("FK_Roles_Company");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
