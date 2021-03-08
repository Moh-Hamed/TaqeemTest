using System;
using System.Collections.Generic;

#nullable disable

namespace Barcode_Taqeem.DAL_Data_Access_Layer_.DB_7_3_2021_1_30.Models
{
    public partial class Role
    {
        public int RoleCode { get; set; }
        public string RoleNameAr { get; set; }
        public string RoleNameEn { get; set; }
        public int? RoleCmpCode { get; set; }
        public string RoleActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string CreatedChanel { get; set; }
        public string UpdateChanel { get; set; }

        public virtual Company RoleCmpCodeNavigation { get; set; }
    }
}
