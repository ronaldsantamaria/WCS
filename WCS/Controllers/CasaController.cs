using BusinessObjects.Interfaces;
using BusinessObjets;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WCS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CasaController : ControllerBase
    {
        private readonly ICasasBL _casasBL;

        public CasaController(ICasasBL casasBL)
        {
            _casasBL = casasBL;
        }

        [HttpGet]
        public IEnumerable<CasaModel> Get()
        {
            return _casasBL.GetAllCasas();
        }
    }
}
