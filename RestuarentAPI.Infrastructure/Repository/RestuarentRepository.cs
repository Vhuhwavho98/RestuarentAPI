using Microsoft.EntityFrameworkCore;
using RestuarentAPI.Domain.Entities;
using RestuarentAPI.Domain.IRepository;
using RestuarentAPI.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestuarentAPI.Infrastructure.Repository
{
    public class RestuarentRepository : IRestuarentRepository
    {
        private readonly RestuarentDbContext _context;
        public RestuarentRepository( RestuarentDbContext context)
        {
            _context = context;
        }
        public async Task<Restuarent> CreateRestuarent(Restuarent restuarent)
        {
            await _context.Restuarents.AddAsync(restuarent);
            await _context.SaveChangesAsync(); ;
            return restuarent;
        }

        public async Task<int> DeleteRestuarent(int id)
        {
             await _context.Restuarents.Where(model => model.Id == id).ExecuteDeleteAsync();
            return 0;
        }

        public async Task<List<Restuarent>> GetAll()
        {
            return await _context.Restuarents.ToListAsync();
        }

        public async Task<Restuarent> GetById(int id)
        {
            return await _context.Restuarents.Where(model => model.Id == id).FirstOrDefaultAsync();
        }

        public async Task<int> UpdateRestuarent(Restuarent restuarent, int id)
        {
            await _context.Restuarents.Where(model => model.Id == id).ExecuteUpdateAsync(setters =>
            (setters.SetProperty(m=> m.Name,restuarent.Name)
            .SetProperty(m =>m.Description, restuarent.Description)
            .SetProperty(m=>m.CityName, restuarent.CityName)
            .SetProperty(m=> m.Halaal, restuarent.Halaal)
            .SetProperty(m=>m.CellNumber, restuarent.CellNumber)
            ));

            return 0;
        }
    }
}
