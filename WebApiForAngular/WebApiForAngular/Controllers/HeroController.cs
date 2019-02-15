using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApiForAngular.Model;
using System.Linq;
using Microsoft.AspNetCore.Cors;

namespace WebApiForAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAllOrigins")]
    public class HeroController : ControllerBase
    {
        List<HeroModel> lstHeroes = null;

        public HeroController()
        {
            lstHeroes= new List<HeroModel>() {
                new HeroModel(){Id=1,Name="Mr. Nice"},
                new HeroModel(){Id=2,Name="Narco"},
                new HeroModel(){Id=3,Name="Bombasto"},
                new HeroModel(){Id=4,Name="Celeritas"},
                new HeroModel(){Id=5,Name="Magneta"},
                new HeroModel(){Id=6,Name="RubberMan"},
                new HeroModel(){Id=7,Name="Dynama"},
                new HeroModel(){Id=8,Name="Dr IQ"},
                new HeroModel(){Id=9,Name="Magma"},
                new HeroModel(){Id=10,Name="Tornado"},
            };
        }

        [HttpGet]
        [Route("GetList")]
        public ActionResult<IEnumerable<HeroModel>> GetList()
        {
            return lstHeroes;
        }

        [HttpGet("Get/{id}")]
        public ActionResult<HeroModel> Get(int id)
        {
            return lstHeroes.FirstOrDefault(x=>x.Id==id);
        }

        [HttpPost]
        [Route("UpdateHero")]
        public ActionResult<MessageModel> Update(HeroModel model)
        {
            HeroModel heroModel = lstHeroes.FirstOrDefault(x => x.Id == model.Id);

            if (heroModel == null)
                return new MessageModel() { HasError = true, Message = "This hero is not exist." };

            heroModel.Name = model.Name;
            return new MessageModel() { Message = "Update hero successfully." };
        }
    }
}
