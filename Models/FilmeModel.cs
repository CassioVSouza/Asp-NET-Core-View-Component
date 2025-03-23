namespace AspNetCrudBasico.Models
{
    public class FilmeModel
    {
        public string Nome { get; set; } = string.Empty;
        public int CodigoCategoria { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public int AnoLancamento { get; set; }
    }
}
