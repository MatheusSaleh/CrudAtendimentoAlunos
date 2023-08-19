using System.ComponentModel.DataAnnotations.Schema;

namespace TrabalhoEntityFramwork.Models
{
    public enum Periodo
    {
        Manha, Tarde, Noite
    }
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime aniversario { get; set; }
        public Curso Curso { get; set; }

        public Periodo Periodo { get; set; }
    }
}
