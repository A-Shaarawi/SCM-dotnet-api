using Microsoft.AspNetCore.Mvc;
using MyApi.Data;
using MyApi.Models;
using System.Collections.Generic;

namespace MyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly ItemRepository _repository = new ItemRepository();

        // GET: api/items
        [HttpGet]
        public ActionResult<List<Item>> GetAll() => _repository.GetAll();

        // GET: api/items/{id}
        [HttpGet("{id}")]
        public ActionResult<Item> GetById(int id)
        {
            var item = _repository.GetById(id);
            if (item == null) return NotFound();
            return item;
        }

        // POST: api/items
        [HttpPost]
        public ActionResult<Item> Create(Item item)
        {
            _repository.Add(item);
            return CreatedAtAction(nameof(GetById), new { id = item.Id }, item);
        }

        // PUT: api/items/{id}
        [HttpPut("{id}")]
        public IActionResult Update(int id, Item item)
        {
            if (id != item.Id) return BadRequest();
            var existingItem = _repository.GetById(id);
            if (existingItem == null) return NotFound();

            _repository.Update(item);
            return NoContent();
        }

        // DELETE: api/items/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existingItem = _repository.GetById(id);
            if (existingItem == null) return NotFound();

            _repository.Delete(id);
            return NoContent();
        }
    }
}
