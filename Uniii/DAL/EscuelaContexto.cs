using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using Uniii.Models;

namespace Uniii.DAL
{

       //El contexto es el que se encarga de orquestar entre la aplicación por medio de objetos y la base de datos de referencia

       //Incluir Data Entity
    public class EscuelaContexto : DbContext
    {

        public EscuelaContexto() : base("EscuelaContexto")
        {
        }

        //Incluir los Modelos
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Inscripcion> Inscripciones { get; set; }
        public DbSet<Curso> Cursos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Incluir Conventions
            //Cuando se cree el modelo cree todo en singular
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}