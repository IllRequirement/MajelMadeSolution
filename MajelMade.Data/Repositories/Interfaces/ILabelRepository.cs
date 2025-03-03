using System.Threading.Tasks;
using MajelMade.Domain.Entities;

namespace MajelMade.Data.Repositories.Interfaces
{
    public interface ILabelRepository
    {
        Task<ScannableLabel?> GetByBarcodeAsync(string barcode);
    }
}
