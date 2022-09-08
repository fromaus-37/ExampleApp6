using System.Linq;
namespace ExampleApp6.Models
{
    public interface IRepository
    {
        IQueryable<Product> Products { get; }
    }
}