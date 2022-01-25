using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Zyxenmovies.Domain.Entities;
using Zyxenmovies.Infraestructure.Repository;

namespace movies.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PictureController : ControllerBase
    {
        [HttpGet]
        [Route("Obtener todos")]

        public IActionResult obtener()
        {
            PictureRepository cine = new PictureRepository();
            return Ok (cine.ObtenerPelis());
        }  

          [HttpGet]
          [Route("Por ID")]

        public IActionResult buscarId(int id)
        {
            PictureRepository cine2 = new PictureRepository();
            var cine = cine2.ForID(id);
            if (cine == null)
            {
                return NotFound($"No existe");
            }
            return Ok (cine);
        }  

         [HttpPost]
          [Route("Crear pelicula")]

        public IActionResult CrearPelicula (Picture nuevapeli)
        {
            PictureRepository cine3 = new PictureRepository();
            cine3.CrearPelicula(nuevapeli);
            return CreatedAtAction(nameof(CrearPelicula), nuevapeli);
           
        }  

         [HttpPut]
          [Route("Actualizar Pelicula")]

        public IActionResult ActualizarPeli ( int id, Picture actualizarPeli )
        {
           PictureRepository cine4 = new PictureRepository();
           var excepcion = cine4.ForID(id);
           if (excepcion == null)
           {
               return NotFound($"No existe el id ingresado");
           }
           cine4.ActualizarPeli(id, actualizarPeli);
           return Ok ("Pelicula Actualizada Correctamente");
           
        }  

           [HttpDelete]
          [Route("Borrar Pelicula")]

        public IActionResult BorrarPeli ( int id )
        {
           PictureRepository cine5 = new PictureRepository();
           var excepcion = cine5.ForID(id);
           if (excepcion == null)
           {
               return NotFound($"No existe el id ingresado");
           }
           cine5.BorrarPeli(id);
           return Ok ("La pelicula se ha borrado exitosamente");
           
        }  


         [HttpGet]


        [Route("ForDirector")]
        public IActionResult ForDirector (string NombreProducer)
        {
            PictureRepository cine6 = new PictureRepository();

            var respuesta = cine6.ForDirector(NombreProducer);

            if (respuesta.Count() == 0)

            {

                return NotFound($"El director no existe");

            }

            return Ok (respuesta);

        }






      
        

    }

    

  
}