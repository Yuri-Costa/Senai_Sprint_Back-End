using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai_Filmes_WebApi.Domains;
using Senai_Filmes_WebApi.Interfaces;
using Senai_Filmes_WebApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_Filmes_WebApi.Controllers
{
    //define o tipo de resposta da api que é no formato json
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class GenerosController : ControllerBase
    {
        /// <summary>
        /// ira receber todos os metodos definidos na interface IGenerosRepository
        /// </summary>
        private IGenerosRepository _generoRepository { get; set; }

        
        public GenerosController()
        {
            _generoRepository = new GeneroRepository();
        }
        [HttpGet]
        public IActionResult Get()
        {
            List<GeneroDomain> listGeneros = _generoRepository.ListarTodos();

            return Ok(listGeneros);
        }

        /// <summary>
        /// cadastra um novo genero
        /// </summary>
        /// <returns>retorna um status code 201 - Created</returns>
        [HttpPost]
        public IActionResult Post(GeneroDomain NovoGenero)
        {
            //chama o metodo cadastrar()
            _generoRepository.Cadastrar(NovoGenero);
            //retorna um status code 201 - created
            return StatusCode(201);
        }
    }
}
