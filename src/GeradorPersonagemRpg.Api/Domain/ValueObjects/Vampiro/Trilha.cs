namespace GeradorPersonagemRpg.Api.Domain.ValueObjects.Vampiro;

public abstract class Trilha
{
    protected Trilha(int pontos)
    {
        Pontos = pontos;
    }

    protected string Nome { get; set; }
    public int Pontos { get; set; }
}