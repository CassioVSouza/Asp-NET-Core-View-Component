using AspNetCrudBasico.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCrudBasico.ViewComponents
{
    public class ListaFilmesViewComponent : ViewComponent
    {

        private readonly List<FilmeViewModel> filmes = new List<FilmeViewModel>
    {
        new FilmeViewModel{ Nome = " Teste1", AnoLancamento = 2004, Categoria = " Terror", Descricao = "Um filme de terror" },
        new FilmeViewModel{ Nome = " Teste2", AnoLancamento = 2006, Categoria = " Ação", Descricao = "Um filme de Ação" },
        new FilmeViewModel{ Nome = " Teste3", AnoLancamento = 2008, Categoria = " Aventura", Descricao = "Um filme de Aventura" }
    };

        public async Task<IViewComponentResult> InvokeAsync(string? Categoria, string? Nome, int? AnoLancamento)
        {
            try
            {
                if (Categoria == null && Nome == null && AnoLancamento == null)
                {
                    return View(filmes);
                }
                var listaFiltrada = new List<FilmeViewModel>();

                listaFiltrada = filmes.Where(o => o.Categoria.Contains(Categoria ?? " ") &&
                                             o.Nome.Contains(Nome ?? " ") &&
                                             o.AnoLancamento >= (AnoLancamento ?? 0)).ToList();
                await Task.CompletedTask;
                return View(listaFiltrada);
            }
            catch (Exception) {
                throw;
            }
        }
    }
}
