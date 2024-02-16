using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NETCorePortfolio_API.DAL.ApiContext;
using NETCorePortfolio_API.DAL.Entity;
using System.Linq;

namespace NETCorePortfolio_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        Context c = new Context();
        [HttpGet]
        public IActionResult CategoryList()
        {
            return Ok(c.Categories.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id) {
            var value = c.Categories.Find(id);
            
            if(value == null)
            {
                return BadRequest();
            }

            return Ok(value);
        }

        [HttpPost]
        public IActionResult CategoryAdd(Category p)
        {
            c.Categories.Add(p);
            c.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        public IActionResult CategoryDelete(int id)
        {
            var value = c.Categories.Find(id);
            
            if(value == null)
            {
                return BadRequest();
            }

            c.Remove(value);
            c.SaveChanges();
            return Ok();
        }


        [HttpPut]
        public IActionResult CategoryUpdate(Category p)
        {
            var value = c.Find<Category>(p.Id);
            
            if( value == null)
            {
                return BadRequest();
            }

            value.Name = p.Name;
            c.Update(value);
            c.SaveChanges();
            return Ok();
        }
    }
}
