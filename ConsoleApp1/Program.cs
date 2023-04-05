using SalarioTotalDeUmVendedor;

internal class Program
{
    public static void Main(string[] args)
    {
        SalarioVendedor salario = new SalarioVendedor();
        salario.salarioBase = 1000;
        salario.vendas = 500;
        salario.comissao =0.05;
        Console.WriteLine(salario.SubTotal());
    }
}