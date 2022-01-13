using DYUCoreApp.Data.Entities;
using DYUCoreApp.Data.IRepositories;

namespace TeduCoreApp.Data.EF.Repositories
{
    public class FunctionRepository : EFRepository<Function, string>, IFunctionRepository
    {
        public FunctionRepository(AppDbContext context) : base(context)
        {
        }
    }
}