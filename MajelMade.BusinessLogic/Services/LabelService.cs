using System;
using System.Threading.Tasks;
using MajelMade.BusinessLogic.Interfaces;
using MajelMade.Data.Repositories.Interfaces;
using MajelMade.Domain.Entities;

namespace MajelMade.BusinessLogic.Services
{
    public class LabelService : ILabelService
    {
        private readonly ILabelRepository _labelRepository;

        public LabelService(ILabelRepository labelRepository)
        {
            _labelRepository = labelRepository;
        }

        public async Task<ScannableLabel> GetLabelByBarcodeAsync(string barcode)
        {
            var label = await _labelRepository.GetByBarcodeAsync(barcode);
            if (label == null)
            {
                throw new InvalidOperationException($"No label found with barcode {barcode}");
            }
            return label;
        }
    }
}
