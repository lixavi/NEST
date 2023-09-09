using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEnt
{
    public class EntStudentInfo
    {
        [DisplayName("pk_studentId")]
        public string? Pk_studentId { get; set; }
        [DisplayName("fk_InstituteId")]
        public string? Fk_InstituteId { get; set; }
        [DisplayName("Name")]
        public string? Name { get; set; }
        [DisplayName("Gender")]
        public string? Gender { get; set; }
        [DisplayName("Maritial")]
        public string? Maritial { get; set; }
        [DisplayName("Religion")]
        public string? Religion { get; set; }
        [DisplayName("FatherName")]
        public string? FatherName { get; set; }
        [DisplayName("CNIC")]
        public string? CNIC { get; set; }
        [DisplayName("PhoneNo")]
        public string? PhoneNo { get; set; }
        [DisplayName("Email")]
        public string? Email { get; set; }
        [DisplayName("Country")]
        public string? Country { get; set; }
        [DisplayName("DomicileDistrict")]
        public string? DomicileDistrict { get; set; }
        [DisplayName("DomicileProvince")]
        public string? DomicileProvince { get; set; }
        [DisplayName("StdDisable")]
        public string? StdDisable { get; set; }
        [DisplayName("DisableDisc")]
        public string? DisableDisc { get; set; }
        [DisplayName("DivorceParents")]
        public string? DivorceParents { get; set; }
        [DisplayName("Orphan")]
        public string? Orphan { get; set; }
        [DisplayName("OrphanDessc")]
        public string? OrphanDesc { get; set; }
    }
}
