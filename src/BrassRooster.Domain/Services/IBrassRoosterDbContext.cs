using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BrassRooster.Domain.Models;

namespace BrassRooster.Domain.Services
{
    public interface IBrassRoosterDbContext
    {
        IQueryable<Employee> Employees { get; }

        IQueryable<TestServer> TestServers { get; }

        void Add<TEntity>(TEntity entity)
            where TEntity : class;

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
