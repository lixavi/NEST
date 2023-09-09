using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEnt
{
    public class EntEmployee
    {
        [DisplayName("Pk_EmployeeId")]
        public string? Pk_EmployeeId { get;set; }
        [DisplayName("Name")]
        public string? Name { get;set; }
        [DisplayName("FatherName")]
        public string?    FatherName { get;set; }
        [DisplayName("DOB")]
        public string? DOB { get;set; }

        [DisplayName("Email")]
        public string? Email { get;set;}

        [DisplayName("PhoneNo")]
        public string? PhoneNo { get;set; }

        [DisplayName("CNIC")]
        public string? CNIC { get;set; }

        [DisplayName("Designation")]
        public string? Designation { get;set; }
    }
}
