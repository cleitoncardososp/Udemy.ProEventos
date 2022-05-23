using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _eventos = new Evento[]{
            new Evento(){
                EventoId = 1,
                Tema = "Angular 11 e .NET 5",
                Local = "Belo Horizonte",
                Lote = "1º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = "foto.png"      
            },
            new Evento(){
                EventoId = 2,
                Tema = "Angular e suas novidades",
                Local = "São Paulo",
                Lote = "2º Lote",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                ImagemURL = "foto1.png"      
            }
        };

        public EventoController()
        {
        }

        // GETALL api/evento
        [HttpGet("")]
        public IEnumerable<Evento> GetAll()
        {
            return _eventos;
        }

        // GETBYID api/evento/1
        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById([FromRoute] int id)
        {
            return _eventos.Where(evento => evento.EventoId == id);
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