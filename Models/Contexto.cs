using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace TrabalhoEntityFramwork.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Atendimento> Atendimentos { get; set; }
        public DbSet<Sala> Salas { get; set; }
    }
}
