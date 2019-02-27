using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Uniii.Models
{
    public class Estudiante
    {
        public int ID { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaInscripcion { get; set; }

        //Integración de referencia con el modelo de Inscripciones para la generación de llaves
        public virtual ICollection<Inscripcion> Inscripcion { get; set; }


    }
}