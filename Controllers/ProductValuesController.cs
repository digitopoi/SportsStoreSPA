using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        // [HttpGet]
        // public IEnumerable<Product> GetProducts(bool related = false)
        // {
        //     IQueryable<Product> query = _context.Products;

        //     if (related)
        //     {
        //         query = query.Include(p => p.Supplier).Include(p => p.Ratings);
        //         List<Product> data = query.ToList();
        //         data.ForEach(p => {
        //             if (p.Supplier != null) 
        //             {
        //                 p.Supplier.Products = null;
        //             }
        //             if (p.Ratings != null) 
        //             {
        //                 p.Ratings.ForEach(r => r.Product = null);
        //             }
        //         });
        //         return data;
        //     }
        //     else
        //     {
        //         return query;
        //     }
        // }
    }
}