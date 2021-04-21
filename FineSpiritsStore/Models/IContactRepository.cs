using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FineSpiritsStore.Models
{
    public class IContactRepository
    {
        public interface IBlogRepository
        {
            /* IQueryable allows us to ask the database for just the objects that we require using
            standard LINQ statements and without needing to know what database server stores the data or how it
            processes the query*/
            IQueryable<ContactUs> Contact { get; }
        }

    }
}
