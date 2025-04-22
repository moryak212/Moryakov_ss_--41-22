using Moryakov_КТ_41_22.Models;
using Moryakov_КТ_41_22.Database;
using Moryakov_КТ_41_22.Filters;
using Microsoft.EntityFrameworkCore;

namespace Moryakov_КТ_41_22.Interfaces
{
    public interface ITeacherService
    {
        Task<Teacher[]> GetByFilterAsync(TeacherFilter filter, CancellationToken cancellationToken = default);

    }

    public class TeacherService : ITeacherService
    {
        private readonly Teacher_Dbcontext _context;

        public TeacherService(Teacher_Dbcontext context)
        {
            _context = context;
        }

        public async Task<Teacher[]> GetByFilterAsync(TeacherFilter filter, CancellationToken cancellationToken = default)
        {
            var query = _context.Teachers
                .Include(t => t.Position)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(filter.PositionName))
            {
                query = query.Where(t => t.Position.Name == filter.PositionName);
            }

            return await query.ToArrayAsync(cancellationToken);
        }
    }
}
