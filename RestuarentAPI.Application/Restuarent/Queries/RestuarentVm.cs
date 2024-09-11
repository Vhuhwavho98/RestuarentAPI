using AutoMapper;
using RestuarentAPI.Application.Common.Mappings;
using RestuarentAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestuarentAPI.Application.Restuarent.Queries
{
    public class RestuarentVm : IMapFrom<Domain.Entities.Restuarent>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string RestuarentType { get; set; }
        public string CityName { get; set; }
        public string CellNumber { get; set; }
        public bool Halaal { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.Restuarent, RestuarentVm>().ReverseMap();
        }
    }
}
