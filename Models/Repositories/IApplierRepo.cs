using System.Collections.Generic;
using System.Threading.Tasks;

namespace JobApplying.Models.Repositories
{
    public interface IApplierRepo<T>
    {
        Applier GetApplier(int id);
        List<T> GetAllAppliers();
        Task<bool> AddApplier(Applier applier);
    }
}