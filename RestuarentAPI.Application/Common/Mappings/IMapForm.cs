using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestuarentAPI.Application.Common.Mappings
{
    public interface IMapForm<T>
    {
        void Mapping(Profile profile);
    }
}
