using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class AnimalController : ControllerBase
    {
        // GET api/animal/search
        [HttpGet("search")]
        public IActionResult Get()
        {
            List<AnimalViewModel> model = new List<AnimalViewModel>
            {
                new AnimalViewModel {
                    Id=4,
                    Name="Верблую",
                    Image="http://www.origins.org.ua/pictures/photo_verblud_3.jpg"
                },
                new AnimalViewModel {
                    Id=7,
                    Name="Білка",
                    Image="https://ichef.bbci.co.uk/news/976/cpsprodpb/7624/production/_104444203_d03fb5eb-685c-42c3-8fa2-eea0ee2dac26.jpg"
                },
            };
            return Ok(model);
        }
    }
}
