using Microsoft.EntityFrameworkCore;
using Moryakov_КТ_41_22.Database;
using Moryakov_КТ_41_22.Filters;
using Moryakov_КТ_41_22.Models;
using Moryakov_КТ_41_22.Interfaces;

namespace Moryakov_КТ_41_22.Services
{
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
                .Include(t => t.AcademicDegree)
                .Include(t => t.Department)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(filter.FullName))
            {
                query = query.Where(t => t.FullName.Contains(filter.FullName));
            }

            if (!string.IsNullOrWhiteSpace(filter.PositionName))
            {
                query = query.Where(t => t.Position.Name == filter.PositionName);
            }

            if (!string.IsNullOrWhiteSpace(filter.AcademicDegreeName))
            {
                query = query.Where(t => t.AcademicDegree.Name == filter.AcademicDegreeName);
            }

            if (!string.IsNullOrWhiteSpace(filter.DepartmentName))
            {
                query = query.Where(t => t.Department.Name == filter.DepartmentName);
            }

            return await query.ToArrayAsync(cancellationToken);
        }
    }
}
