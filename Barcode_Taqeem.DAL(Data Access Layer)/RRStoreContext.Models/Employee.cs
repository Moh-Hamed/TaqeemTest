using System;
using System.Collections.Generic;

#nullable disable

namespace Barcode_Taqeem.DAL_Data_Access_Layer_.RRStoreContext.Models
{
    public partial class Employee
    {
        public string EmpCode { get; set; }
        public string EmpNo { get; set; }
        public string EmpNameAr { get; set; }
        public string EmpNameEn { get; set; }
        public string EmpRoleCode { get; set; }
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

        public virtual LoginUser LoginUser { get; set; }
    }
}
