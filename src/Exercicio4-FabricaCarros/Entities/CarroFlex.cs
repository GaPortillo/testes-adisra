namespace Exercicio4_FabricaCarros.Entities;

public record CarroFlex
{
    public Carro Carro { get; set; }
    public int Portas { get; set; }
    public int Cilindrada { get; set; }

}