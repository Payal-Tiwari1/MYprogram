using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitsAPIController : ControllerBase
    {
        public List<string> fruits = new List<string>() 
        { "Apple", 
          "Banana", 
          "Cherry" 
        };
        
        [HttpGet]
        public List<string> GetFruits()
        {
            return fruits;
        }

        
        
        [HttpGet("{index}")]
        public string GetFruitsByIndex(int index)
        {
            return fruits.ElementAt(index);
        }
    }

    
}
