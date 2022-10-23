namespace GeradorPersonagemRpg.Api.Domain.ValueObjects.Vampiro;

public class Humanidade : Trilha
{
    public Humanidade(int pontos) : base(pontos)
    {
        Nome = nameof(Humanidade);
    }
}