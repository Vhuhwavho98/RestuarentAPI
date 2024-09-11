using AutoMapper;
using MediatR;
using RestuarentAPI.Domain.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestuarentAPI.Application.Restuarent.Commands.UpdateRestuarent
{
    class UpdateRestuarentCommandHandler : IRequestHandler<UpdateRestuarentCommand, int>
    {
        private readonly IRestuarentRepository _restuarentRepository;
        private readonly IMapper _mapper;
        public UpdateRestuarentCommandHandler(IRestuarentRepository restuarentRepository, IMapper mapper)
        {
            _mapper = mapper;
            _restuarentRepository = restuarentRepository;
        }
        public async Task<int> Handle(UpdateRestuarentCommand request, CancellationToken cancellationToken)
        {
            var updatedData = new Domain.Entities.Restuarent() {
                CellNumber = request.CellNumber,
                Name = request.Name,
                CityName = request.CityName,
                Halaal = request.Halaal,
                Description = request.Description,
                RestuarentType = request.RestuarentType,
            };

            return await _restuarentRepository.UpdateRestuarent(updatedData, request.Id);

        }
    }
}
