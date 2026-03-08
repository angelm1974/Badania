using Badania.Data;
using Badania.Models;
using Microsoft.EntityFrameworkCore;

namespace Badania.Services
{
    public class RegistrationService
    {
        private readonly AppDbContext _context;

        public RegistrationService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Registration>> GetRegistrationsAsync()
        {
            return await _context.Registrations.ToListAsync();
        }

        public async Task AddRegistrationAsync(Registration registration)
        {
            _context.Registrations.Add(registration);
            await _context.SaveChangesAsync();
        }
    }
}
