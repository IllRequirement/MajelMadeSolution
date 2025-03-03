using System.Collections.Generic;
using System.Threading.Tasks;
using MajelMade.BusinessLogic.Interfaces;
using MajelMade.Data.Repositories.Interfaces;
using MajelMade.Domain.Entities;

namespace MajelMade.BusinessLogic.Services
{
    public class ModificationTypeService : IModificationTypeService
    {
        private readonly IModificationTypeRepository _repository;

        public ModificationTypeService(IModificationTypeRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ModificationType>> GetAllModificationTypesAsync()
        {
            return await _repository.GetAllAsync();
        }
    }
}
