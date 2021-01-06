using System;
using MVC_CONSOLE.Controllers;
using MVC_CONSOLE.Models;

namespace MVC_CONSOLE
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController prod = new ProdutoController();
            prod.Cadastrar();
            prod.ListarProdutos();
        }


        
    }
}
