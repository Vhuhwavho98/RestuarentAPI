using RestuarentAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestuarentAPI.Domain.IRepository
{
    public interface IRestuarentRepository
    {
        Task<List<Restuarent>> GetAll();
        Task<Restuarent> GetById(int id);
        Task<Restuarent> CreateRestuarent(Restuarent restuarent);
        Task<int> UpdateRestuarent(Restuarent restuarent, int id);
        Task<int> DeleteRestuarent(int id);
    }
}
