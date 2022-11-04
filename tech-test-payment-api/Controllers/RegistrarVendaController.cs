using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using tech_test_payment_api.Context;
using tech_test_payment_api.Entities;

namespace tech_test_payment_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegistrarVendaController : ControllerBase
    {
        private readonly DataBaseContext _context;

        public RegistrarVendaController(DataBaseContext context)
        {
            _context = context;
        }

        [HttpPost("RegistrarVenda")]
        public IActionResult Criar( Venda venda)
        {
            

            _context.Add (venda);
            _context.SaveChanges();

            return CreatedAtAction(nameof(ObterPorId),
            new { id = venda.Id },
            venda);
        }

        [HttpGet("ObterVendaPorId")]
        public IActionResult ObterPorId(int id)
        {
            var venda = _context.Vendas.Find(id);
            if (venda == null) return NotFound();

            return Ok(venda);
        }

        [HttpPut("PagamentoAprovado{id}")]
        public IActionResult PagamentoAprovado(int id)
        {
            var venda = _context.Vendas.Find(id);
            if (venda == null)
            {
                 return NotFound("Venda nao encontardo.");
            }
            else if(venda.DescricaoStatus != "Aguardando Pagamento"){
                return Unauthorized("Não autorizado a alterar.");
            }

            venda.DescricaoStatus = "Pagamento Aprovado";
            _context.Update(venda);
            _context.SaveChanges();

            return Ok("Pedido alterado.");
           
        }
        
        [HttpPut("EnviadoParaTransportadora{id}")]
        public IActionResult  EnviadoParaTransportadora(int id)
        {
            var venda = _context.Vendas.Find(id);
            if (venda == null)
            {
                 return NotFound("Venda nao encontardo.");
            }
            else if(venda.DescricaoStatus == "Encaminhado para transportadora"){
                    
            venda.DescricaoStatus = $"Entrega realizada no dia {DateTime.Now.ToString("dd/MM/yyyy HH:mm")}";
            _context.Update(venda);
            _context.SaveChanges();
                
                return Ok($"Status da Venda = {venda.DescricaoStatus}");
            }

                return Unauthorized("Não é possivel entregar essa venda.");
  
        }

        [HttpPut("Venda Cancelada{id}")]
         public IActionResult  VendaCancelada(int id)
        {
            var venda = _context.Vendas.Find(id);
            
            if (venda == null)
            {
                 return NotFound("Venda nao encontardo.");
            }
            else if(venda.DescricaoStatus != "Encaminhado para transportadora" ||
                venda.DescricaoStatus != "Pagamento Aprovado"){
                    
            venda.DescricaoStatus = "Cancelado";
            _context.Update(venda);
            _context.SaveChanges();
                
                return Ok($"Status da Venda = {venda.DescricaoStatus}");
            }

                return Unauthorized("Não é possivel cancelar essa venda.");
  
        }

        
    }
    
}
