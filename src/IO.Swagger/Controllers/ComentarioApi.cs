/*
 * Livraria Virtual
 *
 * Manipulação de livros e suas dependências 
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    public class ComentarioApiController : Controller
    { 
        /// <summary>
        /// Adiciona um comentario para um livro
        /// </summary>
        
        /// <param name="livroId">ID do livro</param>
        /// <param name="body">dados do comentrario que será adicionado</param>
        /// <response code="405">Dados inválidos</response>
        [HttpPost]
        [Route("/IKokiri/Livrariav/v1/livros/{livroId}/comentarios")]
        [ValidateModelState]
        [SwaggerOperation("AddComentario")]
        public virtual IActionResult AddComentario([FromRoute][Required]long? livroId, [FromBody]Comentario body)
        { 
            //TODO: Uncomment the next line to return response 405 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(405);


            throw new NotImplementedException();
        }
    }
}
