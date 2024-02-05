using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;

namespace ParcialAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly ILogger<ItemController> _logger;

        public ItemController(ILogger<ItemController> logger)
        {
            _logger = logger;
        }

        private static List<Item> items = new List<Item>();

        [HttpGet ("Listar", Name = "Listar")]
        public ActionResult<IEnumerable<Item>> GetItems()
        {
            return Ok(items);
        }

        [HttpPost]
        public ActionResult<Item> AddItem(Item newItem)
        {
            newItem.Id = items.Count + 1;
            items.Add(newItem);
            return CreatedAtAction(nameof(GetItems), new { id = newItem.Id }, newItem);
        }
    }
}
