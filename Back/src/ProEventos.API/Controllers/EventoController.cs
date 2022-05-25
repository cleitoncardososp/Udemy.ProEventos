using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly DataContext _context;

        public EventoController(DataContext context)
        {
            _context = context;

        }

        // GETALL api/evento
        [HttpGet("")]
        public IEnumerable<Evento> GetAll()
        {
            return _context.Eventos.ToList();
        }

        // GETBYID api/evento/1
        [HttpGet("{id}")]
        public Evento GetById([FromRoute] int id)
        {
            return _context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
        }


        // POST api/evento
        [HttpPost]
        public string Post()
        {
            return "POST";
        }

        // PUT api/evento/5
        [HttpPut]
        public string Put(int id)
        {
            return $"Put - ID: {id}";
        }

        // DELETE api/evento/5
        [HttpDelete]
        public string Delete(int id)
        {
            return $"Delete - ID: {id}";
        }
    }
}