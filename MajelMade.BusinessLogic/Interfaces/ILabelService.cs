using System.Threading.Tasks;
using MajelMade.Domain.Entities;

namespace MajelMade.BusinessLogic.Interfaces
{
    public interface ILabelService
    {
        Task<ScannableLabel> GetLabelByBarcodeAsync(string barcode);
        // You could add additional methods here if needed.
    }
}
