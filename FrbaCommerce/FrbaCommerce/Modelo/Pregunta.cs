using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.FrbaCommerce.Modelo
{
    class Pregunta
    {
        String pregunta { get; set; }
        DateTime fecha { get; set; }
        String respuesta { get; set; }
        DateTime fechaRespuesta { get; set; }

        public Pregunta(String pregunta, DateTime fecha, String respuesta, DateTime fechaRespuesta) { 
        this.pregunta = pregunta;
        this.fecha = fecha;
        this.respuesta = respuesta;
        this.fechaRespuesta = fechaRespuesta;

        }
    }
}
