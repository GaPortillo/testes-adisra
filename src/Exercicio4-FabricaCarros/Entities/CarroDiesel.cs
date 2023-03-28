namespace Exercicio4_FabricaCarros.Entities;

public record CarroDiesel
{
    public Carro Carro { get; set; }
    public int CapacidadeCarga { get; set; }
    public int VolumeCacamba { get; set; }
}