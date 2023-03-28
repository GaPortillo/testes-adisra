namespace Exercicio4_FabricaCarros.Services;

public static class CalculaCustoDeVenda 
{
    public static double CustoDeVenda(double custoProducao, int imposto)
    {
        var lucroFabrica = custoProducao * 0.25;
        var valorImposto = custoProducao * ((double)imposto / 100);
        var custoVenda = custoProducao + valorImposto + lucroFabrica;

        return custoVenda;
    }
}