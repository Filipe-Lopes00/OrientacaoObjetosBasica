using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrenheitParaGrausCelsius
{//subtraia 32 e divida por 1,8. °C = (°F − 32) ÷ 1, 8.
    internal class FahrenheitCelsius
    {
        public double TempC;
        public double CalcularFh()
        { return (TempC - 32) / 1.8 ; }
        
    }
}
