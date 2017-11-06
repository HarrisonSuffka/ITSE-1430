/*
 * ITSE 1430
 */
using System;

namespace Nile.Stores
{
    /// <summary>Provides a <see cref="MemoryProductDatabase"/> with products already added.</summary>
    public static class ProductDatabaseExtension
    {
        /// <summary>Initializes an instance of the <see cref="SeedMemoryProductDatabase"/> class.</summary>
        public static void WithSeedData (this IProductDatabase database)
        {
           database.Add(new Product() { Name = "Galaxy S8", Price = 800 });
           database.Add(new Product() { Name = "Galaxy S7", Price = 650 });
           database.Add(new Product() { Name = "Galaxy Note 7", Price = 150, IsDiscontinued = true });
           database.Add(new Product() { Name = "Galaxy Note 8", Price = 1000 });
           database.Add(new Product() { Name = "Windows Phone", Price = 100, IsDiscontinued = true });
           database.Add(new Product() { Name = "iPhone X", Price = 1150 });
        }                                      
    }
}
