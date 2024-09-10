using MediatR;
using RestuarentAPI.Application.Restuarent.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestuarentAPI.Application.Restuarent.Commands.CreateRestuarent
{
    public class CreateRestuarentCommand : IRequest<RestuarentVm>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string RestuarentType { get; set; }
        public string CityName { get; set; }
        public string CellNumber { get; set; }
        public bool Halaal { get; set; }
    }
}
