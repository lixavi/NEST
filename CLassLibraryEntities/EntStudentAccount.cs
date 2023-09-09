using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEnt
{
    public class EntStudentAccount
    {
        public int fk_StudentId { get; set; }   
        public string AcTitle { get;set; }
        public string IBANNo { get;set; }
        public string BankName { get;set;}
        public int Amount { get;set; }

    }
}
