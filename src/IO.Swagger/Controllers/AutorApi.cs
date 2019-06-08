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
    public class AutorApiController : Controller
    { 
        /// <summary>
        /// Adiciona um novo autor
        /// </summary>
        
        /// <param name="body">dados do autor que será adicionado</param>
        /// <response code="405">Dados inválidos</response>
        [HttpPost]
        [Route("/IKokiri/Livrariav/v1/autores")]
        [ValidateModelState]
        [SwaggerOperation("AddAutor")]
        public virtual IActionResult AddAutor([FromBody]Autor body)
        { 
            //TODO: Uncomment the next line to return response 405 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(405);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Remoção de um autor
        /// </summary>
        /// <remarks>Remove um autor</remarks>
        /// <param name="id">identificador do autor que será removido</param>
        /// <response code="400">Autor inválido</response>
        /// <response code="404">Autor não encontrado</response>
        [HttpDelete]
        [Route("/IKokiri/Livrariav/v1/autores/{id}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteAutor")]
        public virtual IActionResult DeleteAutor([FromRoute][Required]int? id)
        { 
            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Busca autor por id
        /// </summary>
        /// <remarks>Retorna um unico autor</remarks>
        /// <param name="id">identificador do autor de retorno</param>
        /// <response code="200">seccess</response>
        /// <response code="400">ID inválido</response>
        /// <response code="404">Autor não encontrado</response>
        [HttpGet]
        [Route("/IKokiri/Livrariav/v1/autores/{id}")]
        [ValidateModelState]
        [SwaggerOperation("GetAutorById")]
        [SwaggerResponse(statusCode: 200, type: typeof(Autor), description: "seccess")]
        public virtual IActionResult GetAutorById([FromRoute][Required]long? id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Autor));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            string exampleJson = null;
            exampleJson = "{\n  \"nome\" : \"nome\",\n  \"id\" : 6\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Autor>(exampleJson)
            : default(Autor);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Busca autores do armazenamento
        /// </summary>
        
        /// <response code="200">success</response>
        /// <response code="400">não encontrado</response>
        [HttpGet]
        [Route("/IKokiri/Livrariav/v1/autores")]
        [ValidateModelState]
        [SwaggerOperation("GetAutores")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Autor>), description: "success")]
        public virtual IActionResult GetAutores()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Autor>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            string exampleJson = null;
            exampleJson = "[ {\n  \"nome\" : \"nome\",\n  \"id\" : 6\n}, {\n  \"nome\" : \"nome\",\n  \"id\" : 6\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<Autor>>(exampleJson)
            : default(List<Autor>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Atualização de um autor
        /// </summary>
        /// <remarks>Efetua a alteração de um ou varios dados de um autor</remarks>
        /// <param name="id">identificador do autor que será alterado</param>
        /// <param name="body">dados do autor que serão alterados</param>
        /// <response code="400">Autor inválido</response>
        /// <response code="404">Autor não encontrado</response>
        [HttpPut]
        [Route("/IKokiri/Livrariav/v1/autores/{id}")]
        [ValidateModelState]
        [SwaggerOperation("UpdateAutor")]
        public virtual IActionResult UpdateAutor([FromRoute][Required]int? id, [FromBody]Autor body)
        { 
            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }
    }
}
