using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tech_test_payment_api.Entities
{
    public class Vendedor
    {
        public int Id { get; set; }

        public string CPFVendedor { get; set; }

        public string NomeVendedor { get; set; }

        public string EmailVendedor { get; set; }

        public string TelefoneVendedor { get; set; }

       
    }
}
