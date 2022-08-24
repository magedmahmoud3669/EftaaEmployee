using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dal.Entity
{
    public class Employees
    {
        [Key]
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string NationalId { get; set; }
        
        //[DataType(DataType.PhoneNumber)]
        public string Mobile { get; set; }
       
        public string Email { get; set; }
        
        public string AddressInCairo { get; set; }
       
        public string AddressOutCairo { get; set; }
        
     
        public string ChangingReason { get; set; }
        [ForeignKey("ScoialStatus"), Column(Order = 1)]
        public int? ScoialStatusId { get; set; }
        [ForeignKey("CurrentFiqhSchool"), Column(Order = 2)]
        public int? CurrentFiqhSchoolId { get; set; }
        [ForeignKey(" LastFiqhSchool"), Column(Order = 3)]
        public int? LastFiqhSchoolId { get; set; }
        [ForeignKey("FiqhInPreparatorySchool"), Column(Order = 4)]
        public int? FiqhInPreparatorySchoolId { get; set; }
        [ForeignKey("FiqhInSecondarySchool"), Column(Order = 5)]
        public int? FiqhInSecondarySchoolId { get; set; }

        public LookupsValue? ScoialStatus { get; set; }
        public LookupsValue? CurrentFiqhSchool { get; set; }
        public LookupsValue? LastFiqhSchool { get; set; }
        public LookupsValue? FiqhInPreparatorySchool { get; set; }
        public LookupsValue? FiqhInSecondarySchool { get; set; }
    }
}
