using System;
using System.Collections.Generic;

#nullable disable

namespace Barcode_Taqeem.DAL_Data_Access_Layer_.DB_7_3_2021_1_30.Models
{
    public partial class GeneralDictionaryDetail
    {
        public int GddCdoe { get; set; }
        public string GddGdmDescAr { get; set; }
        public string GddGdmDescEn { get; set; }
        public int? GddGdmTypeCode { get; set; }
        public string GddActive { get; set; }
        public int? GddCreatedBy { get; set; }
        public DateTime? GddCreatedAt { get; set; }
        public string GddCreatedChanel { get; set; }
        public int? GddUpdateBy { get; set; }
        public DateTime? GddUpdateAt { get; set; }
        public string GddUpdateChanel { get; set; }

        public virtual GeneralDictionaryMaster GddGdmTypeCodeNavigation { get; set; }
    }
}
