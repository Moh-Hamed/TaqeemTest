using System;
using System.Collections.Generic;

#nullable disable

namespace Barcode_Taqeem.DAL_Data_Access_Layer_.DB_7_3_2021_1_30.Models
{
    public partial class GeneralDictionaryMaster
    {
        public GeneralDictionaryMaster()
        {
            GeneralDictionaryDetails = new HashSet<GeneralDictionaryDetail>();
        }

        public int GdmTypeCode { get; set; }
        public string GdmTypeDescEn { get; set; }
        public string GdmTypeDescAr { get; set; }
        public string GdmActive { get; set; }
        public int? GdmCreatedBy { get; set; }
        public DateTime? GdmCreatedAt { get; set; }
        public string GdmCreatedChanel { get; set; }
        public int? GdmUpdateBy { get; set; }
        public DateTime? GdmUpdateAt { get; set; }
        public string GdmUpdateChanel { get; set; }

        public virtual ICollection<GeneralDictionaryDetail> GeneralDictionaryDetails { get; set; }
    }
}
