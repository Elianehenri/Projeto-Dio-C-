using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tech_test_payment_api.Entities
{
    public class Produto
    {
        public int Id{ get; set; }
        public string NomeProduto { get; set; }
        public decimal Preco { get; set; }
      

        public Produto( )
        {
            
        }

       
    }

}
