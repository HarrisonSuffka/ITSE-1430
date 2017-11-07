/*
 * ITSE 1430
 */
using System;

namespace Nile.Stores
{
    /// <summary>Provides a <see cref="MemoryProductDatabase"/> with products already added.</summary>
    public static class ProductDatabaseExtension
    {
        public static Product GetByName (this IProductDatabase source, string name)
        {
            foreach ( var item in source.GetAll())
            {
                if (String.Compare(item.Name, name, true) == 0)
                    return item;
            };
            return null;
        }

        /// <summary>Initializes an instance of the <see cref="SeedMemoryProductDatabase"/> class.</summary>
        public static void WithSeedData (this IProductDatabase source)
        {
          source.Add(new Product() { Name = "Galaxy S8", Price = 800 });
          source.Add(new Product() { Name = "Galaxy S7", Price = 650 });
          source.Add(new Product() { Name = "Galaxy Note 7", Price = 150, IsDiscontinued = true });
          source.Add(new Product() { Name = "Galaxy Note 8", Price = 1000 });
          source.Add(new Product() { Name = "Windows Phone", Price = 100, IsDiscontinued = true });
          source.Add(new Product() { Name = "iPhone X", Price = 1150 });
        }                                      
    }
}
