using MediatR;
using RestuarentAPI.Domain.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestuarentAPI.Application.Restuarent.Commands.DeleteRestuarent
{
    public class DeleteRestuarentCommandHandler : IRequestHandler<DeleteRestuarentCommand, int>
    {
        private readonly IRestuarentRepository _restuarentRepository;
        public DeleteRestuarentCommandHandler( IRestuarentRepository restuarentRepository)
        {
            _restuarentRepository = restuarentRepository;
        }
        public async Task<int> Handle(DeleteRestuarentCommand request, CancellationToken cancellationToken)
        {
            return await _restuarentRepository.DeleteRestuarent(request.Id);

        }
    }
}
