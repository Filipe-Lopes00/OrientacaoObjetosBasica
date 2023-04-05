using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioTotalDeUmVendedor
{ //Crie um programa para calcular o salário total de um vendedor. Deverá  ser informado o salário base e o total de vendas. A comissão é calculada  com um percentual (informado pelo usuário) sobre o total de vendas.  

    internal class SalarioVendedor
    {
        public double salarioBase;
        public double vendas;
        public double comissao;
        
        public double SubTotal() 

        {
            return (comissao * vendas) + salarioBase;
        }   
        

    }
}
