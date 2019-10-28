using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using EpicodusPets.Models;
using Microsoft.EntityFrameworkCore;

namespace EpicodusPets.Controllers
{
    [Route("api/pets/{PetId}/[controller]")]
    [ApiController]
    public class PhotosController : ControllerBase
    {
        private PetsContext _db;

        // GET api/pets/5/photo/1
        [HttpGet("{id}")]
        public ActionResult<Photo> Get(int id)
        {
            return _db.Photos.FirstOrDefault(entry => entry.PhotoId == id);
        }
    }
}