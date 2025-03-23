namespace AspNetCrudBasico.Models.ViewModel
{
    public class FilmeViewModel
    {
        public string Nome { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public int AnoLancamento { get; set; }
    }
}
