namespace taskApis.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using taskApis.Models;
    using taskApis.DTOs;
    using Microsoft.EntityFrameworkCore;

    [ApiController]
    [Route("map-sub-type")]

    public class MapSubTypesController : ControllerBase
    {
        private readonly MapConfigurationContext _ctx;

        public MapSubTypesController(MapConfigurationContext ctx)
        {
            this._ctx = ctx;
        }

        // [HttpGet]
        // public IActionResult Get()
        // {
        //     var mapSubTypes = this._ctx.MapSubTypes.Select(x => new DataDTO{
        //         Id = x.Id,
        //         Value = x.Value
        //     }).ToList();
        //     return Ok(mapSubTypes);
        // }

        // [HttpGet("{id}")]
        // public IActionResult GetById(int id)
        // {
        //     var element = this._ctx.MapSubTypes.FirstOrDefault((elem)=> elem.Id == id);
        //      var mapSubTypeDTO = new DataDTO
        //      {
        //         Id = element.Id,
        //         Value = element.Value
        //     };
        //     return Ok(mapSubTypeDTO);
        // }

        [HttpGet("get-by-mapType/{mapTypeid}")]
        public IActionResult GetByMapTypeId(int mapTypeid)
        {
            var mapType = this._ctx.MapTypes.Include(x => x.MapSubTypes)
            .FirstOrDefault(x => x.Id == mapTypeid);

            var mapSubTypesDTOs = mapType.MapSubTypes.Select(x => new DataDTO{
                Id = x.Id,
                Value = x.Value
            }).ToList();

            return Ok(mapSubTypesDTOs);
        }

        // [HttpDelete("{id}")]
        // public IActionResult Remove(int id)
        // {
        //     var element = this._ctx.MapSubTypes.FirstOrDefault((elem)=> elem.Id == id);
        //     if(element != null)
        //     {
        //         this._ctx.MapSubTypes.Remove(element);
        //         this._ctx.SaveChanges();
        //         return Ok(true);
        //     }
        //     return Ok(false);
        // }
    }
}