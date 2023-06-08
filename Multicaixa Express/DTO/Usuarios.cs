using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicaixa_Express.DTO
{
   
        class Usuario
        {
            public string Pin { get; set; }
            public string NIF { get; set; }
            public double Saldo { get; set; }

            public List<Usuario> Conta()
            {
                return new List<Usuario>() {
              new Usuario() {Pin = "123456", NIF = "002400LA030", Saldo = 3000},
              new Usuario() {Pin = "660050", NIF = "007400LA090", Saldo = 8000}
            };
            }



        }
    
}
