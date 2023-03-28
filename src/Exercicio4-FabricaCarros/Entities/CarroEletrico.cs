namespace Exercicio4_FabricaCarros.Entities;

public record CarroEletrico
{
    public Carro Carro { get; set; }
    public int Potencia { get; set; }
    public int DuracaoBateria { get; set; }

}