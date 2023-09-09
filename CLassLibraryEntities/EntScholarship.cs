using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEnt
{
    public class EntScholarship
    {
        public string pk_scholarshipId { get; set; }
        public string fk_ProvinceId { get; set; }
        public string fk_InstituteId { get; set; }
        public string Year { get; set; }
        public string AllocatedSlot { get; set; }
        public string ProgramID { get; set; }           
        public string TotalScolarships { get; set; }
        public string AfterISACAllocated { get; set; }
        public string AmountSpent { get; set; }

    }
}
