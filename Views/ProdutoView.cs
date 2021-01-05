using System;
using System.Collections.Generic;
using MVC_CONSOLE.Models;

namespace MVC_CONSOLE.Views
{
    public class ProdutoView
    {
        public void Listar(List<Produto> produtos)
        {
            foreach (var item in produtos)
            {
                Console.WriteLine($"Código : {item.Codigo}");
                Console.WriteLine($"Produto : {item.Nome}");
                Console.WriteLine($"Preço : R$ {item.Preco}");
                Console.WriteLine();
            }
        }
    }
}