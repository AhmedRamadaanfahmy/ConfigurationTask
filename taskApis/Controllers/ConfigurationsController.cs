namespace taskApis.Controllers{
    using Microsoft.AspNetCore.Mvc;
    using taskApis.Models;
    using taskApis.DTOs;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.AspNetCore.Cors;

    [ApiController]
    [Route("[controller]")]
    public class ConfigurationsController : ControllerBase
    {
        private readonly MapConfigurationContext _ctx;
        public ConfigurationsController(MapConfigurationContext ctx)
        {
            this._ctx = ctx;
        }

        // [HttpGet]
        // public IActionResult Get()
        // {
        //     var configurations = this._ctx.Configurations.ToList();
        //     return Ok(configurations);
        // }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var configuration = this._ctx.Configurations.FirstOrDefault(x => x.Id == id);
            return Ok(configuration);
        }

        // [HttpDelete]
        // public IActionResult Remove(int id)
        // {
        //     var element = this._ctx.Configurations.FirstOrDefault((elem)=> elem.Id == id);
        //     if(element != null)
        //     {
        //         this._ctx.Configurations.Remove(element);
        //         this._ctx.SaveChanges();
        //         return Ok(true);
        //     }
        //     return Ok(false);
        // }

        [HttpPost]

       // [EnableCors("http://localhost:4200")]
        
        public IActionResult Add([FromBody] ConfigurationDTO configurationDTO)
        {
            this._ctx.Configurations.Add(new Configuration{
                ClusterRadius = configurationDTO.ClusterRadius,
                GeoFencing = configurationDTO.GeoFencing,
                TimeBuffer = configurationDTO.TimeBuffer,
                LocationBuffer = configurationDTO.LocationBuffer,
                Duration = configurationDTO.Duration,
                MapTypeId = configurationDTO.MapTypeId,
                MapSubTypeId = configurationDTO.MapSubTypeId
            });  
            return Ok(this._ctx.SaveChanges());
        }
    }
}