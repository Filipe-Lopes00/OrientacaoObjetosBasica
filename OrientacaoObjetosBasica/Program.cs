﻿using OrientacaoObjetosBasica;

internal class Program
{
    

    private static void Main(string[] args)
    {
       CaixaRetangular caixa = new CaixaRetangular();
        caixa.altura=10;
        caixa.largura=10;
        caixa.comprimento=10;    
        Console.WriteLine(caixa.CalcularVolume());
    }
    
}