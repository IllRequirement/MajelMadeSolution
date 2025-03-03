using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MajelMade.Data.Contexts;
using MajelMade.Domain.Entities;
using MajelMade.Data.Repositories.Interfaces;

namespace MajelMade.Data.Repositories.Implementations
{
    public class LabelRepository : ILabelRepository
    {
        private readonly MajelMadeDbContext _context;

        public LabelRepository(MajelMadeDbContext context)
        {
            _context = context;
        }

        public async Task<ScannableLabel?> GetByBarcodeAsync(string barcode)
        {
            return await _context.ScannableLabels
                .FirstOrDefaultAsync(l => l.BarcodeValue == barcode);
        }
    }
}
