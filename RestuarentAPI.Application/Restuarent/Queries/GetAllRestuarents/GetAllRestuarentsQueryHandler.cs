using AutoMapper;
using MediatR;
using RestuarentAPI.Domain.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestuarentAPI.Application.Restuarent.Queries.GetAllRestuarents
{
    public class GetAllRestuarentsQueryHandler : IRequestHandler<GetAllRestuarentsQuery, List<RestuarentVm>>
    {
        private readonly IRestuarentRepository _restuarentRepository;
        private readonly IMapper _mapper;

        public GetAllRestuarentsQueryHandler(IRestuarentRepository restuarent, IMapper mapper)
        {
            _restuarentRepository = restuarent;
            _mapper = mapper;
        }
        public async Task<List<RestuarentVm>> Handle(GetAllRestuarentsQuery request, CancellationToken cancellationToken)
        {
            var restuarent = await _restuarentRepository.GetAll();
            return _mapper.Map<List<RestuarentVm>>(restuarent);
        }
    }
}
