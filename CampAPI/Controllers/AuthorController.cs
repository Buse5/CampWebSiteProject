using Microsoft.AspNetCore.Mvc;

namespace CampAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        [HttpGet]
        public ActionResult<CampData.AuthorData> GetById(int entityID)
        {
            CampService.AuthorService authorServices = new CampService.AuthorService();
            var data = authorServices.GetById(entityID);
            if (data != null) return Ok(data);
            return NotFound("Yazar bulunamadı !!");
        }
    }
}
