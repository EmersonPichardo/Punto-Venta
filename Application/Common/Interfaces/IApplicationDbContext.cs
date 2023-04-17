using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces;

public interface IApplicationDbContext
{
    //DbSet<BaseEntity> Entities { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
