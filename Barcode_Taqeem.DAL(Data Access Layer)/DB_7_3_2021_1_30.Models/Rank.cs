using System;
using System.Collections.Generic;

#nullable disable

namespace Barcode_Taqeem.DAL_Data_Access_Layer_.DB_7_3_2021_1_30.Models
{
    public partial class Rank
    {
        public Rank()
        {
            Employees = new HashSet<Employee>();
        }

        public int RankCode { get; set; }
        public string RankNameAr { get; set; }
        public string RankNameEn { get; set; }
        public int? RankCmpCode { get; set; }
        public string RankActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string CreatedChanel { get; set; }
        public string UpdateChanel { get; set; }

        public virtual Company RankCmpCodeNavigation { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
