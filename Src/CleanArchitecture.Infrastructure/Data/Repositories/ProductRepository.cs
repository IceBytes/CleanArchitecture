﻿using CleanArchitecture.Domain.Entities.Products;
using CleanArchitecture.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Data.Repositories
{
    public class ProductRepository : RepositoryBase<ProductItem>, IProductRepository
    {
        public ProductRepository(DataContext dataContext) : base(dataContext)
        {
            
        }
    }
}
