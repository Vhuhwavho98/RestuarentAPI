using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestuarentAPI.Application.Restuarent.Queries.GetAllRestuarents
{
    public  class GetAllRestuarentsQuery :IRequest<List<RestuarentVm>>
    {
    }
}
