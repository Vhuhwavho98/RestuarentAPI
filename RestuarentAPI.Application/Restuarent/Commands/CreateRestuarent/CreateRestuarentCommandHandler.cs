using AutoMapper;
using MediatR;
using RestuarentAPI.Application.Restuarent.Queries;
using RestuarentAPI.Domain.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestuarentAPI.Application.Restuarent.Commands.CreateRestuarent
{
    public class CreateRestuarentCommandHandler : IRequestHandler<CreateRestuarentCommand, RestuarentVm>
    {
        private readonly IRestuarentRepository _restuarentRepository;
        private readonly IMapper _mapper;

        public CreateRestuarentCommandHandler(IRestuarentRepository restuarentRepository, IMapper mapper)
        {
            _restuarentRepository = restuarentRepository;
            _mapper = mapper;
        }
        public async Task<RestuarentVm> Handle(CreateRestuarentCommand request, CancellationToken cancellationToken)
        {
            var restuarent = new Domain.Entities.Restuarent() {
                CellNumber = request.CellNumber,
                Name =request.Name,
                CityName= request.CityName,
                Halaal= request.Halaal,
                Description= request.Description,
                RestuarentType= request.RestuarentType,
            };

            var result =await _restuarentRepository.CreateRestuarent(restuarent);
            return _mapper.Map<RestuarentVm>(result);

        }
    }
}
