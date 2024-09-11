﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestuarentAPI.Application.Restuarent.Commands.DeleteRestuarent
{
    public class DeleteRestuarentCommand :IRequest<int>
    {
        public int Id { get; set; } 
    }
}
