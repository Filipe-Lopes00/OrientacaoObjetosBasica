using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombustívelporKm_
{
    internal class combustível_
    {
        public double kmInicial;
        public double kmFinal;
        public double combustivel;

        public double CalcularConsumo()
        { return (kmFinal - kmInicial) / combustivel; }
           
        

        

     }

}           
        
    

