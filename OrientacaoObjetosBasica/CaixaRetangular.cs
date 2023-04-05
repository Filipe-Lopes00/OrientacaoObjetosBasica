using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetosBasica
{
    internal class CaixaRetangular
    {
        public int altura;
        public int largura;
        public int comprimento;
        public int CalcularVolume()
        { return altura * largura * comprimento; }
        
    }

}
