using MVC_CONSOLE.Models;
using MVC_CONSOLE.Views;

namespace MVC_CONSOLE.Controllers
{
    public class ProdutoController
    {
        // Models

        Produto produto = new Produto();


        // Views
        ProdutoView produtoView = new ProdutoView();

        public void ListarProdutos()
        {

            produtoView.Listar( produto.Ler ());


        }


    }
}