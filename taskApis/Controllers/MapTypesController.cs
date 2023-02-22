namespace taskApis.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using taskApis.Models;
    using taskApis.DTOs;
    using Microsoft.EntityFrameworkCore;

    [ApiController]
    [Route("map-type")]
    public class MapTypeController : ControllerBase
    {
        private readonly MapConfigurationContext map_context;

        public MapTypeController(MapConfigurationContext map_context)
        {
            this.map_context = map_context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var map_types = this.map_context.MapTypes.Select(x => new DataDTO{
                Id = x.Id,
                Value = x.Value
            }).ToList();
            
            return Ok(map_types);
        }

        // [HttpGet("GetById/{id}")]
        // public IActionResult GetById(int id){
        //     var element = this.map_context.MapTypes.FirstOrDefault((elem)=> elem.Id == id);
        //     return Ok(element);
        // }

        // [HttpDelete("Remove/{id}")]
        // public IActionResult Remove(int id){
        //     var element = this.map_context.MapTypes.FirstOrDefault((elem)=> elem.Id == id);
        //     if(element != null)
        //     {
        //         this.map_context.MapTypes.Remove(element);
        //         this.map_context.SaveChanges();
        //         return Ok(true);
        //     }
        //     return Ok(false);
        // }
    }
}
