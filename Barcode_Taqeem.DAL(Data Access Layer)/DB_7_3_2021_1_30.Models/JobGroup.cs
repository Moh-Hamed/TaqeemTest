using System;
using System.Collections.Generic;

#nullable disable

namespace Barcode_Taqeem.DAL_Data_Access_Layer_.DB_7_3_2021_1_30.Models
{
    public partial class JobGroup
    {
        public JobGroup()
        {
            Jobs = new HashSet<Job>();
        }

        public int JbgCode { get; set; }
        public string JbgNameAr { get; set; }
        public string JbgJbfgNameEn { get; set; }
        public int? JbgCmpCode { get; set; }
        public string JbgActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string CreatedChanel { get; set; }
        public string UpdateChanel { get; set; }

        public virtual Company JbgCmpCodeNavigation { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
    }
}
