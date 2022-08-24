using AutoMapper;
using Bl.Models;
using Dal.Entity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDataEmplyee.BL.Mapper
{
    public class DomainProfile:Profile
    {
        public DomainProfile()
        {
            CreateMap<Employees, EmployeesVM>();
            CreateMap<EmployeesVM, Employees>();

            CreateMap<Lookups, LookupsVM>();
            CreateMap<LookupsVM, Lookups>();

            CreateMap<LookupsValue, LookupsValueVM>();
            CreateMap<LookupsValueVM, LookupsValue>();
        }

    }
}
