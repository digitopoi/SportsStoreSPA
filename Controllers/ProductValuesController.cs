using Microsoft.AspNetCore.Mvc;
using SportsStoreSPA.Models;

namespace SportsStoreSPA.Controllers
{
    [Route("api/products")]
    public class ProductValuesController : Controller
    {
        private DataContext _context;

        public ProductValuesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public Product GetProduct(long id)
        {
            return _context.Products.Find(id);
        }
    }
}