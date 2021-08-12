using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Application.Base;
using Application.Http.Requests;
using Application.Http.Responses;
using Domain.Contract;
using Domain.Entities;
using Domain.Helpers.Security;
using Domain.Repositories;

namespace Application.Services
{
    public class PersonaService : Service<Persona>
    {
        private readonly IPersonaRepository _personaRepository;

        public PersonaService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _personaRepository = unitOfWork.PersonaRepository;
        }

        public IResponse<CrearPersonaResponse> CrearPersona(CrearPersonaRequest request)
        {
            var persona = new Persona
            {
                Nombre = request.Nombre,
                Apellidos = request.Apellidos,
                Email = request.Email,
                Telefono = request.Telefono,
                Edad = request.Edad,
                Cedula = request.Cedula
            };
            UnitOfWork.PersonaRepository.Add(persona);
            UnitOfWork.Commit();

            return new Response<CrearPersonaResponse>("ok", HttpStatusCode.OK, true, new CrearPersonaResponse(persona));
        }

        public IResponse<IEnumerable<PersonaResponse>> Todas()
        {
            var personas = UnitOfWork.PersonaRepository.FindBy();
            var personasResponse = personas.Select(x => new PersonaResponse(x));
            return new Response<IEnumerable<PersonaResponse>>("ok", HttpStatusCode.OK, true, personasResponse);
        }
    }
}