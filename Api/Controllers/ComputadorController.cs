using System;
using BusinessLayer.Interface;
using DataAccess.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Computador")]
    public class ComputadorController : Controller
    {

        private readonly IComputadorBll _computadorBll;

        public ComputadorController(IComputadorBll computadorBll)
        {
            _computadorBll = computadorBll;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Computador computador)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _computadorBll.Inserir(computador);
                    return StatusCode(201);
                }
                return BadRequest();
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpDelete("{idComputador}")]
        public IActionResult Delete(int idComputador)
        {
            try
            {
                _computadorBll.Deletar(idComputador);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPut("{idComputador}")]
        public IActionResult Put(int idComputador, [FromBody]Computador computador)
        {
            try
            {
                _computadorBll.Atualizar(idComputador, computador);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Json(_computadorBll.ObterTodos());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("{idComputador}")]
        public IActionResult Get(int idComputador)
        {
            try
            {
                return Json(_computadorBll.Obter(idComputador));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}