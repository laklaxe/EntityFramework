using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Uniii.Models
{
    public enum Grado
    {
        A, B, C, D, F
    }

    public class Inscripcion
    {
        public int InscripcionID { get; set; }
        public int CursoID { get; set; }
        public int EstudianteID { get; set; }
        public Grado? Grado { get; set; }

        //Integración de referencia con los modelos Curso y estudiante  para la generación de llaves Foraneas
        public virtual Curso Curso { get; set; }
        public virtual Estudiante Estuadiante { get; set; }
    }
}