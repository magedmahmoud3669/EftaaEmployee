using Dal.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Models
{
    public class EmployeesVM
    {
        
        public int Id { get; set; }
        
        public string Name { get; set; }
        [RegularExpression("[23](?:[0-9]{2}(?:(?:(?:0[13578]|1[02])(?:0[1-9]|[12][0-9]|3[01]))|(?:(?:0[469]|11)(?:0[1-9]|[12][0-9]|30))|(?:02(?:0[1-9]|1[0-9]|2[0-8])))|(?:(?:04|08|[2468][048]|[13579][26]|(?<=3)00)0229))(?:0[1-4]|[12][1-9]|3[1-5]|88)[0-9]{4}[1-9]", ErrorMessage = "invalid national id")]
        public string NationalId { get; set; }
        [RegularExpression("(201)[0-9]{9}", ErrorMessage = "invalid mobile number")]
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
