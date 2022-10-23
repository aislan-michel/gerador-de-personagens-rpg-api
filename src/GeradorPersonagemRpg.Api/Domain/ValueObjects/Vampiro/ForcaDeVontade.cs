namespace GeradorPersonagemRpg.Api.Domain.ValueObjects.Vampiro;

public class ForcaDeVontade
{
    public ForcaDeVontade(int pontos)
    {
        Pontos = pontos;
    }

    public int Pontos { get; set; }
}