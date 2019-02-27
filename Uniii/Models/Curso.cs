using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Uniii.Models
{
    public class Curso
    {
        //Se incluye using System.ComponentModel.DataAnnotations.Schema;
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CursoID { get; set; }
        public string Nombre { get; set; }
        public int Creditos { get; set; }


        //Integración de referencia con el modelo de Inscripciones para la generación de llaves
        public virtual ICollection<Inscripcion> Inscripciones { get; set; }
    }
}