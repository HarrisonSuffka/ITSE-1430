using System.Collections.Generic;

namespace Nile
{
    public interface IProductDatabase
    {
        Product Add( Product product );

        Product Get( int Id );

       IEnumerable<Product> GetAll();

        void Remove( int id );

        Product Update( Product product );

    }
}