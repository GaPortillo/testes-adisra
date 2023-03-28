using System.Security.AccessControl;
using Exercicio4_FabricaCarros.Enums;

namespace Exercicio4_FabricaCarros.Entities;

public record Carro
{
    public int Chassi{ get; set; }
    public int Motor { get; set; }
    public ETipoCarro TipoCarro { get; set; }
    public double CustoProducao { get; set; }
    public int ImpostoProducao { get; set; } = 20;

}