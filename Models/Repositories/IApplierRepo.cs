using System.Collections.Generic;

namespace JobApplying.Models.Repositories
{
    public interface IApplierRepo<T>
    {
        Applier GetApplier(int id);
        List<T> GetAllAppliers();
        bool AddApplier(Applier applier);
    }
}