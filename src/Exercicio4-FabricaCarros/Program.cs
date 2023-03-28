using Exercicio4_FabricaCarros.Entities;
using Exercicio4_FabricaCarros.Enums;
using Exercicio4_FabricaCarros.Services;

public class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Digite o tipo do carro que deseja adicionar: " +
                          "\nDiesel" +
                          "\nFlex" +
                          "\nEletrico");
        var resposta =Console.ReadLine().ToLower();
        var tipoCarro = resposta == "diesel" ? ETipoCarro.Diesel :
            resposta == "flex" ? ETipoCarro.Flex : ETipoCarro.Eletrico;

        var impostoCarro = resposta == "diesel" ? 20 + (int)ECarroImpostoAdicional.Diesel :
            resposta == "flex" ? 20 : 20 + (int)ECarroImpostoAdicional.Eletrico;

        var carro = new Carro
        {
            Chassi = 1,
            CustoProducao = 35000,
            TipoCarro = tipoCarro,
            ImpostoProducao = impostoCarro,
            Motor = 3
        };

        switch (tipoCarro)
        {
            case ETipoCarro.Diesel:
                var carroDiesel = new CarroDiesel
                {
                    CapacidadeCarga = 4,
                    Carro = carro,
                    VolumeCacamba = 10
                };

                Console.WriteLine($"O custo de venda sera: R${CalculaCustoDeVenda.CustoDeVenda(carroDiesel.Carro.CustoProducao, carroDiesel.Carro.ImpostoProducao)}");
                break;

            case ETipoCarro.Flex:
                var carroFlex = new CarroFlex
                {
                    Carro = carro,
                    Cilindrada = 6,
                    Portas = 4
                };
                Console.WriteLine($"O custo de venda sera: R${CalculaCustoDeVenda.CustoDeVenda(carroFlex.Carro.CustoProducao, carroFlex.Carro.ImpostoProducao)}");
                break;

            case ETipoCarro.Eletrico:
                var carroEletrico = new CarroEletrico()
                {
                    Carro = carro,
                    DuracaoBateria = 5000,
                    Potencia = 600
                };
                Console.WriteLine($"O custo de venda sera: R${CalculaCustoDeVenda.CustoDeVenda(carroEletrico.Carro.CustoProducao, carroEletrico.Carro.ImpostoProducao)}");
                break;
        }

        
    }
}