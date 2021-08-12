using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Base;
using Application.Http.Requests;
using Application.Http.Responses;
using Application.Services;
using Domain.Contract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonaController : ControllerBase
    {
        private readonly ILogger<PersonaController> _logger;
        private readonly PersonaService _personaService;

        public PersonaController(ILogger<PersonaController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _personaService = new PersonaService(unitOfWork);
        }

        [HttpPost]
        public ActionResult<Response<CrearPersonaResponse>> Login(CrearPersonaRequest request)
        {
            var response = _personaService.CrearPersona(request);
            return StatusCode((int)response.Code, response);
        }

        [HttpGet]
        public ActionResult<Response<IEnumerable<PersonaResponse>>> Todas()
        {
            var response = _personaService.Todas();
            return StatusCode((int)response.Code, response);
        }
    }
}