using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Encora.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Encora.Controllers
{
    [ApiExplorerSettings(GroupName = "1.0")]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]

    public class HomeController : ControllerBase
    {

        private readonly IStringBusiness stringBusiness;
        public HomeController(IStringBusiness stringBusiness)
        {
            this.stringBusiness = stringBusiness;  
        }
        #region [Encora ]
        /// <summary>
        /// Operation to obtain a string ordered by frequency
        /// </summary>
        /// <returns>String sorted by frequency 200 OK, 404 Not Found datos no encontrados, 400 BadRequest o 500 error interno.</returns>
        /// <response code="200">String sorted by frequency</response>
        /// <response code="400">Wrong service request.</response>
        /// <response code="404">Not Found service to sorted String</response>
        /// <response code="500">Error interno.</response>
        /// 
        [ApiVersion("1.0")]
        [HttpGet("sorted")]
        [ProducesResponseType(typeof(String), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<ActionResult<String>> StringSorted([FromQuery] String param)
        {
            return await stringBusiness.GetStringSortingOperations(param);
        }
        #endregion
    }
}