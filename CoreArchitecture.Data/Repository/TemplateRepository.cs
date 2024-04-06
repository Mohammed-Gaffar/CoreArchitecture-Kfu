using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoreArchitecture.Data
{
    public class TemplateRepository : BaseRepository<Template, CoreArchitectureContext>
    {
        public TemplateRepository(CoreArchitectureContext dbContext) : base(dbContext)
        {
        }

        public virtual async Task<IList<Template>> GetAllTemplate()
        {
            return await _dbSet.ToListAsync();
        }
        public virtual async Task<Template> GetTemplateById(int id)
        {
            return await _dbSet.FindAsync(id);
        }
    }
}
