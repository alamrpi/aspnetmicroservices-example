﻿using Catalog.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Data.Context
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
