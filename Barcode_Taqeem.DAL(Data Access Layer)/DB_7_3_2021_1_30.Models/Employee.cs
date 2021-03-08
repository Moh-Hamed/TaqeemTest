using System;
using System.Collections.Generic;

#nullable disable

namespace Barcode_Taqeem.DAL_Data_Access_Layer_.DB_7_3_2021_1_30.Models
{
    public partial class Employee
    {
        public Employee()
        {
            InverseEmpManagerNavigation = new HashSet<Employee>();
        }

        public string EmpCode { get; set; }
        public string EmpNo { get; set; }
        public string EmpNameAr { get; set; }
        public string EmpNameEn { get; set; }
        public int? EmpRoleCode { get; set; }
        public string EmpManager { get; set; }
        public int? EmpReligon { get; set; }
        public string EmpSex { get; set; }
        public string EmpMary { get; set; }
        public int? EmpCmpCode { get; set; }
        public int? EmpBrCode { get; set; }
        public int? EmpDptCode { get; set; }
        public int? EmpJobCode { get; set; }
        public int? EmpRankCode { get; set; }
        public DateTime? EmpBirthDate { get; set; }
        public int? EmpBirthPlaceId { get; set; }
        public string EmpActive { get; set; }
        public int? EmpCreatedBy { get; set; }
        public DateTime? EmpCreatedAt { get; set; }
        public string EmpCreatedChanel { get; set; }
        public int? EmpUpdateBy { get; set; }
        public DateTime? EmpUpdateAt { get; set; }
        public string EmpUpdateChanel { get; set; }

        public virtual Country EmpBirthPlace { get; set; }
        public virtual Company EmpCmpCodeNavigation { get; set; }
        public virtual DptDev EmpDptCodeNavigation { get; set; }
        public virtual Job EmpJobCodeNavigation { get; set; }
        public virtual Employee EmpManagerNavigation { get; set; }
        public virtual Rank EmpRankCodeNavigation { get; set; }
        public virtual ICollection<Employee> InverseEmpManagerNavigation { get; set; }
    }
}
