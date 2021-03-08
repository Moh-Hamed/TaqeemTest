using System;
using System.Collections.Generic;

#nullable disable

namespace Barcode_Taqeem.DAL_Data_Access_Layer_.DB_7_3_2021_1_30.Models
{
    public partial class Branch
    {
        public Branch()
        {
            DptDevs = new HashSet<DptDev>();
        }

        public int BrCode { get; set; }
        public string BrNameEn { get; set; }
        public string BrNameAr { get; set; }
        public int BrCmpCode { get; set; }
        public string BrActive { get; set; }
        public int? BrCreatedBy { get; set; }
        public DateTime? BrCreatedAt { get; set; }
        public string BrCreatedChanel { get; set; }
        public int? BrUpdateBy { get; set; }
        public DateTime? BrUpdateAt { get; set; }
        public string BrUpdateChanel { get; set; }

        public virtual Company BrCmpCodeNavigation { get; set; }
        public virtual ICollection<DptDev> DptDevs { get; set; }
    }
}
