using AutoMapper;
using MediatR;
using RestuarentAPI.Domain.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestuarentAPI.Application.Restuarent.Queries.GetRestuarentById
{
    public class GetRestuarentByIdQueryHandler : IRequestHandler<GetRestuarentByIdQuery,RestuarentVm>
    {
        private readonly IRestuarentRepository _restuarentRepository;
        private readonly IMapper _mapper;
        public GetRestuarentByIdQueryHandler(IRestuarentRepository restuarentRepository, IMapper mapper)
        {
            _mapper = mapper;
            _restuarentRepository = restuarentRepository;
        }
        public async Task<RestuarentVm>Handle(GetRestuarentByIdQuery request, CancellationToken cancellationToken)
        {
            var restuarent = await _restuarentRepository.GetById(request.Id);
            return _mapper.Map<RestuarentVm>(restuarent);
        }
    }
}
