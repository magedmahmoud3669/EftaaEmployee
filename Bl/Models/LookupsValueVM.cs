using Dal.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Models
{
    public class LookupsValueVM
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int LookupsId { get; set; }
        public Lookups Lookups { get; set; }
    }
}
