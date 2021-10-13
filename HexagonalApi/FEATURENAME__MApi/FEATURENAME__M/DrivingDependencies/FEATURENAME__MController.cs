using Microsoft.AspNetCore.Mvc;
using System;

namespace FEATURENAME__MApi.FEATURENAME__M.DrivingDependencies
{
    [ApiController]
    [Route("api/v1/FEATURENAME__ML")]
    public class FEATURENAME__MController : ControllerBase
    {
        private readonly IFEATURENAME__MService _service;

        public FEATURENAME__MController(IFEATURENAME__MService service) => _service = service;

        [HttpGet]
        public IActionResult GetFEATURENAME__M()
        {
            throw new NotImplementedException();
        }
    }
}
