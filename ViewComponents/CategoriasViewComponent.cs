using AspNetCrudBasico.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCrudBasico.ViewComponents
{
    public class CategoriasViewComponent : ViewComponent
    {
        private readonly List<FilmeViewModel> filmes = new List<FilmeViewModel>
    {
        new FilmeViewModel{ Nome = " Teste1", AnoLancamento = 2004, Categoria = " Terror", Descricao = "Um filme de terror" },
        new FilmeViewModel{ Nome = " Teste2", AnoLancamento = 2006, Categoria = " Ação", Descricao = "Um filme de Ação" },
        new FilmeViewModel{ Nome = " Teste3", AnoLancamento = 2008, Categoria = " Aventura", Descricao = "Um filme de Aventura" }
    };
        public async Task<IViewComponentResult> InvokeAsync()
        {
            try
            {
                var categorias = filmes.Select(o => o.Categoria).ToList();
                await Task.CompletedTask;
                return View(categorias);
            }
            catch (Exception) { throw; }
        }
    }
}
