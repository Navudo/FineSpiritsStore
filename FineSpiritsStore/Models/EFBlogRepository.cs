using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FineSpiritsStore.Models
{
    public class EFBlogRepository : IBlogRepository
    {
        private ApplicationDbContext context;

        public EFBlogRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Blog> Blogs => context.Blogs;
    }
}
