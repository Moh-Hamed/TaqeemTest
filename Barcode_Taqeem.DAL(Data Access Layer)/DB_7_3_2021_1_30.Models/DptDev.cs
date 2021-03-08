using System;
using System.Collections.Generic;

#nullable disable

namespace Barcode_Taqeem.DAL_Data_Access_Layer_.DB_7_3_2021_1_30.Models
{
    public partial class DptDev
    {
        public DptDev()
        {
            Employees = new HashSet<Employee>();
            InverseDptParentNavigation = new HashSet<DptDev>();
        }

        public int DptCode { get; set; }
        public string DptNameAr { get; set; }
        public string DptNameEn { get; set; }
        public int DptBrCode { get; set; }
        public string DptType { get; set; }
        public int? DptParent { get; set; }
        public string DptActive { get; set; }
        public int? DptCreatedBy { get; set; }
        public DateTime? DptCreatedAt { get; set; }
        public string DptCreatedChanel { get; set; }
        public int? DptUpdateBy { get; set; }
        public DateTime? DptUpdateAt { get; set; }
        public string DptUpdateChanel { get; set; }

        public virtual Branch DptBrCodeNavigation { get; set; }
        public virtual DptDev DptParentNavigation { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<DptDev> InverseDptParentNavigation { get; set; }
    }
}
