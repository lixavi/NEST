using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEnt
{
    public class EntInstituteInfo
    {
        [DisplayName("InstituteId")]
        public int PkInstituteId { get; set; }
        [DisplayName("ProvinceId")]
        public string? FkProvinceId { get; set; }
        [DisplayName("InstituteName")]
        public string? InstituteName { get; set; }
    }
}
