using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEnt
{
    public class EntFocalPerson
    {
        [DisplayName("pk_FocalId")]
        public string? Pk_FocalId { get; set; }
        [DisplayName("fk_InstituteId")]
        public string? Fk_InstituteId { get; set; }
        [DisplayName("Name")]
        public string? Name { get; set; }
        [DisplayName("FatherName")]
        public string? FatherName { get; set; }
        [DisplayName("DOB")]
        public string? DOB { get; set; }
        [DisplayName("Email")]
        public string? Email { get; set; }
        [DisplayName("PhoneNo")]
        public string? PhoneNo { get; set; }
        [DisplayName("CNIC")]
        public string? CNIC { get; set; }
        [DisplayName("Address")]
        public string? Address { get; set; }
        [DisplayName("from ")]
        public string? From { get; set; }
        [DisplayName("to")]
        public string? To{ get; set; }


    }
}
