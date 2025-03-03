using System.Collections.Generic;
using System.Threading.Tasks;
using MajelMade.Domain.Entities;

namespace MajelMade.BusinessLogic.Interfaces
{
    public interface IModificationTypeService
    {
        Task<IEnumerable<ModificationType>> GetAllModificationTypesAsync();
    }
}
