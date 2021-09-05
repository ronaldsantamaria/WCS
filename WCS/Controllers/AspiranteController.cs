using BusinessLayer;
using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WCS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AspiranteController : ControllerBase
    {
        private readonly IAspirantesBL _aspirantesBL;

        public AspiranteController(IAspirantesBL aspirantesBL)
        {
            _aspirantesBL = aspirantesBL;
        }

        [HttpGet]
        public IEnumerable<AspiranteModel> Get()
        {
            return _aspirantesBL.GetAllAspirantes();
        }

        [HttpPost]
        public string Create(AspiranteModel aspiranteModel)
        {
            _aspirantesBL.Create(aspiranteModel);
            return "OK";
        }

        [HttpPut]
        public string Update(AspiranteModel aspiranteModel)
        {
            _aspirantesBL.Update(aspiranteModel);
            return "OK";
        }

        [HttpDelete]
        public string Delete(int Id)
        {
            _aspirantesBL.Remove(Id);
            return "OK";
        }
    }
}
