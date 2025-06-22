using FaultTracker.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FaultTracker.DataAccess
{
    public class FaultService
    {
        private readonly FaultTracker.Models.AppDbContext _context;

        public FaultService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Fault>> GetAllAsync()
        {
            return await _context.Faults.ToListAsync();
        }

        public async Task AddAsync(Fault fault)
        {
            await _context.Faults.AddAsync(fault);
            await _context.SaveChangesAsync();
        }
    }
}