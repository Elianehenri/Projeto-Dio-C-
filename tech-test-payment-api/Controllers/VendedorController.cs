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
    public class VendedorController : ControllerBase
    {
        private readonly DataBaseContext _context;

        public VendedorController(DataBaseContext context)
        {
            _context = context;
        }

        [HttpGet("ObterPorId")]
        public IActionResult ObterPorId(int id)
        {
            var vendedor = _context.Vendedores.Find(id);
            if (vendedor == null) return NotFound("Vendedor inexistente");

            return Ok(vendedor);
        }

        [HttpPost("CriarVendedorPorId")]
        public IActionResult Criar(Vendedor vendedor)
        {
            _context.Add (vendedor);
            _context.SaveChanges();

            return CreatedAtAction(nameof(ObterPorId),
            new { id = vendedor.Id },
            vendedor);
        }

        [HttpPut("AtualizarVendedorPorId")]
        public IActionResult Atualizar(int id, Vendedor vendedor)
        {
            var vendedorDb = _context.Vendedores.Find(id);

            if (vendedorDb == null) return NotFound();

            vendedorDb.CPFVendedor = vendedor.CPFVendedor;
            vendedorDb.NomeVendedor = vendedor.NomeVendedor;
            vendedorDb.EmailVendedor = vendedor.EmailVendedor;
            vendedorDb.TelefoneVendedor = vendedor.TelefoneVendedor;

            _context.Vendedores.Update (vendedorDb);
            _context.SaveChanges();

            return Ok(vendedorDb);
        }

        [HttpDelete("ExcluirVendedorPorId")]
        public IActionResult Deletar(int id)
        {
            var vendedorDb = _context.Vendedores.Find(id);

            if (vendedorDb == null) return NotFound();

            _context.Vendedores.Remove (vendedorDb);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
