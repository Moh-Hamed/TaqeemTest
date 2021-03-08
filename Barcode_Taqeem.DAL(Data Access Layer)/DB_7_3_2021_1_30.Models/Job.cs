using System;
using System.Collections.Generic;

#nullable disable

namespace Barcode_Taqeem.DAL_Data_Access_Layer_.DB_7_3_2021_1_30.Models
{
    public partial class Job
    {
        public Job()
        {
            Employees = new HashSet<Employee>();
        }

        public int JobCode { get; set; }
        public string JobNameAr { get; set; }
        public string JobNameEn { get; set; }
        public int? JobJbgCode { get; set; }
        public string JobActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string CreatedChanel { get; set; }
        public string UpdateChanel { get; set; }

        public virtual JobGroup JobJbgCodeNavigation { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
