using System;
using System.Collections.Generic;

#nullable disable

namespace Barcode_Taqeem.DAL_Data_Access_Layer_.RRStoreContext.Models
{
    public partial class LoginUser
    {
        public string LogEmpCode { get; set; }
        public string LogEmpEmail { get; set; }
        public string LogPassword { get; set; }
        public int? LogCreatedBy { get; set; }
        public DateTime? LogCreatedAt { get; set; }
        public string LogCreatedChanel { get; set; }
        public int? LogUpdateBy { get; set; }
        public DateTime? LogUpdateAt { get; set; }
        public string LogUpdateChanel { get; set; }

        public virtual Employee LogEmpCodeNavigation { get; set; }
    }
}
