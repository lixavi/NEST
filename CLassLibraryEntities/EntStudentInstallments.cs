using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEnt
{
    public class EntStudentInstallments
    {
        public string fk_StudentId { get; set; }
        public string Installment { get; set; }
        public string InstallmentDuration { get; set; }
        public string InstallmentAmount { get; set; }
        public string Checqueno { get; set; }
        public string Status { get; set; }
      
    }
}
