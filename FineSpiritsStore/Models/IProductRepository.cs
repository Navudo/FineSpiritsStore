﻿using System.Linq;

namespace FineSpiritsStore.Models
{
    public interface IProductRepository
    {
        /* IQueryable allows us to ask the database for just the objects that we require using
        standard LINQ statements and without needing to know what database server stores the data or how it
        processes the query*/
        IQueryable<Product> Products { get;}
    }
}
    