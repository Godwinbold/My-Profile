using RuggedVilla.Models;
    using Microsoft.AspNetCore.Mvc;
using RuggedVilla.Models.Data;

namespace RuggedVilla.Controllers
{
    [Route("api/RuggedVilla")]
    [ApiController]
    public class RuggedVillaController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDto> GetVillas()
        {

            return VillaStore.VillaStores;
                
                
        }
    }
    
}
