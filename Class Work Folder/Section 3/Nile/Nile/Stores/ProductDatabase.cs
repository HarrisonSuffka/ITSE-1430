using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile.Stores
{
    /// <summary>Base class for product database.</summary>
    public abstract class ProductDatabase : IProductDatabase
    {

        /// <summary>Adds a product.</summary>
        /// <param name="product">The product to add.</param>
        /// <returns>The added product.</returns>
        public Product Add( Product product )
        {
            //Validate
            if (product == null)
                return null;

            //Using IValidatableObject
            if (!ObjectValidator.TryValidate(product, out var errors))
            return null;

            //if (!String.IsNullOrEmpty(product.Validate()))
            //    return null;

            return AddCore(product);

            //Emulate database by storing copy 
            //var newProduct = CopyProduct(product);
                //_products.Add(product);
                //newProduct.Id = _nextId++;
            //AddCore(newProduct);

            //return CopyProduct(newProduct)
            
            //var item = _products[0] as Product;
            //var item = _products[0];

            //TODO: Implement Add
            //return product;
        }

        /// <summary>Get a specific product.</summary>
        /// <returns>The product, if it exists.</returns>
        public Product Get ( int id )
        {
            if (id <= 0)
                return null;

            //foreach ( var product in _products)
            //{
            //    if (product.Id == id)
            //        return CopyProduct(product);
            //}

            //return (product != null) ? CopyProduct(product) : null;
            return GetCore(id);
        }

        protected abstract Product GetCore( int id );

        /// <summary>Gets all products.</summary>
        /// <returns>The products.</returns>
        public IEnumerable<Product> GetAll()
        {
            return GetAllCore();
        }

        protected abstract IEnumerable<Product> GetAllCore();

        /// <summary>Removes the product.</summary>
        /// <param name="product">The product to remove.</param>
        public void Remove( int id )
        {
            if (id <= 0)
                return;

            var product = GetCore(id);
            if (product.Id == id)
                return RemoveCore(product);

        }

        protected abstract void RemoveCore( int id );

        /// <summary>Updates a product.</summary>
        /// <param name="product">The product to update.</param>
        /// <returns>The updated product.</returns>
        public Product Update( Product product )
        {

           if (product == null)
                    return null;

            //Using IValidatableObject
            if (!ObjectValidator.TryValidate(product, out var errors))
                return null;

            //if (!String.IsNullOrEmpty(product.Validate()))
            //     return null;

            //get existing product 
            var existing = GetCore(product.Id);
            if (existing == null)
                return null;

            _products.Remove(existing);
            //Emulate database by storing copy 
             var newProduct = CopyProduct(product);
            _products.Add(product);

            return UpdateCore( existing ,product);
        }

        protected abstract Product UpdateCore( Product existing, Product newItem );

        protected abstract Product AddCore( Product product );

    }
}
