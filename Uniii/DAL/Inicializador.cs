using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Uniii.Models;

namespace Uniii.DAL
{
    //El inicializador es el que se encarga de registrar información base en la base de datos de referencia
    public class Inicializador : System.Data.Entity.DropCreateDatabaseIfModelChanges<EscuelaContexto>
    {
        protected override void Seed(EscuelaContexto context)
        {
            var estudiantes = new List<Estudiante>
            {
            new Estudiante{Nombre="Carson",Apellido="Alexander",FechaInscripcion=DateTime.Parse("2005-09-01")},
            new Estudiante{Nombre="Meredith",Apellido="Alonso",FechaInscripcion=DateTime.Parse("2002-09-01")},
            new Estudiante{Nombre="Arturo",Apellido="Anand",FechaInscripcion=DateTime.Parse("2003-09-01")},
            new Estudiante{Nombre="Gytis",Apellido="Barzdukas",FechaInscripcion=DateTime.Parse("2002-09-01")},
            new Estudiante{Nombre="Yan",Apellido="Li",FechaInscripcion=DateTime.Parse("2002-09-01")},
            new Estudiante{Nombre="Peggy",Apellido="Justice",FechaInscripcion=DateTime.Parse("2001-09-01")},
            new Estudiante{Nombre="Laura",Apellido="Norman",FechaInscripcion=DateTime.Parse("2003-09-01")},
            new Estudiante{Nombre="Nino",Apellido="Olivetto",FechaInscripcion=DateTime.Parse("2005-09-01")}
            };

            estudiantes.ForEach(s => context.Estudiantes.Add(s));
            context.SaveChanges();
            var cursos = new List<Curso>
            {
            new Curso{CursoID=1050,Nombre="Chemistry",Creditos=3,},
            new Curso{CursoID=4022,Nombre="Microeconomics",Creditos=3,},
            new Curso{CursoID=4041,Nombre="Macroeconomics",Creditos=3,},
            new Curso{CursoID=1045,Nombre="Calculus",Creditos=4,},
            new Curso{CursoID=3141,Nombre="Trigonometry",Creditos=4,},
            new Curso{CursoID=2021,Nombre="Composition",Creditos=3,},
            new Curso{CursoID=2042,Nombre="Literature",Creditos=4,}
            };
            cursos.ForEach(s => context.Cursos.Add(s));
            context.SaveChanges();
            var inscripciones = new List<Inscripcion>
            {
            new Inscripcion{EstudianteID=1,CursoID=1050,Grado=Grado.A},
            new Inscripcion{EstudianteID=1,CursoID=4022,Grado=Grado.C},
            new Inscripcion{EstudianteID=1,CursoID=4041,Grado=Grado.B},
            new Inscripcion{EstudianteID=2,CursoID=1045,Grado=Grado.B},
            new Inscripcion{EstudianteID=2,CursoID=3141,Grado=Grado.F},
            new Inscripcion{EstudianteID=2,CursoID=2021,Grado=Grado.F},
            new Inscripcion{EstudianteID=3,CursoID=1050},
            new Inscripcion{EstudianteID=4,CursoID=1050,},
            new Inscripcion{EstudianteID=4,CursoID=4022,Grado=Grado.F},
            new Inscripcion{EstudianteID=5,CursoID=4041,Grado=Grado.C},
            new Inscripcion{EstudianteID=6,CursoID=1045},
            new Inscripcion{EstudianteID=7,CursoID=3141,Grado=Grado.A},
            };
            inscripciones.ForEach(s => context.Inscripciones.Add(s));
            context.SaveChanges();
        }
    }
}