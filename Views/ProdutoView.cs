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
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Produto: {item.Nome}");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Preço: R${item.Preco}");
                Console.WriteLine();
                Console.ResetColor();
            }
        }

        public Produto CadastrarProduto()
        {   
            Produto produto = new Produto();

            Console.Clear();
            Console.WriteLine("Digite um código:");
            produto.Codigo = int.Parse(Console.ReadLine() );
            
            Console.WriteLine("Digite um nome para o produto:");
            produto.Nome = Console.ReadLine();

            Console.WriteLine($"Digite o preço do produto:");
            produto.Preco = float.Parse(Console.ReadLine());
            Console.WriteLine();


          

            
       
          

            return produto;
        }
        
    }
}