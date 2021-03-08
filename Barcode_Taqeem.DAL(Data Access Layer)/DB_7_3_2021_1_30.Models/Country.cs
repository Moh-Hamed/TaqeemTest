using System;
using System.Collections.Generic;

#nullable disable

namespace Barcode_Taqeem.DAL_Data_Access_Layer_.DB_7_3_2021_1_30.Models
{
    public partial class Country
    {
        public Country()
        {
            Employees = new HashSet<Employee>();
        }

        public int CotCode { get; set; }
        public string CotNameAr { get; set; }
        public string CotNameEn { get; set; }
        public string CotKey { get; set; }
        public string CotNameKey { get; set; }
        public string CotActive { get; set; }
        public string CotCreatedChanel { get; set; }
        public int? CotCreatedBy { get; set; }
        public DateTime? CotCreatedAt { get; set; }
        public string CotUpdateChanel { get; set; }
        public int? CotUpdateBy { get; set; }
        public DateTime? CotUpdateAt { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
