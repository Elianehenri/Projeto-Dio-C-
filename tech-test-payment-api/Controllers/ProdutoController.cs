using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using tech_test_payment_api.Context;
using tech_test_payment_api.Entities;

namespace tech_test_payment_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly DataBaseContext _context;

        public ProdutoController(DataBaseContext context)
        {
            _context = context;
        }


    [HttpPost("CriarProdutoNovo")]
        public IActionResult Criar(Produto produto)
        {
            _context.Add (produto);
            _context.SaveChanges();

            return CreatedAtAction(nameof(ObterPorId),
            new { id = produto.Id },
            produto);
        }

        [HttpGet("BuscarProdutoPorId")]
        public IActionResult ObterPorId(int id)
        {
            var produto = _context.Produtos.Find(id);
            {
                if (produto == null)
                {
                    return NotFound();
                }
                return Ok(produto);
            }
        }

        [HttpGet("BuscarProdutoPorNome")]
         public IActionResult ObterPorNome(string nome)
        {
             
           var produtos = _context.Produtos.Where(x => x.NomeProduto .Contains(nome));
            return Ok(produtos);
        }
        [HttpPut("AtualizarProdutoPorId")]
        public IActionResult Atualizar(int id, Produto produto)
        {
            var produtoDb = _context.Produtos.Find(id);

            if (produtoDb == null) return NotFound();

            produtoDb.NomeProduto = produto.NomeProduto;

            _context.Produtos.Update (produtoDb);
            _context.SaveChanges();

            return Ok(produtoDb);
        }

        [HttpDelete("ExluirPorId")]
         public IActionResult Deletar(int id)
        {
            var produtoDb = _context.Produtos.Find(id);

            if (produtoDb == null) return NotFound();

            _context.Produtos.Remove(produtoDb);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
