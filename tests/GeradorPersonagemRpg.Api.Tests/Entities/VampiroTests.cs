using System.Text;
using System.Text.Json;
using GeradorPersonagemRpg.Api.Domain.Entities;
using GeradorPersonagemRpg.Api.Domain.Enums.Vampiro;

namespace GeradorPersonagemRpg.Api.Tests.Entities;

public class VampiroTests
{
    [Fact]
    public void DistribuirAtributosAleatoriamente()
    {
        var vampiro = new Vampiro(Cla.Brujah, TipoVampiro.Neofito);

        vampiro.DistribuirAtributos();
        
        var json = JsonSerializer.Serialize(vampiro.Atributos);
        File.WriteAllText(@"../../../Data/vampiro-teste-atributos.json", json, Encoding.UTF8);
    }
}