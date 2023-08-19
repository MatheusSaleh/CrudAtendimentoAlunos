namespace TrabalhoEntityFramwork.Models
{
    public class Sala
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Equipamentos { get; set; }
        public char Situacao { get; set; }
    }
}
