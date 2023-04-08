using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public interface ICatalogContext
    {

        /// <summary>
        /// mongodb collection
        /// </summary>
        IMongoCollection<Product> Products { get; }
    }
}
