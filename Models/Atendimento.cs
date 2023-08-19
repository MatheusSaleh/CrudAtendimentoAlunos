namespace TrabalhoEntityFramwork.Models
{
    public class Atendimento
    {
        public int Id { get; set; }
        public Aluno Aluno { get; set; }
        public Sala Sala { get; set; }
        public DateTime Date { get; set; }
        public String Time { get; set; }

    }
}
