using System;
using System.Collections.Generic;

#nullable disable

namespace Barcode_Taqeem.DAL_Data_Access_Layer_.DB_7_3_2021_1_30.Models
{
    public partial class Company
    {
        public Company()
        {
            Branches = new HashSet<Branch>();
            Employees = new HashSet<Employee>();
            JobGroups = new HashSet<JobGroup>();
            Ranks = new HashSet<Rank>();
            Roles = new HashSet<Role>();
        }

        public int CmpCode { get; set; }
        public string CmpNameAr { get; set; }
        public string CmpNameEn { get; set; }
        public int? CmpCotCode { get; set; }
        public string CmpArAdress { get; set; }
        public string CmpEnAdress { get; set; }
        public string CmpVatNo { get; set; }
        public string CmpTradingRecordNo { get; set; }
        public string CmpTradingRoomNo { get; set; }
        public string CmpFooterDesc { get; set; }
        public string CmpLicensNo { get; set; }
        public DateTime? CmpLicensStartDate { get; set; }
        public string CmpActive { get; set; }
        public int? CmpCreatedBy { get; set; }
        public DateTime? CmpCreatedAt { get; set; }
        public string CmpCreatedChanel { get; set; }
        public int? CmpUpdateBy { get; set; }
        public DateTime? CmpUpdateAt { get; set; }
        public string CmpUpdateChanel { get; set; }

        public virtual ICollection<Branch> Branches { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<JobGroup> JobGroups { get; set; }
        public virtual ICollection<Rank> Ranks { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
    }
}
